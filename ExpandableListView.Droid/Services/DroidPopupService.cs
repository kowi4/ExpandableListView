
using Android.Widget;
using ExpandableListView.Core;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace ExpandableListView.Droid.Services
{
    class DroidPopupService : IPopupService
    {
        public void Show(string message)
        {
            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
            Toast.MakeText(activity, message, ToastLength.Short).Show();
        }
    }
}