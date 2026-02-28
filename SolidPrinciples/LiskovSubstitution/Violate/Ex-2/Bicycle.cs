using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Violate.Ex_2
{
    internal class Bicycle : IBike
    {

        int speed;

        public void Speed()
        {
            speed = 50;
        }

        public void TurnOnEngine()
        {
            throw new Exception("No Engine Found");
        }

        /// This class violates Liskov Substitution Principle because it is not substitutable for the base class (IBike) due to the fact that it does not have an engine and cannot turn on an engine. This means that if we were to replace an instance of IBike with an instance of Bicycle, 
        /// it would break the functionality of the code that relies on the TurnOnEngine method.
    }
}
