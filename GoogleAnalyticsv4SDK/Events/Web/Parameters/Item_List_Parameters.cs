using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Web.Parameters
{
    public class Item_List_Parameters
    {
        private string _item_list_id;
        private string _item_list_name;
        private List<Item> _items;

        public Item_List_Parameters(List<Item> items, string item_list_id = default, string item_list_name = default)
        {
            this.item_list_id = item_list_id;
            this.item_list_name = item_list_name;
            this.items = items;
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
