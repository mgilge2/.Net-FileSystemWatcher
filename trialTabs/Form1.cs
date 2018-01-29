using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace trialTabs
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher theWatcher;
        private string workingDirectory;
        private string fileFilter;
        private SQLiteConnection dbConnection;

        public Form1()
        {
            this.fileFilter = "*.*";
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(workingDirectory) && !isValidPath(workingDirectory))
            {
                this.monLabel.Text = "Invalid Directory Entered!!";
                this.monLabel.ForeColor = Color.Crimson;
            }
            else
            {
                this.monLabel.Text = "Monitoring Started!!";
                this.monLabel.ForeColor = Color.Green;
                this.theWatcher = new FileSystemWatcher(workingDirectory);
                this.initWatcher();
                this.stopBtn.Enabled = true;
                this.stopToolStripMenuItem.Enabled = false;
                this.toolStopBtn.Enabled = true;
                this.startBtn.Enabled = false;
                this.toolStartButton.Enabled = false;
                this.stopToolStripMenuItem.Enabled = true;
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.theWatcher.EnableRaisingEvents = false;
            this.startBtn.Enabled = true;
            this.startToolStripMenuItem.Enabled = true;
            this.toolStartButton.Enabled = true;
            this.toolStopBtn.Enabled = false;
            this.stopToolStripMenuItem.Enabled = false;
            this.stopBtn.Enabled = false;

            this.monLabel.Text = "Directory to Monitor";
            this.monLabel.ForeColor = Color.Black;
        }

        private void queryDatabasefileExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dbBtn_Click(sender,e);
            this.toolStripButton2.Enabled = false;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) //check operation if it is clicked while the monitor is running, not sure this is working correctly
        {
            this.fswOutput.Rows.Clear();
            this.clearBtn.Enabled = false;
            this.clearToolStripMenuItem.Enabled = false;
            this.dbBtn.Enabled = false;
            this.sToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void extSelBoxChanged(object sender, EventArgs e)
        {
            this.fileFilter = this.extSelBox.Text;
        }

        private void dirBoxChanged(object sender, EventArgs e)
        {
            this.workingDirectory = this.dirBox.Text;
        }

        public void initWatcher()
        {
            this.theWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            this.theWatcher.Changed += new FileSystemEventHandler(OnChanged);
            this.theWatcher.Created += new FileSystemEventHandler(OnChanged);
            this.theWatcher.Deleted += new FileSystemEventHandler(OnChanged);
            this.theWatcher.Renamed += new RenamedEventHandler(OnRenamed);

            this.theWatcher.IncludeSubdirectories = true;
            this.theWatcher.Filter = this.fileFilter;
            this.theWatcher.EnableRaisingEvents = true;  //this sets the watcher to start watching may want to move this and or add a method for it
        }


        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            FileInfo info = new FileInfo(e.FullPath);
            if (!(info.Name.Equals("OutputFile")) && !(info.Name.Equals("output.sqlite")) && !(info.Name.Equals("output.sqlite-journal")))
            {
                //string results = (info.Name + " " + e.FullPath + " " + e.ChangeType + " " + DateTime.Now);  //need to add date and time here!
                this.UpdateDataGrid(info.Name, e.FullPath, e.ChangeType.ToString(), System.DateTime.Now.ToString());

                //this.writeToFile(results);
                //this.writeToDatabase(results);
            }
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            FileInfo info = new FileInfo(e.FullPath);

            if (!(info.Name.Equals("OutputFile")) && !(info.Name.Equals("output.sqlite")) && !(info.Name.Equals("output.sqlite-journal")))
            {
                //  string results = (info.Name + " " + e.OldFullPath + " renamed to " + e.FullPath + " " + e.ChangeType + " " + DateTime.Now); // + " " + e.ChangeType);  //this also needs date and time! e.OldFullPath or some shit
                this.UpdateDataGrid(info.Name, e.FullPath, e.ChangeType.ToString(), System.DateTime.Now.ToString());  //wtf is wrong with DateTime.Now?ffs!!
                //this.writeToFile(results);
                //  this.writeToDatabase(results);
            }
        }

        private bool isValidPath(String path) //check this function swear to god it made it so c: wasnt valid which it isnt in winblows in terms of monitoring in the last assignment....
        {
            Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");

            if (string.IsNullOrWhiteSpace(path) || path.Length < 3)
            {
                return false;
            }

            if (!driveCheck.IsMatch(path.Substring(0, 3)))
            {
                return false;
            }

            var x1 = (path.Substring(3, path.Length - 3));
            string strTheseAreInvalidFileNameChars = new string(Path.GetInvalidPathChars());
            strTheseAreInvalidFileNameChars += @":?*";
            Regex containsABadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");

            if (containsABadCharacter.IsMatch(path.Substring(3, path.Length - 3)))
            {
                return false;
            }

            var driveLetterWithColonAndSlash = Path.GetPathRoot(path);

            if (!DriveInfo.GetDrives().Any(x => x.Name == driveLetterWithColonAndSlash))
            {
                return false;
            }

            //this part was what I added, it might be all that we really need here!
            DirectoryInfo info = new DirectoryInfo(path);
            return info.Exists;
        }

        public void UpdateDataGrid(string fn, string dir, string change, string date)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    this.fswOutput.Rows.Add(fn, dir, change, date);
                    this.clearToolStripMenuItem.Enabled = true;
                    this.clearBtn.Enabled = true;
                    this.dbBtn.Enabled = true;
                    this.sToolStripMenuItem.Enabled = true;
                    this.toolStripButton2.Enabled = true;
                });
            }
            catch (Exception e)
            {

            }
        }

        private void dirBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.startToolStripMenuItem_Click(sender, e);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == 0)
            {
                this.tabControl.SelectedIndex = 1;
            }
            else
            {
                this.tabControl.SelectedIndex = 0;
            }
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            this.createDatabase();
            this.writeToDatabase();
            this.toolStripButton2.Enabled = false;
            this.clearToolStripMenuItem_Click(sender, e);
        }

        private void createDatabase()
        {
            if (!File.Exists(@"..\..\..\OutputFile\output.sqlite")) //added this if since last ran, need to make sure we arent overwriting existing database!
            {
                SQLiteConnection.CreateFile(@"..\..\..\OutputFile\\output.sqlite");  //@"C:\Users\mgilge\Documents\output.sqlite")
            }
            using (this.dbConnection = new SQLiteConnection(@"data source=..\..\..\OutputFile\output.sqlite;Version=3"))
            {
                using (SQLiteCommand command = new SQLiteCommand(this.dbConnection))
                {
                    this.dbConnection.Open();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS [FileChanges] ([FileName] VARCHAR(2048) , [Directory] VARCHER(2048) , [Change] VARCHAR(2048) , [Time] VARCHAR(2048) )";
                    command.ExecuteNonQuery();

                    this.dbConnection.Close();
                }
            }
        }

        private void writeToDatabase()
        {
            SQLiteCommand command; 

            using (this.dbConnection = new SQLiteConnection(@"Data Source=..\..\..\OutputFile\output.sqlite;Version=3"))
            {
                using (command = new SQLiteCommand(this.dbConnection))
                {
                   this.dbConnection.Open();
                    using (var transaction = this.dbConnection.BeginTransaction())
                    {
                        foreach (DataGridViewRow row in this.fswOutput.Rows)
                        {
                            try
                            {
                                string fn = row.Cells[0].Value.ToString();
                                string dir = row.Cells[1].Value.ToString();
                                string change = row.Cells[2].Value.ToString();
                                string time = row.Cells[3].Value.ToString();

                                command.CommandText = "INSERT INTO FileChanges (FileName, Directory, Change, Time) Values (@param1, @param2, @param3, @param4)";
                                command.Parameters.AddWithValue("@param1", fn);
                                command.Parameters.AddWithValue("@param2", dir);
                                command.Parameters.AddWithValue("@param3", change);
                                command.Parameters.AddWithValue("@param4", time);

                                command.ExecuteNonQuery();
                            }
                            catch (Exception e)
                            {
                                //yes im bad so sue me! it works doesnt it? you think your better then me dont you!
                            }
                        }
                        transaction.Commit();
                     }

                    this.dbConnection.Close();
                }
            }
        }

        private void queryDatabaseExtension()
        {
            SQLiteCommand command;
            try
            {
                using (this.dbConnection = new SQLiteConnection(@"Data Source=..\..\..\OutputFile\output.sqlite;Version=3"))
                {
                    using (command = new SQLiteCommand(this.dbConnection))
                    {
                        this.dbConnection.Open();

                        command.CommandText = "SELECT * FROM FileChanges WHERE FileName LIKE  @param1";  //"'%ini'";
                        command.Parameters.Add(new SQLiteParameter("@param1", "%" + this.querySelBox.Text));
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        DataTable records = new DataTable();
                        adapter.Fill(records);
                        this.dataGridView1.DataSource = records;

                        this.dbConnection.Close();
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Database is Empty!!", "Invalid Database", MessageBoxButtons.OK);
            }

        }

        private void queryDatabaseChange()
        {
            SQLiteCommand command;
            try
            {
                using (this.dbConnection = new SQLiteConnection(@"Data Source=..\..\..\OutputFile\output.sqlite;Version=3"))
                {
                    using (command = new SQLiteCommand(this.dbConnection))
                    {
                        this.dbConnection.Open();

                        command.CommandText = "SELECT * FROM FileChanges WHERE Change LIKE @param1";    //"'%ini'";
                        command.Parameters.Add(new SQLiteParameter("@param1", "%" + this.changeSelBox.Text));
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        DataTable records = new DataTable();
                        adapter.Fill(records);
                        this.dataGridView1.DataSource = records;

                        this.dbConnection.Close();
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Database is Empty!!", "Invalid Database", MessageBoxButtons.OK);
            }

        }

        private void queryDatabaseDirectory()
        {
            SQLiteCommand command;
            try
            {
                using (this.dbConnection = new SQLiteConnection(@"Data Source=..\..\..\OutputFile\output.sqlite;Version=3"))
                {
                    using (command = new SQLiteCommand(this.dbConnection))
                    {
                        this.dbConnection.Open();

                        command.CommandText = "SELECT * FROM FileChanges WHERE Directory LIKE @param1";    //"'%ini'";
                        command.Parameters.Add(new SQLiteParameter("@param1",  this.dirSelBox.Text + "%"));
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        DataTable records = new DataTable();
                        adapter.Fill(records);
                        this.dataGridView1.DataSource = records;

                        this.dbConnection.Close();
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Database is Empty!!", "Invalid Database", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queryDatabaseExtension();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null; //rename handle the button being enabled pls k thanks bai
        }

        private void changeQueryBtn_Click(object sender, EventArgs e)
        {
            this.queryDatabaseChange();
        }

        private void dirQueryBtn_Click(object sender, EventArgs e)
        {
            this.queryDatabaseDirectory();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to write to the Database before exiting the Program?", "Save Before Exit", MessageBoxButtons.YesNoCancel);

            if (dialog == DialogResult.Yes)
            {
                this.writeToDatabase();
                
             
            }
            else if (dialog == DialogResult.No)
            {
              
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void eraseDbBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete the Database?", "Delete Database", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (this.dbConnection = new SQLiteConnection(@"data source=..\..\..\OutputFile\output.sqlite;Version=3"))
                {
                    using (SQLiteCommand command = new SQLiteCommand(this.dbConnection))
                    {
                        this.dbConnection.Open();
                        command.CommandText = "DROP TABLE IF EXISTS FileChanges";
                        command.ExecuteNonQuery();

                        this.dbConnection.Close();
                    }
                }
                this.button1_Click_1(sender, e);
            }
           
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.aboutToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command;
                using (this.dbConnection = new SQLiteConnection(@"Data Source=..\..\..\OutputFile\output.sqlite;Version=3"))
                {
                    using (command = new SQLiteCommand(this.dbConnection))
                    {
                        this.dbConnection.Open();

                        command.CommandText = "SELECT * FROM FileChanges WHERE Directory LIKE @param1 AND Change LIKE @param2 AND FileName LIKE @param3";    

                        command.Parameters.Add(new SQLiteParameter("@param1", this.dirSelBox.Text + "%"));
                        command.Parameters.Add(new SQLiteParameter("@param2", "%" + this.changeSelBox.Text));
                        command.Parameters.Add(new SQLiteParameter("@param3", "%" + this.querySelBox.Text));
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                        DataTable records = new DataTable();
                        adapter.Fill(records);
                        this.dataGridView1.DataSource = records;

                        this.dbConnection.Close();
                    }
                }
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Database is Empty!!", "Invalid Database", MessageBoxButtons.OK);
            }
          
        }

        private void fswOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string filePath = Path.GetFullPath(this.fswOutput.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + filePath);
            }
            
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.createDatabase();
            this.writeToDatabase();
            this.clearToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.eraseDbBtn_Click(sender, e);
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string filePath = Path.GetFullPath(this.dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + filePath);
            }
        }

        private void queryDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;
        }

        private void fileWatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 0;
        }

    }
}

