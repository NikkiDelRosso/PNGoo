using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGoo
{
    public class CompressionSettings
    {
        /// <summary>
        /// Types of compression that can be output
        /// </summary>
        public enum PNGType
        {
            /// <summary>
            /// Index PNG of up to 256 colours
            /// </summary>
            Indexed
        }

        /// <summary>
        /// Settings for indexed output
        /// </summary>
        public CompressionTypeSettings.Indexed Indexed = new PNGoo.CompressionTypeSettings.Indexed();

        /// <summary>
        /// The type of PNG to output
        /// </summary>
        public PNGType OutputType = PNGType.Indexed;

        /// <summary>
        /// Constructor
        /// </summary>
        public CompressionSettings() {}
    }
}
