using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Apply
{
    internal class AirPlane : IDrivable, IFlyable
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
        /// This class is following the Interface Segregation Principle because it only implements the methods that are relevant to its functionality as an airplane, 
        /// and it is not forced to implement any methods that are not relevant to its functionality.
    }
}
