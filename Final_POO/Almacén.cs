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

        public List<ProductoInformatico> ObtenerProductosOrdenadosMenor()
        {
            return Productos.OrderBy(p => p.Precio).ToList();
        }

        public List<ProductoInformatico> ObtenerProductosOrdenadosMayor()
        {
            return Productos.OrderByDescending(p => p.Precio).ToList();
        }
    }
}
