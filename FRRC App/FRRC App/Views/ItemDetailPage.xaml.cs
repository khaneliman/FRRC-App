using Fox_River_Racing_Club_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Fox_River_Racing_Club_App.Views
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