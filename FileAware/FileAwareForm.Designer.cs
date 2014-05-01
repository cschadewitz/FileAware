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
            this.richTextBoxFileAware = new System.Windows.Forms.RichTextBox();
            this.ContextMenuFileAware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherFileAware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileAware)).BeginInit();
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
            this.buttonRun.Location = new System.Drawing.Point(1021, 462);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(118, 28);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Location = new System.Drawing.Point(36, 434);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(118, 28);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "Choose Folder";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.Location = new System.Drawing.Point(160, 434);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(979, 22);
            this.textBoxPath.TabIndex = 2;
            // 
            // errorProviderFileAware
            // 
            this.errorProviderFileAware.ContainerControl = this;
            // 
            // richTextBoxFileAware
            // 
            this.richTextBoxFileAware.Location = new System.Drawing.Point(36, 13);
            this.richTextBoxFileAware.Name = "richTextBoxFileAware";
            this.richTextBoxFileAware.Size = new System.Drawing.Size(1103, 415);
            this.richTextBoxFileAware.TabIndex = 4;
            this.richTextBoxFileAware.Text = "";
            // 
            // FormFileAware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 502);
            this.Controls.Add(this.richTextBoxFileAware);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 550);
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
        private System.Windows.Forms.RichTextBox richTextBoxFileAware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
    }
}

