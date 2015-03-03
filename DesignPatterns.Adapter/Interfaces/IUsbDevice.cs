
namespace DesignPatterns.Adapter.Interfaces
{
    public interface IUsbDevice
    {
        string ReadFromUsb();

        void WriteToUsb(string info);
    }
}
