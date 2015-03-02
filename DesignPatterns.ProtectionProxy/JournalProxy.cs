using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtectionProxy
{
    public class JournalProxy : IJournalData
    {
        private IJournalData journalData;

        private string password = "password";

        public bool Authenticate(string suppliedPassword)
        {
            if (suppliedPassword != password)
            {
                return false;
            }

            journalData = new JournalData();
            return true;
        }

        public void InsertNewRow(string row)
        {
            if (journalData == null)
            {
                Console.WriteLine("Only authenticated users allowed to insert new rows");
                return;
            }

            journalData.InsertNewRow(row);
        }

        public string GetAllRows()
        {
            if (journalData == null)
            {
                Console.WriteLine("Only authenticated users allowed to retrieve journal data content");
                return string.Empty;
            }

            return journalData.GetAllRows();
        }
    }
}
