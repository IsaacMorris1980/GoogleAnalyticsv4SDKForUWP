namespace GoogleAnalyticsv4SDK.Models
{
    public class Item
    {
        private string _item_id;  //required
        private string _item_name; //required
        private string _affiliation;
        private string _coupon;
        private string _currency;
        private decimal _discount;
        private int _index;
        private string _item_brand;
        private string _item_category;
        private string _item_category2;
        private string _item_category3;
        private string _item_category4;
        private string _item_category5;
        private string _item_list_id;
        private string _item_list_name;
        private string _item_variant;
        private string _location_id;
        private decimal _price;
        private int _quantity;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item_id"></param>
        /// <param name="item_name"></param>
        public Item(string item_id, string item_name)
        {
            this._item_id = item_id;
            this._item_name = item_name;
        }
        public string item_id
        {
            get
            {
                return _item_id;
            }
            set
            {
                _item_id = value;
            }
        }
        public string item_name
        {
            get
            {
                return _item_name;
            }
            set
            {
                _item_name = value;
            }
        }
        public string affiliation
        {
            get
            {
                return _affiliation;
            }
            set
            {
                _affiliation = value;
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
        public decimal discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        public int index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }
        public string item_brand
        {
            get
            {
                return _item_brand;
            }
            set
            {
                _item_brand = value;
            }
        }
        public string item_category
        {
            get
            {
                return _item_category;
            }
            set
            {
                _item_category = value;
            }
        }
        public string item_category2
        {
            get
            {
                return _item_category2;
            }
            set
            {
                _item_category2 = value;
            }
        }
        public string item_category3
        {
            get
            {
                return _item_category3;
            }
            set
            {
                _item_category3 = value;
            }
        }
        public string item_category4
        {
            get
            {
                return _item_category4;
            }
            set
            {
                _item_category4 = value;
            }
        }
        public string item_category5
        {
            get
            {
                return _item_category5;
            }
            set
            {
                _item_category5 = value;
            }
        }
        public string item_list_id
        {
            get
            {
                return _item_list_id;
            }
            set
            {
                _item_list_id = value;
            }
        }
        public string item_list_name
        {
            get
            {
                return _item_list_name;
            }
            set
            {
                _item_list_name = value;
            }
        }
        public string item_variant
        {
            get
            {
                return _item_variant;
            }
            set
            {
                _item_variant = value;
            }
        }
        public string location_id
        {
            get
            {
                return _location_id;
            }
            set
            {
                _location_id = value;
            }
        }
        public decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

    }
}
