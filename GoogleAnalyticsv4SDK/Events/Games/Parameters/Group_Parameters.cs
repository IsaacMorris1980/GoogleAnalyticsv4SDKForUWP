using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games.Parameters
{
    public class Group_Parameters
    {
        public string _group_id;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string group_id
        {
            get
            {
                return _group_id;
            }
            set
            {
                _group_id = value;
            }
        }
        public Group_Parameters(string group_id)
        {
            this.group_id = group_id;
        }

    }
}
