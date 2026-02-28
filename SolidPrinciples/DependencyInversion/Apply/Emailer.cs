using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Apply
{
    internal class Emailer : INotifier
    {
        private readonly ICollection<string> _listenersEmails;
        public Emailer(List<string> listenersEmails)
        {
            _listenersEmails = listenersEmails;
        }

        public void Send(string emailMessage)
        {
            foreach (var listener in _listenersEmails)
                Console.WriteLine($"Sending Email messsage [{emailMessage}] to : {listener}");
        }
    }
}
