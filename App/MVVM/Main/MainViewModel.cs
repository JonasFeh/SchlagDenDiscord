using App.MVVM.Category;
using App.MVVM.MarkenLogo;
using App.MVVM.WhoThat;
using Games;
using SchlagDenDiscord.Core.Core;
using SchlagDenDiscord.MVVM.ScoreBoard;
using SchlagDenDiscord.MVVM.TopBar;
using System.Collections.Generic;

namespace SchlagDenDiscord.MVVM.Main
{
    class MainViewModel : ViewModelBase<MainModel>
    {
        #region Commands

        public RelayCommand OpenScoreBoard => new RelayCommand( _ => CurrentView = ScoreBoardViewModel, _ => true );
        public RelayCommand OpenGame1 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 1 )], _ => true );
        public RelayCommand OpenGame2 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 2 )], _ => true );
        public RelayCommand OpenGame3 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 3 )], _ => true );
        public RelayCommand OpenGame4 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 4 )], _ => true );
        public RelayCommand OpenGame5 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 5 )], _ => true );
        public RelayCommand OpenGame6 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 6 )], _ => true );
        public RelayCommand OpenGame7 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 7 )], _ => true );
        public RelayCommand OpenGame8 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 8 )], _ => true );
        public RelayCommand OpenGame9 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 9 )], _ => true );
        public RelayCommand OpenGame10 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 10 )], _ => true );
        public RelayCommand OpenGame11 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 11 )], _ => true );
        public RelayCommand OpenGame12 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 12 )], _ => true );
        public RelayCommand OpenGame13 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 13 )], _ => true );
        public RelayCommand OpenGame14 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 14 )], _ => true );
        public RelayCommand OpenGame15 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 15 )], _ => true );
        public RelayCommand OpenGameStechen => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 16 )], _ => true );
        public RelayCommand OpenSpareGame17 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 17 )], _ => true );
        public RelayCommand OpenSpareGame18 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 18 )], _ => true );
        public RelayCommand OpenSpareGame19 => new RelayCommand( _ => CurrentView = m_GameViewModels[GameFactory.Instance.GetGameEnum( 19 )], _ => true );
        
        #endregion

        public TopBarViewModel TopBarViewModel { get; set; }

        public ScoreBoardViewModel ScoreBoardViewModel { get; set; }


        private ViewModelBase m_CurrentView;

        private IDictionary<Game, ViewModelBase> m_GameViewModels;

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

            m_GameViewModels = getGameViewModels();

            m_CurrentView = ScoreBoardViewModel;
        }

        private static IDictionary<Game, ViewModelBase> getGameViewModels()
        {
            return new Dictionary<Game, ViewModelBase>
            {
                { Game.Markenlogo, new MarkenLogoViewModel() },
                { Game.WhoThat, new WhoThatViewModel() },
                { Game.Category, new CategoryGameViewModel((CategoryGame)GameFactory.Instance.GetGame(Game.Category)) },
            };
        }
    }
}
