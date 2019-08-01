using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataCards
{
    public partial class App : Application
    {
        public static string DbPath { get; private set; }

        public App()
        {
            InitializeComponent();

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            string dbName = "data-cards.db";
            DbPath = Path.Combine(folderPath, dbName);

            MainPage = new NavigationPage(new DataCardIndex());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
