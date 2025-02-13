using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public class PlacaMadre : ProductoInformatico
    {
        public string Socket { get; set; }

        public PlacaMadre(string nombre, string marca, decimal precio, int stock, string socket)
            : base(nombre, marca, precio, stock, "Placa Madre")
        {
            Socket = socket;
        }

        public override decimal CalcularDescuento(decimal porcentaje)
        {
            return Precio - (Precio * (porcentaje / 100));
        }
    }
}
