using System.Security.Cryptography;

namespace Games
{
    public abstract class PictureAndAnswerBase : GameBase
    {
        public PictureAndAnswerBase( int theGameNumber, string theName, Game theGame ) : base( theGameNumber, theName, GameType.PictureAndAnswer, theGame )
        {
            Elements = new List<PictureAndAnswerElement>();
        }

        public List<PictureAndAnswerElement> Elements { get; protected set; }

        protected string SolutionDir => Common.VisualStudioProvider.TryGetSolutionDirectoryInfo().FullName;

        protected abstract string RessourceFolder { get; }

        protected static List<T> Shuffle<T>( List<T> theList )
        {
            var provider = new RNGCryptoServiceProvider();
            int n = theList.Count;
            while ( n > 1 )
            {
                byte[] box = new byte[1];
                do
                {
                    provider.GetBytes( box );
                }
                while ( !( box[0] < n * ( Byte.MaxValue / n ) ) );
                int k = ( box[0] % n );
                n--;
                T value = theList[k];
                theList[k] = theList[n];
                theList[n] = value;
            }
            return theList;
        }
    }
}
