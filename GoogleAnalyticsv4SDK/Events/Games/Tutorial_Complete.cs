using GoogleAnalyticsv4SDK.Interfaces;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Tutorial_Complete : IEvent
    {
        private string _name;
        public Tutorial_Complete()
        {

        }
        public string name
        {
            get
            {
                return _name;
            }
        }
    }
}
