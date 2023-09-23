using Data;
using Games;
using Microsoft.VisualBasic;
using SchlagDenDiscord.Core.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace App.MVVM.Category
{
    internal class CategoryElementViewModel : ViewModelBase<CategoryElementModel>
    {
        public string Solution { get; set; }

        private bool isVisible;
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                OnPropertyChanged( nameof( IsVisible ) );
            }
        }

        // Handle button click to toggle visibility
        public ICommand ToggleVisibilityCommand => new RelayCommand( _ =>
        {
            IsVisible = !IsVisible;
        } );
    }

    internal class CategoryRoundViewModel : ViewModelBase<CategoryRoundModel>
    {
        public string Name { get; set; }

        public ObservableCollection<CategoryElementViewModel> Solutions { get; set; }
    }

    internal class CategoryViewModel : ViewModelBase<CategoryModel>
    {
        private ObservableCollection<CategoryRoundViewModel> m_AllRounds;

        public ObservableCollection<CategoryRoundViewModel> AllRounds
        {
            get
            {
                if ( m_AllRounds == null )
                    m_AllRounds = new ObservableCollection<CategoryRoundViewModel>();

                return m_AllRounds;
            }
            set { m_AllRounds = value; }
        }

        private IList<CategoryElement> Rounds => ( GameFactory.Instance.GetGame( Game.Category ) as CategoryGame ).Elements;

        private int CurrentIndex { get; set; } = 0;

        public CategoryRoundViewModel CurrentRound { get; set; }

        public ICommand StartNewRound => new RelayCommand( _ => getNextRound(), _ => { return CurrentIndex + 1 <= Rounds.Count; } );

        private void getNextRound()
        {
            if ( Rounds == null )
            {
                var aFirstRound = Rounds.First();
                CurrentRound = new CategoryRoundViewModel
                {
                    Name = aFirstRound.Name,
                    Solutions = new ObservableCollection<CategoryElementViewModel>(),
                };
                foreach ( var aSolution in aFirstRound.Solutions )
                {
                    var aNewViewModel = new CategoryElementViewModel
                    {
                        Solution = aSolution,
                        IsVisible = false,
                    };
                    CurrentRound.Solutions.Add( aNewViewModel );
                }
                CurrentIndex++;
                return;
            }

            // Ensure the index is valid
            if ( CurrentIndex >= 0 && CurrentIndex < Rounds.Count - 1 )
            {
                // Get the next element
                var aNextElement = Rounds[CurrentIndex + 1];
                CurrentRound = new CategoryRoundViewModel
                {
                    Name = aNextElement.Name,
                    Solutions = new ObservableCollection<CategoryElementViewModel>(),
                };
                foreach ( var aSolution in aNextElement.Solutions )
                {
                    var aNewViewModel = new CategoryElementViewModel
                    {
                        Solution = aSolution,
                        IsVisible = false,
                    };
                    CurrentRound.Solutions.Add( aNewViewModel );
                }
                CurrentIndex++;
            }
            else
            {
                return;
            }
        }

    }
}
