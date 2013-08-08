using System.Collections.Generic;

namespace PictureSyncManager
{
    public class PortableDeviceFolder : PortableDeviceObject
    {
        public PortableDeviceFolder(string id, string name, string date, string size, int sizeB) : base(id, name, date, size, sizeB)
        {
            this.Files = new List<PortableDeviceObject>();
        }

        public IList<PortableDeviceObject> Files { get; set; }
    }
}