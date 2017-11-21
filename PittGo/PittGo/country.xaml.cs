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
    public partial class country : ContentPage
    {
        public country()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_INDIA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("INDIA"));
        }

        private void TapGestureRecognizer_Tapped_PARAGUAY(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("PARAGUAY"));
        }

        private void TapGestureRecognizer_Tapped_CHINA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("CHINA"));
        }

        private void TapGestureRecognizer_Tapped_SAUDIARABIA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("SAUDIARABIA"));
        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(new SignUpPage());
        }
    }
}