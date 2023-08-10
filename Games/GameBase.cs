namespace Games
{
    public abstract class GameBase
    {
        public GameBase( int theGameNumber, string theName, GameType theGameType, Game theGame )
        {
            GameNumber = theGameNumber;
            Name = theName;
            GameType = theGameType;
            Game = theGame;
        }

        public string Name { get; }

        public int GameNumber { get; }

        public GameType GameType { get; }

        public Game Game { get; }
    }
}
