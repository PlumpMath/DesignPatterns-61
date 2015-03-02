using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtectionProxy
{
    public interface IJournalData
    {
        void InsertNewRow(string row);

        string GetAllRows();
    }
}
