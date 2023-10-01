namespace Games
{
    public class GameFactory
    {

        #region Singleton

        private GameFactory() { }
        static GameFactory() { }

        private static GameFactory m_instance = new GameFactory();

        public static GameFactory Instance
        {
            get => m_instance;
            set => m_instance = value;
        }

        #endregion

        private Dictionary<Game, GameBase> GameRegistry = new Dictionary<Game, GameBase>
        {
            { Game.Google, new CategoryGame(2, "Google") },
            { Game.Category, new CategoryGame(7, "Kategorie") },
            { Game.Markenlogo, new MarkenlogosGame(9, "Markenlogos") },
            { Game.WhoThat, new WhoThatGame(10, "Wer ist das?") },
            { Game.Poker, new PokerGame(12, "PokerGame") },
        };

        public GameBase GetGame( Game theGame )
        {
            return GameRegistry[theGame];
        }

        public int GetGameNumber( Game theGame )
        {
            return GameRegistry.Values.First( x => x.Game == theGame ).GameNumber;
        }

        public Game GetGameEnum( int theGameNumber )
        {
            return GameRegistry.Values.First( x => x.GameNumber == theGameNumber ).Game;
        }
    }
}
