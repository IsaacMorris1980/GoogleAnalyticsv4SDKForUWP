using GoogleAnalyticsv4SDK.Events.Games.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Spend_Virtual_Currency
    {
        private string _name = "spend_virtual_currency";
        private Virtual_Currency_Parameters _parameters;

        public Spend_Virtual_Currency(string virtual_currency_name, decimal value, string item_name = default)
        {
            this.parameters = new Virtual_Currency_Parameters(virtual_currency_name, value, item_name);
        }

        public string name
        {
            get
            {
                return _name;
            }
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
