using App.MVVM.Category;
using Games;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace App.MVVM.Poker
{
    /// <summary>
    /// Interaction logic for PokerView.xaml
    /// </summary>
    public partial class PokerView : UserControl
    {
        public CategoryElementViewModel CurrentRound { get; set; }
        private int m_CurrentIndex;
        private IList<CategoryElement> AllRounds => ( (PokerGame)GameFactory.Instance.GetGame( Game.Poker ) ).Elements;

        public PokerView()
        {
            InitializeComponent();

            m_CurrentIndex = 0;

            CurrentRound = new CategoryElementViewModel( AllRounds[m_CurrentIndex] );
            this.DataContext = CurrentRound;
        }

        public void OnNextButtonClick( object sender, RoutedEventArgs e )
        {
            m_CurrentIndex++;
            if ( m_CurrentIndex >= AllRounds.Count )
            {
                return;
            }
            CurrentRound = CurrentRound = new CategoryElementViewModel( AllRounds[m_CurrentIndex] );
            this.DataContext = CurrentRound;
        }

        public void OnStringButtonClick( object sender, RoutedEventArgs e )
        {
            var aClickedButton = (Button)sender;
            var aContentGrid = aClickedButton.FindName( "Solution" ) as TextBlock;

            if ( aContentGrid.Visibility == Visibility.Hidden )
            {
                aContentGrid.Visibility = Visibility.Visible;
            }
            else
            {
                aContentGrid.Visibility = Visibility.Hidden;
            }
        }
    }
}
