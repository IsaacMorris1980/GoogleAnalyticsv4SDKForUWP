﻿using GoogleAnalyticsv4SDK.Events.Web.Parameters;
using GoogleAnalyticsv4SDK.Interfaces;

namespace GoogleAnalyticsv4SDK.Events.Web
{
    public class Search : IEvent
    {
        private string _name = "search";
        private Search_Parameters _parameters;

        public Search(Search_Parameters parameters)
        {
            this.parameters = parameters;
        }

        public string name
        {
            get
            {
                return _name;
            }
        }
        public Search_Parameters parameters
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