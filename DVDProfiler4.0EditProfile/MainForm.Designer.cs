namespace DVD_Profiler_4._0
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCollectionxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AudioGrid = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Channels = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Content2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubtitleGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveFeatureButton = new System.Windows.Forms.Button();
            this.AddFeatureButton = new System.Windows.Forms.Button();
            this.ProfileFeatureListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableFeaturesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfileOtherFeatureTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfileOtherFeatureListBox = new System.Windows.Forms.ListBox();
            this.RemoveOtherFeatureButton = new System.Windows.Forms.Button();
            this.AddOtherFeatureButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudioGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubtitleGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCollectionxmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCollectionxmlToolStripMenuItem
            // 
            this.openCollectionxmlToolStripMenuItem.Name = "openCollectionxmlToolStripMenuItem";
            this.openCollectionxmlToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openCollectionxmlToolStripMenuItem.Text = "Open Collection.xml";
            this.openCollectionxmlToolStripMenuItem.Click += new System.EventHandler(this.OnOpenCollectionxmlToolStripMenuItemClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 640);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Audio & Subtitles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(970, 608);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AudioGrid);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // AudioGrid
            // 
            this.AudioGrid.AllowUserToResizeRows = false;
            this.AudioGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AudioGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AudioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AudioGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Kind,
            this.Format,
            this.Channels,
            this.Content,
            this.Content2});
            this.AudioGrid.Location = new System.Drawing.Point(6, 19);
            this.AudioGrid.Name = "AudioGrid";
            this.AudioGrid.Size = new System.Drawing.Size(952, 270);
            this.AudioGrid.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "Main Feature",
            "Alternate Cut"});
            this.Type.Name = "Type";
            this.Type.Width = 39;
            // 
            // Kind
            // 
            this.Kind.HeaderText = "Kind";
            this.Kind.Items.AddRange(new object[] {
            "",
            "Commentary",
            "Music Only",
            "Audio Descriptive",
            "Special Effects"});
            this.Kind.Name = "Kind";
            this.Kind.Width = 39;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Items.AddRange(new object[] {
            "",
            "Dolby Digital",
            "DTS",
            "Dolby Digital EX",
            "DTS ES",
            "PCM",
            "MPEG-1 Audio Layer II (MP2)"});
            this.Format.Name = "Format";
            this.Format.Width = 45;
            // 
            // Channels
            // 
            this.Channels.HeaderText = "Channels";
            this.Channels.Items.AddRange(new object[] {
            "",
            "Mono",
            "2-Channel Stereo",
            "Dolby Surround",
            "3.1",
            "4.0",
            "4.1",
            "5.0",
            "5.1",
            "5.1 (Matrixed 6.1)",
            "6.1 (Discrete)",
            "7.1"});
            this.Channels.Name = "Channels";
            this.Channels.Width = 57;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Items.AddRange(new object[] {
            "",
            "Afrikaans",
            "Arabic",
            "Bahasa",
            "Bambara",
            "Basque",
            "Bulgarian",
            "Cantonese",
            "Catalonian",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Farsi",
            "Finnish",
            "Flemish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Italian",
            "Japanese",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Mongolian",
            "Norwegian",
            "Other",
            "Pashtu",
            "Polish",
            "Portuguese",
            "Romanian",
            "Rumantsch",
            "Russian",
            "Serbian",
            "Slovak",
            "Spanish",
            "Swedish",
            "Swiss German",
            "Tagalog",
            "Thai",
            "Tibetan",
            "Turkish",
            "Valencian",
            "Vietnamese",
            "Zulu"});
            this.Content.Name = "Content";
            this.Content.Width = 50;
            // 
            // Content2
            // 
            this.Content2.HeaderText = "Content #2";
            this.Content2.Items.AddRange(new object[] {
            "",
            "Afrikaans",
            "Arabic",
            "Bahasa",
            "Bambara",
            "Basque",
            "Bulgarian",
            "Cantonese",
            "Catalonian",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Farsi",
            "Finnish",
            "Flemish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Italian",
            "Japanese",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Mongolian",
            "Norwegian",
            "Other",
            "Pashtu",
            "Polish",
            "Portuguese",
            "Romanian",
            "Rumantsch",
            "Russian",
            "Serbian",
            "Slovak",
            "Spanish",
            "Swedish",
            "Swiss German",
            "Tagalog",
            "Thai",
            "Tibetan",
            "Turkish",
            "Valencian",
            "Vietnamese",
            "Zulu"});
            this.Content2.Name = "Content2";
            this.Content2.Width = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SubtitleGrid);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subtitles";
            // 
            // SubtitleGrid
            // 
            this.SubtitleGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtitleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SubtitleGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SubtitleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubtitleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3});
            this.SubtitleGrid.Location = new System.Drawing.Point(6, 19);
            this.SubtitleGrid.Name = "SubtitleGrid";
            this.SubtitleGrid.Size = new System.Drawing.Size(952, 272);
            this.SubtitleGrid.TabIndex = 1;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Type";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Main Feature",
            "Alternate Cut"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 39;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Kind";
            this.dataGridViewComboBoxColumn2.Items.AddRange(new object[] {
            "",
            "SDH",
            "Close Captioned (CC)",
            "Commentary",
            "Trivia"});
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 39;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.HeaderText = "Content";
            this.dataGridViewComboBoxColumn3.Items.AddRange(new object[] {
            "",
            "Afrikaans",
            "Arabic",
            "Bahasa",
            "Bambara",
            "Basque",
            "Bulgarian",
            "Catalonian",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Farsi",
            "Finnish",
            "Flemish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Italian",
            "Japanese",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Mongolian",
            "Norwegian",
            "Other",
            "Pashtu",
            "Polish",
            "Portuguese",
            "Romanian",
            "Rumantsch",
            "Russian",
            "Serbian",
            "Slovakian",
            "Slovenian",
            "Spanish",
            "Swedish",
            "Swiss German",
            "Tagalog",
            "Thai",
            "Tibetan",
            "Turkish",
            "Valencian",
            "Vietnamese",
            "Xhosa",
            "Zulu"});
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Features & Formats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(970, 608);
            this.splitContainer2.SplitterDistance = 133;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(964, 127);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video Formats";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.splitContainer3);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(964, 465);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Features";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 16);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.RemoveFeatureButton);
            this.splitContainer3.Panel1.Controls.Add(this.AddFeatureButton);
            this.splitContainer3.Panel1.Controls.Add(this.ProfileFeatureListBox);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.AvailableFeaturesListBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.ProfileOtherFeatureTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.ProfileOtherFeatureListBox);
            this.splitContainer3.Panel2.Controls.Add(this.RemoveOtherFeatureButton);
            this.splitContainer3.Panel2.Controls.Add(this.AddOtherFeatureButton);
            this.splitContainer3.Size = new System.Drawing.Size(958, 446);
            this.splitContainer3.SplitterDistance = 451;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Features in Profile:";
            // 
            // RemoveFeatureButton
            // 
            this.RemoveFeatureButton.Enabled = false;
            this.RemoveFeatureButton.Location = new System.Drawing.Point(187, 56);
            this.RemoveFeatureButton.Name = "RemoveFeatureButton";
            this.RemoveFeatureButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveFeatureButton.TabIndex = 4;
            this.RemoveFeatureButton.Text = "<--";
            this.RemoveFeatureButton.UseVisualStyleBackColor = true;
            this.RemoveFeatureButton.Click += new System.EventHandler(this.OnRemoveFeatureButtonClick);
            // 
            // AddFeatureButton
            // 
            this.AddFeatureButton.Enabled = false;
            this.AddFeatureButton.Location = new System.Drawing.Point(187, 27);
            this.AddFeatureButton.Name = "AddFeatureButton";
            this.AddFeatureButton.Size = new System.Drawing.Size(64, 23);
            this.AddFeatureButton.TabIndex = 3;
            this.AddFeatureButton.Text = "-->";
            this.AddFeatureButton.UseVisualStyleBackColor = true;
            this.AddFeatureButton.Click += new System.EventHandler(this.OnAddFeatureButtonClick);
            // 
            // ProfileFeatureListBox
            // 
            this.ProfileFeatureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProfileFeatureListBox.FormattingEnabled = true;
            this.ProfileFeatureListBox.Location = new System.Drawing.Point(257, 27);
            this.ProfileFeatureListBox.Name = "ProfileFeatureListBox";
            this.ProfileFeatureListBox.Size = new System.Drawing.Size(172, 407);
            this.ProfileFeatureListBox.TabIndex = 2;
            this.ProfileFeatureListBox.SelectedIndexChanged += new System.EventHandler(this.OnProfileFeatureListBoxSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Features:";
            // 
            // AvailableFeaturesListBox
            // 
            this.AvailableFeaturesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AvailableFeaturesListBox.FormattingEnabled = true;
            this.AvailableFeaturesListBox.Items.AddRange(new object[] {
            "Additional Episodes",
            "Alternative Ending",
            "BD-Live",
            "Bonus CD",
            "Bonus Trailers",
            "Booklets",
            "Certificate of Authenticity",
            "CineChat ",
            "Closed Captioned",
            "Commercials",
            "D-Box",
            "Deleted Scenes",
            "Digital Copy",
            "DVD-ROM Content",
            "Feature Trailers",
            "Featurettes",
            "Gag Reel",
            "Gallery",
            "Interactive Games",
            "Interviews",
            "Introductions",
            "Isolated Scores",
            "Mini-Poster",
            "Multi-Angle",
            "Music Videos",
            "Never Before Seen Footage",
            "Outtakes/Bloopers",
            "Picture-in-Picture",
            "Play All",
            "Printable Scripts",
            "Production Notes/Bios",
            "Promo Spots",
            "PSA\'s",
            "Scene Access",
            "Screen Test",
            "Season Play",
            "Shorts",
            "Sing-Alongs",
            "Sketches",
            "Sneak Peaks",
            "Storyboard Comparison",
            "Storybook",
            "THX Certified",
            "THX Optimizer",
            "Trivia Tracks",
            "U-Control",
            "Video Commentary",
            "Web Links",
            "Webisodes"});
            this.AvailableFeaturesListBox.Location = new System.Drawing.Point(6, 27);
            this.AvailableFeaturesListBox.Name = "AvailableFeaturesListBox";
            this.AvailableFeaturesListBox.Size = new System.Drawing.Size(175, 407);
            this.AvailableFeaturesListBox.TabIndex = 0;
            this.AvailableFeaturesListBox.SelectedIndexChanged += new System.EventHandler(this.OnAvailableFeaturesListBoxSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Other Feature:";
            // 
            // ProfileOtherFeatureTextBox
            // 
            this.ProfileOtherFeatureTextBox.Location = new System.Drawing.Point(3, 30);
            this.ProfileOtherFeatureTextBox.Name = "ProfileOtherFeatureTextBox";
            this.ProfileOtherFeatureTextBox.Size = new System.Drawing.Size(238, 20);
            this.ProfileOtherFeatureTextBox.TabIndex = 10;
            this.ProfileOtherFeatureTextBox.TextChanged += new System.EventHandler(this.OnOtherFeatureTextBoxTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Other Features in Profile:";
            // 
            // ProfileOtherFeatureListBox
            // 
            this.ProfileOtherFeatureListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProfileOtherFeatureListBox.FormattingEnabled = true;
            this.ProfileOtherFeatureListBox.Location = new System.Drawing.Point(317, 27);
            this.ProfileOtherFeatureListBox.Name = "ProfileOtherFeatureListBox";
            this.ProfileOtherFeatureListBox.Size = new System.Drawing.Size(172, 407);
            this.ProfileOtherFeatureListBox.TabIndex = 6;
            this.ProfileOtherFeatureListBox.SelectedIndexChanged += new System.EventHandler(this.OnProfileOtherFeatureListBoxSelectedIndexChanged);
            // 
            // RemoveOtherFeatureButton
            // 
            this.RemoveOtherFeatureButton.Enabled = false;
            this.RemoveOtherFeatureButton.Location = new System.Drawing.Point(247, 56);
            this.RemoveOtherFeatureButton.Name = "RemoveOtherFeatureButton";
            this.RemoveOtherFeatureButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveOtherFeatureButton.TabIndex = 8;
            this.RemoveOtherFeatureButton.Text = "Remove";
            this.RemoveOtherFeatureButton.UseVisualStyleBackColor = true;
            this.RemoveOtherFeatureButton.Click += new System.EventHandler(this.OnRemoveOtherFeatureButtonClick);
            // 
            // AddOtherFeatureButton
            // 
            this.AddOtherFeatureButton.Enabled = false;
            this.AddOtherFeatureButton.Location = new System.Drawing.Point(247, 27);
            this.AddOtherFeatureButton.Name = "AddOtherFeatureButton";
            this.AddOtherFeatureButton.Size = new System.Drawing.Size(64, 23);
            this.AddOtherFeatureButton.TabIndex = 7;
            this.AddOtherFeatureButton.Text = "Add";
            this.AddOtherFeatureButton.UseVisualStyleBackColor = true;
            this.AddOtherFeatureButton.Click += new System.EventHandler(this.OnAddOtherFeatureButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 679);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 718);
            this.Name = "MainForm";
            this.Text = "DVD Profiler 4.0 Edit Profile v2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AudioGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubtitleGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCollectionxmlToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView AudioGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SubtitleGrid;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveFeatureButton;
        private System.Windows.Forms.Button AddFeatureButton;
        private System.Windows.Forms.ListBox ProfileFeatureListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AvailableFeaturesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProfileOtherFeatureTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ProfileOtherFeatureListBox;
        private System.Windows.Forms.Button RemoveOtherFeatureButton;
        private System.Windows.Forms.Button AddOtherFeatureButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn Kind;
        private System.Windows.Forms.DataGridViewComboBoxColumn Format;
        private System.Windows.Forms.DataGridViewComboBoxColumn Channels;
        private System.Windows.Forms.DataGridViewComboBoxColumn Content;
        private System.Windows.Forms.DataGridViewComboBoxColumn Content2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
    }
}

