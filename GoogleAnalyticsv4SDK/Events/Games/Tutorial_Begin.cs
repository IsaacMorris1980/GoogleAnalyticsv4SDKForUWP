using GoogleAnalyticsv4SDK.Interfaces;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Tutorial_Begin : IEvent
    {
        private string _name = "tutorial_begin";
        public Tutorial_Begin()
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
