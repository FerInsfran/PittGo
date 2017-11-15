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

        public institutionpage(String country)
        {
            InitializeComponent();
            this.Institutions = new ObservableCollection<Institution>();

            Institution RESTAURANTS = new Institution
        

            {
            Description = "Places to go and eat",
            Name = "Restaurants",
            ImageURL = "https://image.flaticon.com/icons/png/512/242/242452.png",
        };
            this.Institutions.Add(RESTAURANTS);

            Institution GROCERIES = new Institution

            {
                Description = "Make your food healthy and tasty",
                Name = "Groceries",
                ImageURL = "https://image.freepik.com/free-vector/shopping-basket-full-of-healthy-organic-fresh-food_3446-152.jpg",
            };
            this.Institutions.Add(GROCERIES);

            Institution GATHERINGS = new Institution

            {
                Description = "Places to visit",
                Name = "Entertainment places",
                ImageURL = "http://cdn.mysitemyway.com/etc-mysitemyway/icons/legacy-previews/icons/simple-red-square-icons-sports-hobbies/129787-simple-red-square-icon-sports-hobbies-masks-sc37.png",
            };
            this.Institutions.Add(GATHERINGS);
            this.Institutionlistview.ItemsSource = this.Institutions;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new country());
        }

        private void TapGestureRecognizer_Tapped_RESTAURANTS(object sender, EventArgs e)
        {
            GlobalConfig.MobileService.GetTable<Institution>();
            List<Institution> databaserestaurants = GlobalConfig.MobileService.GetTable<RESTAURANTS>().Where(rec => true).TolistAsync;
            this.Institutions = new ObservableCollection<Institution>(databaseinstitutions);
        }

        private void TapGestureRecognizer_Tapped_GROCERIES(object sender, EventArgs e)
        {

        }
        private void TapGestureRecognizer_Tapped_GATHERINGS(object sender, EventArgs e)
        {

        }

    }
}