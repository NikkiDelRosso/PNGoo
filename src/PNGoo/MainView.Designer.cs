namespace PNGoo
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.overwriteIfLargerCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colourSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pngTypeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileBatchDataGridView = new System.Windows.Forms.DataGridView();
            this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealFileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptimisedSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.addFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBatchDataGridView)).BeginInit();
            this.fileListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(649, 125);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.outputDirectoryBrowseButton);
            this.groupBox1.Controls.Add(this.outputDirectoryTextBox);
            this.groupBox1.Controls.Add(this.outputDirectoryLabel);
            this.groupBox1.Controls.Add(this.overwriteIfLargerCheckBox);
            this.groupBox1.Controls.Add(this.overwriteCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // outputDirectoryBrowseButton
            // 
            this.outputDirectoryBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirectoryBrowseButton.Location = new System.Drawing.Point(235, 85);
            this.outputDirectoryBrowseButton.Name = "outputDirectoryBrowseButton";
            this.outputDirectoryBrowseButton.Size = new System.Drawing.Size(72, 21);
            this.outputDirectoryBrowseButton.TabIndex = 4;
            this.outputDirectoryBrowseButton.Text = "Browse...";
            this.outputDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.outputDirectoryBrowseButton.Click += new System.EventHandler(this.outputDirectoryBrowseButton_Click);
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(10, 85);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(219, 20);
            this.outputDirectoryTextBox.TabIndex = 3;
            // 
            // outputDirectoryLabel
            // 
            this.outputDirectoryLabel.AutoSize = true;
            this.outputDirectoryLabel.Location = new System.Drawing.Point(7, 68);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.outputDirectoryLabel.TabIndex = 2;
            this.outputDirectoryLabel.Text = "Output Directory:";
            // 
            // overwriteIfLargerCheckBox
            // 
            this.overwriteIfLargerCheckBox.AutoSize = true;
            this.overwriteIfLargerCheckBox.Location = new System.Drawing.Point(10, 42);
            this.overwriteIfLargerCheckBox.Name = "overwriteIfLargerCheckBox";
            this.overwriteIfLargerCheckBox.Size = new System.Drawing.Size(249, 17);
            this.overwriteIfLargerCheckBox.TabIndex = 1;
            this.overwriteIfLargerCheckBox.Text = "Output / Overwrite Even if Larger Than Original";
            this.overwriteIfLargerCheckBox.UseVisualStyleBackColor = true;
            // 
            // overwriteCheckBox
            // 
            this.overwriteCheckBox.AutoSize = true;
            this.overwriteCheckBox.Location = new System.Drawing.Point(10, 19);
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.Size = new System.Drawing.Size(230, 17);
            this.overwriteCheckBox.TabIndex = 0;
            this.overwriteCheckBox.Text = "Output to Same Directory (Overwrite PNGs)";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            this.overwriteCheckBox.CheckedChanged += new System.EventHandler(this.overwriteCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.colourSettingsButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pngTypeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 116);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compression Options";
            // 
            // colourSettingsButton
            // 
            this.colourSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourSettingsButton.Location = new System.Drawing.Point(206, 39);
            this.colourSettingsButton.Name = "colourSettingsButton";
            this.colourSettingsButton.Size = new System.Drawing.Size(100, 23);
            this.colourSettingsButton.TabIndex = 2;
            this.colourSettingsButton.Text = "Colour Settings...";
            this.colourSettingsButton.UseVisualStyleBackColor = true;
            this.colourSettingsButton.Click += new System.EventHandler(this.colourSettingsButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PNG Type:";
            // 
            // pngTypeComboBox
            // 
            this.pngTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pngTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pngTypeComboBox.Location = new System.Drawing.Point(10, 40);
            this.pngTypeComboBox.Name = "pngTypeComboBox";
            this.pngTypeComboBox.Size = new System.Drawing.Size(190, 21);
            this.pngTypeComboBox.TabIndex = 1;
            this.pngTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.pngTypeComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Visible = false;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(140, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.ToolTipText = "Progress of files processed";
            this.progressBar.Visible = false;
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(93, 17);
            this.statusText.Text = "No files selected";
            // 
            // fileBatchDataGridView
            // 
            this.fileBatchDataGridView.AllowUserToAddRows = false;
            this.fileBatchDataGridView.AllowUserToResizeRows = false;
            this.fileBatchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBatchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileBatchDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.fileBatchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileBatchDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.fileBatchDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.fileBatchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileBatchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileColumn,
            this.RealFileColumn,
            this.OriginalSizeColumn,
            this.OptimisedSizeColumn,
            this.StatusColumn});
            this.fileBatchDataGridView.ContextMenuStrip = this.fileListContextMenu;
            this.fileBatchDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.fileBatchDataGridView.Location = new System.Drawing.Point(0, 149);
            this.fileBatchDataGridView.Name = "fileBatchDataGridView";
            this.fileBatchDataGridView.ReadOnly = true;
            this.fileBatchDataGridView.RowHeadersVisible = false;
            this.fileBatchDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileBatchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileBatchDataGridView.Size = new System.Drawing.Size(649, 189);
            this.fileBatchDataGridView.TabIndex = 2;
            this.fileBatchDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.fileBatchDataGridView_RowsRemoved);
            this.fileBatchDataGridView.SelectionChanged += new System.EventHandler(this.fileBatchDataGridView_SelectionChanged);
            // 
            // FileColumn
            // 
            this.FileColumn.FillWeight = 200F;
            this.FileColumn.HeaderText = "File";
            this.FileColumn.Name = "FileColumn";
            this.FileColumn.ReadOnly = true;
            // 
            // RealFileColumn
            // 
            this.RealFileColumn.HeaderText = "Actual File";
            this.RealFileColumn.Name = "RealFileColumn";
            this.RealFileColumn.ReadOnly = true;
            this.RealFileColumn.Visible = false;
            // 
            // OriginalSizeColumn
            // 
            this.OriginalSizeColumn.FillWeight = 50F;
            this.OriginalSizeColumn.HeaderText = "Original";
            this.OriginalSizeColumn.Name = "OriginalSizeColumn";
            this.OriginalSizeColumn.ReadOnly = true;
            // 
            // OptimisedSizeColumn
            // 
            this.OptimisedSizeColumn.FillWeight = 50F;
            this.OptimisedSizeColumn.HeaderText = "Optimised";
            this.OptimisedSizeColumn.Name = "OptimisedSizeColumn";
            this.OptimisedSizeColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // fileListContextMenu
            // 
            this.fileListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteMenuItem});
            this.fileListContextMenu.Name = "fileListContextMenu";
            this.fileListContextMenu.Size = new System.Drawing.Size(144, 26);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pasteMenuItem.Text = "&Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // addFilesButton
            // 
            this.addFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesButton.Location = new System.Drawing.Point(516, 344);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(75, 23);
            this.addFilesButton.TabIndex = 4;
            this.addFilesButton.Text = "Add Files...";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeItemButton.Enabled = false;
            this.removeItemButton.Location = new System.Drawing.Point(6, 344);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 3;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(597, 344);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(45, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // addFilesDialog
            // 
            this.addFilesDialog.DefaultExt = "png";
            this.addFilesDialog.Multiselect = true;
            this.addFilesDialog.Title = "Add Files...";
            // 
            // outputFolderBrowserDialog
            // 
            this.outputFolderBrowserDialog.Description = "Select Output Directory";
            this.outputFolderBrowserDialog.SelectedPath = "E:\\projects\\PNGoo\\pngs\\compiled\\";
            this.outputFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(440, 344);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MainView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addFilesButton);
            this.Controls.Add(this.fileBatchDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(587, 320);
            this.Name = "MainView";
            this.Text = "PNGoo";
            this.Activated += new System.EventHandler(this.MainView_Activated);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainView_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBatchDataGridView)).EndInit();
            this.fileListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button outputDirectoryBrowseButton;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.CheckBox overwriteIfLargerCheckBox;
        private System.Windows.Forms.CheckBox overwriteCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pngTypeComboBox;
        private System.Windows.Forms.Button colourSettingsButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.OpenFileDialog addFilesDialog;
        private System.Windows.Forms.ContextMenuStrip fileListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealFileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptimisedSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        public System.Windows.Forms.ToolStripStatusLabel statusText;
        public System.Windows.Forms.DataGridView fileBatchDataGridView;
        private System.Windows.Forms.Button cancelButton;





    }
}

