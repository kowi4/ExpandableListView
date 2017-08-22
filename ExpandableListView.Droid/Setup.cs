using Android.Content;
using ExpandableListView.Core;
using ExpandableListView.Droid.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace ExpandableListView.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override void InitializePlatformServices()
        {
            base.InitializePlatformServices();
            Mvx.RegisterType<IPopupService, DroidPopupService>();
        }
    }
}
