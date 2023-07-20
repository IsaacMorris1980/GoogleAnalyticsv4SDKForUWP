using GoogleAnalyticsv4SDK.Events.Web.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class View_Search_Results
    {
        private string _name;
        private Search_Parameters _parameters;
        public View_Search_Results(string search_term = default)
        {
            this.parameters = new Search_Parameters(search_term);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Search_Parameters parameters
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
