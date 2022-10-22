namespace DogWalkApp
{
    partial class ReportPage
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
            this.exitButton = new System.Windows.Forms.Button();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.clientCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.attributeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.reportCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(694, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 49);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataListBox
            // 
            this.dataListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 16;
            this.dataListBox.Location = new System.Drawing.Point(29, 336);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(765, 228);
            this.dataListBox.TabIndex = 1;
            // 
            // clientCheckListBox
            // 
            this.clientCheckListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.clientCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientCheckListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.clientCheckListBox.FormattingEnabled = true;
            this.clientCheckListBox.Location = new System.Drawing.Point(6, 30);
            this.clientCheckListBox.Name = "clientCheckListBox";
            this.clientCheckListBox.Size = new System.Drawing.Size(197, 187);
            this.clientCheckListBox.TabIndex = 5;
            // 
            // attributeCheckListBox
            // 
            this.attributeCheckListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.attributeCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attributeCheckListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.attributeCheckListBox.FormattingEnabled = true;
            this.attributeCheckListBox.Location = new System.Drawing.Point(5, 28);
            this.attributeCheckListBox.Name = "attributeCheckListBox";
            this.attributeCheckListBox.Size = new System.Drawing.Size(213, 204);
            this.attributeCheckListBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(360, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 20);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "label1";
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(694, 86);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 49);
            this.runButton.TabIndex = 10;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(29, 20);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(140, 21);
            this.activeCheckBox.TabIndex = 11;
            this.activeCheckBox.Text = "Active Account(s)";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(29, 48);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(150, 21);
            this.inactiveCheckBox.TabIndex = 12;
            this.inactiveCheckBox.Text = "Inactive Account(s)";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(694, 179);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 49);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // reportCheckListBox
            // 
            this.reportCheckListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.reportCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportCheckListBox.FormattingEnabled = true;
            this.reportCheckListBox.Location = new System.Drawing.Point(6, 34);
            this.reportCheckListBox.Name = "reportCheckListBox";
            this.reportCheckListBox.Size = new System.Drawing.Size(194, 187);
            this.reportCheckListBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportCheckListBox);
            this.groupBox1.Location = new System.Drawing.Point(244, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 238);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standardized Reports";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.attributeCheckListBox);
            this.groupBox2.Location = new System.Drawing.Point(464, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 238);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Report Attributes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clientCheckListBox);
            this.groupBox3.Location = new System.Drawing.Point(29, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 236);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Listing";
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inactiveCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.exitButton);
            this.Name = "ReportPage";
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.ListBox dataListBox;
        public System.Windows.Forms.CheckedListBox clientCheckListBox;
        public System.Windows.Forms.CheckedListBox attributeCheckListBox;
        private System.Windows.Forms.Button runButton;
        public System.Windows.Forms.CheckBox activeCheckBox;
        public System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.CheckedListBox reportCheckListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}