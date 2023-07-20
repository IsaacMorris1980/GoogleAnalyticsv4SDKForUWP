using GoogleAnalyticsv4SDK.Events.Mobile.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

using Newtonsoft.Json;

using System;

namespace GoogleAnalyticsv4SDK.Events.Mobile
{
    public class Execeptions : IEvent
    {
        private Exception_Parameters _parameters;
        private const string _name = "exception";
        public Execeptions(Exception e)
        {
            this._parameters = new Exception_Parameters(e);

        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public Exception_Parameters parameters
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
