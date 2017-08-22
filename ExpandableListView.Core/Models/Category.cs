using MvvmCross.Core.ViewModels;

namespace ExpandableListView
{
    public class Category : MvxObservableCollection<Contact>
    {
        public string Title { get; set; }

        public Category(string title)
        {
            Title = title;
        }
    }
}
