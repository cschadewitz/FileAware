namespace FileAware
{
    partial class FormFileAware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileAware));
            this.ContextMenuFileAware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconFileAware = new System.Windows.Forms.NotifyIcon(this.components);
            this.fileSystemWatcherFileAware = new System.IO.FileSystemWatcher();
            this.folderBrowserDialogFileAware = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.errorProviderFileAware = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBoxFileAware = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControlFileAware = new System.Windows.Forms.TabControl();
            this.tabPageWatcherView = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ContextMenuFileAware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherFileAware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileAware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControlFileAware.SuspendLayout();
            this.tabPageWatcherView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuFileAware
            // 
            this.ContextMenuFileAware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUIToolStripMenuItem,
            this.configRunToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ContextMenuFileAware.Name = "ContextMenuFileAware";
            this.ContextMenuFileAware.Size = new System.Drawing.Size(159, 76);
            this.ContextMenuFileAware.Text = "File";
            // 
            // showUIToolStripMenuItem
            // 
            this.showUIToolStripMenuItem.Name = "showUIToolStripMenuItem";
            this.showUIToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.showUIToolStripMenuItem.Text = "Show UI";
            this.showUIToolStripMenuItem.Click += new System.EventHandler(this.showUIToolStripMenuItem_Click);
            // 
            // configRunToolStripMenuItem
            // 
            this.configRunToolStripMenuItem.Name = "configRunToolStripMenuItem";
            this.configRunToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.configRunToolStripMenuItem.Text = "Choose/Run";
            this.configRunToolStripMenuItem.Click += new System.EventHandler(this.configRunToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIconFileAware
            // 
            this.notifyIconFileAware.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconFileAware.BalloonTipText = "FileAware is still running";
            this.notifyIconFileAware.BalloonTipTitle = "Info";
            this.notifyIconFileAware.ContextMenuStrip = this.ContextMenuFileAware;
            this.notifyIconFileAware.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconFileAware.Icon")));
            this.notifyIconFileAware.Text = "FileAware";
            // 
            // fileSystemWatcherFileAware
            // 
            this.fileSystemWatcherFileAware.EnableRaisingEvents = true;
            this.fileSystemWatcherFileAware.IncludeSubdirectories = true;
            this.fileSystemWatcherFileAware.SynchronizingObject = this;
            this.fileSystemWatcherFileAware.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_OnChange);
            this.fileSystemWatcherFileAware.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_OnChange);
            this.fileSystemWatcherFileAware.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_OnChange);
            this.fileSystemWatcherFileAware.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_OnRename);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(1048, 107);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(118, 28);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Location = new System.Drawing.Point(347, 107);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(128, 28);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "Choose Directory";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.Location = new System.Drawing.Point(6, 79);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(469, 22);
            this.textBoxPath.TabIndex = 2;
            // 
            // errorProviderFileAware
            // 
            this.errorProviderFileAware.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1160, 468);
            this.dataGridView1.TabIndex = 4;
            // 
            // richTextBoxFileAware
            // 
            this.richTextBoxFileAware.Location = new System.Drawing.Point(907, 6);
            this.richTextBoxFileAware.Name = "richTextBoxFileAware";
            this.richTextBoxFileAware.Size = new System.Drawing.Size(54, 57);
            this.richTextBoxFileAware.TabIndex = 5;
            this.richTextBoxFileAware.Text = "";
            this.richTextBoxFileAware.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControlFileAware
            // 
            this.tabControlFileAware.Controls.Add(this.tabPageWatcherView);
            this.tabControlFileAware.Controls.Add(this.tabPage2);
            this.tabControlFileAware.Location = new System.Drawing.Point(0, 57);
            this.tabControlFileAware.Name = "tabControlFileAware";
            this.tabControlFileAware.SelectedIndex = 0;
            this.tabControlFileAware.Size = new System.Drawing.Size(1182, 649);
            this.tabControlFileAware.TabIndex = 8;
            // 
            // tabPageWatcherView
            // 
            this.tabPageWatcherView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageWatcherView.Controls.Add(this.textBoxPath);
            this.tabPageWatcherView.Controls.Add(this.buttonFolderBrowser);
            this.tabPageWatcherView.Controls.Add(this.richTextBoxFileAware);
            this.tabPageWatcherView.Controls.Add(this.dataGridView1);
            this.tabPageWatcherView.Controls.Add(this.buttonRun);
            this.tabPageWatcherView.Location = new System.Drawing.Point(4, 25);
            this.tabPageWatcherView.Name = "tabPageWatcherView";
            this.tabPageWatcherView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWatcherView.Size = new System.Drawing.Size(1174, 620);
            this.tabPageWatcherView.TabIndex = 0;
            this.tabPageWatcherView.Text = "File Watcher";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1160, 468);
            this.dataGridView2.TabIndex = 5;
            // 
            // FormFileAware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.tabControlFileAware);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.Name = "FormFileAware";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileAware";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFileAware_FormClosing);
            this.Resize += new System.EventHandler(this.FormFileAware_Resize);
            this.ContextMenuFileAware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherFileAware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileAware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlFileAware.ResumeLayout(false);
            this.tabPageWatcherView.ResumeLayout(false);
            this.tabPageWatcherView.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuFileAware;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconFileAware;
        private System.IO.FileSystemWatcher fileSystemWatcherFileAware;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogFileAware;
        private System.Windows.Forms.ErrorProvider errorProviderFileAware;
        private System.Windows.Forms.ToolStripMenuItem showUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configRunToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBoxFileAware;
        private System.Windows.Forms.TabControl tabControlFileAware;
        private System.Windows.Forms.TabPage tabPageWatcherView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

