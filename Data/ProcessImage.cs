namespace Data
{
    public class ProcessImage
    {
        #region Singleton

        private ProcessImage() { }
        static ProcessImage() { }

        private static ProcessImage _instance = new ProcessImage();

        public static ProcessImage Instance
        {
            get => _instance;
            set => _instance = value;
        }

        #endregion

        public Team GetTeamByEnum( Common.Team theTeam )
        {
            switch ( theTeam )
            {
                case Common.Team.Team1:
                    return Team1;
                case Common.Team.Team2:
                    return Team2;
                case Common.Team.Team3:
                    return Team3;
            }
            throw new ArgumentOutOfRangeException();
        }

        public Team Team1 { get; set; } = new Team( 1 );
        public Team Team2 { get; set; } = new Team( 2 );
        public Team Team3 { get; set; } = new Team( 3 );

        public Dictionary<int, bool> GamesNotPlayed = new Dictionary<int, bool>
        {
            { 1, true },
            { 2, true },
            { 3, true },
            { 4, true },
            { 5, true },
            { 6, true },
            { 7, true },
            { 8, true },
            { 9, true },
            { 10, true },
            { 11, true },
            { 12, true },
        };
    }
}
