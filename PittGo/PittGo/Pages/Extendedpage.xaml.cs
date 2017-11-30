using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PittGo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Extendedpage : ContentPage
    {
        public Extendedpage(Institution item)
        {
            InitializeComponent();
            this.MapImage.Source = item.ImageURL;
            this.nameLabel.Text = item.Name;
            this.describtionLabel.Text = item.Description;
        }
    }
}