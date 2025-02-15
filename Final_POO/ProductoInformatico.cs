using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public abstract class ProductoInformatico
    {
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        protected ProductoInformatico(string marca, string nombre, string tipo, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio <= 0) throw new ArgumentException("El precio debe ser mayor a 0.");
            if (stock < 0) throw new ArgumentException("El stock no puede ser negativo.");

            Nombre = nombre;
            Marca = marca;
            Tipo = tipo;
            Precio = precio;
            Stock = stock;
        }

        public virtual string MostrarInfo()
        {
            return $"{Tipo}: {Nombre} - {Marca}, Precio: {Precio:C}, Stock: {Stock}";
        }

        //public abstract decimal CalcularDescuento(decimal porcentaje);
    }
}
