using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    internal class PlacaDeVideo : ProductoInformatico
    {
        public int CapacidadGB { get; set; }

        public PlacaDeVideo(string marca, string nombre, string tipo, decimal precio, int stock, int capacidadGB) : base(marca, nombre, tipo, precio, stock)
        {
            CapacidadGB = capacidadGB;
        }

        public override decimal CalcularDescuento(decimal porcentaje)
        {
            return Precio - (Precio * (porcentaje / 100));
        }
    }
}
