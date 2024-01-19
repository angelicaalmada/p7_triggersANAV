using p7_triggersANAV.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace p7_triggersANAV.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCategoria : ContentPage
    {
        public PaginaCategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}