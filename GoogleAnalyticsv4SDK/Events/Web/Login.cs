using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Login : IEvent
    {
        private string _name = "login";
        private Login_SignUp_Parameters _parameters;
        public Login(string method = default)
        {
            this.parameters = new Login_SignUp_Parameters(method);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Login_SignUp_Parameters parameters
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
