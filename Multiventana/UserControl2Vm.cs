using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiventana
{
    class UserControl2Vm:ObservableObject
    {
        private String mensaje;



        public String Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl2Vm()
        {
            Mensaje = "Soy UserControl 2";
        }
    }
}
