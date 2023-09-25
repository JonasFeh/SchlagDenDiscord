﻿using Games;
using SchlagDenDiscord.Core.Core;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace App.MVVM.Category
{
    public class CategoryGameViewModel : ViewModelBase
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

        public CategoryGameViewModel( CategoryGame theCategoryGame )
        {
            GameNumber = theCategoryGame.GameNumber;
            GameName = theCategoryGame.Name;

            var aTempElements = new ObservableCollection<CategoryElementViewModel>();
            foreach ( var aElement in theCategoryGame.Elements )
            {
                aTempElements.Add( new CategoryElementViewModel( aElement ) );
            }
            Elements = aTempElements;
        }
    }
}
