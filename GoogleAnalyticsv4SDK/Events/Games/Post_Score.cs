using GoogleAnalyticsv4SDK.Events.Games.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Post_Score
    {
        private string _name = "post_score";
        private Post_Parameters _parameters;

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
