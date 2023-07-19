using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce.Parameters
{
    public class Cart_Parameters
    {
        private string _currency;
        private decimal _value;
        private List<Item> _items;

        public Cart_Parameters(string currency, decimal value, List<Item> items)
        {
            this.currency = currency;
            this.value = value;
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
