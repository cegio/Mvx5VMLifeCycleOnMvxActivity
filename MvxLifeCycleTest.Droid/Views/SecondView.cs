using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvxLifeCycleTest.Droid.Views
{
    [Activity(Label = "View for SecondView")]
    public class SecondView : ActivityBase
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}