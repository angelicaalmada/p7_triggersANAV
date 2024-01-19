using p7_triggersANAV.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace p7_triggersANAV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
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
