using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSFAPIUNI.TO
{
    public class IN_PRODU
    {
        public short emp_codi { get; set; } // Codigo Empresa
        public int pro_cont { get; set; } // Consecutivo Interno Producto
        public string pro_codi { get; set; } // Codigo del Producto
        public string pro_nomb { get; set; } //Nombre del Producto
      //  public double ins_cont { get; set; } // Instalacion
        public int uni_codi { get; set; }
    }
}