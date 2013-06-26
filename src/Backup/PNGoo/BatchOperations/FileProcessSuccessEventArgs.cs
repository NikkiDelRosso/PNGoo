using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGoo.BatchOperations
{
    public delegate void FileProcessSuccessEventHandler(object sender, FileProcessSuccessEventArgs e);

    /// <summary>
    /// Arguments for a successful file process
    /// </summary>
    public class FileProcessSuccessEventArgs : EventArgs
    {
        private string originalFilePath;
        /// <summary>
        /// Path to the original file
        /// </summary>
        public string OriginalFilePath
        {
            get
            {
                return originalFilePath;
            }
        }

        private string newFilePath;
        /// <summary>
        /// Path to the newly (over)written file
        /// </summary>
        public string NewFilePath
        {
            get
            {
                return newFilePath;
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

        private Compressor.PNGCompressor compressor;
        /// <summary>
        /// Compressor that produced the smallest file. Null if compressor wasn't used (original file copied)
        /// </summary>
        public Compressor.PNGCompressor Compressor
        {
            get
            {
                return compressor;
            }
        }

        /// <summary>
        /// Arguments for a successful file process
        /// </summary>
        /// <param name="originalFilePath">Path to the original file</param>
        /// <param name="newFilePath">Path to the newly (over)written file</param>
        /// <param name="filePathIndex">Index in the set of files given to the batch</param>
        /// <param name="compressor">Compressor that produced the smallest file</param>
        public FileProcessSuccessEventArgs(string originalFilePath, string newFilePath, int filePathIndex, Compressor.PNGCompressor compressor)
            : base()
        {
            this.originalFilePath = originalFilePath;
            this.newFilePath = newFilePath;
            this.filePathIndex = filePathIndex;
            this.compressor = compressor;
        }

    }
}
