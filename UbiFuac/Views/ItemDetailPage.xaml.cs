using System.ComponentModel;
using Xamarin.Forms;
using UbiFuac.ViewModels;

namespace UbiFuac.Views
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