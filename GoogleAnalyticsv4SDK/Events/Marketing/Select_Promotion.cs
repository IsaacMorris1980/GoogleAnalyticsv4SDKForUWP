using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class Select_Promotion : IEvent
    {
        private string _name = "select_promotion";
        private Promotion_Parameters _parameters;

        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Promotion_Parameters parameters
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
