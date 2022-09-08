using PrimeiroApp.Services;
using PrimeiroApp.Views;
using PrimeiroApp.Views.SqlIte;
using PrimeiroApp.Views.Testes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeiroApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = pagina que vai iniciar 
            //todo app precisa de uma mainpage
            //MainPage = new AppShell();

            MainPage = new ClienteView();

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
