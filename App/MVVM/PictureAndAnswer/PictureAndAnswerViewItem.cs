using Games;
using SchlagDenDiscord.Core;
using SchlagDenDiscord.Core.Core;
using System.Windows.Controls;

namespace App.MVVM.PictureAndAnswer
{
    public class PictureAndAnswerViewItem : ViewItem
    {
        private readonly PictureAndAnswerBase game;

        public PictureAndAnswerViewItem(PictureAndAnswerBase theGame)
        {
            game = theGame;
        }

        public override UserControl View => new PictureAndAnswerView();

        public override ViewModelBase ViewModel => new PictureAndAnswerViewModel( game );

        public override ModelBase Model => new PictureAndAnswerModel();
    }
}
