using GoogleAnalyticsv4SDK.Events.Games.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Join_Group
    {
        private string name = "join_group";
        private Group_Parameters _parameters;
        public Join_Group(Group_Parameters parameters)
        {
            this.parameters = parameters;
        }
        [JsonProperty("params")]
        public Group_Parameters parameters
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
