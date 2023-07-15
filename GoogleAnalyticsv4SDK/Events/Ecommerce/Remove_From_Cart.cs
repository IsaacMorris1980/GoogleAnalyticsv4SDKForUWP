using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Remove_From_Cart
    {
        private string _name = "remove_from_cart";
        private Ecommerce_Parameters _parameters;

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
