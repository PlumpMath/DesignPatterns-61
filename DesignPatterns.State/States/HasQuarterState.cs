using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.States
{
    public class HasQuarterState : State
    {
        private Random randomWinner = new Random();

        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine) { }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.CurrentState = gumballMachine.NoQuarterState;
        }

        public override bool TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = randomWinner.Next(0, 9);
            if (winner == 0 && gumballMachine.GumballsCount > 1)
            {
                gumballMachine.CurrentState = gumballMachine.WinnerState;
            }
            else
            {
                gumballMachine.CurrentState = gumballMachine.SoldState;
            }

            return true;
        }
    }
}
