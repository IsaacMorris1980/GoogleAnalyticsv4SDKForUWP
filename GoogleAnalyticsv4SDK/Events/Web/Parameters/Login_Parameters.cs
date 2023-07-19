namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Login_SignUp_Parameters
    {
        private string _method;
        public Login_SignUp_Parameters(string method = default)
        {
            this.method = method;
        }
        public string method
        {
            get
            {
                return _method;
            }
            set
            {
                _method = value;
            }
        }
    }
}
