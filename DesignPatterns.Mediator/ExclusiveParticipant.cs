using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ExclusiveParticipant : Participant
    {
        public ExclusiveParticipant(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("***");
            base.Receive(from, message);
        }
    }
}
