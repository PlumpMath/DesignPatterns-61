using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter
{
    public class Laptop
    {
        public IUsbDevice UsbDevice { get; set; }

        public string ReadFromExternalDevice() 
        {
            return UsbDevice == null ? string.Empty : UsbDevice.ReadFromUsb();
        }

        public void WriteToExternalDevice(string info) 
        {
            if (UsbDevice == null)
            {
                return;
            }

            UsbDevice.WriteToUsb(info);
        }
    }
}
