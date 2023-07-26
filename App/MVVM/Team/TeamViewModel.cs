using SchlagDenDiscord.Core.Core;

namespace App.MVVM.Team
{
    internal class TeamViewModel : ViewModelBase<TeamModel>
    {
        private Data.Team m_Team;

        public Data.Team Team => m_Team;

        public TeamViewModel()
        {
            m_Team = new Data.Team();
        }
    }
}
