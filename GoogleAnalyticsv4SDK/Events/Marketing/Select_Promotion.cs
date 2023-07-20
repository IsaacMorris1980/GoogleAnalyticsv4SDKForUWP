using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class Select_Promotion : IEvent
    {
        private string _name = "select_promotion";
        private Promotion_Parameters _parameters;
        public Select_Promotion(string creative_name = default, string creative_slot = default, string promotion_id = default, string promotion_name = default, List<Item> items = default)
        {
            this.parameters = new Promotion_Parameters(creative_name, creative_slot, promotion_id, promotion_name, items);
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Promotion_Parameters parameters
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
