using DesignPatterns.State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class GumballMachine
    {
        public GumballMachine(int gumballsNumber)
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            WinnerState = new WinnerState(this);
            GumballsCount = gumballsNumber;

            if (gumballsNumber > 0)
            {
                
                CurrentState = NoQuarterState;
            }
            else
            {
                CurrentState = SoldOutState;
            }
        }

        public NoQuarterState NoQuarterState { get; private set; }

        public HasQuarterState HasQuarterState { get; private set; }

        public SoldState SoldState { get; private set; }

        public SoldOutState SoldOutState { get; private set; }

        public WinnerState WinnerState { get; private set; }

        public State CurrentState { get; set; }

        public int GumballsCount { get; private set; }

        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void EjectQuarter() 
        {
            CurrentState.EjectQuarter();
        }

        public void TurnCrank() 
        {
            if (CurrentState.TurnCrank())
            {
                CurrentState.Dispense();
            }
        }

        public void ReleaseBall() 
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            if (GumballsCount > 0)
            {
                GumballsCount--;
            }
        }

        public void Refill(int count)
        {
            GumballsCount += count;
            CurrentState = NoQuarterState;
        }
    }
}
