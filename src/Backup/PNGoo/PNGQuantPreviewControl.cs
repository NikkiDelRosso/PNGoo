using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace PNGoo
{
    public partial class PNGQuantPreviewControl : UserControl
    {
        /// <summary>
        /// How the background moves compared to the foreground
        /// </summary>
        private const int paralaxDivisor = 4;

        /// <summary>
        /// Original unchanged image
        /// </summary>
        private Image originalImage;

        /// <summary>
        /// Fires when 'CompressedImageData' changes
        /// </summary>
        public event EventHandler CompressedImageDataChange;

        /// <summary>
        /// The types of preview that can be displayed
        /// </summary>
        public enum PreviewTypes
        {
            Original,
            PNGQuant,
            Ie6
        }


        private PreviewTypes previewType = PreviewTypes.PNGQuant;

        public PreviewTypes PreviewType
        {
            get
            {
                return previewType;
            }
            set
            {
                previewType = value;
                outputImageValid = false;
            }
        }

        private byte[] imageData;
        /// <summary>
        /// Original unchanged image data
        /// </summary>
        public byte[] OriginalImageData
        {
            get
            {
                return imageData;
            }
            set
            {
                imageData = value;
                pngQuantPreviewValid = false;
                outputImageValid = false;
                ie6PreviewValid = false;
            }
        }

        private byte[] compressedImageData;
        /// <summary>
        /// Compressed image data
        /// </summary>
        public byte[] CompressedImageData
        {
            get
            {
                return compressedImageData;
            }
        }

        private Image _pngQuantPreview;
        /// <summary>
        /// Original image passed through the current PNGQuant settings
        /// </summary>
        private Image pngQuantPreview {
            get
            {
                if (!pngQuantPreviewValid)
                {
                    generatePNGQuantPreviewImage();
                }
                return _pngQuantPreview;
            }
            set
            {
                _pngQuantPreview = value;
            }
        }

        private Image _ie6Preview;
        /// <summary>
        /// Emulates how the pngQuantPreview image will appear in ie6
        /// </summary>
        private Image ie6Preview
        {
            get
            {
                if (!ie6PreviewValid)
                {
                    generateIe6PreviewImage();
                }
                return _ie6Preview;
            }
            set
            {
                _ie6Preview = value;
            }
        }

        /// <summary>
        /// Texture for the transparent areas of the image
        /// </summary>
        private TextureBrush transTexture;

        /// <summary>
        /// Current position of the image's centre, offset from the
        /// centre of the canvas
        /// </summary>
        private Point currentPosition;

        private CompressionTypeSettings.Indexed compressionSettings = new CompressionTypeSettings.Indexed();
        /// <summary>
        /// Settings for indexed compression
        /// </summary>
        public CompressionTypeSettings.Indexed CompressionSettings
        {
            get
            {
                return compressionSettings;
            }
        }

        private double zoom = 1;
        /// <summary>
        /// Zoom value (1 = original size)
        /// </summary>
        public double Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                // offset the position of the image so it appears to zoom into the centre
                adjustImagePositionForZoom(value, zoom);
                zoom = value;
                outputImageValid = false;
            }
        }

        /// <summary>
        /// Position the mouse was last time we checked
        /// </summary>
        private Point previousMousePosition;

        /// <summary>
        /// Is the data stored in 'pngQuantPreview' valid?
        /// </summary>
        private bool pngQuantPreviewValid = false;

        /// <summary>
        /// Is the data stored in 'ie6Preview' valid?
        /// </summary>
        private bool ie6PreviewValid = false;

        /// <summary>
        /// Is the data stored in 'outputImage' valid?
        /// </summary>
        private bool outputImageValid = false;

        /// <summary>
        /// The image which is output to the control
        /// </summary>
        private Image outputImage;

        /// <summary>
        /// Create an interactive preview of PNGQuant
        /// </summary>
        public PNGQuantPreviewControl()
        {
            InitializeComponent();
            // events
            this.Load += new EventHandler(PNGQuantPreviewControl_Load);
            this.MouseDown += new MouseEventHandler(PNGQuantPreviewControl_MouseDown);
            this.MouseMove += new MouseEventHandler(PNGQuantPreviewControl_MouseMove);
            this.compressionSettings.PropertyChanged += new EventHandler(compressionSettings_PropertyChanged);
        }

        void compressionSettings_PropertyChanged(object sender, EventArgs e)
        {
            pngQuantPreviewValid = false;
            outputImageValid = false;
            ie6PreviewValid = false;
        }

        void PNGQuantPreviewControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point fromStart = new Point(e.X - previousMousePosition.X, e.Y - previousMousePosition.Y);
                currentPosition.Offset(fromStart);
                previousMousePosition = e.Location;
                Draw();
            }
        }

        void PNGQuantPreviewControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                previousMousePosition = e.Location;
            }
        }

        void PNGQuantPreviewControl_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(PNGQuantPreviewControl_Resize);
            setupTransTexture();
            createOriginalImage();
            generatePNGQuantPreviewImage();
        }

        void PNGQuantPreviewControl_Resize(object sender, EventArgs e)
        {
            Draw();
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
            MemoryStream ms;

            if (OriginalImageData == null)
            {
                originalImage = new Bitmap(1,1);
            }
            else
            {
                ms = new MemoryStream(OriginalImageData);
                originalImage = Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Regenerate the PNGQuant preview image following changes to settings
        /// </summary>
        private void generatePNGQuantPreviewImage()
        {
            if (OriginalImageData != null)
            {
                Compressor.PNGQuant quantImg = new Compressor.PNGQuant(OriginalImageData);
                quantImg.CompressionSettings = compressionSettings;

                quantImg.Start();
                // store our compressed image data
                compressedImageData = quantImg.CompressedFile;
                MemoryStream ms = new MemoryStream(compressedImageData);
                pngQuantPreview = Image.FromStream(ms);
                // fire event
                OnCompressedImageDataChange();
            }
            else
            {
                pngQuantPreview = originalImage;
            }
            pngQuantPreviewValid = true;
        }

        /// <summary>
        /// Take the PNG quant preview and make anything semi
        /// transparent fully transparent (how it appears in
        /// IE6)
        /// </summary>
        private void generateIe6PreviewImage()
        {
            // clone our preview image
            Bitmap bm = (Bitmap)pngQuantPreview.Clone();

            // if the bitmap has an alpha channel, we need to process it
            if (bm.PixelFormat == PixelFormat.Format32bppArgb)
            {
                // get data from the bitmap
                BitmapData data = bm.LockBits(
                    new Rectangle(0, 0, bm.Width, bm.Height),
                    ImageLockMode.ReadWrite,
                    bm.PixelFormat);

                unsafe
                {
                    byte* imgPtr = (byte*)(data.Scan0);
                    int ptr = 0;
                    // itterate through rows of image data
                    for (int i = 0; i < data.Height; i++)
                    {
                        // itterate through cols of image data
                        for (int j = 0; j < data.Width; j++)
                        {
                            // make the alpha channel fully transparent if it's not fully opaque
                            if (imgPtr[ptr + 3] != 255)
                            {
                                imgPtr[ptr + 3] = 0;
                            }
                            // move on 4 bytes
                            ptr += 4;
                        }
                        // move onto next column
                        ptr += data.Stride - data.Width * 4;
                    }
                }

                bm.UnlockBits(data);
            }

            ie6Preview = bm;
            ie6PreviewValid = true;
        }

        /// <summary>
        /// Draw to the canvas
        /// </summary>
        public void Draw()
        {
            if (!outputImageValid)
            {
                generateOutputImage();
            }
            this.Invalidate();
        }

        /// <summary>
        /// Generates the output image, zoom levels etc
        /// </summary>
        private void generateOutputImage()
        {
            // select the preview we want to display
            Image imageToProcess = originalImage;
            switch (previewType)
            {
                case PreviewTypes.PNGQuant:
                    imageToProcess = pngQuantPreview;
                    break;
                case PreviewTypes.Ie6:
                    imageToProcess = ie6Preview;
                    break;
            }

            // apply the zoom
            int newWidth = (int)Math.Round(imageToProcess.Width * zoom);
            int newHeight = (int)Math.Round(imageToProcess.Height * zoom);
            outputImage = new Bitmap(newWidth, newHeight);
            Graphics gfx = Graphics.FromImage(outputImage);
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            gfx.DrawImage(imageToProcess, 0, 0, newWidth, newHeight);
            outputImageValid = true;
        }

        /// <summary>
        /// This converts the center position of the image to a top / left position
        /// </summary>
        /// <param name="paralax">Divide the offset by the paralax amount?</param>
        /// <returns>Top left position</returns>
        private Point getTopLeftPosition(bool paralax)
        {
            // get the center point of the picture box and image
            int pictureBoxCenterX = this.Width / 2;
            int pictureBoxCenterY = this.Height / 2;
            int imageCenterX = outputImage.Width / 2;
            int imageCenterY = outputImage.Height / 2;
            int divisor = paralax ? paralaxDivisor : 1;

            // return the offset point
            return new Point(
                pictureBoxCenterX - imageCenterX + (currentPosition.X / divisor),
                pictureBoxCenterY - imageCenterY + (currentPosition.Y / divisor)
            );
        }

        /// <summary>
        /// Alters the position of the image so it appears if the
        /// image is zoomed into the centre of the view
        /// </summary>
        /// <param name="newZoom">New zoom value</param>
        /// <param name="oldZoom">Previous zoom value</param>
        private void adjustImagePositionForZoom(double newZoom, double oldZoom)
        {
            double zoomChange = newZoom / oldZoom;
            currentPosition.X = (int)Math.Round(currentPosition.X * zoomChange);
            currentPosition.Y = (int)Math.Round(currentPosition.Y * zoomChange);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (outputImage != null)
            {
                Graphics gfx = e.Graphics;
                Point topLeft = getTopLeftPosition(true);
                transTexture.ResetTransform();
                transTexture.TranslateTransform(topLeft.X, topLeft.Y);
                gfx.FillRectangle(transTexture, 0, 0, this.Width, this.Height);
                gfx.DrawImage(outputImage, getTopLeftPosition(false));
            }
        }

        /// <summary>
        /// Fire when the pngquant image has been generated
        /// </summary>
        private void OnCompressedImageDataChange()
        {
            if (CompressedImageDataChange != null)
            {
                CompressedImageDataChange(this, EventArgs.Empty);
            }
        }

        
    }
}
