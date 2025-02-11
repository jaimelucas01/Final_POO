using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaProductos
{
    public abstract class ProductoInformatico
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Tipo { get; set; }

        protected ProductoInformatico(string nombre, string marca, decimal precio, int stock, string tipo)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio <= 0) throw new ArgumentException("El precio debe ser mayor a 0.");
            if (stock < 0) throw new ArgumentException("El stock no puede ser negativo.");

            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Stock = stock;
            Tipo = tipo;
        }

        public virtual string MostrarInfo()
        {
            return $"{Tipo}: {Nombre} - {Marca}, Precio: {Precio:C}, Stock: {Stock}";
        }

        public abstract decimal CalcularDescuento(decimal porcentaje);
    }
}
