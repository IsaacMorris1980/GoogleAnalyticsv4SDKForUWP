using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Add_Shipping_Info
    {
        private string _name = "add_shipping_info";
        private Ecommerce_Parameters _parameters;//required for calls

        private Add_Shipping_Info(Ecommerce_Parameters parameters)
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
        public Ecommerce_Parameters parameters
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
