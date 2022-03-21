using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IF2.Models;
using Xamarin.Forms;
using IF2.Services;
using XamEffects;
using SQLite;
using System.IO;
namespace IF2.Views
{


    public partial class LivePage : ContentPage
    {
        Label Label;
        
        public LivePage()
        {
            InitializeComponent();

            LiveService.AddLive("2022年3月19日（土）: ILLUSION FORCE presents「ILLUSION FORCE×GAUNTLET LONGSTAGE 'GACHINKO'2MAN GIG」", 20220319);
            LiveService.AddLive("2022年3月20日（日）Phantom Excaliver presents 聖剣フェス」", 202203020);
            LiveService.AddLive("2022年4月2日（土）Bad Company vol.17」", 20220402);
            LiveService.AddLive("2022年4月10日（日）VELL'z FIRE presents", 20220410);
            LiveService.AddLive("2022年4月10日（日）ILLUSION FORCE presents「ILLUSION FORCE×Amiliyah LONG STAGE 2MAN GIG」", 20220410);
            LiveService.AddLive("2022年4月29日（金・祝）渋谷メタル会 presents 渋谷メタル会フェス 2022」", 20220429);
            LiveService.AddLive("2022年5月15日（日）「タイトル未定」", 20220515);
            LiveService.AddLive("2022年6月11日（土)「梅雨前線ツアー2022 'Regan(SAISEIGA)札幌凱旋SP2days' DAY① Vol.145」", 20220611);
            LiveService.AddLive("2022年6月18日（土）MinstreliX presents「MinstreliX × ILLUSION FORCE 2MAN Show」（昼公演）", 20220618);
            LiveService.AddLive("2022年6月18日（土）MinstreliX presents「MinstreliX × ILLUSION FORCE 2MAN Show」（夜公演）", 20220618);
            LiveService.AddLive("2022年9月24日（土）「タイトル未定」", 20220924);
            var Lists = LiveService.db.Table<Live>().ToList();
            MainListView.ItemsSource = Lists;
            /*int dater = LiveService.date;
            if (dater <= Convert.ToInt32(DateTime.Now))
            {
                Label.TextDecorations = TextDecorations.Strikethrough;
            }*/
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
                case "2022年5月15日（日）「タイトル未定」":
                    await Navigation.PushAsync(new p515());
                    break;
                case "2022年6月11日（土)「梅雨前線ツアー2022 'Regan(SAISEIGA)札幌凱旋SP2days' DAY① Vol.145」":
                    await Navigation.PushAsync(new s611());
                    break;
                case "2022年6月18日（土）MinstreliX presents「MinstreliX × ILLUSION FORCE 2MAN Show」（昼公演）":
                    await Navigation.PushAsync(new h618());
                    break;
                case "2022年6月18日（土）MinstreliX presents「MinstreliX × ILLUSION FORCE 2MAN Show」（夜公演）":
                    await Navigation.PushAsync(new y618());
                    break;
                case "2022年9月24日（土）「タイトル未定」":
                    await Navigation.PushAsync(new d924());
                    break;
            }


        }




    }
}
