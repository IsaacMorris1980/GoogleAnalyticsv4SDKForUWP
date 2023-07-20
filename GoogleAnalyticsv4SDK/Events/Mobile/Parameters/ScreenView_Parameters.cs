using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Mobile.Parameters
{
    public class ScreenView_Parameters
    {
        private string _screen_name, _screen_resolution;
        private List<Item> _items = new List<Item>();
        public ScreenView_Parameters(string screen_name, string screen_resoltion)
        {
            this.screen_name = screen_name;
            this.screen_resolution = screen_resoltion;
        }

        public string screen_name
        {
            get
            {
                return this._screen_name;
            }
            set
            {
                this._screen_name = value;
            }
        }
        public string screen_resolution
        {
            get
            {
                return this._screen_resolution;
            }
            set
            {
                this._screen_resolution = value;
            }
        }
    }
}
