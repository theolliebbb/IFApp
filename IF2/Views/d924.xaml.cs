using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace IF2.Views
{
    public partial class d924 : ContentPage
    {
        public d924()
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
            await SendEmail("9月２４日のライブ注文", message, email);


        }


        private async void Map_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                await Launcher.OpenAsync("http://maps.apple.com/?q=Sendai+Macana");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // open the maps app directly
                await Launcher.OpenAsync("https://www.google.com/maps/place/Sendai+MACANA/@38.25924,140.8699328,17z/data=!3m2!4b1!5s0x5f8a28161861fb97:0x22c373d27cc9fb70!4m5!3m4!1s0x5f8a283c35591195:0x75468340cdbc7b0!8m2!3d38.2592358!4d140.8721215");
            }
        }
    }
}
