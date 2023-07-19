using GoogleAnalyticsv4SDK.Events.Games.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Post_Score : IEvent
    {
        private string _name = "post_score";
        private Post_Parameters _parameters;

        public Post_Score(int score, int level = default, string character = default)
        {
            _parameters = new Post_Parameters(score, level, character);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Post_Parameters parameters
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
