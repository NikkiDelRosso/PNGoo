using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

namespace PNGoo
{
    class PNGQuantPreview
    {
        static 

        /// <summary>
        /// Original unchanged image
        /// </summary>
        private Image originalImage;

        /// <summary>
        /// Original unchanged image data
        /// </summary>
        private byte[] originalImageData;

        /// <summary>
        /// Original image passed through the current PNGQuant settings
        /// </summary>
        private Image pngQuantPreview;

        /// <summary>
        /// Offscreen bitmap to build image
        /// </summary>
        private Bitmap offScreenBm;

        /// <summary>
        /// Graphics object for the offscreen bitmap
        /// </summary>
        private Graphics offScreenGfx;

        /// <summary>
        /// Texture for the transparent areas of the image
        /// </summary>
        private TextureBrush transTexture;

        /// <summary>
        /// Current position of the image's centre, from the
        /// centre of the canvas
        /// </summary>
        private Point currentPosition;
        
        /// <summary>
        /// The picturebox to draw to
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// How many colours to give the image
        /// </summary>
        private int Colours = 255;

        /// <summary>
        /// Use ordered dithering?
        /// </summary>
        public bool OrderedDither = false;

        /// <summary>
        /// Zoom value (1 = original size)
        /// </summary>
        public double Zoom = 1;

        /// <summary>
        /// Create an interactive preview of PNGQuant
        /// </summary>
        /// <param name="pictureBox">PictureBox to output to</param>
        /// <param name="imageData">File data for an image</param>
        /// <param name="colours">Number of colours to use</param>
        /// <param name="orderedDither">Use ordered dithering?</param>
        /// <param name="zoom">Zoom level to start with</param>
        public PNGQuantPreview(System.Windows.Forms.PictureBox pictureBox, byte[] imageData, int colours, bool orderedDither, double zoom)
        {
            // setup properties from parameters
            this.pictureBox = pictureBox;
            Colours = colours;
            OrderedDither = orderedDither;
            Zoom = zoom;
            originalImageData = imageData;

            // listen for some events on the picturebox
            pictureBox.Resize += new EventHandler(pictureBox_Resize);
            pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(pictureBox_MouseMove);

            createOffScreenBm();
            setupTransTexture();
            createOriginalImage();
            GeneratePreviewImage();
            draw();

        }

        ~PNGQuantPreview()
        {
            // remove listeners
            pictureBox.Resize -= new EventHandler(pictureBox_Resize);
            pictureBox.MouseDown -= new System.Windows.Forms.MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove -= new System.Windows.Forms.MouseEventHandler(pictureBox_MouseMove);
        }

        /// <summary>
        /// Recreates our offscreen bitmap. Needs to be done initially or if the 
        /// canvas changes size
        /// </summary>
        private void createOffScreenBm()
        {
            offScreenBm = new Bitmap(pictureBox.Width, pictureBox.Height);
            offScreenGfx = Graphics.FromImage(offScreenBm);
        }

        /// <summary>
        /// Setup the paralax background image for the canvas
        /// </summary>
        private void setupTransTexture()
        {
            Image transTile = Image.FromStream(
                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("PNGoo.libs.trans.png")
            );
            transTexture = new TextureBrush(transTile);
        }

        /// <summary>
        /// Generate the "image"
        /// </summary>
        private void createOriginalImage()
        {
            MemoryStream ms = new MemoryStream(originalImageData);
            originalImage = Image.FromStream(ms);
            /*PNGQuant quantImg = new PNGQuant(originalImageData);
            quantImg.Colours = Colours;
            MemoryStream ms = new MemoryStream(quantImg.CompressedFile);
            pngQuantPreview = Image.FromStream(ms);*/
        }

        /// <summary>
        /// Regenerate the preview image following changes to settings
        /// </summary>
        public void GeneratePreviewImage()
        {
            PNGQuant quantImg = new PNGQuant(originalImageData);
            quantImg.Colours = Colours;
            if (OrderedDither)
            {
                quantImg.Options |= PNGQuant.CompressorOptions.None;
            }
            quantImg.Start();
            MemoryStream ms = new MemoryStream(quantImg.CompressedFile);
            pngQuantPreview = Image.FromStream(ms);
        }

        /// <summary>
        /// Draw to the canvas
        /// </summary>
        private void draw()
        {
            offScreenGfx.FillRectangle(transTexture, 0, 0, offScreenBm.Width, offScreenBm.Height);
            offScreenGfx.DrawImage(pngQuantPreview, 0, 0);
            pictureBox.Image = offScreenBm;
        }

        private void pictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            createOffScreenBm();
            throw new NotImplementedException();
        }
    }
}
