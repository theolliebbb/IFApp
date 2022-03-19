using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IF2.ViewModels;
using Xamarin.Forms;
using XamEffects;
namespace IF2.Views
{


    public partial class LivePage : ContentPage
    {

        Label Label;
        public LivePage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<Live>


            {
                new Live
                {
                    Name = "2022年3月19日（土）: ILLUSION FORCE presents「ILLUSION FORCE×GAUNTLET LONGSTAGE 'GACHINKO'2MAN GIG」",
                    Date = "2015, 12, 12",

                },

            new Live
                {
                Name = "2022年3月20日（日）Phantom Excaliver presents 聖剣フェス」",

               },
            new Live
                {
                Name = "2022年4月2日（土）Bad Company vol.17」",

               },
            new Live
                {
                Name = "2022年4月10日（日）VELL'z FIRE presents",

               },
            new Live
                {
                Name = "2022年4月10日（日）ILLUSION FORCE presents「ILLUSION FORCE×Amiliyah LONG STAGE 2MAN GIG」",

               },
            new Live
                {
                Name = "2022年4月29日（金・祝）渋谷メタル会 presents 渋谷メタル会フェス 2022」",

               }

           };


        }


        private void ViewCell_Tapped(object sender, System.EventArgs e)
        {
            var viewCell = (ViewCell)sender;
            viewCell.View.BackgroundColor = Color.Transparent;

        }


        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Live;
            ((ListView)sender).SelectedItem = null;

            switch (Selected.Name)
            {
                case "2022年3月19日（土）: ILLUSION FORCE presents「ILLUSION FORCE×GAUNTLET LONGSTAGE 'GACHINKO'2MAN GIG」":
                    await Navigation.PushAsync(new Live1());
                    break;
                case "2022年3月20日（日）Phantom Excaliver presents 聖剣フェス」":
                    await Navigation.PushAsync(new Phantom());
                    break;
                case "2022年4月2日（土）Bad Company vol.17」":
                    await Navigation.PushAsync(new Bad());
                    break;
                case "2022年4月10日（日）VELL'z FIRE presents":
                    await Navigation.PushAsync(new Vell());
                    break;
                case "2022年4月10日（日）ILLUSION FORCE presents「ILLUSION FORCE×Amiliyah LONG STAGE 2MAN GIG」":
                    await Navigation.PushAsync(new Ami());
                    break;
                case "2022年4月29日（金・祝）渋谷メタル会 presents 渋谷メタル会フェス 2022」":
                    await Navigation.PushAsync(new Kai());
                    break;
            }


        }




    }
}
