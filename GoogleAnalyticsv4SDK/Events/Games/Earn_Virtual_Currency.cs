using GoogleAnalyticsv4SDK.Events.Games.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Earn_Virtual_Currency : IEvent
    {
        private string name = "earn_virtual_currency";
        private Virtual_Currency_Parameters _parameters;

        public Earn_Virtual_Currency(string virtual_currency_name = default, decimal value = default)
        {
            _parameters = new Virtual_Currency_Parameters(virtual_currency_name, value, default);
        }
        public Earn_Virtual_Currency(Virtual_Currency_Parameters parameters)
        {
            this.parameters = parameters;
        }
        [JsonProperty("params")]
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
