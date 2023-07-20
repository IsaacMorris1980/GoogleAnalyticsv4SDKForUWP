using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Sign_Up : IEvent
    {
        private string _name = "sign_up";
        private Login_SignUp_Parameters _parameters;

        public Sign_Up(string method = default)
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
