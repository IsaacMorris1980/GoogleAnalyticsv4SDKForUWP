using GoogleAnalyticsv4SDK.Events.Games.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Unlock_Achievement
    {
        private string _name;
        private Achievement_Parameters _parametrers;

        public Unlock_Achievement(string achievement_id)
        {
            parameters = new Achievement_Parameters(achievement_id);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Achievement_Parameters parameters
        {
            get
            {
                return _parametrers;
            }
            set
            {
                _parametrers = value;
            }
        }
    }
}
