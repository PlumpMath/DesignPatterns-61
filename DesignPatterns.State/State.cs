using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public abstract class State
    {
        protected GumballMachine gumballMachine;

        public State(GumballMachine gumballMachine) 
        {
            this.gumballMachine = gumballMachine;
        }

        public abstract void InsertQuarter();

        public virtual void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public abstract bool TurnCrank();

        public virtual void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
