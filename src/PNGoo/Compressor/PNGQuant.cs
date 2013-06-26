using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PNGoo.Compressor
{
    class PNGQuant : PNGCompressor
    {
        /// <summary>
        /// Compression options
        /// </summary>
        public CompressionTypeSettings.Indexed CompressionSettings = new PNGoo.CompressionTypeSettings.Indexed();

        /// <summary>
        /// Compress a PNG, creates a palleted png.
        /// </summary>
        /// <param name="fileToCompress">Data to compress</param>
        public PNGQuant (byte[] fileToCompress) : base (fileToCompress)
        {
            cmdLocation = AppDomain.CurrentDomain.BaseDirectory + @"\libs\pngquanti\pngquanti.exe";
        }

        /// <summary>
        /// Start compressing the png
        /// </summary>
        public override void Start()
        {
            Process cmdProcess = this.createProcess();
            string tmpFile = this.createTmpOriginalFile();
            string outputSuffix = "-fs8.png";
            if (CompressionSettings.OrderedDither)
            {
                cmdProcess.StartInfo.Arguments += " -ordered";
                outputSuffix = "-or8.png";
            }
            cmdProcess.StartInfo.Arguments += " " + CompressionSettings.Colours;
            cmdProcess.StartInfo.Arguments += " \"" + tmpFile.Replace("\"", @"\") + "\"";
            cmdProcess.Start();
            cmdProcess.WaitForExit();
            // build path for compressed file
            string compressedFilePath = tmpFile + outputSuffix;
            // pick up the compressed file
            compressedFile = File.ReadAllBytes(compressedFilePath);
            // tidy up
            File.Delete(compressedFilePath);
            deleteTmpOriginalFile();

            //Program.WriteToConsole(cmdProcess.StandardError.ReadToEnd());
            //Program.WriteToConsole(cmdProcess.StandardOutput.ReadToEnd());
        }
    }
}
