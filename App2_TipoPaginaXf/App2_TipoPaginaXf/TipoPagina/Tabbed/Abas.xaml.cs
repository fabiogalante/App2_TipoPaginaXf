using App2_TipoPaginaXf.TipoPagina.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_TipoPaginaXf.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new Pagina1())
            {
                Title = "titulo 3 teste pag. 1"
            });

        }
    }
}