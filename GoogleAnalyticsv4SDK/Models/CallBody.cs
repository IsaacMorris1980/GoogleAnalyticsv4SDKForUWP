using System;
using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Models
{
    public class CallBody
    {

        private string _client_id = "e509cccc-65ee-4635-916f-cf73119c19b1";
        private string _user_id;
        private long _timestamp_micros;
        private string _engagement_time_msec = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        private string _session_id = "1234";
        private bool _non_personalized_ads = true;
        private List<Object> _events = new List<Object>();
        public CallBody(string client_id, List<Object> events)
        {
            _client_id = client_id;
            _events = events;
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
        //public string session_id
        //{
        //    get
        //    {
        //        return _session_id;
        //    }
        //    set
        //    {
        //        _session_id = value;
        //    }
        //}
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
        public List<Object> events
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
