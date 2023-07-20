using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class Generate_Lead : IEvent
    {
        private string _name = "generate_lead";
        private Lead_Parameters _parameters;

        public Generate_Lead(string currency, decimal value)
        {
            this.parameters = new Lead_Parameters(currency, value);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Lead_Parameters parameters
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
