using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace IF2.Views
{
    public partial class y618 : ContentPage
    {
        public y618()
        {
            InitializeComponent();
        }




        private async void Website_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;

            await Browser.OpenAsync(url);
        }

        private async Task SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,

                    //Cc = ccRecipients,
                    //Bcc = bccRecipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }
        }
        private async void Email_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;
            var email = new List<string>()
            {
                "official.illusionforce@gmail.com"
            };
            string message = "名前:";
            ;
            await SendEmail("6月１８日のライブ注文", message, email);


        }


        private async void Map_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?q=osaka+shovel");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/Bigtwin+Diner+SHOVEL/@34.6697319,135.4975886,17z/data=!3m1!4b1!4m5!3m4!1s0x6000e713d05d3207:0xe3854900c03882f2!8m2!3d34.6697275!4d135.4997773");
            }
        }
    }
}
