using GoogleAnalyticsv4SDK.Interfaces;

using System;
using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Models
{
    public class HttpRequestBody
    {

        private string _client_id;
        private string _user_id;
        private long _timestamp_micros;
        private string _engagement_time_msec = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        private string _session_id = "1234";
        private bool _non_personalized_ads = true;
        private List<IEvent> _events = new List<IEvent>();
        public HttpRequestBody(string client_id, List<IEvent> events, string user_id = default, string session_id = default, bool non_personalized_ads = default)
        {
            this.client_id = client_id;
            this.events = events;
            this.user_id = user_id;
            ////this.timestamp_micros = timestamp_micros;
            ////this.engagement_time_msec = engagement_time_msec;
            this.session_id = session_id;
            this.non_personalized_ads = non_personalized_ads;
        }
        public string client_id
        {
            get
            {
                return _client_id;
            }
            set
            {
                _client_id = value;
            }
        }
        public string user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                _user_id = value;
            }
        }
        //public string engagement_time_msec
        //{
        //    get
        //    {
        //        return _engagement_time_msec;
        //    }
        //    set
        //    {
        //        _engagement_time_msec = value;
        //    }
        //}
        public string session_id
        {
            get
            {
                return _session_id;
            }
            set
            {
                _session_id = value;
            }
        }
        //public long timestamp_micros
        //{
        //    get
        //    {
        //        return _timestamp_micros;
        //    }
        //    set
        //    {
        //        _timestamp_micros = value;
        //    }
        //}
        public bool non_personalized_ads
        {
            get
            {
                return _non_personalized_ads;
            }
            set
            {
                _non_personalized_ads = value;
            }
        }
        public List<IEvent> events
        {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
            }

        }

    }
}
