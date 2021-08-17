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
    public partial class DireccionPage : ContentPage
    {
        private DireccionViewModel vm;
        public DireccionPage()
        {
            InitializeComponent();
            vm = new DireccionViewModel();
            BindingContext = vm;
        }
    }
}