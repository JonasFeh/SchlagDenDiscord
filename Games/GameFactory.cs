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
            { Game.Markenlogo, new Markenlogos(1, "Markenlogos") },
        };

        public GameBase GetGame( Game theGame )
        {
            return GameRegistry[theGame];
        }
    }
}
