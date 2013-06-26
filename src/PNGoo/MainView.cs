using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;

namespace PNGoo
{
    public partial class MainView : Form
    {
        private delegate void passMsg(string msg);

        /// <summary>
        /// Settings to use for batch file processing
        /// </summary>
        private static CompressionSettings compressionSettings = new CompressionSettings();

        private int FilesProcessed;
        private int TotalFiles;
        private bool Running = false;
        private int PercentComplete;
        private System.Windows.Forms.Timer ProgressTimer = new System.Windows.Forms.Timer();

        private BatchOperations.BatchFileCompressor batch = new BatchOperations.BatchFileCompressor();

        public MainView()
        {
            InitializeComponent();

            batch.FileProcessSuccess += new PNGoo.BatchOperations.FileProcessSuccessEventHandler(batch_FileProcessSuccess);
            batch.FileProcessFail += new PNGoo.BatchOperations.FileProcessFailEventHandler(batch_FileProcessFail);
            batch.Complete += new EventHandler(batch_Complete);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // add compression types
            string[] enumNames = Enum.GetNames(typeof(CompressionSettings.PNGType));
            this.pngTypeComboBox.Items.AddRange(enumNames);
            this.pngTypeComboBox.SelectedIndex = 0;
        }

        private void updateFileCount()
        {
            string[] fileList = getFileList();
            TotalFiles = fileList.Length;
            updateStatusText((TotalFiles == 0? "No" : TotalFiles.ToString()) + " files selected");
        }

        private void updateStatusText(string text)
        {
             statusText.Text = text;
        }

        private void SetRunning()
        {
            fileBatchDataGridView.AllowUserToDeleteRows = false;
            Running = true;
            goButton.Enabled = false;
            addFilesButton.Enabled = false;
            removeItemButton.Enabled = false;
            cancelButton.Enabled = true;
            progressBar.Visible = true;
        }

        private void SetStoppedRunning()
        {
            fileBatchDataGridView.AllowUserToDeleteRows = true;
            Running = false;
            goButton.Enabled = true;
            addFilesButton.Enabled = true;
            setRemoveButtonEnabled();
            cancelButton.Enabled = false;
            progressBar.Visible = false;
            statusText.Text = String.Format("Processing complete. {0} files processed.", FilesProcessed);
        }

        private void updateProgress(object sender, EventArgs e)
        {
            PercentComplete = FilesProcessed * 100 / TotalFiles;
            
            try
            {
                progressBar.Value = PercentComplete;
            }
            catch (System.InvalidOperationException)
            {
                Debug.Print("Can't update progress bar...");
            }
             

            try
            {
                updateStatusText(String.Format("{0}/{1} Files Processed ({2}%)", FilesProcessed, TotalFiles, PercentComplete));
            }
            catch (System.InvalidOperationException)
            {
                Debug.Print("Can't update status text...");
            }

            if (!Running)
            {
                ProgressTimer.Stop();
                SetStoppedRunning();
            }
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            if (addFilesDialog.ShowDialog() == DialogResult.OK)
            {
                addFiles(addFilesDialog.FileNames);
            }
        }

        /// <summary>
        /// Adds a file to fileBatchDataGridView
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <param name="display">Displayed 'path'</param>
        private void addFileToBatch(string path, string display)
        {
            FileInfo fileInfo = new FileInfo(path);
            // we don't accept directories (yet)
            if (fileInfo.Attributes == FileAttributes.Directory)
            {
                return;
            }
            // search for duplicates of the current file
            foreach (DataGridViewRow row in fileBatchDataGridView.Rows)
            {

                if (row.Cells["RealFileColumn"].Value.ToString() == path)
                {
                    return;
                }
            }
            long fileSize = new FileInfo(path).Length;
            fileBatchDataGridView.Rows.Add(display, path, formatFileSize(fileSize), "", "Uncompressed");
        }
        /// <summary>
        /// Adds a file to fileBatchDataGridView.
        /// </summary>
        /// <param name="path">Path to file</param>
        private void addFileToBatch(string path)
        {
            addFileToBatch(path, path);
        }

        private void addFiles(string[] files)
        {
            if (!Running)
            {
                foreach (string file in files)
                {
                    addFileToBatch(file);
                }
                updateFileCount();
            }
        }

        private void addFiles(System.Collections.Specialized.StringCollection collection)
        {
            string[] files = new string[collection.Count];
            collection.CopyTo(files, 0);
            addFiles(files);
        }

        /// <summary>
        /// Create a display string for a filesize
        /// </summary>
        /// <param name="fileSize">Filesize in bytes</param>
        /// <returns>Formatted string</returns>
        private string formatFileSize(long fileSize)
        {
            return Math.Round(fileSize / 1024.0, 2) + "k";
        }

        private void MainView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void MainView_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            addFiles(files);
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.StringCollection files = Clipboard.GetFileDropList();
            addFiles(files);
        }

        /// <summary>
        /// Pastes files from the clipboard into the datagrid
        /// </summary>
        private void pasteFiles()
        {
            if (!Running)
            {
                if (canPasteFiles())
                {
                    System.Collections.Specialized.StringCollection files = Clipboard.GetFileDropList();
                    addFiles(files);
                }
            }
        }

        /// <summary>
        /// Can files be pasted from the clipboard?
        /// </summary>
        /// <returns>true if files can be pasted</returns>
        private bool canPasteFiles()
        {
            return Clipboard.ContainsFileDropList();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                foreach (DataGridViewRow row in fileBatchDataGridView.SelectedRows)
                {
                    fileBatchDataGridView.Rows.Remove(row);
                }
            }
        }

        private void fileBatchDataGridView_RowsRemoved(object sender, EventArgs e)
        {
            updateFileCount();
        }

        private void setRemoveButtonEnabled()
        {
            removeItemButton.Enabled = (fileBatchDataGridView.SelectedRows.Count != 0);
        }


        private void fileBatchDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            setRemoveButtonEnabled();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Running)
            {
                pasteFiles();
            }
        }

        private void MainView_Activated(object sender, EventArgs e)
        {
            bool canPaste = canPasteFiles();
            pasteMenuItem.Enabled = canPaste;
            pasteToolStripMenuItem.Enabled = canPaste;
        }

        private void outputDirectoryBrowseButton_Click(object sender, EventArgs e)
        {
            if (outputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryTextBox.Text = outputFolderBrowserDialog.SelectedPath;
            }
        }

        private void colourSettingsButton_Click(object sender, EventArgs e)
        {
            ColourSettings colourSettings;
            string filePath;

            DataGridViewSelectedRowCollection selectedRows = fileBatchDataGridView.SelectedRows;

            // bug out if there aren't any rows selected
            if (selectedRows.Count == 0)
            {
                MessageBox.Show(
                    "To prevew colour settings, you must first select an image to preview from the list below",
                    "No Image Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            filePath = fileBatchDataGridView.SelectedRows[0].Cells["RealFileColumn"].Value.ToString();
            try
            {
                colourSettings = new ColourSettings(filePath);
                colourSettings.CompressionSettings = compressionSettings.Indexed;
                colourSettings.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "The selected image could not be loaded.",
                    "Invalid Image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (colourSettings.DialogResult == DialogResult.OK)
            {
                compressionSettings.Indexed = colourSettings.CompressionSettings;
            }
            
        }

        private void overwriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputDirectoryTextBox.Enabled =
                outputDirectoryBrowseButton.Enabled =
                !overwriteCheckBox.Checked;
        }

        private void pngTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            compressionSettings.OutputType = (CompressionSettings.PNGType)pngTypeComboBox.SelectedIndex;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string[] fileList = getFileList();

            // are there entries in our file list?
            if (fileList.Length == 0)
            {
                MessageBox.Show(
                    "Please add some files to be processed first",
                    "No files in batch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // check we've got an output directory
            if (!overwriteCheckBox.Checked && outputDirectoryTextBox.Text == String.Empty)
            {
                MessageBox.Show(
                    "Please select an output directory to continue",
                    "No output directory selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // check the output directory exists
            if (!overwriteCheckBox.Checked && !isValidOutputDirectory(outputDirectoryTextBox.Text))
            {
                MessageBox.Show(
                    "Output directory does not exist",
                    "Invalid output directory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // update output
            updateFileColsToNewFile();

            // let's start the batch
            batch.OutputDirectory = outputDirectoryTextBox.Text;
            batch.OutputIfLarger = overwriteIfLargerCheckBox.Checked;
            batch.CompressionSettings = compressionSettings;
            batch.FilePaths = fileList;

            // if we're wanting to overwrite the original, set the output dir to null
            if (overwriteCheckBox.Checked)
            {
                batch.OutputDirectory = null;
            }

            // Set some UI stuff
            SetRunning();

            FilesProcessed = 0;
            PercentComplete = 0;

            ProgressTimer.Tick += new EventHandler(updateProgress);
            ProgressTimer.Start();

            batch.Start();
        }

        /// <summary>
        /// Updates the 'file' and 'original' cols to reflect the path of the last written file, in
        /// the case of recompression.
        /// </summary>
        void updateFileColsToNewFile()
        {
            foreach (DataGridViewRow row in fileBatchDataGridView.Rows)
            {
                // We know we're dealing with a new file if the optimised size col isn't empty
                if ((string)row.Cells["OptimisedSizeColumn"].Value != String.Empty)
                {
                    row.Cells["FileColumn"].Value = row.Cells["RealFileColumn"].Value;
                    row.Cells["OriginalSizeColumn"].Value = row.Cells["OptimisedSizeColumn"].Value;
                }
            }
        }

        void batch_FileProcessFail(object sender, PNGoo.BatchOperations.FileProcessFailEventArgs e)
        {
            DataGridViewRow row = fileBatchDataGridView.Rows[e.FilePathIndex];
            row.Cells["StatusColumn"].Value = String.Format("Error: {0}", e.Error);
        }

        void batch_FileProcessSuccess(object sender, PNGoo.BatchOperations.FileProcessSuccessEventArgs e)
        {
            ++FilesProcessed;

            DataGridViewRow row = fileBatchDataGridView.Rows[e.FilePathIndex];

            if (e.Compressor != null)
            {
                // update optimised size column
                row.Cells["OptimisedSizeColumn"].Value = formatFileSize(e.Compressor.CompressedFile.Length);
                // update actual file row to point to the new file, so further compressions act on the new file
                row.Cells["RealFileColumn"].Value = e.NewFilePath;
                // update status
                string compressorUsed = e.Compressor.GetType().Name;
                row.Cells["StatusColumn"].Value = String.Format("Complete: {0} used", compressorUsed);
            }
            else
            {
                // the original file was just copied
                // update optimised size column
                DataGridViewCell cell = row.Cells["OptimisedSizeColumn"];
                if (cell.Value.ToString() == String.Empty)
                {
                    cell.Value = row.Cells["OriginalSizeColumn"].Value;
                }
                row.Cells["StatusColumn"].Value = "Complete: Original file copied";
            }

        }

        void batch_Complete(object sender, EventArgs e)
        {
            Running = false;
        }

        /// <summary>
        /// Gets the list of files added to the box
        /// </summary>
        /// <returns>List of files</returns>
        private string[] getFileList()
        {
            string[] fileList = new string[fileBatchDataGridView.Rows.Count];
            int i = 0;

            foreach (DataGridViewRow row in fileBatchDataGridView.Rows)
            {
                fileList[i++] = row.Cells["RealFileColumn"].Value.ToString();
            }
            return fileList;
        }

        /// <summary>
        /// Check if an output path is absolute and valid
        /// </summary>
        /// <param name="path">Output path</param>
        /// <returns>False if the path is invalid</returns>
        private bool isValidOutputDirectory(string path)
        {
            FileInfo fi = new FileInfo(path);
            if ((fi.Attributes & FileAttributes.Directory) == 0)
            {
                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            batch.Cancel();
            Running = false;
        }

    }
}
