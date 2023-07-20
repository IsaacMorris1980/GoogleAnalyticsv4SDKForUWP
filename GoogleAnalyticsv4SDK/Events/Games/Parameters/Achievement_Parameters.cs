using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games.Parameters
{
    public class Achievement_Parameters
    {
        private string _achievement_id;

        public Achievement_Parameters(string achievement_id)
        {
            this.achivement_id = achievement_id;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string achivement_id
        {
            get
            {
                return _achievement_id;
            }
            set
            {
                _achievement_id = value;
            }
        }
    }
}
