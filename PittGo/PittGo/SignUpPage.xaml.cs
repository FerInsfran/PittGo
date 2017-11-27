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

            
        }

        private async void UpdateButton_Clicked(object sender, EventArgs e)
        {

            User userToSave = new User();

            userToSave.EmailAddress = email.Text;
            userToSave.Password = password.Text; 




           

            email.Text = "";
            password.Text = "";

            


            

         

            Navigation.PushAsync(new country());
        }
    }
}