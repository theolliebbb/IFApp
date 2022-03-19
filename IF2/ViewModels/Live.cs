using System;

using Xamarin.Forms;

namespace IF2.ViewModels
{
    public class Live : ContentPage
    {
        private string date;
    public string Name { get; set; }
     public string Date { get; set; }
    public string Place { get; set; }
        public string Time { get; set; }

        public static implicit operator Live(ViewCell v)
        {
            throw new NotImplementedException();
        }
    }

}

