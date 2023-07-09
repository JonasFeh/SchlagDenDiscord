using App.MVVM.TopBar;
using App.Registries;
using FinanceOverviewApp.Core;
using System;

namespace App.MVVM.Main
{
    class MainViewModel : ViewModelBase<MainModel>
    {
        public TopBarViewModel TopBarVM { get; set; }


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
            TopBarVM = new TopBarViewModel();
        }
    }
}
