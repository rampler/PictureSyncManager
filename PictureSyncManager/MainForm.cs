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
        PhotosManager photosManager = new PhotosManager();       

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
            }
            catch (System.ApplicationException ex) { MessageBox.Show(ex.Message); }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            photosManager.connectToDevice(listOfDevices.Text);
            photosManager.getPhotosfromDevice();
            TreeNode[] array = new TreeNode[photosManager.getPhotosSize()];
            int i = 0;
            foreach(var item in photosManager.getPhotos())
            {
                array[i] = new TreeNode(item.Name);
                i++;
            }
            tree.Nodes.Add(new TreeNode("Wszystkie",array));
            tree.ExpandAll();
            photosManager.disconnectDevice();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listOfDevices.Items.Clear();
                tree.Nodes.Clear();
                listOfDevices.Text = "";
                listOfDevices.Items.AddRange(photosManager.devicesList().ToArray());
                listOfDevices.Text = photosManager.devicesList().First.Value;
            }
            catch (System.ApplicationException ex) { MessageBox.Show(ex.Message); }
        }

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

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            System.Threading.Thread about = new System.Threading.Thread(new System.Threading.ThreadStart(AboutThread));
            about.Start();
        }

        public static void AboutThread()
        {
            Application.Run(new About());
        }

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
        
    }
}
