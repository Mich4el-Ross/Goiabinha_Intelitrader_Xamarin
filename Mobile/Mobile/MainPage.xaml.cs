using Mobile.API;
using Mobile.View;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Add_New_User(object sender, EventArgs e)
        {

            if (CrossConnectivity.Current.IsConnected)
            {
                await Navigation.PushAsync(new AddUser());
            }
            else
            {
                DisplayAlert("Oops", "You're not connected to internet", "Gotcha!");
            }
        }

        private async void Show_All_Users(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                await Navigation.PushAsync(new ShowUsers());
            }
            else
            {
                DisplayAlert("Oops", "You're not connected to internet", "Gotcha!");
            }

        }

    }
}
