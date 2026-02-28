using SolidPrinciples.DependencyInversion.Apply;
using SolidPrinciples.LiskovSubstitution;
using SolidPrinciples.LiskovSubstitution.Apply.Ex_1;
using SolidPrinciples.LiskovSubstitution.Apply.Ex_2;
using SolidPrinciples.LiskovSubstitution.Violate.Ex_1;
using SolidPrinciples.LiskovSubstitution.Violate.Ex_2;

namespace SolidPrinciples
{
    internal class Program
    {

        // Releated to Liskov Substitution Principle Interface Example
        static void StartBike(IBike bike)
        {
            bike.Speed();
            bike.TurnOnEngine();
        }

        static void Main(string[] args)
        {

            ////////////////////////// SOLID Principles //////////////////////////


            /// SOLID is an acronym for five design principles that help developers create maintainable and scalable software.
            /// The SOLID principles are:
            /// 1. Single Responsibility Principle (SRP): A class should have only one reason to change,
            /// meaning it should have only one responsibility.
            /// 2. Open/Closed Principle (OCP): Software entities (classes, modules, functions, etc.) 
            /// should be open for extension but closed for modification.
            /// 3. Liskov Substitution Principle (LSP): Objects of a superclass should be replaceable with objects of a subclass 
            /// without affecting the correctness of the program.
            /// 4. Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they do not use. [Devide Interfaces Into Many Smaller Reusable Specific Interfaces]
            /// 5. Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules.


            // 1. Single Responsibility Principle => Show in SingleResponsibility folder
            // 2. Open/Closed Principle => Show in OpenClosed folder


            // 3. Liskov Substitution Principle => Show in LiskovSubstitution folder and these regions for testing the examples

            #region SOLID - Liskov Substitution Principle Violation Example

            //RectangleViolate squareViolate = new SquareViolate(); // ref from parent refere to child object 
            //squareViolate.Width = 5;
            //squareViolate.Height = 10;

            //Console.WriteLine(squareViolate.Area()); // 100  

            /// it will not work as expected because square will set both width and height to 10, so area will be 100 instead of 50
            /// this is a violation of Liskov Substitution Principle
            /// because we are substituting a parent class (Rectangle) with a child class (Square) and it is not working as expected.

            /// to fix this violation we can either remove the inheritance 
            /// or we can make the Square class to be a separate class and not inherit from Rectangle class.
            /// simply we can create a new abstract class Shape and make both Rectangle and Square inherit from it, 
            /// and implement the Area method in both classes.


            #endregion

            #region SOLID - Liskov Substitution Principle Apply Example

            //ShapeApply rectangleApply = new RectangleApply() { Width = 5, Height = 10 };
            //Console.WriteLine(rectangleApply.GetArea()); // 50

            //ShapeApply squareApply = new SquareApply() { Side = 5 };
            //Console.WriteLine(squareApply.GetArea()); // 25

            /// here we are substituting a parent class (Shape) with a child class (Rectangle and Square) 
            /// and it is working as expected. 
            /// This apply the Liskov Substitution Principle

            #endregion

            #region SOLID - Liskov Substitution Principle Interface Example


            //try
            //{
            //    IBike motorBike = new MotorBike();
            //    StartBike(motorBike);
            //    Console.WriteLine("Liskov Substitution working well");
            //}
            //catch (Exception )
            //{
            //    Console.WriteLine("Vioation of Liskov Substitution");
            //}


            //try
            //{
            //    IBike bicycle = new Bicycle();
            //    StartBike(bicycle);
            //    Console.WriteLine("Liskov Substitution working well");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Vioation of Liskov Substitution");
            //}



            #endregion


            // 4. Interface Segregeation Principle => Show in InterfaceSegregation Folder 

            // 5. Dependency Inversion principle => Show in DepencdencyInversion Folder and This Region For Testing 

            #region SOLID - Dependency Inversion Principle Apply 

            //List<string> listeners = new() { "ahmed@gmail.com", "mohamed@gmail.com" };

            //INotifier emailer = new Emailer(listeners);

            //WeatherTracker weatherTrackerEmail = new WeatherTracker(emailer);

            //weatherTrackerEmail.GetWeahtherForecastAndSendEmailOrSMS("Hot");

            //INotifier sms = new SMS();

            //WeatherTracker weatherTrackerSMS = new WeatherTracker(sms);

            //weatherTrackerSMS.GetWeahtherForecastAndSendEmailOrSMS("Hot");

            #endregion

            //////////////////////////////////// بالتوفيق ///////////////////////////////////////

            // Ahmed Refat 
            // Software Engineer - Backend.Net Developer 

        }
    }
}
