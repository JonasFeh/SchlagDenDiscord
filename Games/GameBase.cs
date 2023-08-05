namespace Games
{
    public class GameBase
    {
        public GameBase(int theGameNumber, string theName)
        {
            GameNumber = theGameNumber;
            Name = theName;
        }

        public string Name { get; }

        public int GameNumber { get; }
    }
}
