namespace Data
{
    [Serializable]
    public class Team
    {
        string Name { get; set; }
        IList<string> Members { get; set; }

        int PlayerCount => Members.Count();


        public Team()
        {
            Name = string.Empty;
            Members = new List<string>();
        }
    }
}
