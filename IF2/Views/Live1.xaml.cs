using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace IF2.Views
{
    public partial class Live1 : ContentPage
    {
        public Live1()
        {
            InitializeComponent();
        }




        private async void Website_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;

            await Browser.OpenAsync(url);
        }

        private async void Map_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?q=Shinjuku+Wildside");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/Wild+Side/@35.6912743,139.7086745,17z/data=!3m1!4b1!4m5!3m4!1s0x60188cc2b284a753:0x1831a91c05836290!8m2!3d35.6912743!4d139.7108632");
            }
        }
    }
}
