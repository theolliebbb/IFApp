using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace IF2.Views
{
    public partial class Phantom : ContentPage
    {
        public Phantom()
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
            await Launcher.OpenAsync("http://maps.apple.com/?q=Kichijoji+Club+Citta");
        }
        else if (Device.RuntimePlatform == Device.Android)
        {
            // open the maps app directly
            await Launcher.OpenAsync("https://www.google.com/maps/place/Club+Citta/@35.5278298,139.6950911,17z/data=!3m2!4b1!5s0x601860a248ca51a3:0xdb78b1e2f569f40!4m5!3m4!1s0x601860a236dad971:0x619e27edcd68ea63!8m2!3d35.5278298!4d139.6972798");
        }
    }
}
}
