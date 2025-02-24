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

        protected ProductoInformatico(int id, string nombre, string marca, int stock, decimal precio) : base()
        {
            ID = id;
            Nombre = nombre;
            Marca = marca;
            Stock = stock;
            Precio = precio;
        }
    }
}
