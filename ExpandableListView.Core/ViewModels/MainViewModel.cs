using ExpandableListView.Core;
using MvvmCross.Core.ViewModels;

namespace ExpandableListView.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public override void Start()
        {
            //TODO: Add starting logic here
        }

        private IPopupService popupService;

        private MvxObservableCollection<Category> contacts;
        public MvxObservableCollection<Category> Contacts
        {
            get { return contacts; }
            set
            {
                SetProperty(ref contacts, value);
            }
        }

        private IMvxCommand showToast;
        public IMvxCommand ShowToast
        {
            get
            {
                if (showToast == null)
                {
                    showToast = new MvxCommand<Contact>((contact) =>
                    {
                        popupService.Show(contact.Name);
                 
                    });
                }

                return showToast;
            }
        }

        public MainViewModel(IPopupService popupService)
        {
            this.popupService = popupService;
            Init();
        }

        public void Init()
        {

            Contacts = new MvxObservableCollection<Category>();
            Contacts.Add(new Category("Title of first category"));
            for (int i = 0; i < 4; i++)
            {
                Contacts[0].Add(new Contact(string.Format("My Contact {0}", i + 1),
                                              "fake_email@gmail.com",
                                              "+48 123 123 123"));
            }
            Contacts.Add(new Category("Title of second category"));
            for (int i = 4; i < 8; i++)
            {
                Contacts[1].Add(new Contact(string.Format("My Contact {0}", i + 1),
                                              "fake_email@gmail.com",
                                              "+48 123 123 123"));
            }
            Contacts.Add(new Category("Title of third category"));
            for (int i = 8; i < 11; i++)
            {
                Contacts[2].Add(new Contact(string.Format("My Contact {0}", i + 1),
                                              "fake_email@gmail.com",
                                              "+48 123 123 123"));
            }
        }
    }
}