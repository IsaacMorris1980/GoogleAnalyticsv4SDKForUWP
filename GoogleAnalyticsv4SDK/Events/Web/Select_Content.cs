using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Select_Content : IEvent
    {
        private string _name = "select_content";
        private Select_Content_Parameters _parameters;

        public string name
        {
            get
            {
                return _name;
            }
        }

        public Select_Content(string content_type = default, string content_id = default)
        {
            this.parameters = new Select_Content_Parameters(content_type, content_id);
        }
        [JsonProperty("params")]
        public Select_Content_Parameters parameters
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
