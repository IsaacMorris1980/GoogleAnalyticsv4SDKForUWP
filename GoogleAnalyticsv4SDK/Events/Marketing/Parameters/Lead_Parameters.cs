using Newtonsoft.Json;

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
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
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
