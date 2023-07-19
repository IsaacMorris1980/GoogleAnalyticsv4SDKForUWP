using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce

{

    public class Add_Payment_Info : IEvent
    {
        private string _name = "add_payment_info";
        private Ecommerce_Parameters _parameters;//required for calls

        private Add_Payment_Info(string currency, decimal value, List<Item> items, string coupon = default, string shipping_tier = default, string payment_type = default)
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
