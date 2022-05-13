using Mobile.API;
using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowUsers : ContentPage
    {
        public List<User> UserListData;

        public ShowUsers()
        {
            InitializeComponent();
            UserListData = new List<User>();
            UserListView.ItemTemplate = new DataTemplate(typeof(UserCell));
            UserListView.RowHeight    = 170;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#000000");

        }

        public async void LoadUsers()
        {
            UserListData = await ApiService.GetUsers();
            UserListView.ItemsSource = UserListData.OrderBy(x => x.Id).ToList();
        }

        public void Update_Users_List(Object sender, EventArgs e) 
        {
            LoadUsers();
            DisplayAlert("", "User list updated successfully", "Close");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadUsers();
        }

    }
}