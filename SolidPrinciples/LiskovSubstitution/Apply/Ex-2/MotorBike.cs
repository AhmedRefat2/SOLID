using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Apply.Ex_2
{
    internal class MotorBike : IBike
    {

        int speed = 0;
        bool isEngineOn = false;

        public void Speed()
        {
            speed = 100;
        }

        public void TurnOnEngine()
        {
            isEngineOn = true;
        }

        /// This class adheres to the Liskov Substitution Principle because it can be substituted for the base class (IBike) without breaking the functionality of the code. The MotorBike class has an implementation for both the Speed and TurnOnEngine methods, 
        /// which means that it can be used in place of an IBike without any issues.

    }
}
