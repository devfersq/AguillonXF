using ProyectoAguillon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAguillon.ViewModels
{
    class DireccionViewModel
    {
        public ObservableCollection<Sucursal> sucursales { get; set; } = new ObservableCollection<Sucursal>();
        public ObservableCollection<Direccion> DireccionesCliente { get; set; } = new ObservableCollection<Direccion>();

        public DireccionViewModel()
        {
            LoadDirecciones().GetAwaiter();
            LoadDireccionesCliente().GetAwaiter();
        }

        async Task LoadDireccionesCliente()
        {
            await Task.Run(() =>
            {
                DireccionesCliente.Clear();
                DireccionesCliente.Add(new Direccion
                {
                    IdDireccion = "1",
                    DescripcionDireccion = "Carretera mezquital # 7591 Col. Villas de Sta Rosa Apodaca, 66610 Monterrey, N.L.",
                    CodigoPostal= "66610"
                });
                DireccionesCliente.Add(new Direccion
                {
                    IdDireccion = "2",
                    DescripcionDireccion = "Plaza Sendero Escobedo Local 6 Sendero Divisorio, Norte Pte 130, Valle del Cañada, 66050 Cd Gral Escobedo, N.L.",
                    CodigoPostal= "66050"

                });

            });
        }
        async Task LoadDirecciones()
        {
            await Task.Run(() =>
            {
                sucursales.Clear();

                
                sucursales.Add(new Sucursal
                {
                    IdSucursal = "1",
                    Nombre = "Abasolo",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Abasolo E Irapuato #2253 Col. Guanajuato C.P. 67112 25253 Saltillo, Coahuila",
                    ImagenURL = ""


                });
                sucursales.Add(new Sucursal
                {
                    IdSucursal = "2",
                    Nombre = "Aldama",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Juan Aldama #303 Zona Centro C.P. 25000 Saltillo, Coahuila",
                    ImagenURL = ""


                });
                sucursales.Add(new Sucursal
                {
                    IdSucursal = "3",
                    Nombre = "Central",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Perf. Luis Echeverria 290 L-2 Col Bellavista Cp 25070 Saltillo Coahuila",
                    ImagenURL = ""


                });
                sucursales.Add(new Sucursal
                {
                    IdSucursal = "4",
                    Nombre = "Coss",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Blvd Francisco Coss Y Aguascalientes L 1c Zona Centro C.P. 25000 Saltillo, Coahuila",
                    ImagenURL = ""


                });
                sucursales.Add(new Sucursal
                {
                    IdSucursal = "5",
                    Nombre = "Echeverría",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Periferico Luis Echeverría #6301-8 Col. San Ramón C.P. 25020 Saltillo, Coahuila",
                    ImagenURL = ""


                });

                sucursales.Add(new Sucursal
                {
                    IdSucursal = "6",
                    Nombre = "HEB San Patricio",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Blvd. Los González #2275 Col San José De Los Cerritos C.P. 25000 Saltillo, Coahuila",
                    ImagenURL = ""


                });

                sucursales.Add(new Sucursal
                {
                    IdSucursal = "7",
                    Nombre = "La cabaña",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Periferico Luis Echeverria Alvarez #3410 Fraccionamiento Colinas De San Francisco C.P. 25057 Saltillo, Coahuila",
                    ImagenURL = ""

                });

                sucursales.Add(new Sucursal
                {
                    IdSucursal = "8",
                    Nombre = "Lourdes",
                    Estado = "Coahuila",
                    Ciudad = "Saltillo",
                    Direccion = "Periférico Luis Echeverría 999 L32 Col. Niños Héroes C.P. 25084 Saltillo, Coahuila",
                    ImagenURL = ""

                });
            });
        }
    }
}
