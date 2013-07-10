namespace PictureSyncManager
{
    partial class PictureSyncManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureSyncManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.syncLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.syncBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.onlyNewBox = new System.Windows.Forms.CheckBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.listOfDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateFormatBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.folderPathBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downloadPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.waitingPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.downloadPanel.SuspendLayout();
            this.waitingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.syncLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.syncBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 34);
            this.panel1.TabIndex = 0;
            // 
            // syncLbl
            // 
            this.syncLbl.AutoSize = true;
            this.syncLbl.Location = new System.Drawing.Point(176, 11);
            this.syncLbl.Name = "syncLbl";
            this.syncLbl.Size = new System.Drawing.Size(13, 13);
            this.syncLbl.TabIndex = 2;
            this.syncLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba plików do synchronizacji:";
            // 
            // syncBtn
            // 
            this.syncBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.syncBtn.Location = new System.Drawing.Point(464, 0);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(75, 34);
            this.syncBtn.TabIndex = 0;
            this.syncBtn.Text = "Synchronizuj";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 71);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.updateBtn);
            this.tabPage1.Controls.Add(this.onlyNewBox);
            this.tabPage1.Controls.Add(this.refreshBtn);
            this.tabPage1.Controls.Add(this.listOfDevices);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 45);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Synchronizacja";
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(433, 11);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(93, 23);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Zaktualizuj listę";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // onlyNewBox
            // 
            this.onlyNewBox.AutoSize = true;
            this.onlyNewBox.Checked = true;
            this.onlyNewBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyNewBox.Location = new System.Drawing.Point(334, 15);
            this.onlyNewBox.Name = "onlyNewBox";
            this.onlyNewBox.Size = new System.Drawing.Size(81, 17);
            this.onlyNewBox.TabIndex = 3;
            this.onlyNewBox.Text = "Tylko nowe";
            this.onlyNewBox.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(241, 11);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Odśwież";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // listOfDevices
            // 
            this.listOfDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfDevices.Location = new System.Drawing.Point(83, 11);
            this.listOfDevices.Name = "listOfDevices";
            this.listOfDevices.Size = new System.Drawing.Size(152, 21);
            this.listOfDevices.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Urządzenie:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dateFormatBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.folderPathBtn);
            this.tabPage2.Controls.Add(this.pathBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 45);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zapis";
            // 
            // dateFormatBox
            // 
            this.dateFormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFormatBox.FormattingEnabled = true;
            this.dateFormatBox.Items.AddRange(new object[] {
            "yyyy_mm_dd",
            "yyyy-mm-dd",
            "yyyy.mm.dd",
            "dd_mm_yyyy",
            "dd-mm-yyyy",
            "dd.mm.yyyy"});
            this.dateFormatBox.Location = new System.Drawing.Point(417, 12);
            this.dateFormatBox.Name = "dateFormatBox";
            this.dateFormatBox.Size = new System.Drawing.Size(106, 21);
            this.dateFormatBox.TabIndex = 4;
            this.dateFormatBox.SelectedIndexChanged += new System.EventHandler(this.dateFormatBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Format daty:";
            // 
            // folderPathBtn
            // 
            this.folderPathBtn.Location = new System.Drawing.Point(316, 11);
            this.folderPathBtn.Name = "folderPathBtn";
            this.folderPathBtn.Size = new System.Drawing.Size(24, 23);
            this.folderPathBtn.TabIndex = 2;
            this.folderPathBtn.Text = "...";
            this.folderPathBtn.UseVisualStyleBackColor = true;
            this.folderPathBtn.Click += new System.EventHandler(this.folderPathBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(107, 13);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(200, 20);
            this.pathBox.TabIndex = 1;
            this.pathBox.Text = "C:\\";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ścieżka do galerii:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.aboutBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(531, 45);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pomoc";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(11, 11);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 0;
            this.aboutBtn.Text = "O Programie";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // tree
            // 
            this.tree.CheckBoxes = true;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.HideSelection = false;
            this.tree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(339, 307);
            this.tree.TabIndex = 3;
            this.tree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterCheck);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 307);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tree);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 307);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sizeLbl);
            this.panel3.Controls.Add(this.timeLbl);
            this.panel3.Controls.Add(this.dateLbl);
            this.panel3.Controls.Add(this.nameLbl);
            this.panel3.Controls.Add(this.preview);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 307);
            this.panel3.TabIndex = 4;
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sizeLbl.Location = new System.Drawing.Point(52, 83);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(0, 13);
            this.sizeLbl.TabIndex = 11;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLbl.Location = new System.Drawing.Point(108, 65);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(0, 13);
            this.timeLbl.TabIndex = 10;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLbl.Location = new System.Drawing.Point(93, 47);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(0, 13);
            this.dateLbl.TabIndex = 9;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLbl.Location = new System.Drawing.Point(47, 30);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 13);
            this.nameLbl.TabIndex = 8;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(9, 128);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(181, 172);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 6;
            this.preview.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(5, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Podgląd:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rozmiar: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Godzina modyfikacji:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data modyfikacji:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nazwa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informacje o zdjęciu:";
            // 
            // downloadPanel
            // 
            this.downloadPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.downloadPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downloadPanel.Controls.Add(this.progressBar);
            this.downloadPanel.Location = new System.Drawing.Point(4, 200);
            this.downloadPanel.Name = "downloadPanel";
            this.downloadPanel.Size = new System.Drawing.Size(532, 39);
            this.downloadPanel.TabIndex = 5;
            this.downloadPanel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(519, 23);
            this.progressBar.TabIndex = 0;
            // 
            // waitingPanel
            // 
            this.waitingPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.waitingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waitingPanel.Controls.Add(this.label11);
            this.waitingPanel.Location = new System.Drawing.Point(140, 190);
            this.waitingPanel.Name = "waitingPanel";
            this.waitingPanel.Size = new System.Drawing.Size(276, 55);
            this.waitingPanel.TabIndex = 2;
            this.waitingPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pobieranie listy zdjęć z urządzenia...";
            // 
            // PictureSyncManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 412);
            this.Controls.Add(this.waitingPanel);
            this.Controls.Add(this.downloadPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureSyncManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Sync Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.downloadPanel.ResumeLayout(false);
            this.waitingPanel.ResumeLayout(false);
            this.waitingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label syncLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckBox onlyNewBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button folderPathBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox dateFormatBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel downloadPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox listOfDevices;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Panel waitingPanel;
        private System.Windows.Forms.Label label11;
    }
}

