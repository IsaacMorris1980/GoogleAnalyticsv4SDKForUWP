using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Purchase
    {
        private string _name = "purchase";
        private Purchase_Refund_Parameters _parameters;
        public Purchase(Purchase_Refund_Parameters parameter)
        {
            this.parameters = parameter;
        }
        [JsonProperty("params")]
        public Purchase_Refund_Parameters parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }

}
