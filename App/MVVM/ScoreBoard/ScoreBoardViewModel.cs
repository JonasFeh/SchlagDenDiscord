using Data;
using SchlagDenDiscord.Core.Core;
using System;
using System.Collections.Generic;

namespace SchlagDenDiscord.MVVM.ScoreBoard
{
    class ScoreBoardViewModel : ViewModelBase<ScoreBoardModel>
    {

        public List<bool> ScoreMap = new List<bool>( 16 )
        {
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
            true,
        };

        public RelayCommand Empty1 => new RelayCommand( _ => { }, IsUnscored( 1 ) );
        public RelayCommand Empty2 => new RelayCommand( _ => { }, IsUnscored( 2 ) );
        public RelayCommand Empty3 => new RelayCommand( _ => { }, IsUnscored( 3 ) );
        public RelayCommand Empty4 => new RelayCommand( _ => { }, IsUnscored( 4 ) );
        public RelayCommand Empty5 => new RelayCommand( _ => { }, IsUnscored( 5 ) );
        public RelayCommand Empty6 => new RelayCommand( _ => { }, IsUnscored( 6 ) );
        public RelayCommand Empty7 => new RelayCommand( _ => { }, IsUnscored( 7 ) );
        public RelayCommand Empty8 => new RelayCommand( _ => { }, IsUnscored( 8 ) );
        public RelayCommand Empty9 => new RelayCommand( _ => { }, IsUnscored( 9 ) );
        public RelayCommand Empty10 => new RelayCommand( _ => { }, IsUnscored( 10 ) );
        public RelayCommand Empty11 => new RelayCommand( _ => { }, IsUnscored( 11 ) );
        public RelayCommand Empty12 => new RelayCommand( _ => { }, IsUnscored( 12 ) );
        public RelayCommand Empty13 => new RelayCommand( _ => { }, IsUnscored( 13 ) );
        public RelayCommand Empty14 => new RelayCommand( _ => { }, IsUnscored( 14 ) );
        public RelayCommand Empty15 => new RelayCommand( _ => { }, IsUnscored( 15 ) );

        public Data.Team Team1 => ProcessImage.Instance.GetTeamByEnum( Common.Team.Team1 );

        public RelayCommand Team1Scored1 => new RelayCommand( Scored( Common.Team.Team1, 1 ), IsUnscored( 1 ) );
        public RelayCommand Team1Scored2 => new RelayCommand( Scored( Common.Team.Team1, 2 ), IsUnscored( 2 ) );
        public RelayCommand Team1Scored3 => new RelayCommand( Scored( Common.Team.Team1, 3 ), IsUnscored( 3 ) );
        public RelayCommand Team1Scored4 => new RelayCommand( Scored( Common.Team.Team1, 4 ), IsUnscored( 4 ) );
        public RelayCommand Team1Scored5 => new RelayCommand( Scored( Common.Team.Team1, 5 ), IsUnscored( 5 ) );
        public RelayCommand Team1Scored6 => new RelayCommand( Scored( Common.Team.Team1, 6 ), IsUnscored( 6 ) );
        public RelayCommand Team1Scored7 => new RelayCommand( Scored( Common.Team.Team1, 7 ), IsUnscored( 7 ) );
        public RelayCommand Team1Scored8 => new RelayCommand( Scored( Common.Team.Team1, 8 ), IsUnscored( 8 ) );
        public RelayCommand Team1Scored9 => new RelayCommand( Scored( Common.Team.Team1, 9 ), IsUnscored( 9 ) );
        public RelayCommand Team1Scored10 => new RelayCommand( Scored( Common.Team.Team1, 10 ), IsUnscored( 10 ) );
        public RelayCommand Team1Scored11 => new RelayCommand( Scored( Common.Team.Team1, 11 ), IsUnscored( 11 ) );
        public RelayCommand Team1Scored12 => new RelayCommand( Scored( Common.Team.Team1, 12 ), IsUnscored( 12 ) );
        public RelayCommand Team1Scored13 => new RelayCommand( Scored( Common.Team.Team1, 13 ), IsUnscored( 13 ) );
        public RelayCommand Team1Scored14 => new RelayCommand( Scored( Common.Team.Team1, 14 ), IsUnscored( 14 ) );
        public RelayCommand Team1Scored15 => new RelayCommand( Scored( Common.Team.Team1, 15 ), IsUnscored( 15 ) );

        public Data.Team Team2 => ProcessImage.Instance.GetTeamByEnum( Common.Team.Team2 );

        public Data.Team Team3 => ProcessImage.Instance.GetTeamByEnum( Common.Team.Team3 );


        private Func<object, bool> IsUnscored( int theGameNumber )
        {
            return _ => ScoreMap[theGameNumber];
        }

        private Action<object> Scored( Common.Team theTeam, int theScoreToAdd )
        {
            return _ =>
            {
                ProcessImage.Instance.GetTeamByEnum( theTeam ).Score += theScoreToAdd;
                ScoreMap[theScoreToAdd] = false;
                NotifyTeamsChanged();
                NotifyButtonsCanExecuteChanged();
            };
        }

        private void NotifyTeamsChanged()
        {
            OnPropertyChanged( nameof( Team1 ) );
            OnPropertyChanged( nameof( Team2 ) );
            OnPropertyChanged( nameof( Team3 ) );
        }

        private void NotifyButtonsCanExecuteChanged()
        {
            OnPropertyChanged( nameof( Team1Scored1.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored2.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored3.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored4.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored5.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored6.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored7.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored8.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored9.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored10.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored11.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored12.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored13.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored14.CanExecute ) );
            OnPropertyChanged( nameof( Team1Scored15.CanExecute ) );
        }
    }
}
