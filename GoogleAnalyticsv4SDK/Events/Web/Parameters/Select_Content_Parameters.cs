using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Select_Content_Parameters
    {
        private string _content_type;
        private string _content_id;

        public Select_Content_Parameters(string content_type = default, string content_id = default)
        {
            this.content_type = content_type;
            this.content_id = content_id;
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
        public string content_id
        {
            get
            {
                return _content_id;
            }
            set
            {
                _content_id = value;
            }
        }
    }
}
