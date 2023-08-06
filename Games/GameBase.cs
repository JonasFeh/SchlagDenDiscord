namespace Games
{
    public abstract class GameBase
    {
        private int theGameNumber;
        private string theName;

        public GameBase(int theGameNumber, string theName, GameType theGameType )
        {
            GameNumber = theGameNumber;
            Name = theName;
            GameType = theGameType;

        }

        public string Name { get; }

        public int GameNumber { get; }

        public GameType GameType { get; }
    }
}
