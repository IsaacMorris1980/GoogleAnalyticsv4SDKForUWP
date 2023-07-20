using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Games.Parameters
{
    public class Virtual_Currency_Parameters
    {
        private string _virtual_currency_name;
        private decimal _value;
        private string _item_name;
        public Virtual_Currency_Parameters(string virtual_currency_name = default, decimal value = default, string item_name = default)
        {
            this.virtual_currency_name = virtual_currency_name;
            this.value = value;
            this.item_name = item_name;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string virtual_currency_name
        {
            get
            {
                return _virtual_currency_name;
            }
            set
            {
                _virtual_currency_name = value;
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
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string item_name
        {
            get
            {
                return _item_name;
            }
            set
            {
                _item_name = value;
            }
        }
    }
}
