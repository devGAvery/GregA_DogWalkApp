// Gregory Avery, #700676536, gra65360@ucmo.edu; Final Project - Dog Walking App

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

    public partial class MainPage : Form
    {
                
        public MainPage()
        {
            InitializeComponent();
        }

        // NEW ACCOUNT PAGE
        private void newAcctButton_Click(object sender, EventArgs e)
        {
            AccountPage ap = new AccountPage();  // instantiate the AccountPage

            // make new client, add to clients array in Program.cs
            Account newAcct = new Account();
            Program.clients.Add(newAcct);
            newAcct.ID = Program.clients.Count();
            ap.idLabel.Text = "" + newAcct.ID;

            // make AccountPage visible and hide MainPage
            ap.Show();
            this.Hide();
        }

        // ACCOUNT DETAIL PAGE
        private void viewAcctButton_Click(object sender, EventArgs e)
        {
            if (acctCheckListBox.CheckedItems.Count > 1) // if multiple accounts are selected to view
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result = 
                    MessageBox.Show("Only one client may be selected for the account view.","Account Selection", mbButton, mbIcon);
                if(result == DialogResult.OK) { unselectAllRadioButton.Checked = true; }
            }
            else if (acctCheckListBox.CheckedItems.Count < 1) // if no account is selected to view
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result =
                    MessageBox.Show("You must select one client for the account view.", "Account Selection", mbButton, mbIcon);
            }
            else {
                int clientIndex = 0;
                foreach (string selectedActiveAcct in acctCheckListBox.CheckedItems) 
                {
                    for(int i = 0; i < Program.clients.Count; i++)
                    {
                        if (selectedActiveAcct == 
                            "" + Program.clients[i].ID + ". " + Program.clients[i].dogName + " - " + Program.clients[i].ownerName)
                        { clientIndex = i; }
                    }
                }

                AccountPage ap = new AccountPage();
                ap.timeLabel.Text = "" + checkLessThanTen(Program.clients[clientIndex].totalDaysWalked) + ":" +
                    checkLessThanTen(Program.clients[clientIndex].totalHoursWalked) + ":" +
                    checkLessThanTen(Program.clients[clientIndex].totalMinutesWalked) + ":" +
                    checkLessThanTen(Program.clients[clientIndex].totalSecondsWalked);
                ap.idLabel.Text = "" + Program.clients[clientIndex].ID;
                ap.dogNameTextBox.Text = Program.clients[clientIndex].dogName;
                ap.breedTextBox.Text = Program.clients[clientIndex].breed;
                ap.toysTextBox.Text = Program.clients[clientIndex].toys;
                ap.treatsTextBox.Text = Program.clients[clientIndex].treats;
                ap.rateTextBox.Text = "" + Program.clients[clientIndex].hourlyRate;
                ap.colorTextBox.Text = Program.clients[clientIndex].color;
                ap.vetOfficeTextBox.Text = Program.clients[clientIndex].vetOffice;
                ap.vetPhoneTextBox.Text = Program.clients[clientIndex].vetPhone;
                ap.ownerNameTextBox.Text = Program.clients[clientIndex].ownerName;
                ap.ownerPhoneTextBox.Text = Program.clients[clientIndex].ownerPhone;
                ap.streetTextBox.Text = Program.clients[clientIndex].street;
                ap.aptTextBox.Text = Program.clients[clientIndex].apt;
                ap.cityTextBox.Text = Program.clients[clientIndex].city;
                ap.stComboBox.Text = Program.clients[clientIndex].state;
                ap.zipTextBox.Text = Program.clients[clientIndex].zip;

                ap.pictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"{Program.clients[clientIndex].imageName}"));

                if (Program.clients[clientIndex].activeClient == true) { ap.activeRadioButton.Checked = true; }
                if (Program.clients[clientIndex].activeClient == false) { ap.inactiveRadioButton.Checked = true; }

                foreach (string note in Program.clients[clientIndex].notes)
                { ap.notesListBox.Items.Add(note); }

                ap.Show();
                this.Hide();
            }
        }

        // EXIT APPLICATION
        private void exitButton_Click(object sender, EventArgs e) { Application.Exit(); }

        // SELECT ALL FROM CLIENT CHECKLIST BOX
        private void selectAllRadioButton_CheckedChanged(object sender, EventArgs e)
        { for (int j = 0; j < acctCheckListBox.Items.Count; j++) { acctCheckListBox.SetItemChecked(j, true); } }

        // UN-SELECT ALL FROM CLIENT CHECKLIST BOX
        private void unselectAllRadioButton_CheckedChanged(object sender, EventArgs e)
        { for (int j = 0; j < acctCheckListBox.Items.Count; j++) { acctCheckListBox.SetItemChecked(j, false); } }

        /*
        // INVOICE PAGE (SINGLE CLIENT)
        private void indivReportButton_Click(object sender, EventArgs e)
        {
            if (acctCheckListBox.CheckedItems.Count > 1) // if multiple accounts are selected to view
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result =
                    MessageBox.Show("Only one client may be selected for the individual report.", "Report Selection", mbButton, mbIcon);
                if (result == DialogResult.OK) { unselectAllRadioButton.Checked = true; }
            }
            else if (acctCheckListBox.CheckedItems.Count < 1) // if no account is selected to view
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result =
                    MessageBox.Show("You must select one client for the individual report.", "Report Selection", mbButton, mbIcon);
            }
            else
            {
                InvoicePage ip = new InvoicePage();

                foreach (int indexChecked in acctCheckListBox.CheckedIndices)
                {
                    ip.clientLabel.Text = "" + Program.clients[indexChecked].ID + " - " + Program.clients[indexChecked].dogName
                       + "  [" + Program.clients[indexChecked].breed + "]";

                    ip.ownerLabel.Text = "" + Program.clients[indexChecked].ownerName;

                    ip.rateLabel.Text = "$" + Program.clients[indexChecked].hourlyRate + ".00";
                }

                var checkedObjects =
                    from objs in Program.clients
                    where acctCheckListBox.CheckedItems.Contains(objs) == true
                    select objs.walkDates;

                var dateTimes =
                    from dtTm in checkedObjects
                    where dtTm != null
                    select dtTm;

                foreach (var data in dateTimes)
                {
                    ip.singleReportListBox.Items.Add("1. " + data.ToString());
                    Console.WriteLine($"{data}");
                }

                ip.Show();
                this.Hide();
            }
        }
        */

        // REPORT PAGE
        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportPage rp = new ReportPage();
            rp.dateLabel.Text = DateTime.Now.ToString();

            // update client listing
            foreach (Account acct in Program.clients)
            {
                // only update unique owner info
                if (!rp.clientCheckListBox.Items.Contains(acct.ownerName)) { rp.clientCheckListBox.Items.Add(acct.ownerName); }
            }

            // update reporting attributes
            ReportAttributes reportData = new ReportAttributes();
            rp.attributeCheckListBox.Items.Add(reportData.ID);
            rp.attributeCheckListBox.Items.Add(reportData.ownerName);
            rp.attributeCheckListBox.Items.Add(reportData.ownerPhone);
            rp.attributeCheckListBox.Items.Add(reportData.address);
            rp.attributeCheckListBox.Items.Add(reportData.hourlyRate);
            rp.attributeCheckListBox.Items.Add(reportData.acctBalance);
            rp.attributeCheckListBox.Items.Add(reportData.timeWalked);
            rp.attributeCheckListBox.Items.Add(reportData.dogName);
            rp.attributeCheckListBox.Items.Add(reportData.breed);
            rp.attributeCheckListBox.Items.Add(reportData.color);
            rp.attributeCheckListBox.Items.Add(reportData.toys);
            rp.attributeCheckListBox.Items.Add(reportData.treats);
            rp.attributeCheckListBox.Items.Add(reportData.vetOffice);
            rp.attributeCheckListBox.Items.Add(reportData.vetPhone);

            // update prefab reports
            Report standardReport = new Report();
            rp.reportCheckListBox.Items.Add(standardReport.walkSummary);
            rp.reportCheckListBox.Items.Add(standardReport.ownerDetail);
            rp.reportCheckListBox.Items.Add(standardReport.dogDetail);
            rp.reportCheckListBox.Items.Add(standardReport.accountStatus);

            rp.Show();
            this.Hide();
        }

        // TIMED WALK PAGE
        private void timedWalkButton_Click(object sender, EventArgs e)
        {
            TimedWalk tw = new TimedWalk();

            foreach (int indexChecked in acctCheckListBox.CheckedIndices)
            { tw.walkersListBox.Items.Add(Program.clients[indexChecked].dogName + " - " + Program.clients[indexChecked].breed); }

            tw.Show();
            this.Hide();
        }

        public string checkLessThanTen(int checkDigit)
        {
            if (checkDigit < 10) 
            {
                switch (checkDigit)
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
            else { return "" + checkDigit; }
        }
    }
}
