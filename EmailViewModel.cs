using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiApp8
{
    public partial class EmailViewModel : ObservableObject
    {

        [ObservableProperty]
        private Email _email;
    }
}
