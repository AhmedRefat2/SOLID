using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Apply
{
    internal interface INotifier
    {
        void Send(string email);
    }
}
