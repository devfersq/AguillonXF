using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAguillon.Models
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string ImagenURL { get; set; }
        public double DescuentoCantidad { get; set; }

        public double Descuento { get; set; }
        public bool EsFavorito { get; set; }
        public bool ProductoDestacado { get; set; }
        
        public double Rating { get; set; }
    }
}
