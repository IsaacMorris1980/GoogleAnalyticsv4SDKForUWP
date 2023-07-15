namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Login_Parameters
    {
        private string _method;
        public Login_Parameters(string method = default)
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
