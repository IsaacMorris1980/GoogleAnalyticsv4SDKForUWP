using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class View_Item_List
    {
        private string _name;
        private Item_List_Parameters _parameters;
        public View_Item_List(List<Item> items, string item_list_id = default, string item_list_name = default)
        {
            this.parameters = new Item_List_Parameters(items, item_list_id, item_list_name);
        }

        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Item_List_Parameters parameters
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
