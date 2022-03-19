using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace IF2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var button = (MenuItem)sender;
            var url = button.ClassId;

            await Browser.OpenAsync(url);
        }

    }
}
