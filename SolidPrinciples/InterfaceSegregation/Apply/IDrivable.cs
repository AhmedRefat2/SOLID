using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Apply
{
    internal interface IDrivable
    {
        void Drive();
        void StartEngine();
        void StopEngine();
    }
}
