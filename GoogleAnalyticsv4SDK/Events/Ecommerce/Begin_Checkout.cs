using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Begin_Checkout : IEvent
    {
        private string _name = "begin_checkout";
        private Ecommerce_Parameters _parameters;//required for calls

        private Begin_Checkout(string currency, decimal value, List<Item> items, string coupon = default)
        {
            this.parameters = new Ecommerce_Parameters(currency, value, items, coupon);
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
