using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenApp.Data;
using System.IO;

namespace ExamenApp
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public static SQLiteHelper SqliteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lugares.db3"));
                }
                return db;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
