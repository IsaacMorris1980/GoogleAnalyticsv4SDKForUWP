using GoogleAnalyticsv4SDK.Events.Games.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Join_Group : IEvent
    {
        private string name = "join_group";
        private Group_Parameters _parameters;
        public Join_Group(string group_id = default)
        {
            this.parameters = new Group_Parameters(group_id);
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
