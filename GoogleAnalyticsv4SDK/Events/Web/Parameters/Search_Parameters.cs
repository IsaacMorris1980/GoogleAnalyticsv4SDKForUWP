namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Search_Parameters
    {
        private string _search_term;

        public Search_Parameters(string search_term)
        {
            this.search_term = search_term;
        }
        public string search_term
        {
            get
            {
                return _search_term;
            }
            set
            {
                _search_term = value;
            }
        }
    }
}
