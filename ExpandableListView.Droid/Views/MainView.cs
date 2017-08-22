using Android;
using Android.App;
using Android.OS;
using ExpandableListView.ViewModels;
using MvvmCross.Droid.Views;

namespace ExpandableListView.Droid.Views
{
    [Activity(Theme = "@style/Theme.Splash")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
        protected override void OnResume()
        {
            base.OnResume();

            (ViewModel as MainViewModel).Init();
        }
    }
}
