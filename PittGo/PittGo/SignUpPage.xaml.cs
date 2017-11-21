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
         

        

           

            await GlobalConfig.MobileService.GetTable<User>().InsertAsync(userToSave);

            email.Text = "";
            password.Text = "";

            


            

            GlobalConfig.LoggedInUser = userToSave;

            Navigation.PushAsync(new country());
        }
    }
}