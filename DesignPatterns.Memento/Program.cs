using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    /// <summary>
    /// Without violating encapsulation, capture and externalize an objects internal state
    /// so that the object can be restored to this state later.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var salesProspect = new SalesProspect();
            salesProspect.Name = "Leo van Halen";
            salesProspect.Phone = "(050) 000-0000";
            salesProspect.Budget = 20000.0;

            var prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveMemento();

            salesProspect.Name = "Fred Welch";
            salesProspect.Phone = "(099) 000-0000";
            salesProspect.Budget = 40000.0;

            salesProspect.RestoreMemento(prospectMemory.Memento);

            Console.ReadLine();
        }
    }
}
