namespace Data
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }
        public  IList<string> Members { get; set; }

        public int PlayerCount => Members.Count();

        public Team()
        {
            Name = string.Empty;
            Members = new List<string>();
        }
    }
}
