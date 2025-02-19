using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public class ProductoInformatico : ProductoBase
    {
        public ProductoInformatico() : base() { }

        protected ProductoInformatico(int id, string nombre, string marca, decimal precio, int stock) : base()
        {
            ID = id;
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Stock = stock;
        }
    }
}
