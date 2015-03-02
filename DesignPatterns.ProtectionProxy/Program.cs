using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtectionProxy
{
    /// <summary>
    /// The proxy pattern provides a surrogate for another object to control access to it.
    /// A protection proxy controls access to a resource based on access rights.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var journalData = new JournalProxy();
            var row1 = "Some text";
            var row2 = "Some other text";
            Console.WriteLine("Using wrong password");
            journalData.Authenticate("wrong password");
            Console.WriteLine("Inserting {0}", row1);
            journalData.InsertNewRow(row1);
            Console.WriteLine("Inserting {0}", row2);
            journalData.InsertNewRow(row2);
            Console.WriteLine("Retrieving the journal data content");
            Console.WriteLine("Result:\n{0}", journalData.GetAllRows());
            Console.WriteLine();

            Console.WriteLine("Using correct password");
            journalData.Authenticate("password");
            Console.WriteLine("Inserting {0}", row1);
            journalData.InsertNewRow(row1);
            Console.WriteLine("Inserting {0}", row2);
            journalData.InsertNewRow(row2);
            Console.WriteLine("Retrieving the journal data content");
            Console.WriteLine("Result:\n{0}", journalData.GetAllRows());
            Console.ReadLine();
        }
    }
}
