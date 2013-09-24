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
        private FileHelper fh;

        public MainForm()
        {
            InitializeComponent();

            fh = new FileHelper(lstFiles);
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
                fh.MoveFiles(txtSource.Text, txtDest.Text, chkShowPath.Checked);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = true;
            fh.Search(txtSource.Text, txtFilter.Text, chkFilter.Checked);
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fh.lstFiles.Items.Count; i++)
            {
                fh.lstFiles.SetSelected(i, true);
            }
        }

        private void btnSelNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fh.lstFiles.Items.Count; i++)
            {
                fh.lstFiles.SetSelected(i, false);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fh.lstFiles.Items.Clear();
            btnGo.Enabled = false;
        }

        private bool CheckList()
        {
            if (fh.lstFiles.SelectedItems.Count <= 0)
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
            fh.lstFiles.Items.Clear();

            if (chkShowPath.Checked)
            {
                foreach (FileInfo f in fh.FileList)
                {
                    fh.lstFiles.Items.Add(Path.Combine(f.FilePath, f.FileName));
                }
            }
            else
            {
                foreach (FileInfo f in fh.FileList)
                {
                    fh.lstFiles.Items.Add(f.FileName);
                }
            }
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilter.Checked)
                txtFilter.Enabled = true;
            else
                txtFilter.Enabled = false;
        }
    }
}