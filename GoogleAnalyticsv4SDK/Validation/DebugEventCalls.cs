using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoogleAnalyticsv4SDK
{
    public class DebugEventCalls
    {
        private string measurement_id; //required
        private string api_secret;  //required
        private string client_id; //required
        public async Task<List<ValidationMessage>> SendEvent(Event e)
        {
            return null;
        }
    }
}
