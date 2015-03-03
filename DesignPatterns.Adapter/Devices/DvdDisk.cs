using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Devices
{
    public class DvdDisk : IDvdDisk
    {
        string info = string.Empty;

        public string ReadFromDvd()
        {
            return info;
        }

        public void WriteToDvd(string info)
        {
            this.info = info;
        }
    }
}
