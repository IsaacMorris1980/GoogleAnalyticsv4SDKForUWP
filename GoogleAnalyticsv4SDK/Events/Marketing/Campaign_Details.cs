using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class Campaign_Details : IEvent
    {
        private string name = "campaign_details";
        private Campaign_Parameters _parameters;

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
