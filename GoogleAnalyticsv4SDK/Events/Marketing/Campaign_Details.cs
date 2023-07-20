using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class Campaign_Details : IEvent
    {
        private string name = "campaign_details";
        private Campaign_Parameters _parameters;

        public Campaign_Details(string campaign_id = default, string campaign = default, string source = default, string medium = default, string term = default, string content = default)
        {
            this.parameters = new Campaign_Parameters(campaign_id, campaign, source, medium, term, content);
        }
        [JsonProperty("params")]
        public Campaign_Parameters parameters
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
