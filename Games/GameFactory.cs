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
            { Game.Markenlogo, new MarkenlogosGame(1, "Markenlogos") },
            { Game.WhoThat, new WhoThatGame(11, "Wer ist das?") },
            { Game.Category, new CategoryGame(8, "Kategorie") },
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
