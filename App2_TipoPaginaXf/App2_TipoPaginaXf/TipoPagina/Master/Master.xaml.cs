using System;
using App2_TipoPaginaXf.TipoPagina.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXf.TipoPagina.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Pagina1());
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            Detail = new Pagina2();
        }

        private void MudarPagina3(object sender, EventArgs e)
        {
            Detail = new Conteudo();
        }
    }
}