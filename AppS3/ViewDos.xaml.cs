using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        public ViewDos(string usuario, string clave)
        {
            InitializeComponent();

            lblusuario.Text = usuario;
            lblclave.Text = clave;

            txtusuario.Text = usuario;
            txtclave.Text = clave;
        }
    }
}