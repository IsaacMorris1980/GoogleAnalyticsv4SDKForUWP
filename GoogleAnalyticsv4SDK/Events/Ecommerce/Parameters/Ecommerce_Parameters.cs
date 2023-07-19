using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters
{

    public class Ecommerce_Parameters
    {
        private string _currency; //required
        private decimal _value; //required
        private string _coupon;
        private string _shipping_tier;
        private string _payment_type;
        private List<Item> _items; //required

        public Ecommerce_Parameters(string currency, decimal value, List<Item> items, string coupon = "", string shipping_tier = "", string payment_type = "")
        {
            this.currency = currency;
            this.value = value;
            this.coupon = coupon;
            this.shipping_tier = shipping_tier;
            this.payment_type = payment_type;
            this.items = items;
        }
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
        public string shipping_tier
        {
            get
            {
                return _shipping_tier;
            }
            set
            {
                _shipping_tier = value;
            }
        }
        public string payment_type
        {
            get
            {
                return _payment_type;
            }
            set
            {
                _payment_type = value;
            }
        }
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
