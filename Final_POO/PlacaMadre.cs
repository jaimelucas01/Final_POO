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

        public PlacaMadre(string marca, string nombre, string tipo, decimal precio, int stock, string socket) : base(marca, nombre, tipo, precio, stock)
        {
            Socket = socket;
        }

        //public override decimal CalcularDescuento(decimal porcentaje)
        //{
        //    return Precio - (Precio * (porcentaje / 100));
        //}
    }
}
