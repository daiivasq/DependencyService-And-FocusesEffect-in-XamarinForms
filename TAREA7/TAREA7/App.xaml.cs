using System;
using TAREA7.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TAREA7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
