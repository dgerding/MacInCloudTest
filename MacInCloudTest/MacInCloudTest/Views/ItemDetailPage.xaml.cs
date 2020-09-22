using System.ComponentModel;
using Xamarin.Forms;
using MacInCloudTest.ViewModels;

namespace MacInCloudTest.Views
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