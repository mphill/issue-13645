using System.ComponentModel;
using Xamarin.Forms;
using Issue_13645.ViewModels;

namespace Issue_13645.Views
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