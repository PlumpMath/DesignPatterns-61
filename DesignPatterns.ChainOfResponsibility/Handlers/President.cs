using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, purchase.Number);
            }
            else
            {
                Console.WriteLine("Request #{0} requires an executive meeting", purchase.Number);
            }
        }
    }
}
