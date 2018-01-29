namespace trialTabs
{

    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dbBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.fswOutput = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsolutePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.extSelBox = new System.Windows.Forms.ComboBox();
            this.monLabel = new System.Windows.Forms.Label();
            this.extLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStartButton = new System.Windows.Forms.ToolStripButton();
            this.toolStopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.eraseDbBtn = new System.Windows.Forms.Button();
            this.dirQueryLabel = new System.Windows.Forms.Label();
            this.dirSelBox = new System.Windows.Forms.ComboBox();
            this.dirQueryBtn = new System.Windows.Forms.Button();
            this.changeQueryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.changeSelBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.queryBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.querySelBox = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatbasechangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswOutput)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(586, 589);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dbBtn);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.fswOutput);
            this.tabPage1.Controls.Add(this.stopBtn);
            this.tabPage1.Controls.Add(this.startBtn);
            this.tabPage1.Controls.Add(this.dirBox);
            this.tabPage1.Controls.Add(this.extSelBox);
            this.tabPage1.Controls.Add(this.monLabel);
            this.tabPage1.Controls.Add(this.extLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Watcher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dbBtn
            // 
            this.dbBtn.Enabled = false;
            this.dbBtn.Location = new System.Drawing.Point(51, 495);
            this.dbBtn.Name = "dbBtn";
            this.dbBtn.Size = new System.Drawing.Size(75, 23);
            this.dbBtn.TabIndex = 22;
            this.dbBtn.Text = "Write to DB";
            this.dbBtn.UseVisualStyleBackColor = true;
            this.dbBtn.Click += new System.EventHandler(this.dbBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Location = new System.Drawing.Point(439, 496);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fswOutput
            // 
            this.fswOutput.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fswOutput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fswOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fswOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.fswOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fswOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.AbsolutePath,
            this.ChangeType,
            this.DateTime});
            this.fswOutput.Location = new System.Drawing.Point(51, 161);
            this.fswOutput.Name = "fswOutput";
            this.fswOutput.ReadOnly = true;
            this.fswOutput.RowHeadersVisible = false;
            this.fswOutput.Size = new System.Drawing.Size(463, 312);
            this.fswOutput.TabIndex = 20;
            this.fswOutput.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fswOutput_CellContentClick);
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // AbsolutePath
            // 
            this.AbsolutePath.HeaderText = "Absolute Path";
            this.AbsolutePath.Name = "AbsolutePath";
            this.AbsolutePath.ReadOnly = true;
            // 
            // ChangeType
            // 
            this.ChangeType.HeaderText = "ChangeType";
            this.ChangeType.Name = "ChangeType";
            this.ChangeType.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Date & Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(439, 120);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 19;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Lime;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(256, 120);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 18;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(256, 94);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(258, 20);
            this.dirBox.TabIndex = 17;
            this.dirBox.TextChanged += new System.EventHandler(this.dirBoxChanged);
            this.dirBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dirBox_KeyDown_1);
            // 
            // extSelBox
            // 
            this.extSelBox.FormattingEnabled = true;
            this.extSelBox.Items.AddRange(new object[] {
            "*.*",
            "*.txt",
            "*.exe",
            "*.doc",
            "*.java",
            "*.cs",
            "*.ini"});
            this.extSelBox.Location = new System.Drawing.Point(51, 94);
            this.extSelBox.Name = "extSelBox";
            this.extSelBox.Size = new System.Drawing.Size(121, 21);
            this.extSelBox.TabIndex = 16;
            this.extSelBox.Text = "*.*";
            this.extSelBox.Leave += new System.EventHandler(this.extSelBoxChanged);
            // 
            // monLabel
            // 
            this.monLabel.AutoSize = true;
            this.monLabel.Location = new System.Drawing.Point(253, 76);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(99, 13);
            this.monLabel.TabIndex = 15;
            this.monLabel.Text = "Directory to Monitor";
            // 
            // extLabel
            // 
            this.extLabel.AutoSize = true;
            this.extLabel.Location = new System.Drawing.Point(48, 76);
            this.extLabel.Name = "extLabel";
            this.extLabel.Size = new System.Drawing.Size(105, 13);
            this.extLabel.TabIndex = 14;
            this.extLabel.Text = "Monitor by Extension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select a file extension, a directory, and click Start to begin the File System Mo" +
    "nitor.";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStartButton,
            this.toolStopBtn,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(572, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStartButton
            // 
            this.toolStartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStartButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStartButton.Image")));
            this.toolStartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStartButton.Name = "toolStartButton";
            this.toolStartButton.Size = new System.Drawing.Size(23, 22);
            this.toolStartButton.Text = "toolStartButton";
            this.toolStartButton.ToolTipText = "Start the FileWatcher";
            this.toolStartButton.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // toolStopBtn
            // 
            this.toolStopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStopBtn.Enabled = false;
            this.toolStopBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolStopBtn.Image")));
            this.toolStopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStopBtn.Name = "toolStopBtn";
            this.toolStopBtn.Size = new System.Drawing.Size(23, 22);
            this.toolStopBtn.Text = "toolStopBtn";
            this.toolStopBtn.ToolTipText = "Stop the FileWatcher";
            this.toolStopBtn.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save results to DataBase";
            this.toolStripButton2.Click += new System.EventHandler(this.queryDatabasefileExtensionToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileSystemWatcherToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.sToolStripMenuItem,
            this.queryDBToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fileSystemWatcherToolStripMenuItem.Text = "Watcher";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.sToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sToolStripMenuItem.Text = "Save to DB";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // queryDBToolStripMenuItem
            // 
            this.queryDBToolStripMenuItem.Name = "queryDBToolStripMenuItem";
            this.queryDBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.queryDBToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.queryDBToolStripMenuItem.Text = "Query DB";
            this.queryDBToolStripMenuItem.Click += new System.EventHandler(this.queryDBToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.eraseDbBtn);
            this.tabPage2.Controls.Add(this.dirQueryLabel);
            this.tabPage2.Controls.Add(this.dirSelBox);
            this.tabPage2.Controls.Add(this.dirQueryBtn);
            this.tabPage2.Controls.Add(this.changeQueryBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.changeSelBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.queryBtn);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.querySelBox);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB Watcher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Run All Queries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eraseDbBtn
            // 
            this.eraseDbBtn.Location = new System.Drawing.Point(45, 518);
            this.eraseDbBtn.Name = "eraseDbBtn";
            this.eraseDbBtn.Size = new System.Drawing.Size(121, 23);
            this.eraseDbBtn.TabIndex = 34;
            this.eraseDbBtn.Text = "Erase Database";
            this.eraseDbBtn.UseVisualStyleBackColor = true;
            this.eraseDbBtn.Click += new System.EventHandler(this.eraseDbBtn_Click);
            // 
            // dirQueryLabel
            // 
            this.dirQueryLabel.AutoSize = true;
            this.dirQueryLabel.Location = new System.Drawing.Point(384, 71);
            this.dirQueryLabel.Name = "dirQueryLabel";
            this.dirQueryLabel.Size = new System.Drawing.Size(95, 13);
            this.dirQueryLabel.TabIndex = 33;
            this.dirQueryLabel.Text = "Query By Directory";
            // 
            // dirSelBox
            // 
            this.dirSelBox.FormattingEnabled = true;
            this.dirSelBox.Items.AddRange(new object[] {
            "c:\\windows",
            "c:\\users"});
            this.dirSelBox.Location = new System.Drawing.Point(387, 98);
            this.dirSelBox.Name = "dirSelBox";
            this.dirSelBox.Size = new System.Drawing.Size(121, 21);
            this.dirSelBox.TabIndex = 32;
            this.dirSelBox.Text = "c:\\windows";
            // 
            // dirQueryBtn
            // 
            this.dirQueryBtn.Location = new System.Drawing.Point(387, 136);
            this.dirQueryBtn.Name = "dirQueryBtn";
            this.dirQueryBtn.Size = new System.Drawing.Size(121, 23);
            this.dirQueryBtn.TabIndex = 31;
            this.dirQueryBtn.Text = "Run Directory Query";
            this.dirQueryBtn.UseVisualStyleBackColor = true;
            this.dirQueryBtn.Click += new System.EventHandler(this.dirQueryBtn_Click);
            // 
            // changeQueryBtn
            // 
            this.changeQueryBtn.Location = new System.Drawing.Point(211, 136);
            this.changeQueryBtn.Name = "changeQueryBtn";
            this.changeQueryBtn.Size = new System.Drawing.Size(121, 23);
            this.changeQueryBtn.TabIndex = 30;
            this.changeQueryBtn.Text = "Run Change Query";
            this.changeQueryBtn.UseVisualStyleBackColor = true;
            this.changeQueryBtn.Click += new System.EventHandler(this.changeQueryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Query By Change";
            // 
            // changeSelBox
            // 
            this.changeSelBox.FormattingEnabled = true;
            this.changeSelBox.Items.AddRange(new object[] {
            "Changed",
            "Created",
            "Deleted",
            "Renamed"});
            this.changeSelBox.Location = new System.Drawing.Point(211, 98);
            this.changeSelBox.Name = "changeSelBox";
            this.changeSelBox.Size = new System.Drawing.Size(121, 21);
            this.changeSelBox.TabIndex = 28;
            this.changeSelBox.Text = "Changed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Clear Queary Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(45, 136);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(121, 23);
            this.queryBtn.TabIndex = 26;
            this.queryBtn.Text = "Run Extension Query";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Query By Extension";
            // 
            // querySelBox
            // 
            this.querySelBox.FormattingEnabled = true;
            this.querySelBox.Items.AddRange(new object[] {
            "txt",
            "exe",
            "doc",
            "java",
            "cs",
            "ini"});
            this.querySelBox.Location = new System.Drawing.Point(45, 98);
            this.querySelBox.Name = "querySelBox";
            this.querySelBox.Size = new System.Drawing.Size(121, 21);
            this.querySelBox.TabIndex = 24;
            this.querySelBox.Text = "ini";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem8});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(572, 24);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.queryDatbasechangeToolStripMenuItem,
            this.queryDatabaseDirectoryToolStripMenuItem,
            this.queryDatabaseallToolStripMenuItem,
            this.toolStripMenuItem7,
            this.clearResultsToolStripMenuItem,
            this.fileWatcherToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem3.Text = "Database";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItem6.Text = "Query Database(file extension)";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.button1_Click);
            // 
            // queryDatbasechangeToolStripMenuItem
            // 
            this.queryDatbasechangeToolStripMenuItem.Name = "queryDatbasechangeToolStripMenuItem";
            this.queryDatbasechangeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.queryDatbasechangeToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.queryDatbasechangeToolStripMenuItem.Text = "Query Datbase(change)";
            this.queryDatbasechangeToolStripMenuItem.Click += new System.EventHandler(this.changeQueryBtn_Click);
            // 
            // queryDatabaseDirectoryToolStripMenuItem
            // 
            this.queryDatabaseDirectoryToolStripMenuItem.Name = "queryDatabaseDirectoryToolStripMenuItem";
            this.queryDatabaseDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.queryDatabaseDirectoryToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.queryDatabaseDirectoryToolStripMenuItem.Text = "Query Database(directory)";
            this.queryDatabaseDirectoryToolStripMenuItem.Click += new System.EventHandler(this.dirQueryBtn_Click);
            // 
            // queryDatabaseallToolStripMenuItem
            // 
            this.queryDatabaseallToolStripMenuItem.Name = "queryDatabaseallToolStripMenuItem";
            this.queryDatabaseallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.queryDatabaseallToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.queryDatabaseallToolStripMenuItem.Text = "Query Database(all)";
            this.queryDatabaseallToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(277, 22);
            this.toolStripMenuItem7.Text = "Delete Database";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fileWatcherToolStripMenuItem
            // 
            this.fileWatcherToolStripMenuItem.Name = "fileWatcherToolStripMenuItem";
            this.fileWatcherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.fileWatcherToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.fileWatcherToolStripMenuItem.Text = "FileWatcher";
            this.fileWatcherToolStripMenuItem.Click += new System.EventHandler(this.fileWatcherToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem8.Text = "Help";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem9.Text = "About";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(463, 289);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 586);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(583, 625);
            this.MinimumSize = new System.Drawing.Size(583, 625);
            this.Name = "Form1";
            this.Text = "File Watcher Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswOutput)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView fswOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsolutePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.ComboBox extSelBox;
        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Label extLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStartButton;
        private System.Windows.Forms.ToolStripButton toolStopBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dbBtn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox querySelBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changeQueryBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox changeSelBox;
        private System.Windows.Forms.Label dirQueryLabel;
        private System.Windows.Forms.ComboBox dirSelBox;
        private System.Windows.Forms.Button dirQueryBtn;
        private System.Windows.Forms.Button eraseDbBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatbasechangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileWatcherToolStripMenuItem;
    }
}

