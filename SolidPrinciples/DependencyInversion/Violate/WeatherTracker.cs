using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Violate
{

    /// These 2 classes depend on Emailer class and this is Series Problem 
    /// Try to Make Change on the Emailer Class 
    /// You Need To Refactor All Classes (That Depend on This Class) to work with new chnages 
    /// This Violate Dependancy Inversion Principle (DIP)
    
    internal class WeatherTracker
    {
        Emailer emailer;
        string currentWeather = string.Empty;
        public WeatherTracker()
        {
            emailer = new Emailer();
        }


        // Take Weather Condition And Send Email To All Users With This Condtion 
        public void SetCurrentCondtion(string weatherDescription)
        {
            currentWeather = weatherDescription;

            if (currentWeather.ToLower().Contains("hot"))  
                    emailer.SendEmail(currentWeather);
        }
    }
    internal class WeatherDegree
    {
        Emailer mailer;

        public WeatherDegree()
        {
            mailer = new Emailer();
        }

        public void SendEmailWithDegree(int minDegree, int maxDegree)
        { 
            mailer.SendEmail($"Min Degree Is: {minDegree} :: Max Degree Is: {maxDegree}");
        }
    }

}
