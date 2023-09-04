using App.MVVM.PictureAndAnswer;
using Games;

namespace App.MVVM.WhoThat
{
    internal class WhoThatViewModel : PictureAndAnswerViewModel
    {

        public WhoThatViewModel() : base( GameFactory.Instance.GetGame( Game.WhoThat ) )
        {
        }
    }
}
