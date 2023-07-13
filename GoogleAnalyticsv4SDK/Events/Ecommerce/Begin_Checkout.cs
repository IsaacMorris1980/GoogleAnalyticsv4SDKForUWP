using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;
namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Begin_Checkout
    {
        private string _name = "begin_checkout";
        private Ecommerce_Parameters _parameters;//required for calls

        private Begin_Checkout(string currency, decimal value, List<Item> items, string coupon = "", string shipping_tier = "", string payment_type = "")
        {
            parameters = new Ecommerce_Parameters(currency, value, items, coupon, shipping_tier, payment_type);
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
