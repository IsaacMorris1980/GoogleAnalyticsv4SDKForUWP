using GoogleAnalyticsv4SDK.Events.Games.Parameters;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Earn_Virtual_Currency
    {
        private string name = "earn_virtual_currency";
        private Virtual_Currency_Parameters _parameters;

        public Earn_Virtual_Currency(Virtual_Currency_Parameters parameters)
        {
            this.parameters = parameters;
        }
        public Virtual_Currency_Parameters parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
}
