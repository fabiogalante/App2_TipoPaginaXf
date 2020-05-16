using App2_TipoPaginaXf.TipoPagina.Carousel;
using Xamarin.Forms;

namespace App2_TipoPaginaXf
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IntroducaoApp();
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
