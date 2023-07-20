using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Select_Item : IEvent
    {
        private string _name = "select_item";
        private Select_Item_Parameters _parameters;
        public Select_Item(List<Item> items, string item_list_id = default, string item_list_name = default)
        {
            this.parameters = new Select_Item_Parameters(items, item_list_id, item_list_name);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Select_Item_Parameters parameters
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
