using Newtonsoft.Json;

using System;

namespace GoogleAnalyticsv4SDK.Events.Mobile.Parameters
{
    public class Exception_Parameters
    {
        private Exception _exception;
        private Exception _innerexception;
        private string _message;
        private string _stacktrace;
        private string _source;

        public Exception_Parameters(Exception e)
        {
            this._exception = e;
            this._innerexception = e.InnerException;
            this._message = e.Message;
            this._stacktrace = e.StackTrace;
            this._source = e.Source;
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
    }
}
