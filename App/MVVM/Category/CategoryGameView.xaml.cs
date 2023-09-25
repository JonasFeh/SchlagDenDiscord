using Games;
using System.Collections.Generic;
using System.Windows.Controls;

namespace App.MVVM.Category
{
    /// <summary>
    /// Interaction logic for CategoryGameView.xaml
    /// </summary>
    public partial class CategoryGameView : UserControl
    {
        public CategoryElementViewModel CurrentRound { get; set; }
        private int m_CurrentIndex = 0;
        private IList<CategoryElement> AllRounds => ( (CategoryGame)GameFactory.Instance.GetGame( Game.Category ) ).Elements;

        public CategoryGameView()
        {
            InitializeComponent();

            CurrentRound = new CategoryElementViewModel( AllRounds[m_CurrentIndex] );
            this.DataContext = CurrentRound;
        }
    }
}
