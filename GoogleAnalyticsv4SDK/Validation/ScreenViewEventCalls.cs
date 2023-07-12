using GoogleAnalyticsv4SDK.Events.Mobile.Navigation;
using GoogleAnalyticsv4SDK.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace GoogleAnalyticsv4SDK.Validation
{
    public class ScreenViewEventCalls
    {
        private string measurement_id; //required
        private string api_secret;  //required
        private string client_id; //required
        private string debugurl;
        private string collecturl;
        private List<Object> events = new List<Object>();

        public ScreenViewEventCalls(string measurement_id, string api_secret, string client_id)
        {
            this.measurement_id = measurement_id;
            this.client_id = client_id;
            this.api_secret = api_secret;
            this.debugurl = $"https://www.google-analytics.com/debug/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";
            this.collecturl = $"https://www.google-analytics.com/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";


        }
        public async Task<HttpResponseMessage> DebugScreenviewEvent(string screenname)
        {
            try
            {

                ScreenView screen = new ScreenView(screenname, GetScreenResolution());
                events.Add(screen);
                CallBody call = new CallBody(this.client_id, events);
                var jsonofCall = JsonConvert.SerializeObject(call, Formatting.Indented);
                HttpStringContent stringofCallToSend = new HttpStringContent(jsonofCall, UnicodeEncoding.Utf8, "application/json");
                HttpClient client = new HttpClient();
                HttpResponseMessage DidCallSucceed = await client.PostAsync(new Uri(debugurl), stringofCallToSend);
                return DidCallSucceed;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public async Task CollectScreenViews(string screenname)
        {
            try
            {
                ScreenView screen = new ScreenView(screenname, GetScreenResolution());
                events.Add(screen);
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
        public string GetScreenResolution()
        {
            var displayInformation = DisplayInformation.GetForCurrentView();
            var screenSize = new Size(displayInformation.ScreenWidthInRawPixels,
                                      displayInformation.ScreenHeightInRawPixels);
            return $"{screenSize.Width} X {screenSize.Height}";
        }
    }
}
