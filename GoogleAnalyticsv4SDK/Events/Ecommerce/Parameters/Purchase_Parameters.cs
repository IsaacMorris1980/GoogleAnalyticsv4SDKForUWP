using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters
{
    public class Purchase_Refund_Parameters
    {
        private string _currency;
        private string _transaction_id;
        private decimal _value;
        private string _coupon;
        private decimal _shipping;
        private decimal _tax;
        List<Item> _items;
        public Purchase_Refund_Parameters(string _currency, string _transaction_id, decimal _value, List<Item> _items, string _coupon = default, decimal _shipping = default, decimal _tax = default)
        {
            this.currency = _currency;
            this.transaction_id = transaction_id;
            this.value = value;
            this.coupon = coupon;
            this.shipping = shipping;
            this.tax = tax;
            this.items = items;
            this.currency = currency;
            this.transaction_id = transaction_id;
            this.value = value;
            this.coupon = coupon;
            this.shipping = shipping;
            this.tax = tax;
            this.items = items;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string currency
        {
            get
            {
                return _currency;
            }
            set
            {
                _currency = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string transaction_id
        {
            get
            {
                return _transaction_id;
            }
            set
            {
                _transaction_id = value;
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
        public string coupon
        {
            get
            {
                return _coupon;
            }
            set
            {
                _coupon = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal shipping
        {
            get
            {
                return _shipping;
            }
            set
            {
                _shipping = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal tax
        {
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Item> items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }
}
