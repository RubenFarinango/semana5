using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                var parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("codigo", txtCodigo.Text);
                parameters.Add("nombre", txtNombre.Text);
                parameters.Add("apellido", txtApellido.Text);
                parameters.Add("edad", txtEdad.Text);
                client.UploadValues("http://192.168.21.145/uisrael2023/post.php", "POST", parameters);
             }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "cerrar");
            }
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }

}