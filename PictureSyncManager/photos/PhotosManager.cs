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
        private string dateFormat = "yyyy_mm_dd";

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
                    string extension = System.IO.Path.GetExtension(item.Name);
                    string[] popularPhotosExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".raw", ".tif", "tiff" };
                    string[] anotherRawExtensions = { ".crw", ".cr2", ".dcs",".dcr", ".drf", ".k25", ".kdc",
                            ".dng", ".bay", ".erf", ".raf", ".3fr", ".fff", ".mos", ".pnx", ".mef",
                            ".mrw", ".nef", ".nrw", ".orf", ".rw2", ".ptx", ".pef", ".cap", ".iiq",
                            ".eip", ".rwz", ".r3d", ".x3f", ".arw", ".srf", ".srz" };
                    string[] videosExtensions = { ".avi", ".mov", ".mp4", "m4v", ".mxf", ".wmv", ".3gp", ".flv" };
                    if (popularPhotosExtensions.Contains(extension.ToLower())) photos.AddLast((PortableDeviceFile)item);
                    else if (videosExtensions.Contains(extension.ToLower())) photos.AddLast((PortableDeviceFile)item);
                    else if (anotherRawExtensions.Contains(extension.ToLower())) photos.AddLast((PortableDeviceFile)item);
                }
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
         * Changing dates to format: dateFormat and time to format: hh:mm
         *
         * */
        private void changeDates()
        {
            foreach (var item in photos)
            {
                item.Time = item.Date.Substring(11, 5);
                if (dateFormat.Equals("yyyy_mm_dd")) item.Date = item.Date.Substring(0, 4) + "_" + item.Date.Substring(5, 2) + "_" + item.Date.Substring(8, 2);
                else if (dateFormat.Equals("yyyy-mm-dd")) item.Date = item.Date.Substring(0, 4) + "-" + item.Date.Substring(5, 2) + "-" + item.Date.Substring(8, 2);
                else if (dateFormat.Equals("yyyy.mm.dd")) item.Date = item.Date.Substring(0, 4) + "." + item.Date.Substring(5, 2) + "." + item.Date.Substring(8, 2);
                else if (dateFormat.Equals("dd_mm_yyyy")) item.Date = item.Date.Substring(8, 2) + "_" + item.Date.Substring(5, 2) + "_" + item.Date.Substring(0, 4);
                else if (dateFormat.Equals("dd-mm-yyyy")) item.Date = item.Date.Substring(8, 2) + "-" + item.Date.Substring(5, 2) + "-" + item.Date.Substring(0, 4);
                else if (dateFormat.Equals("dd.mm.yyyy")) item.Date = item.Date.Substring(8, 2) + "." + item.Date.Substring(5, 2) + "." + item.Date.Substring(0, 4);
            }
        }

        /*
         * Set Date Format
         * */
        public void setDateFormat(string format) { dateFormat = format; }
        /*
         * Getting list of photos from DCIM folders on device
         * - without params - all
         * @param string - gallery path - only new photos
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

        public void getPhotosfromDevice(string galleryPath)
        {
            getPhotosfromDevice();
            LinkedList<PortableDeviceFile> temp = new LinkedList<PortableDeviceFile>();
            foreach (var photo in photos)
                if (!System.IO.File.Exists(galleryPath + "/" + photo.Date + "/" + photo.Name)) temp.AddLast(photo);
            photos = temp;
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

        /*
         * Download photo to gallery
         * Directory - date
         * If directory doesn't exits - create it
         * @param PortableDeviceFile - photo to download
         * @param string - gallery path
         * */
        public void downloadPhoto(PortableDeviceFile item, string path) 
        {
            string folderPath = System.IO.Path.Combine(path, item.Date);
            if (!System.IO.Directory.Exists(folderPath)) System.IO.Directory.CreateDirectory(folderPath);
            device.DownloadFile(item, System.IO.Path.Combine(folderPath, item.Name)); 
        }

        /*
         * Get Preview
         * Download file to bufor
         * */
        public void getPreview(PortableDeviceFile item, string deviceName) 
        {
            connectToDevice(deviceName);
            try{ device.DownloadFile(item, "data/bufor"); }
            catch (System.IO.IOException ex) { MessageBox.Show(ex.Message); }
            disconnectDevice();
        }

    }
}
