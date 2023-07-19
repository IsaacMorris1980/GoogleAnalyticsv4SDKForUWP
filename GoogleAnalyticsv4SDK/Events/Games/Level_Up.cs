using GoogleAnalyticsv4SDK.Events.Games.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Level_Up : IEvent
    {
        private string _name = "level_up";
        private Level_Parameters _parameters;
        public Level_Up(int level = default, string character = default)
        {
            this.parameters = new Level_Parameters(level, character);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Level_Parameters parameters
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
