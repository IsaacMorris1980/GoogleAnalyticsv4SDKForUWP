using GoogleAnalyticsv4SDK.Events.Web.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Login
    {
        private string _name = "login";
        private Login_Parameters _parameters;
        public Login(Login_Parameters parameters)
        {
            this.parameters = parameters;
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Login_Parameters parameters
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
