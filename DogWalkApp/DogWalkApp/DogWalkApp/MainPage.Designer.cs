namespace DogWalkApp
{
    partial class MainPage
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
            this.newAcctButton = new System.Windows.Forms.Button();
            this.viewAcctButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timedWalkButton = new System.Windows.Forms.Button();
            this.acctCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectAllRadioButton = new System.Windows.Forms.RadioButton();
            this.unselectAllRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAcctButton
            // 
            this.newAcctButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAcctButton.Location = new System.Drawing.Point(28, 43);
            this.newAcctButton.Margin = new System.Windows.Forms.Padding(4);
            this.newAcctButton.Name = "newAcctButton";
            this.newAcctButton.Size = new System.Drawing.Size(156, 48);
            this.newAcctButton.TabIndex = 2;
            this.newAcctButton.Text = "NEW ACCOUNT";
            this.newAcctButton.UseVisualStyleBackColor = true;
            this.newAcctButton.Click += new System.EventHandler(this.newAcctButton_Click);
            // 
            // viewAcctButton
            // 
            this.viewAcctButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAcctButton.Location = new System.Drawing.Point(28, 111);
            this.viewAcctButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewAcctButton.Name = "viewAcctButton";
            this.viewAcctButton.Size = new System.Drawing.Size(156, 48);
            this.viewAcctButton.TabIndex = 3;
            this.viewAcctButton.Text = "VIEW ACCOUNT";
            this.viewAcctButton.UseVisualStyleBackColor = true;
            this.viewAcctButton.Click += new System.EventHandler(this.viewAcctButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(23, 111);
            this.reportButton.Margin = new System.Windows.Forms.Padding(4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(156, 52);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "REPORTS";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newAcctButton);
            this.groupBox1.Controls.Add(this.viewAcctButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(215, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportButton);
            this.groupBox3.Controls.Add(this.timedWalkButton);
            this.groupBox3.Location = new System.Drawing.Point(239, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(203, 187);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applications";
            // 
            // timedWalkButton
            // 
            this.timedWalkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedWalkButton.Location = new System.Drawing.Point(23, 43);
            this.timedWalkButton.Margin = new System.Windows.Forms.Padding(4);
            this.timedWalkButton.Name = "timedWalkButton";
            this.timedWalkButton.Size = new System.Drawing.Size(156, 52);
            this.timedWalkButton.TabIndex = 1;
            this.timedWalkButton.Text = "TIMED WALK";
            this.timedWalkButton.UseVisualStyleBackColor = true;
            this.timedWalkButton.Click += new System.EventHandler(this.timedWalkButton_Click);
            // 
            // acctCheckListBox
            // 
            this.acctCheckListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.acctCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acctCheckListBox.CheckOnClick = true;
            this.acctCheckListBox.FormattingEnabled = true;
            this.acctCheckListBox.Location = new System.Drawing.Point(21, 60);
            this.acctCheckListBox.Margin = new System.Windows.Forms.Padding(4);
            this.acctCheckListBox.Name = "acctCheckListBox";
            this.acctCheckListBox.Size = new System.Drawing.Size(248, 221);
            this.acctCheckListBox.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(159, 231);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT APP";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selectAllRadioButton
            // 
            this.selectAllRadioButton.AutoSize = true;
            this.selectAllRadioButton.Location = new System.Drawing.Point(21, 29);
            this.selectAllRadioButton.Name = "selectAllRadioButton";
            this.selectAllRadioButton.Size = new System.Drawing.Size(111, 21);
            this.selectAllRadioButton.TabIndex = 8;
            this.selectAllRadioButton.TabStop = true;
            this.selectAllRadioButton.Text = "SELECT ALL";
            this.selectAllRadioButton.UseVisualStyleBackColor = true;
            this.selectAllRadioButton.CheckedChanged += new System.EventHandler(this.selectAllRadioButton_CheckedChanged);
            // 
            // unselectAllRadioButton
            // 
            this.unselectAllRadioButton.AutoSize = true;
            this.unselectAllRadioButton.Location = new System.Drawing.Point(138, 29);
            this.unselectAllRadioButton.Name = "unselectAllRadioButton";
            this.unselectAllRadioButton.Size = new System.Drawing.Size(131, 21);
            this.unselectAllRadioButton.TabIndex = 9;
            this.unselectAllRadioButton.TabStop = true;
            this.unselectAllRadioButton.Text = "UNSELECT ALL";
            this.unselectAllRadioButton.UseVisualStyleBackColor = true;
            this.unselectAllRadioButton.CheckedChanged += new System.EventHandler(this.unselectAllRadioButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.acctCheckListBox);
            this.groupBox4.Controls.Add(this.unselectAllRadioButton);
            this.groupBox4.Controls.Add(this.selectAllRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(450, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 308);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Client Listing";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 345);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newAcctButton;
        private System.Windows.Forms.Button viewAcctButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button timedWalkButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.CheckedListBox acctCheckListBox;
        private System.Windows.Forms.RadioButton selectAllRadioButton;
        private System.Windows.Forms.RadioButton unselectAllRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}