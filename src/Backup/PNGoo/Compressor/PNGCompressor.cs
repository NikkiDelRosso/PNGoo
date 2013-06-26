using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace PNGoo.Compressor
{
    /// <summary>
    /// Abstract for creating a compressed PNG
    /// </summary>
    public abstract class PNGCompressor
    {
        /// <summary>
        /// Is a given byte array a PNG file?
        /// </summary>
        /// <param name="fileData">File data</param>
        /// <returns>True if the file is a PNG</returns>
        public static bool IsPng(byte[] fileData)
        {
            byte[] pngHeader = {137, 80, 78, 71, 13, 10, 26, 10};

            if (pngHeader.SequenceEqual(fileData.Take(8)))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Original file data
        /// </summary>
        protected byte[] originalFile;
        /// <summary>
        /// Compressed file data
        /// </summary>
        protected byte[] compressedFile;
        /// <summary>
        /// Loctation of process to run
        /// </summary>
        protected string cmdLocation;

        /// <summary>
        /// Create a compressed PNG
        /// </summary>
        /// <param name="fileToCompress">
        /// Path to the file to compress
        /// </param>
        public PNGCompressor(String fileToCompress)
        {
            originalFile = File.ReadAllBytes(fileToCompress);
        }
        /// <summary>
        /// Create a compressed PNG
        /// </summary>
        /// <param name="fileToCompress">
        /// Data to compress
        /// </param>
        public PNGCompressor(byte[] fileToCompress)
        {
            originalFile = fileToCompress;
        }

        /// <summary>
        /// Start compressing the png
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// The original file, prior to compression
        /// </summary>
        public byte[] OriginalFile
        {
            get
            {
                return originalFile;
            }
        }

        /// <summary>
        /// The compressed file stream
        /// </summary>
        public byte[] CompressedFile
        {
            get
            {
                return compressedFile;
            }
        }

        /// <summary>
        /// Creates a process to use for calling a cmd line compressor
        /// </summary>
        /// <returns>The process</returns>
        protected Process createProcess()
        {
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = this.cmdLocation;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.RedirectStandardError = true;
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.StartInfo.CreateNoWindow = true;
            return cmdProcess;
        }


        /// <summary>
        /// tmp File location. We use this to make sure we delete it after use.
        /// </summary>
        private String tmpFileLocation;
        /// <summary>
        /// Create a temp copy of the orignal file to feed to a cmd line compressor
        /// </summary>
        /// <returns>Location of the file</returns>
        protected String createTmpOriginalFile()
        {
            if (tmpFileLocation == null)
            {
                tmpFileLocation = Path.GetTempFileName();
                Image img;
                
                // ensure we've been given a valid image
                try
                {
                    img = Image.FromStream(new MemoryStream(originalFile));
                }
                catch (Exception)
                {
                    throw new Exception("Invalid Image Format");
                }
                // write the image out to a png, in case it wasn't to begin with
                img.Save(tmpFileLocation, ImageFormat.Png);
            }
            return tmpFileLocation;
        }

        /// <summary>
        /// Get rid of our temp file, if it exists
        /// </summary>
        protected void deleteTmpOriginalFile()
        {
            if (tmpFileLocation != null)
            {
                File.Delete(tmpFileLocation);
            }
        }
    }
}
