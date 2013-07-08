﻿using System;
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

        public void getPhotosfromDevice()
        {
            var folder = device.GetContents();
            foreach (var item in folder.Files)
            {
                if (item is PortableDeviceFolder)
                {
                    if (item.Name.Equals("DCIM")) CheckFolderContents((PortableDeviceFolder)item);
                    else CheckFolderContentsNDCIM((PortableDeviceFolder)item);
                }
            }
            
        }

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

        public void disconnectDevice() { device.Disconnect();  }

        public LinkedList<string> getPhotosNames() //TODO - erase Date from Name
        {
            LinkedList<string> list = new LinkedList<string>();
            foreach (var photo in photos.OrderBy(j => j.Date)) list.AddFirst(photo.Name + " - " + photo.Date);
            return list;
        }
       
    }
}
