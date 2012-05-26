using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVSplitter
{
    public struct ThreadNode
    {
        public string InputFileName;
        public string InputFilePath;
        public string OutputFilePath;
        public string OutputFileName;
        public string OutputFileExtension;
        public int MaxRowsPerFile;
    }

    public partial class frmMain : Form
    {
        OpenFileDialog ofd;

        FileSplitter fileSplitter; // An instance of the file splitting class

        public frmMain()
        {
            InitializeComponent();

            // Set up the new dialog
            ofd = new OpenFileDialog() { Filter = "Text Files or CSV Files (*.txt, *.csv)|*.txt;*.csv" };
            fileSplitter = new FileSplitter();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // If a file was chosen, set the textbox
                txtFileName.Text = ofd.FileName;
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }

        /// <summary>
        /// Checks if the application is ready to start splitting
        /// </summary>
        private void CheckIfReady()
        {
            if (txtFileName.Text == "" || comboFileExtension.Text == "" || txtOptionText.Text == "")
            {
                btnSplit.Enabled = false;
            }
            else
            {
                btnSplit.Enabled = true;
            }
        }

        private void comboFileExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            ThreadNode data = new ThreadNode()
            {
                InputFileName = txtFileName.Text,
                InputFilePath = ofd.FileName.Substring(0, (ofd.FileName.Length - ofd.SafeFileName.Length)),
                MaxRowsPerFile = (int)splitAfter.Value,
                OutputFileExtension = comboFileExtension.Text,
                OutputFileName = txtOptionText.Text,
                OutputFilePath = ofd.FileName.Substring(0, (ofd.FileName.Length - ofd.SafeFileName.Length))
            };
            startJob();
            backgroundWorker1.RunWorkerAsync(data);
        }

        private void txtOptionText_TextChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ThreadNode data = (ThreadNode)e.Argument;

            if (string.IsNullOrEmpty(data.InputFileName))
            {
                // Cannot process the file, the filename is invalid
                return;
            }

            // Create the new streamreader to access the file
            StreamReader file = new StreamReader(data.InputFileName);

            // Create a line string object
            string line = string.Empty;

            // Grab the header first for re-use
            string header = file.ReadLine();

            // Create the counting object
            int currentRowCount = 1;

            // Create the filename appendix count
            int currentFileNumber = 0;

            // Create the output string array
            List<string> outputStrings = new List<string>();

            // Loop through the file until there are no more lines to read
            while ((line = file.ReadLine()) != null)
            {
                #region Save Operation

                if (currentRowCount >= splitAfter.Value)
                {
                    SaveCurrentOutput(outputStrings, header, data.OutputFilePath, currentFileNumber, data.OutputFileName, data.OutputFileExtension);

                    // Increase the file number count
                    currentFileNumber++;

                    // Reset the row counter
                    currentRowCount = 1;

                    // Clear the output strings list
                    outputStrings.Clear();
                }

                #endregion Save Operation

                else
                {
                    // We have not reached the maximum number of rows yet, so add this to the output strings
                    outputStrings.Add(line);
                    currentRowCount++;
                }
            }
            SaveCurrentOutput(outputStrings, header, data.OutputFilePath, currentFileNumber, data.OutputFileName, data.OutputFileExtension);
        }

        private void SaveCurrentOutput(List<string> outputStrings, string header, string path, int currentFileNumber, string optionalText, string outputExtension)
        {
            string fileExtension = "." + outputExtension;

            // We have reached the maximum number of rows for this file, save it out
            using (StreamWriter newOutputFile = new StreamWriter(String.Format("{0}{1}{2}{3}", path, optionalText, currentFileNumber, fileExtension)))
            {
                // Preppend the header!
                newOutputFile.WriteLine(header);
                // Iterate through all output strings
                foreach (string newLine in outputStrings)
                {
                    // And output them to the new file
                    newOutputFile.WriteLine(newLine);
                }
                // Close the stream to save the file
                newOutputFile.Close();
            }
#if DEBUG
            // If debug mode, output to console
            Console.WriteLine("Split new file: " + String.Format("{0}{1}{2}{3}", path, optionalText, currentFileNumber, fileExtension));
#endif
        }

        private void startJob()
        {
            this.txtFileName.Visible = false;
            this.txtOptionText.Visible = false;
            this.btnSelectFile.Visible = false;
            this.btnSplit.Visible = false;
            this.comboFileExtension.Visible = false;
            this.lblSplitAfter.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.splitAfter.Visible = false;
            this.lblPleaseWait.Visible = true;
        }

        private void finishJob()
        {
            this.txtFileName.Visible = true;
            this.txtOptionText.Visible = true;
            this.btnSelectFile.Visible = true;
            this.btnSplit.Visible = true;
            this.comboFileExtension.Visible = true;
            this.lblSplitAfter.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.splitAfter.Visible = true;
            this.lblPleaseWait.Visible = false;
        }

        private void backgroundWorker1_ReportProgress(object sender, ProgressChangedEventArgs e)
        {
            //lblPleaseWait.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            finishJob();
        }
    }
}