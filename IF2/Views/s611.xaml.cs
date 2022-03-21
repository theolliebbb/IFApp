using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace IF2.Views
    {
        public partial class s611 : ContentPage
        {
            public s611()
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
                await SendEmail("6月１１日のライブ注文", message, email);


            }


            private async void Map_Clicked(object sender, EventArgs e)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    // https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                    await Launcher.OpenAsync("http://maps.apple.com/?q=sapporo+crazy+monkey");
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    // open the maps app directly
                    await Launcher.OpenAsync("https://www.google.com/maps/place/%E6%9C%AD%E5%B9%8CCrazy+Monkey/@43.053084,141.3526263,3a,75y,90t/data=!3m8!1e2!3m6!1sAF1QipMlOA_4LPqNVZrnSaVVLhCB7I-MAtEt_Ca43TeX!2e10!3e12!6shttps:%2F%2Flh5.googleusercontent.com%2Fp%2FAF1QipMlOA_4LPqNVZrnSaVVLhCB7I-MAtEt_Ca43TeX%3Dw152-h86-k-no!7i3840!8i2160!4m5!3m4!1s0x5f0b29866c7e21bb:0x6a34702e630d5905!8m2!3d43.0528788!4d141.3526787");
                }
            }
        }
    }

