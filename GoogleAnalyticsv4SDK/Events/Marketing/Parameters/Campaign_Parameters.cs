using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Marketing.Parameters
{
    public class Campaign_Parameters
    {
        private string _campaign_id;
        private string _campaign;
        private string _source;
        private string _medium;
        private string _term;
        private string _content;
        public Campaign_Parameters(string campaign_id = default, string campaign = default, string source = default, string medium = default, string term = default, string content = default)
        {
            this.campaign_id = campaign_id;
            this.campaign = campaign;
            this.source = source;
            this.medium = medium;
            this.term = term;
            this.content = content;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string campaign_id
        {
            get
            {
                return _campaign_id;
            }
            set
            {
                _campaign_id = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string campaign
        {
            get
            {
                return _campaign;
            }
            set
            {
                _campaign = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string source
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string medium
        {
            get
            {
                return _medium;
            }
            set
            {
                _medium = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string term
        {
            get
            {
                return _term;
            }
            set
            {
                _term = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }

    }
}
