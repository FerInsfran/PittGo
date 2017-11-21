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
            Navigation.PushAsync(new institutionpage("C1D9BBC5-BFAD-4A06-BF4A-37D588A3E154"));
        }

        private void TapGestureRecognizer_Tapped_PARAGUAY(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("85FAFB94-775C-4121-B9EF-F9457C34D571"));
        }

        private void TapGestureRecognizer_Tapped_CHINA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("670307E1-7609-4C5B-AE43-5532E3BC64DB"));
        }

        private void TapGestureRecognizer_Tapped_SAUDIARABIA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new institutionpage("F9D1B7E3-683B-4351-B8F5-0975A17EBF9E"));
        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(new SignUpPage());
        }
    }
}