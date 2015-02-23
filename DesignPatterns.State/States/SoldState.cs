using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    public class SoldState : State
    {
        public SoldState(GumballMachine gumballMachine) : base(gumballMachine) { }

        public override void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Sorry, you've already turned the crank");
        }

        public override bool TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball");
            return false;
        }

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GumballsCount > 0)
            {
                gumballMachine.CurrentState = gumballMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Out of gumballs");
                gumballMachine.CurrentState = gumballMachine.SoldOutState;
            }
        }
    }
}
