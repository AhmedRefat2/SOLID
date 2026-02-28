using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Violate
{
    internal class AirPlane : IVechile
    {
        public void Drive()
        {
            Console.WriteLine("Air Plane Can: Drive");
        }

        public void Fly()
        {
            Console.WriteLine("Air Plane Can: Fly");
        }

        public void StartEngine()
        {
            Console.WriteLine("Air Plane Can: StartEngine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Air Plane Can: StopEngine");
        }

        /// This class has no problem with Interface Segregation Principle because it is able to implement all the methods defined in the IVechile interface, 
        /// as they are relevant to its functionality as an airplane.
    }
}
