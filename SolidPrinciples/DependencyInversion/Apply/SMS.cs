using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Apply
{
    internal class SMS : INotifier
    {
        public void Send(string email)
        {
            Console.WriteLine($"Sending SMS Message: {email} to Users ");
        }
    }
}
