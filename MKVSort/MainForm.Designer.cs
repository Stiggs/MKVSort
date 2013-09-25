namespace MKVSort
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelAll = new System.Windows.Forms.Button();
            this.btnSelNone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkShowPath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MKV Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(77, 70);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(166, 20);
            this.txtSource.TabIndex = 3;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(77, 105);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(166, 20);
            this.txtDest.TabIndex = 4;
            // 
            // btnSource
            // 
            this.btnSource.AutoSize = true;
            this.btnSource.Location = new System.Drawing.Point(249, 68);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(26, 23);
            this.btnSource.TabIndex = 5;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDest
            // 
            this.btnDest.AutoSize = true;
            this.btnDest.Location = new System.Drawing.Point(249, 103);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(26, 23);
            this.btnDest.TabIndex = 6;
            this.btnDest.Text = "...";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(77, 138);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(166, 20);
            this.txtFilter.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(12, 404);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(260, 31);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Move Files";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.HorizontalScrollbar = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 175);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFiles.Size = new System.Drawing.Size(260, 134);
            this.lstFiles.TabIndex = 10;
            this.ttInfo.SetToolTip(this.lstFiles, "Select the files that you want to move in here.");
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 367);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 31);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(255, 142);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(15, 14);
            this.chkFilter.TabIndex = 12;
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 5000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.ReshowDelay = 100;
            // 
            // btnSelAll
            // 
            this.btnSelAll.Location = new System.Drawing.Point(12, 338);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(79, 23);
            this.btnSelAll.TabIndex = 13;
            this.btnSelAll.Text = "Select All";
            this.btnSelAll.UseVisualStyleBackColor = true;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // btnSelNone
            // 
            this.btnSelNone.Location = new System.Drawing.Point(195, 338);
            this.btnSelNone.Name = "btnSelNone";
            this.btnSelNone.Size = new System.Drawing.Size(77, 23);
            this.btnSelNone.TabIndex = 14;
            this.btnSelNone.Text = "Select None";
            this.btnSelNone.UseVisualStyleBackColor = true;
            this.btnSelNone.Click += new System.EventHandler(this.btnSelNone_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(97, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkShowPath
            // 
            this.chkShowPath.AutoSize = true;
            this.chkShowPath.Location = new System.Drawing.Point(16, 315);
            this.chkShowPath.Name = "chkShowPath";
            this.chkShowPath.Size = new System.Drawing.Size(97, 17);
            this.chkShowPath.TabIndex = 16;
            this.chkShowPath.Text = "Show Full Path";
            this.chkShowPath.UseVisualStyleBackColor = true;
            this.chkShowPath.CheckedChanged += new System.EventHandler(this.chkShowPath_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 443);
            this.Controls.Add(this.chkShowPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelNone);
            this.Controls.Add(this.btnSelAll);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MKV Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.Button btnSelNone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkShowPath;
    }
}

