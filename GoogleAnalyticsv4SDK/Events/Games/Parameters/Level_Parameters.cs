namespace GoogleAnalyticsv4SDK.Events.Games.Parameters
{
    public class Level_Parameters
    {
        private int _level;
        private string _character;
        public int level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }
        public string character
        {
            get
            {
                return _character;
            }
            set
            {
                _character = value;
            }
        }
        public Level_Parameters(int level = default, string character==default)
        {
            this.level = level;
            this.character = character;
        }
    }
}
