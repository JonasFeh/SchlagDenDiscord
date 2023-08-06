
namespace Games
{
    internal class MarkenlogosGame : PictureAndAnswerBase
    {
        public MarkenlogosGame( int theGameNumber, string theName ) : base( theGameNumber, theName )
        {
        }

        protected override string RessourceFolder => Path.Combine( SolutionDir, "res", "markenlogos" );
    }
}
