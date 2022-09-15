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
    public partial class LugaresPage : ContentPage
    {
        public LugaresPage()
        {
            InitializeComponent();
           /* var lugarList = await App.SqliteDB.GetLugaresAsync();
            if (lugarList != null)
            {
                lstAlumnos.ItemsSource = lugarList;
                }*/
        }

    }
}