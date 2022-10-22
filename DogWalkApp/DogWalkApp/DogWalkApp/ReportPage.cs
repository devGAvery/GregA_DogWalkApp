using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkApp
{
    public partial class ReportPage : Form
    {
        public ReportPage() { InitializeComponent(); }

        // EXIT REPORTING PAGE
        private void exitButton_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();

            foreach (Account acct in Program.clients)
            {
                if (acct.activeClient == true)
                {
                    mp.acctCheckListBox.Items.Add($"{acct.ID}. {acct.dogName} - {acct.ownerName}");
                }
            }

            dataListBox.Items.Clear();
            foreach (var client in Program.clients) { client.reportLine = ""; }

            mp.Show();
            this.Hide();
        }

        // RUN report 
        private void runButton_Click(object sender, EventArgs e)
        {
            // determine account status' to search, if nothing selected populate error message
            IEnumerable<Account> tempReportData = null;
            do
            {
                if (activeCheckBox.Checked == false && inactiveCheckBox.Checked == false) 
                {
                    activeCheckBox.Checked = true;
                    inactiveCheckBox.Checked = true;
                }

                if (activeCheckBox.Checked == true && inactiveCheckBox.Checked == true)
                {
                    var accountScope =
                        from selectedAccounts in Program.clients
                        where selectedAccounts.ID > 0
                        select selectedAccounts;

                    tempReportData = accountScope;
                }
                else if (activeCheckBox.Checked == false && inactiveCheckBox.Checked == true)
                {
                    var accountScope =
                        from selectedAccounts in Program.clients
                        where selectedAccounts.activeClient == false
                        select selectedAccounts;

                    tempReportData = accountScope;
                }
                else if (activeCheckBox.Checked == true && inactiveCheckBox.Checked == false)
                {
                    var accountScope =
                        from selectedAccounts in Program.clients
                        where selectedAccounts.activeClient == true
                        select selectedAccounts;

                    tempReportData = accountScope;
                }
                else
                {
                    Console.WriteLine("Error in ReportPage query");
                }

            } while (clientCheckListBox.CheckedItems.Count == 0 &&
                     activeCheckBox.Checked == false && inactiveCheckBox.Checked == false);

            // check for specific clients/accounts
            IEnumerable<Account> tempReportData2 = null;
            if (clientCheckListBox.CheckedItems.Count > 0)
            {
                var specificClients =
                    from reportClients in tempReportData
                    where clientCheckListBox.CheckedItems.Contains(reportClients.ownerName)
                    select reportClients;

                tempReportData2 = specificClients;
            }
            else
            {
                var specificClients =
                    from reportClients in tempReportData
                    select reportClients;

                tempReportData2 = specificClients;
            }

            // standardized report or custom reporting
            // standardized report
            if (reportCheckListBox.CheckedItems.Count > 0)
            {

                // if custom report attributes are selected, while trying to run a standard report, then deselect those
                if(attributeCheckListBox.CheckedItems.Count > 0)
                {
                    for(int i = 0; i < attributeCheckListBox.Items.Count; i++) 
                    { attributeCheckListBox.SetItemChecked(i, false); }
                }
                
                if(reportCheckListBox.CheckedItems.Count > 1)
                {
                    MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                    MessageBoxButtons mbButton = MessageBoxButtons.OK;
                    DialogResult result =
                        MessageBox.Show("You may only select one standardized report.", "Report Selection", mbButton, mbIcon);
                    if (result == DialogResult.OK)
                    {
                        for (int j = 0; j < reportCheckListBox.Items.Count; j++)
                        { reportCheckListBox.SetItemChecked(j, false); }
                    }
                }

                

                if (reportCheckListBox.CheckedItems.Contains("Accounts Receivable"))
                {
                    var acctSpecs1 =
                        from stuff1 in tempReportData2
                        where stuff1.acctBalance > 0
                        select stuff1;

                    foreach (var specs in acctSpecs1)
                    {
                        specs.reportLine += "" + specs.ID + "\t";
                        specs.reportLine += "" + specs.ownerName + "\t";
                        specs.reportLine += "$" + specs.acctBalance + "\t";
                       
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";
                        for (int m = 0; m < specs.walkDates.Count; m++)
                        {
                            specs.reportLine += "" + specs.walkDates[m] + "\t";
                            specs.reportLine += "" + specs.walkTimes[m] + "\t";
                            dataListBox.Items.Add(specs.reportLine);
                            specs.reportLine = "";
                        }
                        specs.reportLine = "\n";
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";
                    }
                }
                else if (reportCheckListBox.CheckedItems.Contains("Walk Summary"))
                {
                    var acctSpecs2 =
                        from stuff2 in tempReportData2
                        select stuff2;

                    foreach (var specs in acctSpecs2)
                    {
                        specs.reportLine += "" + specs.ID + "\t";
                        specs.reportLine += "" + specs.dogName + "\t\t";
                        specs.reportLine += "" + updateDigit(specs.totalDaysWalked) + ":";
                        specs.reportLine += "" + updateDigit(specs.totalHoursWalked) + ":";
                        specs.reportLine += "" + updateDigit(specs.totalMinutesWalked) + ":";
                        specs.reportLine += "" + updateDigit(specs.totalSecondsWalked);
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";

                        for (int k = 0; k < specs.walkDates.Count; k++)
                        {                            
                            specs.reportLine += "" + specs.walkDates[k] + "\t";
                            specs.reportLine += "" + specs.walkTimes[k] + "\t";
                            dataListBox.Items.Add(specs.reportLine);
                            specs.reportLine = "";
                        }
                        specs.reportLine = "\n";
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";
                    }
                }
                else if (reportCheckListBox.CheckedItems.Contains("Owner Detail"))
                {
                    var acctSpecs3 =
                         from stuff3 in tempReportData2
                         select stuff3;

                    foreach (var specs in acctSpecs3.Distinct())
                    {
                        specs.reportLine += "" + specs.ID + "\t";
                        specs.reportLine += "" + specs.ownerName + "\t";
                        specs.reportLine += "" + specs.ownerPhone + "\t";
                        specs.reportLine += "" + specs.street + ", ";
                        specs.reportLine += "" + specs.apt + ", ";
                        specs.reportLine += "" + specs.city + ", ";
                        specs.reportLine += "" + specs.state + ", ";
                        specs.reportLine += "" + specs.zip + "\t";
                        specs.reportLine += "" + specs.dogName + "\t";
                        
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";
                    }
                }
                else if (reportCheckListBox.CheckedItems.Contains("Dog Detail"))
                {
                    var acctSpecs4 =
                         from stuff4 in tempReportData2
                         select stuff4;

                    foreach (var specs in acctSpecs4)
                    {
                        specs.reportLine += "" + specs.ID + "\t";
                        specs.reportLine += "" + specs.dogName + "\t";
                        specs.reportLine += "" + specs.breed + "\t";
                        specs.reportLine += "" + specs.color + "\t";
                        specs.reportLine += "" + specs.toys + "\t";
                        specs.reportLine += "" + specs.treats + "\t";
                        specs.reportLine += "" + specs.vetOffice + "\t";
                        specs.reportLine += "" + specs.vetPhone + "\t";
                        dataListBox.Items.Add(specs.reportLine);
                        specs.reportLine = "";
                    }
                }
            }
            // or custom report
            else
            {
                do
                {
                    // determine custom attribute data for report for client scope
                    if (attributeCheckListBox.CheckedItems.Count > 0)
                    {
                        // create and apply report header
                        ReportAttributes ra2 = new ReportAttributes();
                        if (attributeCheckListBox.CheckedItems.Contains("ID"))
                        { ra2.header1 += "ID\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Client Name"))
                        { ra2.header1 += "NAME\t\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Client Phone"))
                        { ra2.header1 += "PHONE\t\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Client Address"))
                        { ra2.header1 += "ADDRESS\t\t\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Hourly Rate"))
                        { ra2.header1 += "HR_RATE\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Account Balance"))
                        { ra2.header1 += "$DUE\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Time Walked"))
                        { ra2.header1 += "TIME\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Dog Name"))
                        { ra2.header1 += "DOG\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Dog Breed"))
                        { ra2.header1 += "BREED\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Dog Color"))
                        { ra2.header1 += "COLOR\t\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Dog Toys"))
                        { ra2.header1 += "TOYS\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Dog Treats"))
                        { ra2.header1 += "TREAT\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Vet Office"))
                        { ra2.header1 += "VET\t"; }
                        if (attributeCheckListBox.CheckedItems.Contains("Vet Phone"))
                        { ra2.header1 += "VET_PHN\t"; }

                        dataListBox.Items.Add(ra2.header1);

                        // create and apply report data
                        foreach (var attrib in tempReportData2)
                        {
                            if (attributeCheckListBox.CheckedItems.Contains("ID"))
                            { attrib.reportLine = "" + attrib.ID + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Client Name"))
                            { attrib.reportLine += "" + attrib.ownerName + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Client Phone"))
                            { attrib.reportLine += "" + attrib.ownerPhone + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Client Address"))
                            {
                                attrib.reportLine += "" + attrib.street + ", " + attrib.apt +
                                ", " + attrib.city + ", " + attrib.state + ", " + attrib.zip + "\t";
                            }
                            if (attributeCheckListBox.CheckedItems.Contains("Hourly Rate"))
                            { attrib.reportLine += "$ " + attrib.hourlyRate + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Account Balance"))
                            { attrib.reportLine += "$ " + attrib.acctBalance + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Time Walked"))
                            {
                                attrib.reportLine += "" + attrib.totalDaysWalked + ":" + attrib.totalHoursWalked +
                                ":" + attrib.totalMinutesWalked + ":" + attrib.totalSecondsWalked + "\t";
                            }
                            if (attributeCheckListBox.CheckedItems.Contains("Dog Name"))
                            { attrib.reportLine += "" + attrib.dogName + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Dog Breed"))
                            { attrib.reportLine += "" + attrib.breed + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Dog Color"))
                            { attrib.reportLine += "" + attrib.color + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Dog Toys"))
                            { attrib.reportLine += "" + attrib.toys + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Dog Treats"))
                            { attrib.reportLine += "" + attrib.treats + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Vet Office"))
                            { attrib.reportLine += "" + attrib.vetOffice + "\t"; }
                            if (attributeCheckListBox.CheckedItems.Contains("Vet Phone"))
                            { attrib.reportLine += "" + attrib.vetPhone + "\t"; }

                            dataListBox.Items.Add(attrib.reportLine);
                        }
                    }
                    else
                    {
                        MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                        MessageBoxButtons mbButton = MessageBoxButtons.OK;
                        DialogResult result =
                            MessageBox.Show("You must select at least one report attribute to report. 'ID' will be selected automatically.", "Report Attributes", mbButton, mbIcon);
                        if (result == DialogResult.OK)
                        {
                            attributeCheckListBox.SetItemChecked(0, true);
                        }
                    }
                } while (attributeCheckListBox.CheckedItems.Count < 1);
            }
        }


        // CLEAR report
        private void clearButton_Click(object sender, EventArgs e)
        {
            dataListBox.Items.Clear();
            foreach (var client in Program.clients) { client.reportLine = ""; }
        }


        public string updateDigit(int digit)
        {
            if(digit < 10)
            {
                switch (digit)
                {
                    case 1:
                        return "01";
                    case 2:
                        return "02";
                    case 3:
                        return "03";
                    case 4:
                        return "04";
                    case 5:
                        return "05";
                    case 6:
                        return "06";
                    case 7:
                        return "07";
                    case 8:
                        return "08";
                    case 9:
                        return "09";
                }
                return "00";
            }
            else { return "" + digit; }
        }
    }

    public class ReportAttributes
    {
        public string header1;
        public string ID = "ID";
        public string ownerName = "Client Name";
        public string ownerPhone = "Client Phone";
        public string address = "Client Address";
        public string acctBalance = "Account Balance";
        public string timeWalked = "Time Walked";
        public string dogName = "Dog Name";
        public string breed = "Dog Breed";
        public string color = "Dog Color";
        public string toys = "Dog Toys";
        public string treats = "Dog Treats";
        public string hourlyRate = "Hourly Rate";        
        public string vetOffice = "Vet Office";
        public string vetPhone = "Vet Phone";
    }

    public class Report
    {
        public string header2;
        public string accountStatus = "Accounts Receivable";
        public string walkSummary = "Walk Summary";
        public string ownerDetail = "Owner Detail";
        public string dogDetail = "Dog Detail";
    } 
}
