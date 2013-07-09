using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSyncManager.photos
{
    class PhotosManager
    {
        private LinkedList<PortableDeviceFile> photos = new LinkedList<PortableDeviceFile>();
        private PortableDeviceCollection collection = new PortableDeviceCollection();
        private PortableDevice device;

        public LinkedList<PortableDeviceFile> getPhotos() { return photos; }
        public int getPhotosSize() { return photos.Count; }

        /*
         * Checking DCIM folder for photos and adding this photos to LinkedList
         * Recursive
         * @param PortableDeviceFolder
         * */
        private void CheckFolderContents(PortableDeviceFolder folder)
        {
            foreach (var item in folder.Files)
            {
                if (item is PortableDeviceFolder) CheckFolderContents((PortableDeviceFolder)item);
                else if (item is PortableDeviceFile)
                {
                    if (item.Name.Length < 4) { }
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("jpg")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("JPG")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 4).Equals("JPEG")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 4).Equals("jpeg")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("png")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("PNG")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("bmp")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("BMP")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("GIF")) photos.AddLast((PortableDeviceFile)item);
                    else if (item.Name.Substring(item.Name.Length - 3).Equals("gif")) photos.AddLast((PortableDeviceFile)item);
                }
                //device.DownloadFile((PortableDeviceFile)item, @"D:\KCS\");
            }
        }

        /*
         * Checking foder for DCIM folder
         * This function don't add photos to LinkedList of PortableDeviceFile
         * Recursive
         * @param PortableDeviceFolder
         * */
        private void CheckFolderContentsNDCIM(PortableDeviceFolder folder)
        {
            foreach (var item in folder.Files)
            {
                if (item is PortableDeviceFolder)
                {
                    if (item.Name.Equals("DCIM")) CheckFolderContents((PortableDeviceFolder)item);
                    else CheckFolderContentsNDCIM((PortableDeviceFolder)item);
                }
            }
        }

        /**
         * Changing dates to format: dd-mm-yyy
         * */
        private void changeDates()
        {
            foreach (var item in photos) item.Date = item.Date.Substring(8, 2) + "-" + item.Date.Substring(5, 2) + "-" + item.Date.Substring(0, 4);
        }

        /*
         * Getting list of photos from DCIM folders on device
         * */
        public void getPhotosfromDevice()
        {
            var folder = device.GetContents();
            photos.Clear();
            foreach (var item in folder.Files)
            {
                if (item is PortableDeviceFolder)
                {
                    if (item.Name.Equals("DCIM")) CheckFolderContents((PortableDeviceFolder)item);
                    else CheckFolderContentsNDCIM((PortableDeviceFolder)item);
                }
            }
            LinkedList<PortableDeviceFile> temp = new LinkedList<PortableDeviceFile>();
            foreach (var photo in photos.OrderBy(j => j.Date)) temp.AddFirst(photo);
            photos = temp;
            changeDates();
        }

        /*
         * Return list of available devices
         * */
        public LinkedList<string> devicesList()
        {
            LinkedList<string> devices = new LinkedList<string>();
            collection = new PortableDeviceCollection();
            collection.Refresh();
            foreach (var dev in collection)
            {
                dev.Connect();
                devices.AddLast(dev.FriendlyName);
                dev.Disconnect();
            }
            return devices;
        }

        /*
         * Connect to device 
         * @param deviceName
         * */
        public void connectToDevice(string deviceName)
        {
            bool found = false;
            collection.Refresh();
            foreach (var dev in collection)
            {
                dev.Connect();
                if (dev.FriendlyName.Equals(deviceName)) { device = dev; found = true; }
                dev.Disconnect();
            }
            if (found) device.Connect();
            else MessageBox.Show("Urządzenie odłączone!");
        }

        /*
         * Disconnect current device
         * */
        public void disconnectDevice() { device.Disconnect();  }

    }
}
