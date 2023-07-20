using Newtonsoft.Json;

namespace GoogleAnalyticsv4SDK.Events.Mobile.Parameters
{
    public class Exception_Parameters
    {
        private string _exception;
        private string _innerexception;
        private string _message;
        private string _stacktrace;
        private string _source;

        public Exception_Parameters(string exception, string innerexception, string message, string stacktrace, string source)
        {
            this.exception = exception;
            this.innerexception = innerexception;
            this.message = message;
            this.stacktrace = stacktrace;
            this.source = source;
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string exception
        {
            get
            {
                return _exception.ToString();
            }
            set
            {
                _exception = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string innerexception
        {
            get
            {
                return _innerexception;
            }
            set
            {
                _innerexception = value;
            }
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string message
        {
            get

            {
                return _message;
            }
            set
            {
                _message = value;
            }

        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string stacktrace
        {
            get
            {
                return _stacktrace;
            }
            set
            {
                _stacktrace = value;
            }
        }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string source
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }
    }
}
