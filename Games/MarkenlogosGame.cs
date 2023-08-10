
namespace Games
{
    public class MarkenlogosGame : PictureAndAnswerBase
    {
        public MarkenlogosGame( int theGameNumber, string theName ) : base( theGameNumber, theName )
        {
        }

        protected override string RessourceFolder => Path.Combine( SolutionDir, "App", "res", "Markenlogos" );
    }
}
