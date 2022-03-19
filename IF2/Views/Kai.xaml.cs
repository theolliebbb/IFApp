using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace IF2.Views
{
    public partial class Kai : ContentPage
    {
        public Kai()
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
                await Launcher.OpenAsync("http://maps.apple.com/?q=Shibuya+Cyclone");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/SHIBUYA+CYCLONE/@35.6614585,139.6963442,17z/data=!3m1!4b1!4m5!3m4!1s0x60188d9350879a63:0xcfa251f14a6e75df!8m2!3d35.6614585!4d139.6985329");
            }
        }
    }
}