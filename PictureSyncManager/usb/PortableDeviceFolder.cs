using System.Collections.Generic;

namespace PictureSyncManager
{
    public class PortableDeviceFolder : PortableDeviceObject
    {
        public PortableDeviceFolder(string id, string name, string date, string size) : base(id, name, date, size)
        {
            this.Files = new List<PortableDeviceObject>();
        }

        public IList<PortableDeviceObject> Files { get; set; }
    }
}