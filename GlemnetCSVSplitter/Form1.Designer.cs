namespace CSVSplitter
{
    partial class frmMain
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
            this.lblSplitAfter = new System.Windows.Forms.Label();
            this.splitAfter = new System.Windows.Forms.NumericUpDown();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOptionText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFileExtension = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSplitAfter
            // 
            this.lblSplitAfter.AutoSize = true;
            this.lblSplitAfter.Location = new System.Drawing.Point(12, 129);
            this.lblSplitAfter.Name = "lblSplitAfter";
            this.lblSplitAfter.Size = new System.Drawing.Size(122, 13);
            this.lblSplitAfter.TabIndex = 3;
            this.lblSplitAfter.Text = "SPLIT AFTER # ROWS";
            // 
            // splitAfter
            // 
            this.splitAfter.Location = new System.Drawing.Point(15, 145);
            this.splitAfter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.splitAfter.Name = "splitAfter";
            this.splitAfter.Size = new System.Drawing.Size(95, 20);
            this.splitAfter.TabIndex = 2;
            this.splitAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.splitAfter.Value = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(98, 43);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(252, 20);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(356, 41);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(109, 23);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILE TO SPLIT";
            // 
            // txtOptionText
            // 
            this.txtOptionText.Location = new System.Drawing.Point(12, 93);
            this.txtOptionText.Name = "txtOptionText";
            this.txtOptionText.Size = new System.Drawing.Size(198, 20);
            this.txtOptionText.TabIndex = 7;
            this.txtOptionText.TextChanged += new System.EventHandler(this.txtOptionText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "OUTPUT NAMING FORMAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "#FILENUMBER#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "+";
            // 
            // comboFileExtension
            // 
            this.comboFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFileExtension.FormattingEnabled = true;
            this.comboFileExtension.Items.AddRange(new object[] {
            "CSV",
            "TXT"});
            this.comboFileExtension.Location = new System.Drawing.Point(356, 93);
            this.comboFileExtension.Name = "comboFileExtension";
            this.comboFileExtension.Size = new System.Drawing.Size(109, 21);
            this.comboFileExtension.TabIndex = 14;
            this.comboFileExtension.SelectedIndexChanged += new System.EventHandler(this.comboFileExtension_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CSV File Splitter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "© Copyright Alex Hopkins 2012";
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(346, 237);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(119, 31);
            this.btnSplit.TabIndex = 17;
            this.btnSplit.Text = "Start Splitting";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ReportProgress);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.AutoSize = true;
            this.lblPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.Location = new System.Drawing.Point(93, 87);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(309, 50);
            this.lblPleaseWait.TabIndex = 18;
            this.lblPleaseWait.Text = "... Please Wait ...\r\nThis may take several minutes!";
            this.lblPleaseWait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPleaseWait.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 280);
            this.Controls.Add(this.lblPleaseWait);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboFileExtension);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOptionText);
            this.Controls.Add(this.lblSplitAfter);
            this.Controls.Add(this.splitAfter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.splitAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplitAfter;
        private System.Windows.Forms.NumericUpDown splitAfter;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOptionText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboFileExtension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSplit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPleaseWait;

    }
}

