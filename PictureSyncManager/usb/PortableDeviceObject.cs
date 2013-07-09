namespace PictureSyncManager
{
    public abstract class PortableDeviceObject
    {
        protected PortableDeviceObject(string id, string name, string date)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Date { get; set; }
    }
}