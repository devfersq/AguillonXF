using ProyectoAguillon.Models;
using ProyectoAguillon.ViewModels;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace ProyectoAguillon.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[QueryProperty("ProductoId", "IdProducto")]
    public partial class SearchPage : ContentPage
    {
        private SearchViewModel vm;      

        public SearchPage()
        {
            InitializeComponent();
            vm = new SearchViewModel();
            BindingContext = vm;
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string NombreDelProducto = (e.CurrentSelection.FirstOrDefault() as Producto).Nombre;
            //await Shell.Current.GoToAsync($"ProductoDetailPage?nombre={NombreDelProducto}");

            Producto ProductoSeleccionado = new Producto()
            {
                IdProducto = (e.CurrentSelection.FirstOrDefault() as Producto).IdProducto,
                Nombre = (e.CurrentSelection.FirstOrDefault() as Producto).Nombre,
                Descripcion = (e.CurrentSelection.FirstOrDefault() as Producto).Descripcion,
                Precio = (e.CurrentSelection.FirstOrDefault() as Producto).Precio,
                Categoria = (e.CurrentSelection.FirstOrDefault() as Producto).Categoria,
                ImagenURL = (e.CurrentSelection.FirstOrDefault() as Producto).ImagenURL,
                Descuento = (e.CurrentSelection.FirstOrDefault() as Producto).Descuento,
                DescuentoCantidad = (e.CurrentSelection.FirstOrDefault() as Producto).DescuentoCantidad,
                EsFavorito = (e.CurrentSelection.FirstOrDefault() as Producto).EsFavorito,
                ProductoDestacado = (e.CurrentSelection.FirstOrDefault() as Producto).ProductoDestacado,
                Rating = (e.CurrentSelection.FirstOrDefault() as Producto).Rating
            };

            var ProductoSeleccionadoSerializado = JsonConvert.SerializeObject(ProductoSeleccionado);
            await Shell.Current.GoToAsync($"ProductoDetailPage?ProductoSerializado={ProductoSeleccionadoSerializado}");


        }
    }
}