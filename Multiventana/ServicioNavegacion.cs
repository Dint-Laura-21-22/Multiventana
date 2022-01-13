using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Multiventana
{
    class ServicioNavegacion:ObservableObject
    {
        public void AbrirVentanaHija() {
            VentanaHija nueva = new VentanaHija();
            nueva.ShowDialog();
        }

        public UserControl AbrirUC1()
        {
            return new UserControl1();
        }

        public UserControl AbrirUC2()
        {
            return new UserControl2();
        }
    }
}
