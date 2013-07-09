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
        private PhotosManager photosManager = new PhotosManager(); 

        /*
         * Constructor 
         * - initialize components
         * - load gallery path
         * - load list of avaible devices
         * */
        public PictureSyncManager()
        {
            InitializeComponent();
            try
            {
                FileStream file = new FileStream("path.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                pathBox.Text = reader.ReadLine();
                reader.Close();
                file.Close();
            }
            catch (IOException ex) { pathBox.Text = "C:\\"; }
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
        private void updateBtn_Click(object sender, EventArgs e)
        {
            System.Threading.Thread waiting = new System.Threading.Thread(new System.Threading.ThreadStart(WaitingThread));
            waiting.Start();
            tree.Nodes.Clear();
            photosManager.connectToDevice(listOfDevices.Text);
            photosManager.getPhotosfromDevice();
            tree.Nodes.Add(new TreeNode("Wszystkie"));
            string latestDate = "";
            int actualDateIndex = 0;
            foreach(var item in photosManager.getPhotos())
            {
                if (!latestDate.Equals(item.Date))
                {
                    tree.Nodes[0].Nodes.Add(item.Date);
                    actualDateIndex++;
                    latestDate = item.Date;
                }
                tree.Nodes[0].Nodes[actualDateIndex - 1].Nodes.Add(item.Name);
            }
            tree.TopNode.Checked = true;
            checkChildren(tree.TopNode);
            tree.ExpandAll();
            photosManager.disconnectDevice();
            waiting.Abort();
        }

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
         * Starting Waiting Dialog Thread
         * */
        private static void WaitingThread()
        {
            Application.Run(new WaitingDialog());
        }

        /*
         * Saving actual gallery Path to "path.txt"
         * */
        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream("path.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(pathBox.Text);
                writer.Close();
                file.Close();
            }
            catch (IOException ex) { }
        }

        /*
         * Check Node's Children in TreeView
         * Recursive
         * @param TreeNode
         * */
        private void checkChildren(TreeNode root)
        {
            foreach (TreeNode node in root.Nodes)
            {
                node.Checked = true;
                if (node.Nodes.Count == 0) syncLbl.Text = (int.Parse(syncLbl.Text) + 1) + "";
                checkChildren(node);
            }
        }
    }
}
