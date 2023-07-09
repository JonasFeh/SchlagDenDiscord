using SchlagDenDiscord.Core.Core;
using SchlagDenDiscord.MVVM.ScoreBoard;
using SchlagDenDiscord.MVVM.TopBar;

namespace SchlagDenDiscord.MVVM.Main
{
    class MainViewModel : ViewModelBase<MainModel>
    {
        public TopBarViewModel TopBarViewModel { get; set; }

        private ScoreBoardViewModel ScoreBoardViewModel { get; set; }


        private ViewModelBase m_CurrenView;

        public ViewModelBase CurrentView
        {
            get { return m_CurrenView; }
            set
            {
                m_CurrenView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            TopBarViewModel = new TopBarViewModel();
            ScoreBoardViewModel = new ScoreBoardViewModel();
            m_CurrenView = ScoreBoardViewModel;
        }
    }
}
