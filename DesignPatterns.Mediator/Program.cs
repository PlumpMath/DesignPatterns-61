using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// The mediator pattern encapsulates interaction between a set of objects.
    /// Mediator promotes loose coupling by keeping objects from referring to each other explicitly.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new Chatroom();

            var john = new Participant("John");
            var james = new Participant("James");
            var george = new Participant("George");
            var tom = new ExclusiveParticipant("Tom");

            chatroom.Register(john);
            chatroom.Register(james);
            chatroom.Register(george);
            chatroom.Register(tom);

            john.Send("James", "Hi, James!");
            james.Send("John", "Hi, John!");
            james.Send("Tom", "Hi, Tom!");
            george.Send("Tom", "Hi, Tom!");

            Console.ReadLine();
        }
    }
}
