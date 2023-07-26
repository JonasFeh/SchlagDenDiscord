using SchlagDenDiscord.Core.Core;
using System.Windows.Input;

namespace App.MVVM.Setup
{
    internal class SetupViewModel : ViewModelBase<SetupModel>
    {
        #region AddNewTeam

        private RelayCommand m_AddNewTeam;

        public ICommand AddNewTeam
        {
            get
            {
                if ( m_AddNewTeam == null )
                {
                    m_AddNewTeam = new RelayCommand( _ => addNewTeam() );
                }
                return m_AddNewTeam;
            }
        }

        private void addNewTeam()
        {
            
        }

        #endregion

        #region DeleteExistingTeam

        private RelayCommand m_DeleteExistingTeam;

        public ICommand DeleteExistingTeam
        {
            get
            {
                if ( m_DeleteExistingTeam == null )
                {
                    m_DeleteExistingTeam = new RelayCommand( _ => deleteExistingTeam() );
                }
                return m_DeleteExistingTeam;
            }
        }

        private void deleteExistingTeam()
        {

        }

        #endregion
    }
}
