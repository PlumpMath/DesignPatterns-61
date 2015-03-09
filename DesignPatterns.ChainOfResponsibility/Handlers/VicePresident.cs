using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, purchase.Number);
            }
            else
            {
                if (Successor != null)
                {
                    Successor.ProcessRequest(purchase);
                }
            }
        }
    }
}
