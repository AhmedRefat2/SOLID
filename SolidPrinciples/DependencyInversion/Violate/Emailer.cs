using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Violate
{
    internal class Emailer
    {
        public void SendEmail(string emailMessage)
            => Console.WriteLine($"Sending Email With Body: {emailMessage}");
    }
}
