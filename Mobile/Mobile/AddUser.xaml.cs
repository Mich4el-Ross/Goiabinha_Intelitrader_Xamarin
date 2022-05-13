using Mobile.API;
using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUser : ContentPage
    {

        public List<User> UserList;

        public AddUser()
        {
            InitializeComponent();

            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#000000");
        }

        public bool Validate_Fields()
        {
            if (string.IsNullOrEmpty(txtFirstname.Text) && string.IsNullOrEmpty(txtAge.Text) ) {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clean_User_Form()
        {
            txtFirstname.Text = "";
            txtSurname.Text = "";
            txtAge.Text = "";
        }

        private async void Add_User_To_List(object sender, EventArgs e)
        {
            if (Validate_Fields())
            {
                User user = new User
                {
                    Id        = new Guid(),
                    FirstName = txtFirstname.Text.Trim(),
                    SurName = txtSurname.Text.Trim(),
                    Age = Convert.ToInt32(txtAge.Text),
                    CreationDate = DateTime.Now
                };

                try
                {
                    await ApiService.AddNewUser(user);
                    Clean_User_Form();
                    DisplayAlert("Uhul", "User added successfully", "Gotcha!");
                } 
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "close");
                }

            } else
            {
                DisplayAlert("Oops", "Check if all fields are filled in\nCheck if Firstname has at least 5 characters", "close");
            }
        }
    }
}