using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PittGo.Classes;
namespace PittGo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }
       

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private async void LogInButton_Clicked(object sender, EventArgs e)
        {
           
                List<User> users = await GlobalConfig.MobileService.GetTable<User>().Where(rec => rec.EmailAddress == email.Text && rec.Password == password.Text).ToListAsync();
                if (users.Count == 1)
                {
                    GlobalConfig.LoggedInUser = users.First();
                
                   Settings.UserData = users.First();

                Navigation.PushAsync(new country());
                }
                else
                {
                    DisplayAlert("Error", "Invalid Credentials", "Ok");
                }


            }
        }
    }

