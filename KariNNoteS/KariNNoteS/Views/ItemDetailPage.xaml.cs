using KariNNoteS.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KariNNoteS.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}