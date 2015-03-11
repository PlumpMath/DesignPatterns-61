using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Chatroom : IChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (participants.ContainsKey(participant.Name))
            {
                Console.WriteLine("The user with the same name already exists");
                return;
            }

            participants.Add(participant.Name, participant);
            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            var receiver = participants[to];
            if (receiver != null)
            {
                receiver.Receive(from, message);
            }
        }
    }
}
