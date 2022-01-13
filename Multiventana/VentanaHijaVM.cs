using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiventana
{
    class VentanaHijaVM : ObservableObject
    {
        private String mensaje;



        public String Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public VentanaHijaVM()
        {
            Mensaje = "Hola soy la ventana hija";

        }
    }
}
