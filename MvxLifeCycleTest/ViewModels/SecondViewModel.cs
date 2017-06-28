using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace MvxLifeCycleTest.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public SecondViewModel()
        {
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }
        public IMvxCommand CloseCommand => new MvxCommand(DoClose);
        private void DoClose()
        {
            Close(this);
        }

        public override void Appearing()
        {
            base.Appearing();
            MvxTrace.Trace("SecondViewModel Appearing");
        }

        public override void Appeared()
        {
            base.Appeared();
            MvxTrace.Trace("SecondViewModel Appeared");

        }

        public override void Disappearing()
        {
            base.Disappearing();
            MvxTrace.Trace("SecondViewModel Disappearing");

        }

        public override void Disappeared()
        {
            base.Disappeared();
            MvxTrace.Trace("SecondViewModel Disappeared");

        }
    }
}