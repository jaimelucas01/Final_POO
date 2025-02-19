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
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio <= 0) throw new ArgumentException("El precio debe ser mayor a 0.");
            if (stock < 0) throw new ArgumentException("El stock no puede ser negativo.");

            Nombre = nombre;
            ID = id;
            Marca = marca;
            Precio = precio;
            Stock = stock;
        }
    }
}
