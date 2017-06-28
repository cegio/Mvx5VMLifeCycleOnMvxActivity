using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace MvxLifeCycleTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxAsyncCommand GoToSecondViewModelCommand => new MvxAsyncCommand(DoGoToSecondViewModel);
        private async Task DoGoToSecondViewModel()
        {
            await _navigationService.Navigate<SecondViewModel>();
        }

        public override void Appearing()
        {
            base.Appearing();
            MvxTrace.Trace("MainViewModel Appearing");
        }

        public override void Appeared()
        {
            base.Appeared();
            MvxTrace.Trace("MainViewModel Appeared");

        }

        public override void Disappearing()
        {
            base.Disappearing();
            MvxTrace.Trace("MainViewModel Disappearing");

        }

        public override void Disappeared()
        {
            base.Disappeared();
            MvxTrace.Trace("MainViewModel Disappeared");

        }
    }
}