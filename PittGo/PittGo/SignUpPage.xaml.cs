using PittGo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PittGo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();

            if (Settings.UserData != null)
            {
                this.email.text = Settings.UserData.EmailAddress;
                this.password.text = Settings.UserData.Password;
            }
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            User userToSave = new User();
            userToSave.EmailAddress = this.email.Text;
            userToSave.Password = this.password.Text;

            // Save User to Azure



            Settings.UserData = userToSave;

            //GlobalConfig.LoggedInUser = userToSave;

            Navigation.PushAsync(new country());
        }
    }
}