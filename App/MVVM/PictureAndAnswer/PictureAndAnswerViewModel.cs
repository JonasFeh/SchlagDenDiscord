using Games;
using SchlagDenDiscord.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace App.MVVM.PictureAndAnswer
{
    internal class PictureAndAnswerViewModel : ViewModelBase<PictureAndAnswerModel>
    {

        public PictureAndAnswerViewModel( GameBase theGame )
        {
            if ( !( theGame is PictureAndAnswerBase aGame ) )
                throw new ArgumentException( $"Game must be of type {nameof( PictureAndAnswerBase )}" );

            _game = aGame;
            _hideAnswer = Visibility.Hidden;
            Elements = new Queue<PictureAndAnswerElement>( aGame.Elements );
            CurrentElement = Elements.Dequeue();
        }

        public Queue<PictureAndAnswerElement> Elements { get; private set; }

        private Visibility _hideAnswer;

        public Visibility HideAnswer
        {
            get => _hideAnswer;
            set
            {
                _hideAnswer = value;
                OnPropertyChanged( nameof( HideAnswer ) );
            }
        }

        public RelayCommand Next => new RelayCommand( _ => ShowNext(), _ => true );

        private void ShowNext()
        {
            if ( HideAnswer == Visibility.Visible && Elements.Count() > 0 )
            {
                HideAnswer = Visibility.Hidden;
                CurrentElement = Elements.Dequeue();
                return;
            }

            HideAnswer = Visibility.Visible;
        }

        private PictureAndAnswerBase _game;

        private PictureAndAnswerElement _currentElement;
        public PictureAndAnswerElement CurrentElement
        {
            get => _currentElement;
            private set
            {
                _currentElement = value;
                OnPropertyChanged( nameof( CurrentElement ) );
            }
        }


        public int GameNumber => _game.GameNumber;

        public string Header => "Spiel " + GameNumber + " - " + _game.Name;
    }
}
