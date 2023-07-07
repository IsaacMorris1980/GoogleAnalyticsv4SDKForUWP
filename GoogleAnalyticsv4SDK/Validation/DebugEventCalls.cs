using GoogleAnalyticsv4SDK.Models;
using GoogleAnalyticsv4SDK.Events;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.Storage.Streams;

using Windows.Web.Http;

namespace GoogleAnalyticsv4SDK
{
    public class DebugEventCalls
    {
        private string measurement_id = "G-WV43RHFPXN"; //required
        private string api_secret = "iVAKVkeZQ1CNQi4ONEOo9Q";  //required
        private string client_id; //required
        public async Task<HttpResponseMessage> SendScreenviewEvent()
        {
            List<ScreenView> events = new List<ScreenView>();

            ScreenView screen = new ScreenView("test", GetScreenResolution());
            events.Add(screen);
            CallBody call = new CallBody(Guid.NewGuid().ToString(), events);
            var c = JsonConvert.SerializeObject(call, Formatting.Indented);
            HttpStringContent a = new HttpStringContent(c, UnicodeEncoding.Utf8, "application/json");
            HttpClient client = new HttpClient();

            string url = $"https://www.google-analytics.com/debug/mp/collect?api_secret={api_secret}&measurement_id={measurement_id}";
            Uri location = new Uri(url);
            var b = await client.PostAsync(location, a);


            return b;
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
