using GoogleAnalyticsv4SDK.Events.Games.Parameters;

namespace GoogleAnalyticsv4SDK.Events.Games
{
    public class Level_Up
    {
        private string _name = "level_up";
        private Level_Parameters _parameters;
        public Level_Up(Level_Parameters parameters)
        {
            this.parameters = parameters;
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        public Level_Parameters parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
    }
}
