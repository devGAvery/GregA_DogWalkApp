namespace DogWalkApp
{
    partial class TimedWalk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resumeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ssDomain = new System.Windows.Forms.DomainUpDown();
            this.mmDomain = new System.Windows.Forms.DomainUpDown();
            this.hhDomain = new System.Windows.Forms.DomainUpDown();
            this.updateTimeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.walkersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 24);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 32);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(28, 124);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(135, 32);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP / PAUSE";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(28, 75);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(135, 32);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resumeButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Location = new System.Drawing.Point(215, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // resumeButton
            // 
            this.resumeButton.Location = new System.Drawing.Point(28, 171);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(135, 32);
            this.resumeButton.TabIndex = 3;
            this.resumeButton.Text = "RESUME";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ssDomain);
            this.groupBox2.Controls.Add(this.mmDomain);
            this.groupBox2.Controls.Add(this.hhDomain);
            this.groupBox2.Controls.Add(this.updateTimeButton);
            this.groupBox2.Location = new System.Drawing.Point(423, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "SS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "MM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // ssDomain
            // 
            this.ssDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssDomain.Items.Add("00");
            this.ssDomain.Items.Add("01");
            this.ssDomain.Items.Add("02");
            this.ssDomain.Items.Add("03");
            this.ssDomain.Items.Add("04");
            this.ssDomain.Items.Add("05");
            this.ssDomain.Items.Add("06");
            this.ssDomain.Items.Add("07");
            this.ssDomain.Items.Add("08");
            this.ssDomain.Items.Add("09");
            this.ssDomain.Items.Add("10");
            this.ssDomain.Items.Add("11");
            this.ssDomain.Items.Add("12");
            this.ssDomain.Items.Add("13");
            this.ssDomain.Items.Add("14");
            this.ssDomain.Items.Add("15");
            this.ssDomain.Items.Add("16");
            this.ssDomain.Items.Add("17");
            this.ssDomain.Items.Add("18");
            this.ssDomain.Items.Add("19");
            this.ssDomain.Items.Add("20");
            this.ssDomain.Items.Add("21");
            this.ssDomain.Items.Add("22");
            this.ssDomain.Items.Add("23");
            this.ssDomain.Items.Add("24");
            this.ssDomain.Items.Add("25");
            this.ssDomain.Items.Add("26");
            this.ssDomain.Items.Add("27");
            this.ssDomain.Items.Add("28");
            this.ssDomain.Items.Add("29");
            this.ssDomain.Items.Add("30");
            this.ssDomain.Items.Add("31");
            this.ssDomain.Items.Add("32");
            this.ssDomain.Items.Add("33");
            this.ssDomain.Items.Add("34");
            this.ssDomain.Items.Add("35");
            this.ssDomain.Items.Add("36");
            this.ssDomain.Items.Add("37");
            this.ssDomain.Items.Add("38");
            this.ssDomain.Items.Add("39");
            this.ssDomain.Items.Add("40");
            this.ssDomain.Items.Add("41");
            this.ssDomain.Items.Add("42");
            this.ssDomain.Items.Add("43");
            this.ssDomain.Items.Add("44");
            this.ssDomain.Items.Add("45");
            this.ssDomain.Items.Add("46");
            this.ssDomain.Items.Add("47");
            this.ssDomain.Items.Add("48");
            this.ssDomain.Items.Add("49");
            this.ssDomain.Items.Add("50");
            this.ssDomain.Items.Add("51");
            this.ssDomain.Items.Add("52");
            this.ssDomain.Items.Add("53");
            this.ssDomain.Items.Add("54");
            this.ssDomain.Items.Add("55");
            this.ssDomain.Items.Add("56");
            this.ssDomain.Items.Add("57");
            this.ssDomain.Items.Add("58");
            this.ssDomain.Items.Add("59");
            this.ssDomain.Location = new System.Drawing.Point(203, 99);
            this.ssDomain.Name = "ssDomain";
            this.ssDomain.Size = new System.Drawing.Size(61, 38);
            this.ssDomain.TabIndex = 11;
            this.ssDomain.Text = "00";
            this.ssDomain.Wrap = true;
            // 
            // mmDomain
            // 
            this.mmDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmDomain.Items.Add("00");
            this.mmDomain.Items.Add("01");
            this.mmDomain.Items.Add("02");
            this.mmDomain.Items.Add("03");
            this.mmDomain.Items.Add("04");
            this.mmDomain.Items.Add("05");
            this.mmDomain.Items.Add("06");
            this.mmDomain.Items.Add("07");
            this.mmDomain.Items.Add("08");
            this.mmDomain.Items.Add("09");
            this.mmDomain.Items.Add("10");
            this.mmDomain.Items.Add("11");
            this.mmDomain.Items.Add("12");
            this.mmDomain.Items.Add("13");
            this.mmDomain.Items.Add("14");
            this.mmDomain.Items.Add("15");
            this.mmDomain.Items.Add("16");
            this.mmDomain.Items.Add("17");
            this.mmDomain.Items.Add("18");
            this.mmDomain.Items.Add("19");
            this.mmDomain.Items.Add("20");
            this.mmDomain.Items.Add("21");
            this.mmDomain.Items.Add("22");
            this.mmDomain.Items.Add("23");
            this.mmDomain.Items.Add("24");
            this.mmDomain.Items.Add("25");
            this.mmDomain.Items.Add("26");
            this.mmDomain.Items.Add("27");
            this.mmDomain.Items.Add("28");
            this.mmDomain.Items.Add("29");
            this.mmDomain.Items.Add("30");
            this.mmDomain.Items.Add("31");
            this.mmDomain.Items.Add("32");
            this.mmDomain.Items.Add("33");
            this.mmDomain.Items.Add("34");
            this.mmDomain.Items.Add("35");
            this.mmDomain.Items.Add("36");
            this.mmDomain.Items.Add("37");
            this.mmDomain.Items.Add("38");
            this.mmDomain.Items.Add("39");
            this.mmDomain.Items.Add("40");
            this.mmDomain.Items.Add("41");
            this.mmDomain.Items.Add("42");
            this.mmDomain.Items.Add("43");
            this.mmDomain.Items.Add("44");
            this.mmDomain.Items.Add("45");
            this.mmDomain.Items.Add("46");
            this.mmDomain.Items.Add("47");
            this.mmDomain.Items.Add("48");
            this.mmDomain.Items.Add("49");
            this.mmDomain.Items.Add("50");
            this.mmDomain.Items.Add("51");
            this.mmDomain.Items.Add("52");
            this.mmDomain.Items.Add("53");
            this.mmDomain.Items.Add("54");
            this.mmDomain.Items.Add("55");
            this.mmDomain.Items.Add("56");
            this.mmDomain.Items.Add("57");
            this.mmDomain.Items.Add("58");
            this.mmDomain.Items.Add("59");
            this.mmDomain.Location = new System.Drawing.Point(107, 99);
            this.mmDomain.Name = "mmDomain";
            this.mmDomain.Size = new System.Drawing.Size(61, 38);
            this.mmDomain.TabIndex = 10;
            this.mmDomain.Text = "00";
            this.mmDomain.Wrap = true;
            // 
            // hhDomain
            // 
            this.hhDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hhDomain.Items.Add("00");
            this.hhDomain.Items.Add("01");
            this.hhDomain.Items.Add("02");
            this.hhDomain.Items.Add("03");
            this.hhDomain.Items.Add("04");
            this.hhDomain.Items.Add("05");
            this.hhDomain.Items.Add("06");
            this.hhDomain.Items.Add("07");
            this.hhDomain.Items.Add("08");
            this.hhDomain.Items.Add("09");
            this.hhDomain.Items.Add("10");
            this.hhDomain.Items.Add("11");
            this.hhDomain.Items.Add("12");
            this.hhDomain.Items.Add("13");
            this.hhDomain.Items.Add("14");
            this.hhDomain.Items.Add("15");
            this.hhDomain.Items.Add("16");
            this.hhDomain.Items.Add("17");
            this.hhDomain.Items.Add("18");
            this.hhDomain.Items.Add("19");
            this.hhDomain.Items.Add("20");
            this.hhDomain.Items.Add("21");
            this.hhDomain.Items.Add("22");
            this.hhDomain.Items.Add("23");
            this.hhDomain.Location = new System.Drawing.Point(11, 99);
            this.hhDomain.Name = "hhDomain";
            this.hhDomain.Size = new System.Drawing.Size(61, 38);
            this.hhDomain.TabIndex = 9;
            this.hhDomain.Text = "00";
            this.hhDomain.Wrap = true;
            // 
            // updateTimeButton
            // 
            this.updateTimeButton.Location = new System.Drawing.Point(73, 171);
            this.updateTimeButton.Name = "updateTimeButton";
            this.updateTimeButton.Size = new System.Drawing.Size(135, 32);
            this.updateTimeButton.TabIndex = 9;
            this.updateTimeButton.Text = "UPDATE";
            this.updateTimeButton.UseVisualStyleBackColor = true;
            this.updateTimeButton.Click += new System.EventHandler(this.updateTimeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL TIME WALKED:";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalTimeLabel.Location = new System.Drawing.Point(463, 292);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(141, 36);
            this.totalTimeLabel.TabIndex = 7;
            this.totalTimeLabel.Text = "00:00:00";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 345);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(231, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "SAVE and EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(249, 9);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 20);
            this.currentDateLabel.TabIndex = 10;
            this.currentDateLabel.Text = "DD/MM/YYYY";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.walkersListBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 220);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Walkers";
            // 
            // walkersListBox
            // 
            this.walkersListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.walkersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walkersListBox.FormattingEnabled = true;
            this.walkersListBox.ItemHeight = 16;
            this.walkersListBox.Location = new System.Drawing.Point(6, 33);
            this.walkersListBox.Name = "walkersListBox";
            this.walkersListBox.Size = new System.Drawing.Size(185, 176);
            this.walkersListBox.TabIndex = 0;
            // 
            // TimedWalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimedWalk";
            this.Text = "Walk Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown ssDomain;
        private System.Windows.Forms.DomainUpDown mmDomain;
        private System.Windows.Forms.DomainUpDown hhDomain;
        private System.Windows.Forms.Button updateTimeButton;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ListBox walkersListBox;
    }
}