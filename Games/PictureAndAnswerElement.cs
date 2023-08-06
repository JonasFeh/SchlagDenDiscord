namespace Games
{
    public class PictureAndAnswerElement
    {
        public PictureAndAnswerElement( string theName, string theImagePath, int theDifficulty )
        {
            Answer = theName;
            Image = theImagePath;
            Difficulty = theDifficulty;
        }

        public string Image { get; set; }
        public string Answer { get; set; }

        public int Difficulty { get; set; }
    }
}
