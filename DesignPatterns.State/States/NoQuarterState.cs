using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    public class NoQuarterState : State
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine) { }

        public override void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.CurrentState = gumballMachine.HasQuarterState;
        }

        public override bool TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
            return false;
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
