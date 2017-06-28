using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MvxLifeCycleTest.Droid
{
    [Activity(
        Label = "MvxLifeCycleTest.Droid"
        , MainLauncher = true
        , Icon = "@drawable/Icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
