using App.MVVM.Category;
using Games;
using SchlagDenDiscord.Core.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace App.MVVM.Poker
{
    class PokerViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged( string thePropertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( thePropertyName ) );
        }

        public int GameNumber { get; set; }
        public string GameName { get; set; }

        private ObservableCollection<CategoryElementViewModel> m_Elements;
        public ObservableCollection<CategoryElementViewModel> Elements
        {
            get { return m_Elements; }
            set
            {
                if ( m_Elements != value )
                {
                    m_Elements = value;
                    OnPropertyChanged( nameof( Elements ) );
                }
            }
        }

        public PokerViewModel( PokerGame thePokerGame )
        {
            GameNumber = thePokerGame.GameNumber;
            GameName = thePokerGame.Name;

            var aTempElements = new ObservableCollection<CategoryElementViewModel>();
            foreach ( var aElement in thePokerGame.Elements )
            {
                aTempElements.Add( new CategoryElementViewModel( aElement ) );
            }
            Elements = aTempElements;
        }
    }
}
