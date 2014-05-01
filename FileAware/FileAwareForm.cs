//Casey Schadewitz
//Assignment 2
//This program allows you to watch for changes in files
//within a specified directory. The program writes to a log
//file called FileAware.log located in bin/Debug/.
//The program minimizes to the a notification icon in the 
//system tool bar bottom right corner and has commands from 
//there as well.
//The usere can input an absolute path or choose one with the 
//choose folder button.


using FileAware.Properties;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace FileAware
{
    public partial class FormFileAware : Form
    {
       
        private static StreamWriter logWriter;
        private static FileStream logStream;

        private bool runningFlag = false;
        private bool chosenFlag = false;
        private string dbFileName = Application.StartupPath + @"\FileAware.log";
        public FormFileAware()
        {
            InitializeComponent();
            this.Icon = Resources.Gakuseisean_Aire_Search_Folder;
            notifyIconFileAware.Icon = Resources.Gakuseisean_Aire_Search_Folder;
            logStream = new FileStream(dbFileName, FileMode.Append);
            logWriter = new StreamWriter(logStream);
           

        }
       
        //Opens folder browser to choose a path
        private void buttonFolderBrowser_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialogFileAware.ShowDialog();
            textBoxPath.Text = folderBrowserDialogFileAware.SelectedPath;
            chosenFlag = true;
        }
        //Runs the file watcher and appends to both the file and on screen display
        //Alternate function: When already running this method preforms the stopping
        //of the filewatcher
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void buttonRun_Click(object sender, EventArgs e)
        {
           
            if (!runningFlag)
            {
                string path = textBoxPath.Text;
                Uri directoryUri;
                //string directoryPathFormatted = Uri.UnescapeDataString(path);

                try
                {
                    
                    directoryUri = new Uri(path);
                    fileSystemWatcherFileAware.Path = directoryUri.AbsolutePath;
                    //currentTable = "D" + DateTime.Now.ToFileTimeUtc().ToString();
                    //createCommand.CommandText = "CREATE TABLE " + currentTable + " (id integer primary key, time varchar(50), type varchar(10), filename varchar(100), path varchar(1000));";

                    //createCommand.ExecuteNonQuery();
                    //dbDataAdapter.InsertCommand = sqlBuilder.GetInsertCommand(true);

                    //dbDataAdapter.SelectCommand = new SQLiteCommand("SELECT id, time, type, filename, path FROM " + currentTable, dbConnection);
                    ////dbDataAdapter.SelectCommand.
                    //dbDataAdapter.Fill(currentDataSet);
                }
                catch (Exception exp)
                {
                    if (FormWindowState.Minimized == this.WindowState)
                    {
                        notifyIconFileAware.ShowBalloonTip(500, "Error", "The path is not correctly formated", ToolTipIcon.Error);
                    }
                    errorProviderFileAware.SetError(textBoxPath, "The path is not correctly formated");
                    return;
                }
                //}catch(Exception exp)
                //{
                //    textBoxPath.Text = "ERROR: " + exp.Message;
                //    return;
                //}
                logWriter.WriteLineAsync("Log: " + directoryUri.AbsolutePath + "\nStart Date: " + DateTime.Now.ToString() + "\n");
                
                fileSystemWatcherFileAware.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
                

                fileSystemWatcherFileAware.EnableRaisingEvents = true;
                buttonFolderBrowser.Hide();
                textBoxPath.Enabled = false;
                buttonRun.Text = "Stop";
                configRunToolStripMenuItem.Text = "Stop";
                runningFlag = true;
            }
            else
            {
                fileSystemWatcherFileAware.EnableRaisingEvents = false;
                textBoxPath.Enabled = true;
                buttonRun.Text = "Run";
                textBoxPath.Text = " ";
                richTextBoxFileAware.Text = " ";
                logWriter.WriteLineAsync("Log End Date: " + DateTime.Now.ToString() + "\n\n\n");
                configRunToolStripMenuItem.Text = "Config/Run";
                buttonFolderBrowser.Show();
                runningFlag = false;
                chosenFlag = false;
            }

        }

        //Handles the onchange event from the filewatcher
        private void fileSystemWatcher_OnChange(object sender, FileSystemEventArgs e)
        {
            if (System.IO.Path.HasExtension(e.FullPath))
            {
                richTextBoxFileAware.AppendText(String.Format("{3}\nFile {2}: {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, DateTime.Now));
                logWriter.WriteLineAsync(String.Format("{3}\nFile {2}: {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, DateTime.Now));
                //currentDataSet.Tables[currentTable].Rows.Add()
                //currentDataSet.Tables[currentTable].Rows.Add(dataGridViewFileAware.NewRowIndex, DateTime.Now.ToString(), e.ChangeType, e.Name, e.FullPath);
            }
            else
            {
                richTextBoxFileAware.AppendText(String.Format("{3}\nDirectory {2}: {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, DateTime.Now));
                logWriter.WriteLineAsync(String.Format("{3}\nDirectory {2}: {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, DateTime.Now));
                //currentDataSet.Tables[currentTable].Rows.Add(dataGridViewFileAware.NewRowIndex, DateTime.Now.ToString(), e.ChangeType, e.Name, e.FullPath);
            }
            

        }

        //Handles the onrename event from the filewatcher
        private void fileSystemWatcher_OnRename(object sender, RenamedEventArgs e)
        {
            if (System.IO.Path.HasExtension(e.FullPath))
            {
                richTextBoxFileAware.AppendText(String.Format("{4}\nFile {2}: {3} to {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, e.OldName, DateTime.Now));
                logWriter.WriteLineAsync(String.Format("{4}\nFile {2}: {3} to {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, e.OldName, DateTime.Now));
                //currentDataSet.Tables[currentTable].Rows.Add(dataGridViewFileAware.NewRowIndex, DateTime.Now.ToString(), e.ChangeType, e.OldName + e.Name, e.FullPath);
            }
            else
            {
                richTextBoxFileAware.AppendText(String.Format("{4}\nDirectory {2}: {3} to {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, e.OldName, DateTime.Now));
                logWriter.WriteLineAsync(String.Format("{4}\nDirectory {2}: {3} to {0}\nPath: {1}\n", e.Name, e.FullPath, e.ChangeType, e.OldName, DateTime.Now));
                //currentDataSet.Tables[currentTable].Rows.Add(dataGridViewFileAware.NewRowIndex, DateTime.Now.ToString(), e.ChangeType, e.OldName + e.Name, e.FullPath);
            }

        }

        //Handles minimizing to the tool bar and back
        private void FormFileAware_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == this.WindowState)
            {
                notifyIconFileAware.Visible = true;
                notifyIconFileAware.ShowBalloonTip(500);
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else if(FormWindowState.Maximized == this.WindowState)
            {
                notifyIconFileAware.Visible = false;
                this.Show();
                this.Focus();
                
                this.ShowInTaskbar = true;
                this.CenterToScreen();

            }
        }

        //Handles config/run command from the tool bar icon
        private void configRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!runningFlag && !chosenFlag)
            {
                buttonFolderBrowser_Click(sender, e);
                buttonRun_Click(sender, e);
            }
            else if(!runningFlag)
            {
                buttonRun_Click(sender, e);
            }
            else
            {
                buttonRun_Click(sender, e);
            }
        }

        //Handles showUI command from tool bar icon
        private void showUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FormFileAware_Resize(sender, e);
                       
        }

        //Handles exit command from the tool bar icon
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Closes all external resources before the form closes
        private void FormFileAware_FormClosing(object sender, FormClosingEventArgs e)
        {
            logWriter.WriteLine("Log End Date: " + DateTime.Now.ToString() + "\n\n\n");
            logWriter.Close();
            logStream.Close();
            //CloseDataBase();
        }

        

    }
}
