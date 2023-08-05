﻿namespace Data
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }

        public Dictionary<Common.Joker, bool> JokerMap { get; set; }

        public int Score { get; set; }

        public Team( int Number )
        {
            Name = "Team" + Number;
            JokerMap = new Dictionary<Common.Joker, bool>
            {
                { Common.Joker.Double, true},
                { Common.Joker.FuckOff, true},
                { Common.Joker.ReRoll, true},
            };
        }
    }
}
