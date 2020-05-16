using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXf.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}