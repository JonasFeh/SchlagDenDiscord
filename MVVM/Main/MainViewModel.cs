using SchlagDenDiscord.Core.Core;
using SchlagDenDiscord.MVVM.ScoreBoard;
using SchlagDenDiscord.MVVM.TopBar;

namespace SchlagDenDiscord.MVVM.Main
{
    class MainViewModel : ViewModelBase<MainModel>
    {
        public TopBarViewModel TopBarViewModel { get; set; }

        private ScoreBoardViewModel ScoreBoardViewModel { get; set; }


        private ViewModelBase m_CurrentView;

        public ViewModelBase CurrentView
        {
            get => m_CurrentView;
            set
            {
                m_CurrentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            TopBarViewModel = new TopBarViewModel();
            ScoreBoardViewModel = new ScoreBoardViewModel();

            CurrentView = ScoreBoardViewModel;
        }
    }
}
