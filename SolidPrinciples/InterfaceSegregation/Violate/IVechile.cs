using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Violate
{
    internal interface IVechile
    {
        void Drive();
        void Fly();
        void StartEngine();
        void StopEngine();

    }
}
