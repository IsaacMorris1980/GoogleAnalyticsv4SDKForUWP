namespace GoogleAnalyticsv4SDK.Events.Marketing.Parameters
{
    public class Lead_Parameters
    {
        private string _currency;
        private decimal _value;
        public Lead_Parameters(string currency, decimal value)
        {
            this.currency = currency;
            this.value = value;
        }
        public string currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }
        public decimal value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
