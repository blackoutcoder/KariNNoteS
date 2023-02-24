using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KariNNoteS.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("roman.repic@optilon.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}