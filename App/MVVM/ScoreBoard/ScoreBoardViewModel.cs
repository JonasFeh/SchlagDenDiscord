using Common;
using Data;
using SchlagDenDiscord.Core.Core;
using System;
using System.Collections.Generic;

namespace SchlagDenDiscord.MVVM.ScoreBoard
{
    class ScoreBoardViewModel : ViewModelBase<ScoreBoardModel>
    {
        public ScoreBoardViewModel()
        {
            ScoreMap = new List<bool>( 16 )
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
        }

        private int GetMaximumPossiblePoints( Common.Team theTeam )
        {
            var team = ProcessImage.Instance.GetTeamByEnum( theTeam );
            var currentPoints = team.Score;

            var aOpenPoints = GetOpenPoints( team );

            return currentPoints + aOpenPoints;
        }

        private int GetOpenPoints( Data.Team theTeam )
        {
            var openPoints = 0;
            for ( var i = 1; i < ScoreMap.Count - 1; i++ )
            {
                if ( ScoreMap[i] )
                {
                    openPoints += i;
                }
            }

            return openPoints;
        }

        public int MinimumPoints = 0;

        public int Team1Points2Win => GetPoints2Win( Common.Team.Team1, Common.Team.Team2, Common.Team.Team3 );
        public int Team2Points2Win => GetPoints2Win( Common.Team.Team2, Common.Team.Team1, Common.Team.Team3 );
        public int Team3Points2Win => GetPoints2Win( Common.Team.Team3, Common.Team.Team1, Common.Team.Team2 );

        private int GetPoints2Win( Common.Team theTeam, Common.Team theEnemy1, Common.Team theEnemy2 )
        {
            var enemy1MaximumPoints = GetMaximumPossiblePoints( theEnemy1 );
            var enemy2MaximumPoints = GetMaximumPossiblePoints( theEnemy2 );

            var maximumPointAnyEnemyCanScore = Math.Max( enemy1MaximumPoints, enemy2MaximumPoints );

            var yourMaximumPoints = GetMaximumPossiblePoints( theTeam );

            return Math.Min( yourMaximumPoints, maximumPointAnyEnemyCanScore );
        }

        public int Team1MaximumPossiblePoints => GetMaximumPossiblePoints( Common.Team.Team1 );
        public int Team2MaximumPossiblePoints => GetMaximumPossiblePoints( Common.Team.Team2 );
        public int Team3MaximumPossiblePoints => GetMaximumPossiblePoints( Common.Team.Team3 );


        public List<bool> ScoreMap { get; set; }

        #region TopBarCommands

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

        #endregion

        #region Team1

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

        public RelayCommand Team1Joker2x => new RelayCommand( UseJoker( Common.Team.Team1, Common.Joker.Double ), IsJokerUsed( Common.Team.Team1, Common.Joker.Double ) );
        public RelayCommand Team1JokerFuckOff => new RelayCommand( UseJoker( Common.Team.Team1, Common.Joker.FuckOff ), IsJokerUsed( Common.Team.Team1, Common.Joker.FuckOff ) );
        public RelayCommand Team1JokerReRoll => new RelayCommand( UseJoker( Common.Team.Team1, Common.Joker.ReRoll ), IsJokerUsed( Common.Team.Team1, Common.Joker.ReRoll ) );

        #endregion

        #region Team2

        public Data.Team Team2 => ProcessImage.Instance.GetTeamByEnum( Common.Team.Team2 );

        public RelayCommand Team2Scored1 => new RelayCommand( Scored( Common.Team.Team2, 1 ), IsUnscored( 1 ) );
        public RelayCommand Team2Scored2 => new RelayCommand( Scored( Common.Team.Team2, 2 ), IsUnscored( 2 ) );
        public RelayCommand Team2Scored3 => new RelayCommand( Scored( Common.Team.Team2, 3 ), IsUnscored( 3 ) );
        public RelayCommand Team2Scored4 => new RelayCommand( Scored( Common.Team.Team2, 4 ), IsUnscored( 4 ) );
        public RelayCommand Team2Scored5 => new RelayCommand( Scored( Common.Team.Team2, 5 ), IsUnscored( 5 ) );
        public RelayCommand Team2Scored6 => new RelayCommand( Scored( Common.Team.Team2, 6 ), IsUnscored( 6 ) );
        public RelayCommand Team2Scored7 => new RelayCommand( Scored( Common.Team.Team2, 7 ), IsUnscored( 7 ) );
        public RelayCommand Team2Scored8 => new RelayCommand( Scored( Common.Team.Team2, 8 ), IsUnscored( 8 ) );
        public RelayCommand Team2Scored9 => new RelayCommand( Scored( Common.Team.Team2, 9 ), IsUnscored( 9 ) );
        public RelayCommand Team2Scored10 => new RelayCommand( Scored( Common.Team.Team2, 10 ), IsUnscored( 10 ) );
        public RelayCommand Team2Scored11 => new RelayCommand( Scored( Common.Team.Team2, 11 ), IsUnscored( 11 ) );
        public RelayCommand Team2Scored12 => new RelayCommand( Scored( Common.Team.Team2, 12 ), IsUnscored( 12 ) );
        public RelayCommand Team2Scored13 => new RelayCommand( Scored( Common.Team.Team2, 13 ), IsUnscored( 13 ) );
        public RelayCommand Team2Scored14 => new RelayCommand( Scored( Common.Team.Team2, 14 ), IsUnscored( 14 ) );
        public RelayCommand Team2Scored15 => new RelayCommand( Scored( Common.Team.Team2, 15 ), IsUnscored( 15 ) );

        public RelayCommand Team2Joker2x => new RelayCommand( UseJoker( Common.Team.Team2, Common.Joker.Double ), IsJokerUsed( Common.Team.Team2, Common.Joker.Double ) );
        public RelayCommand Team2JokerFuckOff => new RelayCommand( UseJoker( Common.Team.Team2, Common.Joker.FuckOff ), IsJokerUsed( Common.Team.Team2, Common.Joker.FuckOff ) );
        public RelayCommand Team2JokerReRoll => new RelayCommand( UseJoker( Common.Team.Team2, Common.Joker.ReRoll ), IsJokerUsed( Common.Team.Team2, Common.Joker.ReRoll ) );

        #endregion

        #region Team3

        public Data.Team Team3 => ProcessImage.Instance.GetTeamByEnum( Common.Team.Team3 );

        public RelayCommand Team3Scored1 => new RelayCommand( Scored( Common.Team.Team3, 1 ), IsUnscored( 1 ) );
        public RelayCommand Team3Scored2 => new RelayCommand( Scored( Common.Team.Team3, 2 ), IsUnscored( 2 ) );
        public RelayCommand Team3Scored3 => new RelayCommand( Scored( Common.Team.Team3, 3 ), IsUnscored( 3 ) );
        public RelayCommand Team3Scored4 => new RelayCommand( Scored( Common.Team.Team3, 4 ), IsUnscored( 4 ) );
        public RelayCommand Team3Scored5 => new RelayCommand( Scored( Common.Team.Team3, 5 ), IsUnscored( 5 ) );
        public RelayCommand Team3Scored6 => new RelayCommand( Scored( Common.Team.Team3, 6 ), IsUnscored( 6 ) );
        public RelayCommand Team3Scored7 => new RelayCommand( Scored( Common.Team.Team3, 7 ), IsUnscored( 7 ) );
        public RelayCommand Team3Scored8 => new RelayCommand( Scored( Common.Team.Team3, 8 ), IsUnscored( 8 ) );
        public RelayCommand Team3Scored9 => new RelayCommand( Scored( Common.Team.Team3, 9 ), IsUnscored( 9 ) );
        public RelayCommand Team3Scored10 => new RelayCommand( Scored( Common.Team.Team3, 10 ), IsUnscored( 10 ) );
        public RelayCommand Team3Scored11 => new RelayCommand( Scored( Common.Team.Team3, 11 ), IsUnscored( 11 ) );
        public RelayCommand Team3Scored12 => new RelayCommand( Scored( Common.Team.Team3, 12 ), IsUnscored( 12 ) );
        public RelayCommand Team3Scored13 => new RelayCommand( Scored( Common.Team.Team3, 13 ), IsUnscored( 13 ) );
        public RelayCommand Team3Scored14 => new RelayCommand( Scored( Common.Team.Team3, 14 ), IsUnscored( 14 ) );
        public RelayCommand Team3Scored15 => new RelayCommand( Scored( Common.Team.Team3, 15 ), IsUnscored( 15 ) );

        public RelayCommand Team3Joker2x => new RelayCommand( UseJoker( Common.Team.Team3, Common.Joker.Double ), IsJokerUsed( Common.Team.Team3, Common.Joker.Double ) );
        public RelayCommand Team3JokerFuckOff => new RelayCommand( UseJoker( Common.Team.Team3, Common.Joker.FuckOff ), IsJokerUsed( Common.Team.Team3, Common.Joker.FuckOff ) );
        public RelayCommand Team3JokerReRoll => new RelayCommand( UseJoker( Common.Team.Team3, Common.Joker.ReRoll ), IsJokerUsed( Common.Team.Team3, Common.Joker.ReRoll ) );

        #endregion

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
                NotifyPoint2WinChanged();
            };
        }

        private Action<object> UseJoker( Common.Team theTeam, Joker theJoker )
        {
            return _ =>
            {
                ProcessImage.Instance.GetTeamByEnum( theTeam ).JokerMap[theJoker] = false;
                NotifyPoint2WinChanged();
            };
        }

        private Func<object, bool> IsJokerUsed( Common.Team theTeam, Joker theJoker )
        {
            return _ => ProcessImage.Instance.GetTeamByEnum( theTeam ).JokerMap[theJoker];
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

            OnPropertyChanged( nameof( Team2Scored1.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored2.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored3.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored4.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored5.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored6.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored7.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored8.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored9.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored10.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored11.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored12.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored13.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored14.CanExecute ) );
            OnPropertyChanged( nameof( Team2Scored15.CanExecute ) );

            OnPropertyChanged( nameof( Team3Scored1.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored2.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored3.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored4.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored5.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored6.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored7.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored8.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored9.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored10.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored11.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored12.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored13.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored14.CanExecute ) );
            OnPropertyChanged( nameof( Team3Scored15.CanExecute ) );
        }

        private void NotifyPoint2WinChanged()
        {
            OnPropertyChanged( nameof( Team1Points2Win ) );
            OnPropertyChanged( nameof( Team3Points2Win ) );
            OnPropertyChanged( nameof( Team3Points2Win ) );
        }

        private void NotifyJokersChanged()
        {
            OnPropertyChanged( nameof( Team1Joker2x.CanExecute ) );
            OnPropertyChanged( nameof( Team1JokerFuckOff.CanExecute ) );
            OnPropertyChanged( nameof( Team1JokerReRoll.CanExecute ) );
            OnPropertyChanged( nameof( Team2Joker2x.CanExecute ) );
            OnPropertyChanged( nameof( Team2JokerFuckOff.CanExecute ) );
            OnPropertyChanged( nameof( Team2JokerReRoll.CanExecute ) );
            OnPropertyChanged( nameof( Team3Joker2x.CanExecute ) );
            OnPropertyChanged( nameof( Team3JokerFuckOff.CanExecute ) );
            OnPropertyChanged( nameof( Team3JokerReRoll.CanExecute ) );
        }
    }
}
