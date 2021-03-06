using ProyectoAguillon.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoAguillon.Data
{
    public class ProductosData
    {
        public static IList<Producto> ProductosLista { get; private set; }

        static ProductosData()
        {
            ProductosLista = new List<Producto>();

            ProductosLista.Add(new Producto
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
            ProductosLista.Add(new Producto
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
            ProductosLista.Add(new Producto
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
            ProductosLista.Add(new Producto
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
            ProductosLista.Add(new Producto
            {
                IdProducto = "5",
                Nombre = "Maquillaje Polvo Compacto Bissú",
                Descripcion = "Descripción del producto 5.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 59.99,
                EsFavorito = true,
                Rating = 4.5,
                Descuento = 25
            });
            ProductosLista.Add(new Producto
            {
                IdProducto = "6",
                Nombre = "Labial Le Foose",
                Descripcion = "Descripción del producto 6.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 59.99,
                EsFavorito = true,
                Rating = 4.5,
                Descuento = 25
            });
            ProductosLista.Add(new Producto
            {
                IdProducto = "7",
                Nombre = "Brocha Para Difuminar Le Foose",
                Descripcion = "Descripción del producto 7.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 9.99,
                EsFavorito = false,
                Rating = 5,
                Descuento = 35
            });
            ProductosLista.Add(new Producto
            {
                IdProducto = "8",
                Nombre = "Brocha Sesgada Para Base Le Foose",
                Descripcion = "Descripción del producto 8.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 9.99,
                EsFavorito = false,
                Rating = 2.5,
                Descuento = 0
            });
            ProductosLista.Add(new Producto
            {
                IdProducto = "9",
                Nombre = "Aceite Para Cortadoras Wahl",
                Descripcion = "Descripción del producto 9.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 12.99,
                EsFavorito = true,
                Rating = 5,
                Descuento = 5

            });
            ProductosLista.Add(new Producto
            {
                IdProducto = "10",
                Nombre = "Cabeza Maniquí Estilizada",
                Descripcion = "Descripción del producto 10.",
                ImagenURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Uniform_polyhedron-43-t0.png/480px-Uniform_polyhedron-43-t0.png",
                Precio = 19.99,
                EsFavorito = false,
                Rating = 4.5,
                Descuento = 25
            });


        }

        public void lista()
        {

        }

    }
}
