using MvvmCross.Platform.IoC;
using MvvmCross.Platform;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using MvxLifeCycleTest.Core.ViewModels;

namespace MvxLifeCycleTest.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }

    public class AppStart : IMvxAppStart

    {

        private readonly IMvxNavigationService _navigationService;


        public AppStart(IMvxNavigationService navigationService)

        {

            _navigationService = navigationService;

        }



        public void Start(object hint = null)

        {

            try

            {

                _navigationService.Navigate<MainViewModel>();

            }

            catch (Exception e)

            {

            }
        }
    }
}
