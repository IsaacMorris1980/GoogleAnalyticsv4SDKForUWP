using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Marketing.Parameters
{
    public class Promotion_Parameters
    {
        private string _creative_name;
        private string _creative_slot;
        private string _promotion_id;
        private string _promotion_name;
        private List<Item> _items;

        public Promotion_Parameters(string creative_name = default, string creative_slot = default, string promotion_id = default, string promotion_name = default, List<Item> items = default)
        {
            this.creative_name = creative_name;
            this.creative_slot = creative_slot;
            this.promotion_id = promotion_id;
            this.promotion_name = promotion_name;
            this.items = items;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string creative_name
        {
            get
            {
                return _creative_name;
            }
            set
            {
                _creative_name = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string creative_slot
        {
            get
            {
                return _creative_slot;
            }
            set
            {
                _creative_slot = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string promotion_id
        {
            get
            {
                return _promotion_id;
            }
            set
            {
                _promotion_id = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string promotion_name
        {
            get
            {
                return _promotion_name;
            }
            set
            {
                _promotion_name = value;
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
