using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Select_Item : IEvent
    {
        private string _name = "select_item";
        private Select_Item_Parameters _parameters;

        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Select_Item_Parameters parameters
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
