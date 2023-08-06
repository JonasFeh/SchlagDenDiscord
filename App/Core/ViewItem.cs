using System;
using System.Windows.Controls;

namespace SchlagDenDiscord.Core.Core
{
    public abstract class ViewItem<TViewModel, TModel> : ViewItem
        where TViewModel : ViewModelBase<TModel>, new()
        where TModel : ModelBase, new() 
    {

        public override TModel Model => new TModel();

        public override TViewModel ViewModel => new TViewModel();

    }

    public abstract class ViewItem
    {
        public static Guid Id { get; }

        public abstract ViewModelBase ViewModel { get; }

        public abstract ModelBase Model { get; }

        public abstract UserControl View { get; }


        public virtual void OnStartup()
        {
            Model.OnStartup();
            ViewModel.OnStartup();
        }

        public virtual void OnShutdown()
        {
            Model.OnShutdown();
            ViewModel.OnShutdown();
        }
    }
}
