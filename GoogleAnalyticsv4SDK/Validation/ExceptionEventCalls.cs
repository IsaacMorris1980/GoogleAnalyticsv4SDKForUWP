using GoogleAnalyticsv4SDK.Events.Mobile;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Storage.Streams;
using Windows.Web.Http;

namespace GoogleAnalyticsv4SDK.Validation
{
    public class ExceptionEventCalls
    {
        private string measurement_id;
        private string client_id;
        private string api_secret;
        private string debugurl;
        private string collecturl;
        public List<Object> events = new List<Object>();

        public ExceptionEventCalls(string measurement_id, string api_secret, string client_id)
        {
            this.measurement_id = measurement_id;
            this.client_id = client_id;
            this.api_secret = api_secret;
            this.debugurl = $"https://www.google-analytics.com/debug/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";
            this.collecturl = $"https://www.google-analytics.com/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";


        }
        public async Task<HttpResponseMessage> DebugExceptionEvent(Exception error)
        {
            try
            {

                Execeptions errors = new Execeptions(error);
                events.Add(errors);
                CallBody call = new CallBody(this.client_id, events);
                var jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
                HttpStringContent stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
                HttpClient client = new HttpClient();
                var DidCallSucceed = await client.PostAsync(new Uri(debugurl), stringofCallToSend);
                return DidCallSucceed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task CollectException(Exception error)
        {
            try
            {


                Execeptions errors = new Execeptions(error);
                events.Add(errors);
                CallBody call = new CallBody(this.client_id, events);
                var jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
                HttpStringContent stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
                HttpClient client = new HttpClient();
                _ = await client.PostAsync(new Uri(collecturl), stringofCallToSend);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
