using GoogleAnalyticsv4SDK.Interfaces;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

using Windows.Storage.Streams;
using Windows.Web.Http;

using HttpResponseMessage = Windows.Web.Http.HttpResponseMessage;

namespace GoogleAnalyticsv4SDK.Helpers
{
    public class GoogleAnalyticsEndpoints
    {
        private string Api_secret;
        private string Measurement_id;
        public GoogleAnalyticsEndpoints(string api_secret, string measurement_id)
        {
            Api_secret = api_secret;
            Measurement_id = measurement_id;

        }
        public Uri Collect => new Uri($"https://www.google-analytics.com/debug/mp/collect?api_secret={Api_secret}&measurement_id={Measurement_id}");
        public Uri Debug => new Uri($"https://www.google-analytics.com/debug/mp/collect?api_secret={Api_secret}&measurement_id={Measurement_id}");
        /// <summary>
        /// If debug it only checks first event
        /// </summary>
        /// <param name="body"></param>
        /// <param name="client_id"></param>
        /// <param name="debug"></param>
        public async void SendEvent(List<IEvent> body, string client_id, bool debug)
        {
            string jsonofCall;
            HttpStringContent stringofCallToSend;
            Windows.Web.Http.HttpClient client = new Windows.Web.Http.HttpClient();
            HttpRequestBody call = new HttpRequestBody(client_id, body);
            jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
            stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
            if (debug)
            {



                HttpResponseMessage response = await client.PostAsync(Debug, stringofCallToSend);
                var a = await response.Content.ReadAsStringAsync();
                var b = JsonConvert.DeserializeObject<Rootobject>(a);
                Console.WriteLine(b);
                return;
            }
            _ = await client.PostAsync(Collect, stringofCallToSend);
        }
    }
}
