using System;

using Xamarin.Forms;

namespace IF2.ViewModels
{
    public class LiveVM : ContentPage
    {
        public LiveVM()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

