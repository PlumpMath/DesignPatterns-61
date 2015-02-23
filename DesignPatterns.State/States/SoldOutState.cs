using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    public class SoldOutState : State
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine) { }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public override bool TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
            return false;
        }
    }
}
