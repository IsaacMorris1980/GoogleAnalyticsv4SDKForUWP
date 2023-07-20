using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Share : IEvent
    {
        private string _name;
        private Share_Parameters _parameters;
        public Share(string method = default, string content_type = default, string item_id = default)
        {
            this.parameters = new Share_Parameters(method, content_type, item_id);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Share_Parameters parameters
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
