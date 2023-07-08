using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Mobile
{
    public class Execeptions
    {
        private ExceptionEventParameters _parameters;
        private const string _name = "exception";
        public Execeptions(Exception e)
        {
            this._parameters = new ExceptionEventParameters(e, new List<Item>());

        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        [JsonProperty("params")]
        public ExceptionEventParameters parameters
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
    public class ExceptionEventParameters
    {
        private Exception _exception;
        private Exception _innerexception;
        private string _message;
        private string _stacktrace;
        private string _source;
        private List<Item> _items = new List<Item>();
        public ExceptionEventParameters(Exception e, List<Item> items)
        {
            this._exception = e;
            this._innerexception = e.InnerException;
            this._message = e.Message;
            this._stacktrace = e.StackTrace;
            this._source = e.Source;
            this._items = items;
        }

        public string exception
        {
            get
            {
                return JsonConvert.SerializeObject(this._exception.ToString());
            }
        }
        public string innerexception
        {
            get
            {
                if (_innerexception != null)
                {
                    return JsonConvert.SerializeObject(this._innerexception.ToString());
                }
                return _innerexception == null ? string.Empty : JsonConvert.SerializeObject(innerexception, Formatting.Indented);
            }
        }
        public string message
        {
            get

            {
                return _message == string.Empty ? string.Empty : _message;
            }

        }
        public string stacktrace
        {
            get
            {
                return _stacktrace == null ? string.Empty : _stacktrace;
            }
        }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string source
        {
            get
            {
                return _source == string.Empty ? string.Empty : _source;
            }
        }
        public List<Item> items
        {
            get
            {
                return _items;
            }

        }

    }
}
