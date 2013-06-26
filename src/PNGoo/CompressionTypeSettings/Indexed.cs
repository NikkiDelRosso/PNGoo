using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGoo.CompressionTypeSettings
{
    public class Indexed
    {
        public event EventHandler PropertyChanged = delegate {};

        private int colours = 256;
        /// <summary>
        /// How many colours to give the image
        /// </summary>
        public int Colours
        {
            get
            {
                return colours;
            }
            set
            {
                if (value > 256 || value < 2)
                {
                    throw new ArgumentOutOfRangeException("Colours", value, "Invalid colour quantity - must be 2-256");
                }
                colours = value;
                OnPropertyChanged();
            }
        }

        private bool orderedDither = false;
        /// <summary>
        /// Use ordered dithering?
        /// </summary>
        public bool OrderedDither
        {
            get
            {
                return orderedDither;
            }
            set
            {
                orderedDither = value;
                OnPropertyChanged();
            }
        }

        public Indexed()
        {
        }

        /// <summary>
        /// Properties have changed
        /// </summary>
        private void OnPropertyChanged()
        {
            PropertyChanged(this, EventArgs.Empty);
        }
    }
}
