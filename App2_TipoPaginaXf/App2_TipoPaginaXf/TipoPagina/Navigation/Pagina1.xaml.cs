using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXf.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());
        }

        private void ChamarModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void ChamarMaster(object sender, EventArgs e)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}