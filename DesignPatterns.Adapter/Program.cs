using DesignPatterns.Adapter.Devices;
using System;

namespace DesignPatterns.Adapter
{
    /// <summary>
    /// The adapter pattern converts the interface of a class into another interface that client expects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Laptop();
            var dvdDrive = new DvdDrive();
            dvdDrive.Disk = new DvdDisk();
            laptop.UsbDevice = dvdDrive;

            Console.WriteLine("Writing and reading using DVD Drive");
            laptop.WriteToExternalDevice("Some information");
            Console.WriteLine("Returned data: {0}", laptop.ReadFromExternalDevice());
            Console.ReadLine();
        }
    }
}
