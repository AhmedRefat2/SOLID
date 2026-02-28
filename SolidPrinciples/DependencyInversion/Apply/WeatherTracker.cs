using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion.Apply
{
    internal class WeatherTracker
    {
        // This Class Get The Wethear Forcast and Notify All Users With The Wethear Forcast By Email or Any Notification method later

        private readonly INotifier _notifier;
        
        public WeatherTracker(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void GetWeahtherForecastAndSendEmailOrSMS(string wethearForecast)
        {
            if (_notifier is not null)
            {
                if (wethearForecast == "Hot")
                    _notifier.Send(wethearForecast);
            }
        }
    }
}
