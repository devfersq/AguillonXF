using Newtonsoft.Json;
using ProyectoAguillon.Data;
using ProyectoAguillon.Models;
using ProyectoAguillon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAguillon.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[QueryProperty("Nombre", "nombre")]
    [QueryProperty("Producto", "ProductoSerializado")]
    public partial class ProductoDetailPage : ContentPage
    {
        public string Producto
        {
           
            set
            {
                var p = Uri.UnescapeDataString(value);
                var producto = JsonConvert.DeserializeObject<Producto>(p);
                string URI = producto.ImagenURL;

                URI=URI.Insert(7, "/");
                producto.ImagenURL = URI;

                BindingContext = producto;
            }
        }

        //public string Nombre
        //{
        //    set
        //    {
        //        BindingContext = ProductosData.ProductosLista.FirstOrDefault(m => m.Nombre == Uri.UnescapeDataString(value));
        //    }
        //}
        

        public ProductoDetailPage()
        {
            InitializeComponent();
            //BindingContext = vm;
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
            
        }
    }
}