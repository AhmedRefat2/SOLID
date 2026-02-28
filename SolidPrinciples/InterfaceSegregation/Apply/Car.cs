using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Apply
{
    internal class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Car Can: Drive");
        }
        public void StartEngine()
        {
            Console.WriteLine("Car Can: StartEngine");
        }
        public void StopEngine()
        {
            Console.WriteLine("Car Can: StopEngine");
        }

        /// This class is following the Interface Segregation Principle because it only implements the methods that are relevant to its functionality as a car, 
        /// and it is not forced to implement any methods that are not relevant to its functionality.
    }
}
