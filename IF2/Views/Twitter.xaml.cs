using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IF2.ViewModels;
using Xamarin.Forms;

namespace IF2.Views
{
    public partial class Twitter : ContentPage
    {
        public Twitter()
        {
            InitializeComponent();
            webView.Source = "https://twitter.com/illusionforce";
        }
        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        void OnForwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }
    }
}