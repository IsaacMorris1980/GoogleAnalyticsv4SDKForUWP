using GoogleAnalyticsv4SDK.Events.Marketing.Parameters;
using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Marketing
{
    public class View_Promotion
    {
        private string _name;
        private Promotion_Parameters _parameters;

        public View_Promotion(List<Item> items, string creative_name = default, string creative_slot = default, string promotion_id = default, string promotion_name = default)
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
