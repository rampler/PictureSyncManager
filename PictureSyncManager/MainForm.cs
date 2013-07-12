using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PictureSyncManager.photos;
using System.IO;

namespace PictureSyncManager
{
    public partial class PictureSyncManager : Form
    {
        private static PhotosManager photosManager = new PhotosManager();
        private bool isDownloadingStopped = false;
        private string[] videosExtensions = { ".avi", ".mov", ".mp4", "m4v", ".mxf", ".wmv", ".3gp", ".flv" };
        private string[] previewExtensions = { ".jpg", ".jpeg", ".tif", ".tiff", ".png", ".bmp", ".gif" };

        /*
         * Constructor 
         * - initialize components
         * - load gallery path
         * - load list of avaible devices
         * */
        public PictureSyncManager()
        {
            InitializeComponent();
            if (!Directory.Exists("data")) Directory.CreateDirectory("data");
            try
            {
                FileStream file = new FileStream("data/path.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                pathBox.Text = reader.ReadLine();
                reader.Close();
                file.Close();
            }
            catch (IOException ex) { pathBox.Text = "C:\\"; }
            try
            {
                FileStream file = new FileStream("data/format.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                dateFormatBox.Text = reader.ReadLine();
                reader.Close();
                file.Close();
            }
            catch (IOException ex) { dateFormatBox.Text = "yyyy_mm_dd"; }
            try
            {
                listOfDevices.Items.AddRange(photosManager.devicesList().ToArray());
                listOfDevices.Text = photosManager.devicesList().First.Value;
                updateBtn.Enabled = true;
            }
            catch (System.ApplicationException ex) { MessageBox.Show(ex.Message); }
        }

        /*
         * Update list of avaible devices and clear tree
         * */
        private void updateTree()
        {
            waitingPanel.Visible = true;
            Application.DoEvents();
            tree.Nodes.Clear();
            syncLbl.Text = "0";
            photosManager.connectToDevice(listOfDevices.Text);
            if (onlyNewBox.Checked) photosManager.getPhotosfromDevice(pathBox.Text);
            else photosManager.getPhotosfromDevice();
            tree.Nodes.Add(new TreeNode("Wszystkie"));
            string latestDate = "";
            int actualDateIndex = 0, actualItemInGroup = 0;
            foreach (var item in photosManager.getPhotos())
            {
                if (!latestDate.Equals(item.Date))
                {
                    tree.Nodes[0].Nodes.Add(item.Date);
                    tree.Nodes[0].Nodes[actualDateIndex].ImageIndex = 1;
                    tree.Nodes[0].Nodes[actualDateIndex].SelectedImageIndex = 1;
                    actualDateIndex++;
                    latestDate = item.Date;
                    actualItemInGroup = 0;
                }
                tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes.Add(item.Name);
                if (!videosExtensions.Contains(Path.GetExtension(item.Name)))
                {
                    tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes[actualItemInGroup].ImageIndex = 2;
                    tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes[actualItemInGroup].SelectedImageIndex = 2;
                }
                else
                {
                    tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes[actualItemInGroup].ImageIndex = 3;
                    tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes[actualItemInGroup].SelectedImageIndex = 3;
                }
                actualItemInGroup++;
            }
            tree.Nodes[0].Expand();
            tree.SelectedNode = tree.Nodes[0];
            tree.SelectedNode = null;
            photosManager.disconnectDevice();
            waitingPanel.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e) { updateTree(); }

        /*
         * Refresh List of Photos avaible on device.
         * */
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                updateBtn.Enabled = false;
                listOfDevices.Items.Clear();
                tree.Nodes.Clear();
                listOfDevices.Text = "";
                listOfDevices.Items.AddRange(photosManager.devicesList().ToArray());
                listOfDevices.Text = photosManager.devicesList().First.Value;
                updateBtn.Enabled = true;
            }
            catch (System.ApplicationException ex) { MessageBox.Show(ex.Message); }
        }

        /*
         * Show FolderBrowserDialog and select gallery folder
         * */
        private void folderPathBtn_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            using (FolderBrowserDialog fileBrowserDialog = new FolderBrowserDialog())
            {
                fileBrowserDialog.Description = "Podaj ścieżkę do galerii:";
                fileBrowserDialog.ShowNewFolderButton = true;
                if (fileBrowserDialog.ShowDialog() == DialogResult.OK) pathBox.Text = fileBrowserDialog.SelectedPath;
            }
        }

        /*
         * Show About Form
         * */
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            System.Threading.Thread about = new System.Threading.Thread(new System.Threading.ThreadStart(AboutThread));
            about.Start();
        }

        /*
         * Starting About Form Thread
         * */
        private static void AboutThread()
        {
            Application.Run(new About());
        }

        /*
         * Saving actual gallery Path to "path.txt"
         * */
        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream("data/path.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(pathBox.Text);
                writer.Close();
                file.Close();
            }
            catch (IOException ex) { }
        }
        
        /*
         * Saving Date Format to "format.txt"
         * */
        private void dateFormatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream("data/format.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(dateFormatBox.Text);
                writer.Close();
                file.Close();
            }
            catch (IOException ex) { }
            photosManager.setDateFormat(dateFormatBox.Text);
        }

        /*
         * Check Node's Children in TreeView
         * Recursive
         * @param TreeNode
         * @param bool - if true - check, false - uncheck
         * */
        private void checkChildren(TreeNode root, bool check)
        {
            foreach (TreeNode node in root.Nodes)
            {
                if (check)
                {
                    if (!node.Checked) node.Checked = true;
                    if (node.Nodes.Count != 0) checkChildren(node, check);
                }
                else
                {
                    if (node.Checked) node.Checked = false;
                    if (node.Nodes.Count == 0) checkChildren(node, check);
                }
            }
        }

        /*
         * Action After Check Node in TreeView
         * */
        private void tree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                if (e.Node.Nodes.Count == 0 && !e.Node.Text.Equals("Wszystkie")) syncLbl.Text = (int.Parse(syncLbl.Text) + 1) + "";
                else checkChildren(e.Node,true);
            }
            else
            {
                if (e.Node.Nodes.Count == 0 && !e.Node.Text.Equals("Wszystkie")) syncLbl.Text = (int.Parse(syncLbl.Text) - 1) + "";
                else checkChildren(e.Node, false);
            }
        }

        /*
         * Action After Select Node in TreeView
         * Display Preview if photo
         * */
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && !e.Node.Text.Equals("Wszystkie"))
            {
                if (preview.Image != null) preview.Image.Dispose();
                PortableDeviceFile photo = findPhoto(e.Node);
                nameLbl.Text = photo.Name;
                dateLbl.Text = photo.Date;
                timeLbl.Text = photo.Time;
                if (int.Parse(photo.Size) < 1024) sizeLbl.Text = photo.Size + " B";
                else if (int.Parse(photo.Size) < (1024 * 1024)) sizeLbl.Text = Math.Round((double.Parse(photo.Size) / 1024),1) + " kB";
                else sizeLbl.Text = Math.Round((double.Parse(photo.Size) / (1024*1024)), 1) + " MB";
                if (previewExtensions.Contains(Path.GetExtension(photo.Name).ToLower()))
                {
                    photosManager.getPreview(photo, listOfDevices.Text);
                    preview.Image = Image.FromFile("data/bufor");
                }
                else preview.Image = null;
            }
        }

        /*
         * Find Photo by Selected Node
         * */
        private PortableDeviceFile findPhoto(TreeNode node)
        {
            int index = 0;
            for (int i = 0; i < node.Parent.Index; i++) index += tree.Nodes[0].Nodes[i].Nodes.Count;
            index += node.Index;
            return photosManager.getPhotos().ElementAt(index);
        }

        /*
         * Download Checked photos
         * */
        private void syncBtn_Click(object sender, EventArgs e)
        {
            int i = 1;
            progressBar.Value = 0;
            downloadPanel.Visible = true;
            Application.DoEvents();
            tabControl.Enabled = false;
            syncBtn.Enabled = false;
            tree.Enabled = false;

            try
            {
                if (int.Parse(syncLbl.Text) == 0) throw new System.ApplicationException("Nie zaznaczono zdjęć do pobrania");
                photosManager.connectToDevice(listOfDevices.Text);
                foreach (TreeNode parent in tree.Nodes[0].Nodes)
                    foreach (TreeNode node in parent.Nodes)
                        if (node.Checked)
                        {
                            Application.DoEvents();
                            if (isDownloadingStopped) throw new System.ApplicationException("Pobieranie przerwane przez użytkownika.");
                            progressBar.Value = ((i * 100) / int.Parse(syncLbl.Text));
                            photosManager.downloadPhoto(findPhoto(node), pathBox.Text);
                            i++;
                        }
                photosManager.disconnectDevice();
                if (onlyNewBox.Checked) updateTree();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                if (onlyNewBox.Checked && isDownloadingStopped) updateTree();
            };

            isDownloadingStopped = false;
            downloadPanel.Visible = false;
            tabControl.Enabled = true;
            syncBtn.Enabled = true;
            tree.Enabled = true;
        }

        /*
         * Abort Downloading
         * */
        private void abortBtn_Click(object sender, EventArgs e)
        {
            isDownloadingStopped = true;
        }
    }
}
