using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MKVSort
{
    public partial class MainForm : Form
    {
        private List<FileInfo> fileList = new List<FileInfo>();
        private string folderName, filter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            browseFolders(txtSource);
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            browseFolders(txtDest);
        }

        private void browseFolders(TextBox txt)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = fbd.SelectedPath;
                txt.Text = folderName;
            }
        }

        private void Search(string dir)
        {
            fileList.Clear();
            lstFiles.Items.Clear();

            try
            {
                if (chkFilter.Checked)
                    filter = txtFilter.Text;
                else
                    filter = "*"; // Return all files.

                foreach (string f in Directory.GetFiles(dir, filter, SearchOption.AllDirectories))
                {
                    fileList.Add(new FileInfo(f));
                    lstFiles.Items.Add(Path.GetFileName(f));
                }
            }
            catch (System.Exception exception)
            {
                if (exception is ArgumentException)
                {
                    MessageBox.Show(this, "Source is blank or directory doesn't exist!", "Error");
                }
                else
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void MoveFiles(string sDir, string dDir)
        {
            if (!CheckList())
            {
                MessageBox.Show("No files are selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int files = lstFiles.SelectedItems.Count;
                string item = files > 1 ? "files" : "file";
                string plural = files > 1 ? "these" : "this";

                if (MessageBox.Show("Are you sure you want to move " + plural + " " + files.ToString() + " selected " + item + "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (string f in lstFiles.SelectedItems)
                    {
                        
                        if (chkShowPath.Checked)
                            File.Move(f, Path.Combine(dDir, Path.GetFileName(f))); // If the show path box is checked, we need to strip the file name from the path.
                        else
                            File.Move(Path.Combine(sDir, f), Path.Combine(dDir, f)); // If the show path box is NOT checked, we don't need to strip the file name, but we do need to combine it with the source directory so that File.Move knows where it's being moved from!
                    }

                    MessageBox.Show(files.ToString() + " " + item + " successfully moved to " + dDir.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MoveFiles(txtSource.Text, txtDest.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = true;
            Search(txtSource.Text);
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFiles.Items.Count; i++)
            {
                lstFiles.SetSelected(i, true);
            }
        }

        private void btnSelNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFiles.Items.Count; i++)
            {
                lstFiles.SetSelected(i, false);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            btnGo.Enabled = false;
        }

        private bool CheckList()
        {
            if (lstFiles.SelectedItems.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chkShowPath_CheckedChanged(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();

            if (chkShowPath.Checked)
            {
                foreach (FileInfo f in fileList)
                {
                    lstFiles.Items.Add(Path.Combine(f.FilePath, f.FileName));
                }
            }
            else
            {
                foreach (FileInfo f in fileList)
                {
                    lstFiles.Items.Add(f.FileName);
                }
            }
        }
    }
}