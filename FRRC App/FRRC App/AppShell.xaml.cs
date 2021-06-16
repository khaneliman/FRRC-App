using Fox_River_Racing_Club_App.ViewModels;
using Fox_River_Racing_Club_App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fox_River_Racing_Club_App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
