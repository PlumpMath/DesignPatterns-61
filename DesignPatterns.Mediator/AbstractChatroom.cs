using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public interface IChatroom
    {
        void Register(Participant participant);

        void Send(string from, string to, string message);
    }
}
