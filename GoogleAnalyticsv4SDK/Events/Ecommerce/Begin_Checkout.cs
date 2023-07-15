using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;

using Newtonsoft.Json;
namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Begin_Checkout
    {
        private string _name = "begin_checkout";
        private Ecommerce_Parameters _parameters;//required for calls

        private Begin_Checkout(Ecommerce_Parameters parameters)
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
