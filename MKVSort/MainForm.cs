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
        private string folderName;
        private FileHelper fh = new FileHelper();

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

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!CheckList())
            {
                MessageBox.Show("No files are selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fh.MoveFiles(txtSource.Text, txtDest.Text, lstFiles, chkShowPath.Checked);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = true;
            fh.Search(txtSource.Text, lstFiles, txtFilter.Text, chkFilter.Checked);
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
                foreach (FileInfo f in fh.FileList)
                {
                    lstFiles.Items.Add(Path.Combine(f.FilePath, f.FileName));
                }
            }
            else
            {
                foreach (FileInfo f in fh.FileList)
                {
                    lstFiles.Items.Add(f.FileName);
                }
            }
        }
    }
}