using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace MKVSort
{
    class FileHelper
    {
        public List<FileInfo> FileList = new List<FileInfo>();
        public ListBox lstFiles;

        public FileHelper(ListBox lstfiles)
        {
            lstFiles = lstfiles;
        }

        public void Search(string dir, ListBox lstFiles, string filter, bool filterChecked)
        {
            FileList.Clear();
            lstFiles.Items.Clear();

            try
            {
                if (!filterChecked)
                    filter = "*"; // Return all files.

                foreach (string f in Directory.GetFiles(dir, filter, SearchOption.AllDirectories))
                {
                    FileList.Add(new FileInfo(f));
                    lstFiles.Items.Add(Path.GetFileName(f));
                }
            }
            catch (System.Exception exception)
            {
                if (exception is ArgumentException)
                {
                    MessageBox.Show("Source is blank or directory doesn't exist!", "Error");
                }
                else
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        public void MoveFiles(string sDir, string dDir, ListBox lstFiles, bool showPath)
        {
            int files = lstFiles.SelectedItems.Count;
            string item = files > 1 ? "files" : "file";
            string plural = files > 1 ? "these" : "this";

            if (MessageBox.Show("Are you sure you want to move " + plural + " " + files.ToString() + " selected " + item + "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (string f in lstFiles.SelectedItems)
                {

                    if (showPath)
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
}
