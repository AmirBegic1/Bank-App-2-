using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Registration());
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

        public static int finalni_balans { get; set; }

        public static string Ime_Prezime { get; set; }
    }
}
