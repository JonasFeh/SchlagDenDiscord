using Games;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;

namespace App.MVVM.Category
{
    public class CategoryElementViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged( string thePropertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( thePropertyName ) );
        }

        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set
            {
                if ( m_Name != value )
                {
                    m_Name = value;
                    OnPropertyChanged( nameof( Name ) );
                }
            }
        }

        private List<string> m_Solutions;
        public List<string> Solutions
        {
            get { return m_Solutions; }
            set
            {
                if ( m_Solutions != value )
                {
                    m_Solutions = value;
                    OnPropertyChanged( nameof( Solutions ) );
                }
            }
        }

        public void OnStringButtonClick( object sender, RoutedEventArgs e )
        {
            var aClickedButton = (Button)sender;
            if ( aClickedButton.Visibility == Visibility.Hidden )
            {
                aClickedButton.Visibility = Visibility.Visible;
            }
            else
            {
                aClickedButton.Visibility = Visibility.Hidden;
            }
        }

        public CategoryElementViewModel( CategoryElement theCategoryElement )
        {
            Name = theCategoryElement.Name;
            Solutions = (List<string>)theCategoryElement.Solutions;
        }
    }
}
