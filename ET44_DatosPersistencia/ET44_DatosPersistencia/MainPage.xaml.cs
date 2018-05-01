using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ET44_DatosPersistencia
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            botonGuardar.Clicked += BotonGuardar_Clicked;
            botonSuscribirse.Clicked += BotonSuscribirse_Clicked;
            botonPagina2.Clicked += BotonPagina2_Clicked;
		}

        private async void BotonPagina2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }

        private void BotonSuscribirse_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<ContentPage, string>(this, nombreCentroMensaje.Text, (pagina, arg) =>
            {
                datosMensaje.Text = arg;
            });
        }

        private void BotonGuardar_Clicked(object sender, EventArgs e)
        {
            App.Current.Properties[nombreClave.Text] = textoClave.Text;
        }
    }
}
