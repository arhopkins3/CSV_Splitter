using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVSplitter
{
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
            if (fileSplitter.SplitFile(ofd.FileName.Substring(0, (ofd.FileName.Length - ofd.SafeFileName.Length)), ofd.FileName, (int)splitAfter.Value, txtOptionText.Text + "_", comboFileExtension.Text))
            {
                MessageBox.Show("Your file was successfully split into multiple files!");
            }
            else
            {
                MessageBox.Show("Unfortunately, there was an error splitting your files!");
            }
        }

        private void txtOptionText_TextChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }
    }
}