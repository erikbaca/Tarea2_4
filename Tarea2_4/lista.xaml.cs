using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.BaseDatos.listaempleados();
        }

      

        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Models.contructor;
            

            var newpage = new reproductor(d.ruta);
            await Navigation.PushAsync(newpage);
        }

       
    }
}