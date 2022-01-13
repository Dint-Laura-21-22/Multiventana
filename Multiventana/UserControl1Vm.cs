using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiventana
{
    class UserControl1Vm:ObservableObject
    {
        private String mensaje;



        public String Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl1Vm()
        {
            Mensaje = "Soy UserControl 1";
        }
    }
}
