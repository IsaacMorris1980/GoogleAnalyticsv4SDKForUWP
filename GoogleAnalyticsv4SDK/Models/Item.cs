namespace GoogleAnalyticsv4SDK.Models
{
    internal class Item
    {
        private string item_id;  //required
        private string item_name; //required
        private string affiliation;
        private string coupon;
        private string currency;
        private decimal discount;
        private int index;
        private string item_brand;
        private string item_category;
        private string item_category2;
        private string item_category3;
        private string item_category4;
        private string item_category5;
        private string item_list_id;
        private string item_list_name;
        private string item_variant;
        private string location_id;
        private decimal price;
        private int quantity;
        public Item(string item_id, string item_name)
        {
            this.item_id = item_id;
            this.item_name = item_name;
        }
    }
}
