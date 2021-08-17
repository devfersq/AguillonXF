using ProyectoAguillon.Data;
using ProyectoAguillon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoAguillon.ViewModels
{    
    public class HomeViewModel
    {
        
        public ObservableCollection<Carussel> carrusel { get; set; } = new ObservableCollection<Carussel>();
        public ObservableCollection<Carussel> carrusel2 { get; set; } = new ObservableCollection<Carussel>();
        public ObservableCollection<Producto> ListaTopProductos { get; set; } = new ObservableCollection<Producto>();

        public HomeViewModel()
        {
            
            LoadCarrusel().GetAwaiter();
            LoadTopProductos().GetAwaiter();
            LoadCarrusel2().GetAwaiter();
        }

        async void OnTopProductosSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(1000);
        }

        async Task LoadTopProductos()
        {

            await Task.Run(() =>
            {
                ListaTopProductos.Clear();

                ListaTopProductos.Add(new Producto
                {
                    IdProducto = "1",
                    Nombre = "Seda Capilar Chocolate Wött",
                    Descripcion = "Descripción del producto 1.",
                    ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                    Precio = 59.99,
                    EsFavorito = true,
                    Rating = 4.5,
                    Descuento = 25

                }); ;
                ListaTopProductos.Add(new Producto
                {
                    IdProducto = "2",
                    Nombre = "Silky Drop Reconstrucktor 07",
                    Descripcion = "Descripción del producto 2.",
                    ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                    Precio = 99.99,
                    EsFavorito = false,
                    Rating = 5,
                    Descuento = 15
                });
                ListaTopProductos.Add(new Producto
                {
                    IdProducto = "3",
                    Nombre = "Termoprotector Argán Soft Silk",
                    Descripcion = "Descripción del producto 3.",
                    ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                    Precio = 29.99,
                    EsFavorito = true,
                    Rating = 3,
                    Descuento = 25
                });
                ListaTopProductos.Add(new Producto
                {
                    IdProducto = "4",
                    Nombre = "Tratamiento RF Vezia",
                    Descripcion = "Descripción del producto 4.",
                    ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                    Precio = 19.99,
                    EsFavorito = true,
                    Rating = 5,
                    Descuento = 50
                });
            });

        }

        async Task LoadCarrusel()
        {
            await Task.Run(() =>
            {
                carrusel.Clear();
                carrusel.Add(new Carussel { Imagen = "big5.png" });
                carrusel.Add(new Carussel { Imagen = "skin2.png" });
                carrusel.Add(new Carussel { Imagen = "lor1.png" });
                
            });
            
        }

        async Task LoadCarrusel2()
        {
            await Task.Run(() =>
            {
                carrusel2.Clear();
                carrusel2.Add(new Carussel { Imagen = "carrusel2_3.jpg" });
                carrusel2.Add(new Carussel { Imagen = "carrusel2_2.jpg" });
                carrusel2.Add(new Carussel { Imagen = "carrusel2_1.jpg" });
            });

        }
    }
}
