using IF2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace IF2.Services
{
    public static class LiveService
    {
        public static SQLiteConnection db;

        static void Init()
        {
            
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lives.db3");

            db = new SQLiteConnection(databasePath);
            db.DropTable<Live>();
            db.CreateTable<Live>();
        }

        public static void AddLive(string name, int date)
        {
            Init();
         
            var live = new Live
            {
                Name = name,
                Date = date,
                
            };

            var id = db.Insert(live);
        }
        public static void GetProperties()
        {
            Init();
            var Lists = db.Table<Live>().ToList();
        }




    }
}