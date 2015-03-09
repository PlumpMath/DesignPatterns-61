using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Purchase
    {
        public int Number { get; private set; }

        public int Amount { get; private set; }

        public Purchase(int number, int amount)
        {
            this.Number = number;
            this.Amount = amount;
        }
    }
}
