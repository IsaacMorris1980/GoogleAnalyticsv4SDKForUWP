using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Share_Parameters
    {
        private string _method;
        private string _content_type;
        private string _item_id;

        public Share_Parameters(string method = default, string content_type = default, string item_id = default)
        {
            this.method = method;
            this.content_type = content_type;
            this.item_id = item_id;

        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string method
        {
            get
            {
                return _method;
            }
            set
            {
                _method = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string content_type
        {
            get
            {
                return _content_type;
            }
            set
            {
                _content_type = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string item_id
        {
            get
            {
                return _item_id;
            }
            set
            {
                _item_id = value;
            }
        }
    }
}
