using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Devices
{
    public class DvdDrive : IUsbDevice
    {
        public IDvdDisk Disk { get; set; }

        public string ReadFromUsb()
        {
            return Disk == null ? string.Empty : Disk.ReadFromDvd();
        }

        public void WriteToUsb(string info)
        {
            if (Disk == null)
            {
                return;
            }

            Disk.WriteToDvd(info);
        }
    }
}
