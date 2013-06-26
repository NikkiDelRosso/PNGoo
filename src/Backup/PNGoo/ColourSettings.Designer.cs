namespace PNGoo
{
    partial class ColourSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coloursComboBox = new System.Windows.Forms.ComboBox();
            this.ditherCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previewTypeComboBox = new System.Windows.Forms.ComboBox();
            this.zoomComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.compressedFileSizeLabel = new System.Windows.Forms.Label();
            this.originalFileSizeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pngQuantPreview = new PNGoo.PNGQuantPreviewControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(381, 295);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(465, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colours:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // coloursComboBox
            // 
            this.coloursComboBox.FormatString = "N0";
            this.coloursComboBox.FormattingEnabled = true;
            this.coloursComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.coloursComboBox.Location = new System.Drawing.Point(55, 23);
            this.coloursComboBox.Name = "coloursComboBox";
            this.coloursComboBox.Size = new System.Drawing.Size(101, 21);
            this.coloursComboBox.TabIndex = 1;
            this.coloursComboBox.SelectedValueChanged += new System.EventHandler(this.coloursComboBox_SelectedValueChanged);
            this.coloursComboBox.TextUpdate += new System.EventHandler(this.coloursComboBox_TextUpdate);
            // 
            // ditherCheckbox
            // 
            this.ditherCheckbox.AutoSize = true;
            this.ditherCheckbox.Checked = true;
            this.ditherCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ditherCheckbox.Location = new System.Drawing.Point(55, 53);
            this.ditherCheckbox.Name = "ditherCheckbox";
            this.ditherCheckbox.Size = new System.Drawing.Size(54, 17);
            this.ditherCheckbox.TabIndex = 2;
            this.ditherCheckbox.Text = "Dither";
            this.ditherCheckbox.UseVisualStyleBackColor = true;
            this.ditherCheckbox.CheckedChanged += new System.EventHandler(this.ditherCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.coloursComboBox);
            this.groupBox1.Controls.Add(this.ditherCheckbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(381, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.previewTypeComboBox);
            this.groupBox2.Controls.Add(this.zoomComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(382, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Show:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // previewTypeComboBox
            // 
            this.previewTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.previewTypeComboBox.FormattingEnabled = true;
            this.previewTypeComboBox.Items.AddRange(new object[] {
            "Original",
            "Compressed",
            "IE6 Display"});
            this.previewTypeComboBox.Location = new System.Drawing.Point(55, 47);
            this.previewTypeComboBox.Name = "previewTypeComboBox";
            this.previewTypeComboBox.Size = new System.Drawing.Size(101, 21);
            this.previewTypeComboBox.TabIndex = 3;
            this.previewTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.previewTypeComboBox_SelectedIndexChanged);
            // 
            // zoomComboBox
            // 
            this.zoomComboBox.FormatString = "N0";
            this.zoomComboBox.FormattingEnabled = true;
            this.zoomComboBox.Items.AddRange(new object[] {
            "50%",
            "100%",
            "200%",
            "400%",
            "800%",
            "1600%"});
            this.zoomComboBox.Location = new System.Drawing.Point(55, 19);
            this.zoomComboBox.Name = "zoomComboBox";
            this.zoomComboBox.Size = new System.Drawing.Size(101, 21);
            this.zoomComboBox.TabIndex = 1;
            this.zoomComboBox.SelectedIndexChanged += new System.EventHandler(this.zoomComboBox_SelectedIndexChanged);
            this.zoomComboBox.TextUpdate += new System.EventHandler(this.zoomComboBox_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zoom:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.compressedFileSizeLabel);
            this.groupBox3.Controls.Add(this.originalFileSizeLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(382, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // compressedFileSizeLabel
            // 
            this.compressedFileSizeLabel.AutoSize = true;
            this.compressedFileSizeLabel.Location = new System.Drawing.Point(93, 35);
            this.compressedFileSizeLabel.Name = "compressedFileSizeLabel";
            this.compressedFileSizeLabel.Size = new System.Drawing.Size(16, 13);
            this.compressedFileSizeLabel.TabIndex = 3;
            this.compressedFileSizeLabel.Text = "---";
            // 
            // originalFileSizeLabel
            // 
            this.originalFileSizeLabel.AutoSize = true;
            this.originalFileSizeLabel.Location = new System.Drawing.Point(93, 17);
            this.originalFileSizeLabel.Name = "originalFileSizeLabel";
            this.originalFileSizeLabel.Size = new System.Drawing.Size(16, 13);
            this.originalFileSizeLabel.TabIndex = 1;
            this.originalFileSizeLabel.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Compressed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Original:";
            // 
            // pngQuantPreview
            // 
            this.pngQuantPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pngQuantPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pngQuantPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pngQuantPreview.Location = new System.Drawing.Point(0, 0);
            this.pngQuantPreview.Name = "pngQuantPreview";
            this.pngQuantPreview.OriginalImageData = null;
            this.pngQuantPreview.PreviewType = PNGoo.PNGQuantPreviewControl.PreviewTypes.PNGQuant;
            this.pngQuantPreview.Size = new System.Drawing.Size(375, 323);
            this.pngQuantPreview.TabIndex = 0;
            this.pngQuantPreview.TabStop = false;
            this.pngQuantPreview.Zoom = 1;
            this.pngQuantPreview.CompressedImageDataChange += new System.EventHandler(this.pngQuantPreview_CompressedImageDataChange);
            // 
            // ColourSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pngQuantPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MinimumSize = new System.Drawing.Size(457, 305);
            this.Name = "ColourSettings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colour Settings";
            this.Load += new System.EventHandler(this.ColourSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox coloursComboBox;
        private System.Windows.Forms.CheckBox ditherCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox zoomComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox previewTypeComboBox;
        private System.Windows.Forms.Label label3;
        private PNGQuantPreviewControl pngQuantPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label compressedFileSizeLabel;
        private System.Windows.Forms.Label originalFileSizeLabel;
        private System.Windows.Forms.Label label5;
    }
}