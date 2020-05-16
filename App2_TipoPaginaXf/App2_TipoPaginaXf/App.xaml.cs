using System;
using App2_TipoPaginaXf.TipoPagina.Carousel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXf
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoPagina3();
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
