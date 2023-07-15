using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Refund
    {
        private string _name = "refund";
        private Purchase_Refund_Parameters _parameters;
        public Refund(Purchase_Refund_Parameters parameters)
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
        public Purchase_Refund_Parameters parameters
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
