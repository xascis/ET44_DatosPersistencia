using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ET44_DatosPersistencia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();

            botonLeer.Clicked += BotonLeer_Clicked;
            botonEnviarMensaje.Clicked += BotonEnviarMensaje_Clicked;
		}

        private void BotonEnviarMensaje_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<ContentPage, string>(this, nombreCentroMensaje.Text, datosMensaje.Text);
        }

        private void BotonLeer_Clicked(object sender, EventArgs e)
        {
            if (App.Current.Properties.ContainsKey(nombreClave.Text))
            {
                textoClave.Text = (string)App.Current.Properties[nombreClave.Text];
            } else
            {
                textoClave.Text = "La clave no existe";
            }
        }
    }
}