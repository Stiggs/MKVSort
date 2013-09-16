using System;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MKVSort
{
    public partial class MainForm : Form
    {
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
            lstFiles.Items.Clear();

            try
            {
                if (chkFilter.Checked)
                    filter = txtFilter.Text;
                else
                    filter = "*"; // Return all files.

                foreach (string f in Directory.GetFiles(dir, filter, SearchOption.AllDirectories))
                {
                    lstFiles.Items.Add(f);
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
                        File.Move(f, Path.Combine(dDir, Path.GetFileName(f)));
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
    }
}