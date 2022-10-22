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
    public partial class TimedWalk : Form
    {
        private Timer timer1 = new Timer();
        private int secCount;
        private int minCount;
        private int hourCount;
        private string frmtSec = "00";
        private string frmtMin = "00";
        private string frmtHr = "00";
        private string totalTimeSec = "00";
        private string totalTimeMin = "00";
        private string totalTimeHr = "00";
        public DateTime currentDate = DateTime.Now;

        public TimedWalk()
        {
            InitializeComponent();

            currentDateLabel.Text = "" + currentDate;
        }

        // TIMER START
        private void startButton_Click(object sender, EventArgs e)
        {
            secCount = 0;
            minCount = 0;
            hourCount = 0;
            Timer timer = new Timer();
            timer1 = timer;
            timer1.Interval = 1000;
            timer1.Tick += timerTick;
            timer1.Enabled = true;
        }

        private void timerTick(object sender, EventArgs e)
        { 
            secCount++;
            if (secCount == 60) { minCount++; secCount = 0; }
            if(minCount == 60) { hourCount++; minCount = 0; }
            if (secCount < 10) { frmtSec = "0" + secCount; } else if(secCount > 9) { frmtSec = "" + secCount; }
            if (minCount < 10) { frmtMin = "0" + minCount; } else if(minCount > 9) { frmtMin = "" + minCount; }
            if(hourCount < 10) { frmtHr = "0" + hourCount; } else if(hourCount > 9) { frmtHr = "" + hourCount; }
            timeLabel.Text = frmtHr + ":" + frmtMin + ":" + frmtSec;
            totalTimeHr = frmtHr;
            totalTimeMin = frmtMin;
            totalTimeSec = frmtSec;
            totalTimeLabel.Text = totalTimeHr + ":" + totalTimeMin + ":" + totalTimeSec;
        }

        // TIMER PAUSE/STOP
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //totalTimeHr = frmtHr;
            //totalTimeMin = frmtMin;
            //totalTimeSec = frmtSec;
            totalTimeLabel.Text = totalTimeHr + ":" + totalTimeMin + ":" + totalTimeSec;
            zeroFormatedTime();
            timeLabel.Text = frmtHr + ":" + frmtMin + ":" + frmtSec;
        }

        // TIMER RESUME TIMING
        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (frmtMin != "00" || frmtSec != "00") { }
            else
            {
                timeLabel.Text = totalTimeLabel.Text;
                timer1.Enabled = true;
            }
        }

        // SAVE & EXIT
        private void exitButton_Click(object sender, EventArgs e)
        {
            // prevent exit while timer is running, if not running allow update of time to walkers and exit timer
            if(frmtMin != "00" || frmtSec != "00" || frmtHr != "00")
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result =
                    MessageBox.Show("You may not exit while the timer is running. Stop the timer to then Exit.", "Timer Interupt", mbButton, mbIcon);
            }
            else
            {
                MainPage mp = new MainPage();

                foreach (Account acct in Program.clients)
                {
                    // load the new Main page checked list box with clients
                    if (acct.activeClient == true)
                    {
                        mp.acctCheckListBox.Items.Add($"{acct.ID}. {acct.dogName} - {acct.ownerName}");
                    }

                    // update clients that walked with the total walked time
                    if (walkersListBox.Items.Contains(acct.dogName + " - " + acct.breed) == true)
                    {
                        //Console.WriteLine($"Program.clients[{i}].dogName: {Program.clients[i].dogName}, Program.clients[{i}].breed: {Program.clients[i].breed}");
                        acct.addTotalSecondsWalked(Int32.Parse(totalTimeSec));
                        acct.addTotalMinutesWalked(Int32.Parse(totalTimeMin));
                        acct.addTotalHoursWalked(Int32.Parse(totalTimeHr));

                        // calculate billable time by hourly rate, add to account balance
                        acct.acctBalance += (acct.hourlyRate * Int32.Parse(totalTimeHr)) + (acct.hourlyRate * (Int32.Parse(totalTimeMin)/60.0));

                        // add walk date/time stamp and walk time to account
                        acct.walkTimes.Add(updateDigit(Int32.Parse(totalTimeHr)) + ":" + 
                            updateDigit(Int32.Parse(totalTimeMin)) + ":" + updateDigit(Int32.Parse(totalTimeSec)));
                        
                        acct.walkDates.Add(DateTime.Now);
                    }
                }

                mp.Show();
                this.Hide();
            }
        }

        // UPDATE manual time
        public void updateTimeButton_Click(object sender, EventArgs e)
        {
            string[] singleDigits = new string[10] {"0","1","2","3","4","5","6","7","8","9"};

            // manual input; check for Hours input inclusive to acceptable time range for Hours
            if (!hhDomain.Items.Contains(hhDomain.Text))
            {
                if (singleDigits.Contains(hhDomain.Text))
                {
                    hhDomain.Text = updateDigit(Int32.Parse(hhDomain.Text));
                }
                else
                {
                    MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                    MessageBoxButtons mbButton = MessageBoxButtons.OK;
                    DialogResult result =
                        MessageBox.Show("The HOUR value input must be in the respective range.", "Time Input Value Error", mbButton, mbIcon);
                }
            }

            // manual input; check for Minutes input inclusive to acceptable time range for Minutes
            if (!mmDomain.Items.Contains(mmDomain.Text))
            {
                if (singleDigits.Contains(mmDomain.Text))
                {
                    mmDomain.Text = updateDigit(Int32.Parse(mmDomain.Text));
                }
                else
                {
                    MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                    MessageBoxButtons mbButton = MessageBoxButtons.OK;
                    DialogResult result =
                        MessageBox.Show("The MINUTE value input must be in the respective range.", "Time Input Value Error", mbButton, mbIcon);
                }
            }

            // manual input; check for Seconds input inclusive to acceptable time range for Seconds
            if (!ssDomain.Items.Contains(ssDomain.Text))
            {
                if (singleDigits.Contains(ssDomain.Text))
                {
                    ssDomain.Text = updateDigit(Int32.Parse(ssDomain.Text));
                }
                else
                {
                    MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                    MessageBoxButtons mbButton = MessageBoxButtons.OK;
                    DialogResult result =
                        MessageBox.Show("The SECONDS value input must be in the respective range.", "Time Input Value Error", mbButton, mbIcon);
                }
            }

            // if manual input for HH/MM/SS do not meet the acceptable range, generic error message or process update
            if (hhDomain.Items.Contains(hhDomain.Text) && mmDomain.Items.Contains(mmDomain.Text) && ssDomain.Items.Contains(ssDomain.Text))
            {
                checkManualAdd();
            }
            else
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OK;
                DialogResult result =
                    MessageBox.Show("The time values input must be in the respective range.", "Time Input Value Error", mbButton, mbIcon);
            }
        }

        public void checkManualAdd()
        {
            // check for manual override during ongoing timer or prior manually updated time
            if (totalTimeLabel.Text != "00:00:00") 
            {
                MessageBoxIcon mbIcon = MessageBoxIcon.Warning;
                MessageBoxButtons mbButton = MessageBoxButtons.OKCancel;
                DialogResult result =
                    MessageBox.Show("The manual time update will overwrite the existing time. Press 'OK' to proceed, and 'Cancel' to abort update.", "Manual Time Overwrite", mbButton, mbIcon);
                if (result == DialogResult.OK)
                {
                    updateTime();
                }
                else if (result == DialogResult.Cancel)
                {
                    hhDomain.Text = "00";
                    mmDomain.Text = "00";
                    ssDomain.Text = "00";
                }
                else { Console.WriteLine("Error in checkManualAdd()"); }
            }
            else
            {
                updateTime();
            }
        }

        public void updateTime()
        {
            //Console.WriteLine("updateTime()");
            //Console.WriteLine($"BEFORE:  frmtHr: {frmtHr}, frmtMin: {frmtMin}, frmtSec: {frmtSec}");

            // pass manual update (xxDomain.Text) to frmtXx to override any autotimer acrued time
            frmtHr = hhDomain.Text;
            frmtMin = mmDomain.Text;
            frmtSec = ssDomain.Text;
            Console.WriteLine($"AFTER:  frmtHr: {frmtHr}, frmtMin: {frmtMin}, frmtSec: {frmtSec}");

            //Console.WriteLine($"BEFORE:  totalTimeHr: {totalTimeHr}, totalTimeMin: {totalTimeMin}, totalTimeSec: {totalTimeSec}");
            totalTimeHr = stripLeadingZero(frmtHr);
            totalTimeMin = stripLeadingZero(frmtMin);
            totalTimeSec = stripLeadingZero(frmtSec);
            //Console.WriteLine($"AFTER:  totalTimeHr: {totalTimeHr}, totalTimeMin: {totalTimeMin}, totalTimeSec: {totalTimeSec}");

            totalTimeLabel.Text = frmtHr + ":" + frmtMin + ":" + frmtSec;
            //Console.WriteLine($"AFTER:  totalTimeLabel.Text: {totalTimeLabel.Text}");

            zeroFormatedTime();
        }

        public string updateDigit(int digit)
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

        public void zeroFormatedTime()
        {
            frmtHr = "00";
            frmtMin = "00";
            frmtSec = "00";
        }

        public string stripLeadingZero(string zeroNum)
        {
            if (zeroNum.Substring(0, 1) == "0") { return zeroNum.Substring(1, 1); }
            else { return zeroNum; }
        }
    }
}
