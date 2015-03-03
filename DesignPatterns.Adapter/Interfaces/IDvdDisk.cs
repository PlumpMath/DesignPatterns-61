
namespace DesignPatterns.Adapter.Interfaces
{
    public interface IDvdDisk
    {
        string ReadFromDvd();

        void WriteToDvd(string info);
    }
}
