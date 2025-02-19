using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public class Almacén
    {
        public List<ProductoInformatico> Productos { get; set; }

        public Almacén()
        {
            Productos = new List<ProductoInformatico>();
        }
    }
}
