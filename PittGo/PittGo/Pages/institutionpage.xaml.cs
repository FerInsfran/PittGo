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

            Institution restaurant = new Institution

            {
            Description = "Places to go and eat",
            Name = "Restaurants",
            ImageURL = "https://image.flaticon.com/icons/png/512/242/242452.png",
        };
            this.Institutions.Add(restaurant);

            Institution Groceryoptions = new Institution

            {
                Description = "Places to go and eat",
                Name = "Restaurants",
                ImageURL = "https://image.flaticon.com/icons/png/512/242/242452.png",
            };
            this.Institutions.Add(Groceryoptions);

            Institution Gatheringoptions = new Institution

            {
                Description = "Places to go and eat",
                Name = "Restaurants",
                ImageURL = "https://image.flaticon.com/icons/png/512/242/242452.png",
            };
            this.Institutions.Add(Gatheringoptions);

            this.whatareyoulookingfor.ItemsSource = this.Institutions;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new country());
        }
    }
}