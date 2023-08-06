using Games;
using SchlagDenDiscord.Core.Core;

namespace App.MVVM.PictureAndAnswer
{
    internal class PictureAndAnswerViewModel : ViewModelBase<PictureAndAnswerModel>
    {

        public PictureAndAnswerViewModel(PictureAndAnswerBase theGame)
        {
            _game = theGame;
        }

        private PictureAndAnswerBase _game;

        public PictureAndAnswerElement CurrentElement { get; private set; }

        public int GameNumber => _game.GameNumber;

        public string Header => "Spiel " + GameNumber + " - " + _game.Name;

        
    }
}
