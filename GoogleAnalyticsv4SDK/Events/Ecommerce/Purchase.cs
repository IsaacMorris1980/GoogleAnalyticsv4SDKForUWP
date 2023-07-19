using GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Purchase : IEvent
    {
        private string _name = "purchase";
        private Purchase_Refund_Parameters _parameters;
        public Purchase(string _currency, string _transaction_id, decimal _value, List<Item> _items, string _coupon = default, decimal _shipping = default, decimal _tax = default)
        {
            this.parameters = new Purchase_Refund_Parameters(_currency, _transaction_id, _value, _items, _coupon, _shipping, _tax);
        }
        [JsonProperty("params")]
        public Purchase_Refund_Parameters parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
    }

}
