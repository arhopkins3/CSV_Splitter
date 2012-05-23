using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVSplitter
{
    /// <summary>
    /// FileSplitter class by Alex Hopkins
    /// © Copyright 2012 Alex Hopkins
    /// </summary>
    public class FileSplitter
    {
        /// <summary>
        /// Splits a TXT file into smaller CSV files
        /// </summary>
        /// <param name="filename">The path and filename for the TXT file</param>
        /// <param name="splitafter">An integer value for how often to split the file</param>
        public bool SplitFile(string path, string filename, int splitafter, string optionalText, string outputExtension)
        {
            if (string.IsNullOrEmpty(filename))
            {
                // Cannot process the file, the filename is invalid
                return false;
            }

            // Create the new streamreader to access the file
            StreamReader file = new StreamReader(filename);

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

                if (currentRowCount >= splitafter)
                {
                    SaveCurrentOutput(outputStrings, header, path, currentFileNumber, optionalText, outputExtension);

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
            SaveCurrentOutput(outputStrings, header, path, currentFileNumber, optionalText, outputExtension);
            return true;
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
    }
}