namespace Games
{
    public class PictureAndAnswerElement
    {
        public PictureAndAnswerElement( string theName, string theImagePath, int theDifficulty )
        {
            Name = theName;
            LogoPath = theImagePath;
            Difficulty = theDifficulty;
        }

        public string LogoPath { get; set; }
        public string Name { get; set; }

        public int Difficulty { get; set; }
    }
}
