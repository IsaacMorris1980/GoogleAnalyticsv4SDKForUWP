using GoogleAnalyticsv4SDK.Events.Mobile.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Mobile
{
    public class ScreenView : IEvent
    {
        private string _name = "screen_view";
        private ScreenView_Parameters _parameters;
        public ScreenView(string screen_name, string screen_resolution)
        {
            this.name = screen_name;
            this.parameters = new ScreenView_Parameters(screen_name, screen_resolution);
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty("params")]
        public ScreenView_Parameters parameters
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
