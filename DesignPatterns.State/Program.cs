using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    /// <summary>
    /// The state pattern allows an object to alter its beravior when its internal state changes.
    /// The object will appear to change its class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(2);
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Refill(3);
            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.TurnCrank();
            Console.ReadLine();
        }
    }
}
