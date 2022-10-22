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
    public partial class AccountPage : Form
    {
        public MainPage mp = new MainPage();

        public AccountPage()
        { InitializeComponent(); }

        // UPDATE Account info
        private void updateButton_Click(object sender, EventArgs e)  // Update account
        {
            int tempIndex = (Int32.Parse(idLabel.Text)) - 1;
            if(activeRadioButton.Checked == true) { Program.clients[tempIndex].activeClient = true; }
            else
            {
                if (inactiveRadioButton.Checked == true) { Program.clients[tempIndex].activeClient = false; }
                else 
                {
                    // default client status is active when new acct created
                    Program.clients[tempIndex].activeClient = true;
                    activeRadioButton.Checked = true;
                } 
            }

            Program.clients[tempIndex].dogName = dogNameTextBox.Text;
            Program.clients[tempIndex].breed = breedTextBox.Text;
            if(rateTextBox.TextLength == 0) { rateTextBox.Text = "" + 0.00; }
            else { Program.clients[tempIndex].hourlyRate = Double.Parse(rateTextBox.Text); }
            Program.clients[tempIndex].color = colorTextBox.Text;
            Program.clients[tempIndex].vetOffice = vetOfficeTextBox.Text;
            Program.clients[tempIndex].vetPhone = vetPhoneTextBox.Text;
            Program.clients[tempIndex].ownerName = ownerNameTextBox.Text;
            Program.clients[tempIndex].ownerPhone = ownerPhoneTextBox.Text;
            Program.clients[tempIndex].street = streetTextBox.Text;
            Program.clients[tempIndex].apt = aptTextBox.Text;
            Program.clients[tempIndex].city = cityTextBox.Text;
            Program.clients[tempIndex].state = stComboBox.Text;
            Program.clients[tempIndex].zip = zipTextBox.Text;
            Program.clients[tempIndex].toys = toysTextBox.Text;
            Program.clients[tempIndex].treats = treatsTextBox.Text;
            Program.clients[tempIndex].imageName = "clifford";  //default pic for new account(s)

            Program.clients[tempIndex].notes.Clear();
            foreach(string note in notesListBox.Items)
            { Program.clients[tempIndex].notes.Add(note); }

            MessageBoxIcon mbIcon = MessageBoxIcon.Information;
            MessageBoxButtons mbButton = MessageBoxButtons.OK;
            DialogResult result =
                MessageBox.Show("The account information has been saved.", "Account Data", mbButton, mbIcon);
        }

        // ADD Note button, adds textbox note to the notes List
        private void addNoteButton_Click(object sender, EventArgs e)
        {
            notesListBox.Items.Add(notesTextBox.Text);
            notesTextBox.Text = null;
        }

        // EXIT button, leave Account View Page return to Main Page
        private void exitButton_Click(object sender, EventArgs e) 
        {
            // if exit from 'New Account' form without entering dog and owner name, then remove new client object
            if (dogNameTextBox.TextLength == 0 && ownerNameTextBox.TextLength == 0) 
            { Program.clients.Remove(Program.clients[Int32.Parse(idLabel.Text) - 1]); }

            MainPage mp = new MainPage();
            foreach (Account acct in Program.clients)
            {
                if (acct.activeClient == true)
                { mp.acctCheckListBox.Items.Add($"{acct.ID}. {acct.dogName} - {acct.ownerName}"); } 
            }

            mp.Show();
            this.Hide();
        }

        private void radioButtonSelect()
        {
            if (activeRadioButton.Checked == true) { inactiveRadioButton.Checked = false; }
            else { inactiveRadioButton.Checked = true; activeRadioButton.Checked = false; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { radioButtonSelect(); }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { radioButtonSelect(); }
    }
}
