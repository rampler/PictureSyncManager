namespace PictureSyncManager
{
    public abstract class PortableDeviceObject
    {
        protected PortableDeviceObject(string id, string name, string date, string size)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
            this.Size = size;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Size { get; private set; }
    }
}