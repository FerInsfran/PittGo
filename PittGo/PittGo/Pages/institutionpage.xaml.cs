using PittGo.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PittGo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class institutionpage : ContentPage
    {
        public ObservableCollection<Institution> Institutions { get; set; }
        public string countrycode;

        public institutionpage(String country)
        {
            InitializeComponent();
            this.Institutions = new ObservableCollection<Institution>();
            countrycode = country;
           

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new country());
        }

        private async void TapGestureRecognizer_Tapped_RESTAURANTS(object sender, EventArgs e)
        {
           
            List<Institution> databaserestaurants = await GlobalConfig.MobileService.GetTable<Institution>().Where(rec => rec.type=="RESTAURANTS" && rec.CountryID==countrycode).ToListAsync();
            this.Institutions = new ObservableCollection<Institution>(databaserestaurants);
            Institutionlistview.ItemsSource = this.Institutions;
        }

        private async void TapGestureRecognizer_Tapped_GROCERIES(object sender, EventArgs e)
        {
            List<Institution> databaserestaurants = await GlobalConfig.MobileService.GetTable<Institution>().Where(rec => rec.type == "GROCERIES" && rec.CountryID == countrycode).ToListAsync();
            this.Institutions = new ObservableCollection<Institution>(databaserestaurants);
            Institutionlistview.ItemsSource = this.Institutions;
        }
        private async void TapGestureRecognizer_Tapped_GATHERINGS(object sender, EventArgs e)
        {
            List<Institution> databaserestaurants = await GlobalConfig.MobileService.GetTable<Institution>().Where(rec => rec.type == "GATHERINGS" && rec.CountryID == countrycode).ToListAsync();
            this.Institutions = new ObservableCollection<Institution>(databaserestaurants);
            Institutionlistview.ItemsSource = this.Institutions;
        }

        private void Institutionlistview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            Institution selectedinstitution = e.SelectedItem as Institution;
            (sender as ListView).SelectedItem = null;
            Navigation.PushAsync(new Extendedpage(selectedinstitution));
        } 

       
    }
}