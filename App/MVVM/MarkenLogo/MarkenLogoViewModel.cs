using App.MVVM.PictureAndAnswer;
using Games;

namespace App.MVVM.MarkenLogo
{
    class MarkenLogoViewModel : PictureAndAnswerViewModel
    {
        public MarkenLogoViewModel() : base( GameFactory.Instance.GetGame( Game.Markenlogo ) )
        {
        }


    }
}
