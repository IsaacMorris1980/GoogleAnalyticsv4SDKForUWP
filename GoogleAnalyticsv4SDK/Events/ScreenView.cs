using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events
{
    public class ScreenView
    {
        private const string _name = "screen_view";
        private EventParameters _parameters;
        public ScreenView(string screen_name, string screeb_resolution)
        {
            this.parameters = new EventParameters(screen_name, screeb_resolution, new List<Item>());
        }

        public string name
        {
            get { return _name; }
        }
        [JsonProperty("params")]
        public EventParameters parameters
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
        //public string screenname
        //{
        //    get
        //    {
        //        return this._screen_name;
        //    }
        //    set
        //    {
        //        this._screen_name = value;
        //    }
        //}
        //public string screenresolution
        //{
        //    get
        //    {
        //        return this._screen_resolution;
        //    }
        //    set
        //    {
        //        this._screen_resolution = value;
        //    }
        //}
        //public List<Item> items
        //{
        //    get
        //    {
        //        return _items;
        //    }
        //    set
        //    {
        //        _items = value;
        //    }
    }
    //public string screen_title
    //{
    //    get
    //    {
    //        return _page_title;

    //    }
    //    set
    //    {
    //        _page_title = value;
    //    }
    //}
    //public string page_location
    //{
    //    get
    //    {
    //        return _page_location;
    //    }
    //    set
    //    {
    //        _page_location = value;
    //    }
    //}


    public class EventParameters
    {
        private string _screen_name, _screen_resolution;
        private List<Item> _items = new List<Item>();
        public EventParameters(string screen_name, string screen_resoltion, List<Item> items)
        {
            this.screen_name = screen_name;
            this.screenresolution = screen_resoltion;
            this.items = items;
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
        public string screenresolution
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
