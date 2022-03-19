using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace IF2.Views
{
    public partial class Vell : ContentPage
    {
        public Vell()
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
                await Launcher.OpenAsync("http://maps.apple.com/?q=Kichijoji+Crescendo");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/Crescendo/@35.704622,139.5833563,17z/data=!3m1!4b1!4m6!3m5!1s0x6018ee3f66125475:0x37c05c19f0834148!8m2!3d35.7045469!4d139.5855052!16s%2Fg%2F1tgkh9vm");
            }
        }
    }
}
