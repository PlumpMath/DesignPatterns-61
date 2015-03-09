using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public abstract class Approver
    {
        public Approver Successor { get; set; }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
