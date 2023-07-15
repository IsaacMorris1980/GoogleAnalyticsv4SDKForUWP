namespace GoogleAnalyticsv4SDK.Events.Games.Parameters
{
    public class Post_Parameters
    {
        private int _score;
        private int _level;
        private string _character;
        public Post_Parameters(int score, int level = default, string character = default)
        {
            this.score = score;
            this.level = level;
            this.character = character;
        }
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }
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
    }
}
