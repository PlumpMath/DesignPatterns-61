using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtectionProxy
{
    class JournalData : IJournalData
    {
        private StringBuilder journalData = new StringBuilder();

        public void InsertNewRow(string row)
        {
            journalData.AppendLine(row);
        }

        public string GetAllRows()
        {
            return journalData.ToString();
        }
    }
}
