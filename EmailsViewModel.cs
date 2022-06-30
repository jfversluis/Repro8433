using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp8
{
    public partial class EmailsViewModel : ObservableObject
    {
        public ObservableCollection<EmailViewModel> FilteredEmails { get; set; } = new ObservableCollection<EmailViewModel>
        {
            new EmailViewModel
            {
                Email = new Email
                {
                    Recipient = "Mobycorp"
                }
            },
            new EmailViewModel
            {
                Email = new Email
                {
                    Recipient = "Gerald"
                }
            },
        };
    }
}
