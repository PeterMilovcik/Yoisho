using System.Threading.Tasks;
using Yoisho.Services.Dialog;
using Yoisho.Services.Navigation;
using Yoisho.Services.Preference;
using Yoisho.Services.Repository;

namespace Yoisho.ViewModels
{
    public class ViewModel : Observable
    {
        public ViewModel()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
            DialogService = ViewModelLocator.Resolve<IDialogService>();
            RepositoryService = ViewModelLocator.Resolve<IRepositoryService>();
            PreferenceService = ViewModelLocator.Resolve<IPreferenceService>();
        }

        protected INavigationService NavigationService { get; }
        protected IDialogService DialogService { get; }
        protected IRepositoryService RepositoryService { get; }
        protected IPreferenceService PreferenceService { get; }

        public virtual Task Initialize(object parameter) => Task.CompletedTask;
    }

}
