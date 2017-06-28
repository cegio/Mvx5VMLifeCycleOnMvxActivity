using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;

namespace MvxLifeCycleTest.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : ActivityBase
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
        }

        public override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
        }

       
    }
}
