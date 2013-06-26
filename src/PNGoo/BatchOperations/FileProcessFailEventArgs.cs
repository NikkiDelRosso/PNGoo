using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGoo.BatchOperations
{
    public delegate void FileProcessFailEventHandler(object sender, FileProcessFailEventArgs e);

    /// <summary>
    /// Arguments for a failed file process
    /// </summary>
    public class FileProcessFailEventArgs : EventArgs
    {
        private string filePath;
        /// <summary>
        /// Path to the original file
        /// </summary>
        public string FilePath
        {
            get
            {
                return filePath;
            }
        }


        private int filePathIndex;
        /// <summary>
        /// Index in the set of files given to the batch
        /// </summary>
        public int FilePathIndex
        {
            get
            {
                return filePathIndex;
            }
        }

        private string error;
        /// <summary>
        /// Reason for the file to fail processing
        /// </summary>
        public string Error
        {
            get
            {
                return error;
            }
        }

        

        /// <summary>
        /// Arguments for a failed file process
        /// </summary>
        /// <param name="filePath">Path to the original file</param>
        /// <param name="filePathIndex">Index in the set of files given to the batch</param>
        /// <param name="error">Error that caused the fail</param>
        public FileProcessFailEventArgs(string filePath, int filePathIndex, Exception error)
            : base()
        {
            this.filePath = filePath;
            this.filePathIndex = filePathIndex;
            this.error = error.Message;
        }

    }
}
