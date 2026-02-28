using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Violate
{
    internal class Car : IVechile
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
        public void Fly()
        {
            throw new NotImplementedException("Car Can't Fly");
        }

        /// This class is violating the Interface Segregation Principle because it is forced to implement the Fly method,
        /// which is not relevant to its functionality as a car. This can lead to confusion and maintenance issues in the future.
    }
}
