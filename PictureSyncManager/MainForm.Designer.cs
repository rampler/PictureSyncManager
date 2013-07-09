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
            this.panel1 = new System.Windows.Forms.Panel();
            this.syncLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.onlyNewBox = new System.Windows.Forms.CheckBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.listOfDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderPathBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.syncLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(464, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Synchronizuj";
            this.button1.UseVisualStyleBackColor = true;
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
            // folderPathBtn
            // 
            this.folderPathBtn.Location = new System.Drawing.Point(499, 11);
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
            this.pathBox.Size = new System.Drawing.Size(386, 20);
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
            this.tree.Location = new System.Drawing.Point(0, 71);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(539, 307);
            this.tree.TabIndex = 3;
            // 
            // PictureSyncManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 412);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label syncLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listOfDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckBox onlyNewBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button folderPathBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.TreeView tree;
    }
}

