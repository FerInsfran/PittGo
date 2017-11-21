using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PittGo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            //todo:
            //1. hide password
            //2. Log Out Button in Country page
            //3. make the entry larger in sign up page

            // Grabbing the user off the phone to see if they are logged in
            if (Settings.UserData != null)
            {
                GlobalConfig.LoggedInUser = Settings.UserData;
            }

            // This is the case when the user is logged in
            if (GlobalConfig.LoggedInUser != null)
            {
                MainPage = new NavigationPage(new country());

                // Navigation.PushAsync(new country());
            }
            // This is the case where the user is not logged in
            else
            {
                // redirect to a login page, that has a button that takes you to a page to create an account

                MainPage = new NavigationPage(new MainPage());

            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
