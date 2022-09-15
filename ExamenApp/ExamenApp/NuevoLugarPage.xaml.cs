using ExamenApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoLugarPage : ContentPage
    {
        public NuevoLugarPage()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Lugar lugar = new Lugar { 
                    Nombre = txtNombre.Text,
                    ComidaTradicional = txtComida.Text,
                    Ubicacion = txtUbicacion.Text,
                    NumeroContacto = txtNumero.Text,
                };
                await App.SqliteDB.SaveLugarAsync(lugar);
                txtNombre.Text = "";
                txtComida.Text = "";
                txtUbicacion.Text = "";
                txtNumero.Text = "";
                await DisplayAlert("Registro", "Lugar guardado Correctamente", "Ok");
                
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "Ok");
            }
        }
        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtComida.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtUbicacion.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtNumero.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}