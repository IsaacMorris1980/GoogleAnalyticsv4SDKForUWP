using GoogleAnalyticsv4SDK.Events;
using GoogleAnalyticsv4SDK.Models;
using GoogleAnalyticsv4SDK.Validation;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Data.Json;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace GoogleAnalyticsv4SDK
{
    public class ScreenViewEventCalls
    {
        private string measurement_id; //required
        private string api_secret;  //required
        private string client_id; //required
        private string debugurl;
        private string collecturl;
        private List<ScreenView> events = new List<ScreenView>();

        public ScreenViewEventCalls(string measurement_id, string api_secret, string client_id)
        {
            this.measurement_id = measurement_id;
            this.client_id = client_id;
            this.api_secret = api_secret;
            this.debugurl = $"https://www.google-analytics.com/debug/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";
            this.collecturl = $"https://www.google-analytics.com/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";


        }
        public async Task<string> DebugScreenviewEvent(string screenname)
        {


            ScreenView screen = new ScreenView(screenname, GetScreenResolution());
            events.Add(screen);
            CallBody call = new CallBody(this.client_id, events);
            var jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
            HttpStringContent stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
            HttpClient client = new HttpClient();
            var DidCallSucceed = await client.PostAsync(new Uri(debugurl), stringofCallToSend);
            JsonObject ResponseofCall = (JsonObject)JsonConvert.DeserializeObject(DidCallSucceed.Content.ToString());
            ValidationCode code;
            if (Enum.TryParse<ValidationCode>(ResponseofCall["ValidationCode"].ToString(), out code))
            {
                string exceptionstring = $"{ResponseofCall.ToString()}";
                return exceptionstring;
            }
            return "Call Suceeded!";
        }
        public async Task CollectScreenViews(string screenname)
        {
            ScreenView screen = new ScreenView(screenname, GetScreenResolution());
            events.Add(screen);
            CallBody call = new CallBody(this.client_id, events);
            var jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
            HttpStringContent stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
            HttpClient client = new HttpClient();
            _ = await client.PostAsync(new Uri(collecturl), stringofCallToSend);
        }
        public string GetScreenResolution()
        {
            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            return $"{screenSize.Width} X {screenSize.Height}";
        }
    }
}
