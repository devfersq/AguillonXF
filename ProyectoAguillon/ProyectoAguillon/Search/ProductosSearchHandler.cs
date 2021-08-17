using Newtonsoft.Json;
using ProyectoAguillon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoAguillon.Search
{
    public class ProductosSearchHandler : SearchHandler
    {
        public IList<Producto> SugerenciasDeProductos { get; set; } = new List<Producto>();
        public Type SelectedItemNavigationTarget { get; set; }//

        public ProductosSearchHandler()//
        {//
            var helper = new SearchHelper();//
            Task.Run(async ()=>
            {//
                SugerenciasDeProductos = await helper.BusquedaSugerenciaDeProductos();//
                ItemsSource = SugerenciasDeProductos;//
            });//

        }//

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = SugerenciasDeProductos
                    .Where(producto => producto.Nombre.ToLower().Contains(newValue.ToLower()))
                    .ToList<Producto>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            
            //await Shell.Current.GoToAsync($"{GetNavigationTarget()}?nombre={((Producto)item).Nombre}");

            Producto ProductoSeleccionado = new Producto()//
            {               
                
                IdProducto = ((Producto)item).IdProducto,
                Nombre = ((Producto)item).Nombre,
                Descripcion = ((Producto)item).Descripcion,
                Precio = ((Producto)item).Precio,
                Categoria = ((Producto)item).Categoria,
                ImagenURL = ((Producto)item).ImagenURL,
                Descuento = ((Producto)item).Descuento,
                DescuentoCantidad = ((Producto)item).DescuentoCantidad,
                EsFavorito = ((Producto)item).EsFavorito,
                ProductoDestacado = ((Producto)item).ProductoDestacado,
                Rating = ((Producto)item).Rating,               
                
            };

            var ProductoSeleccionadoSerializado = JsonConvert.SerializeObject(ProductoSeleccionado);//

            await Shell.Current.GoToAsync($"ProductoDetailPage?ProductoSerializado={ProductoSeleccionadoSerializado}");//
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}

