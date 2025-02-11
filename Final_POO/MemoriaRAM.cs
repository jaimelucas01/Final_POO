using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_POO;

namespace Final_POO
{
    public class MemoriaRAM : ProductoInformatico
    {
        public int CapacidadGB { get; set; }

        public MemoriaRAM(string nombre, string marca, decimal precio, int stock, int capacidadGB)
            : base(nombre, marca, precio, stock, "Memoria RAM")
        {
            CapacidadGB = capacidadGB;
        }

        public override decimal CalcularDescuento(decimal porcentaje)
        {
            return Precio - (Precio * (porcentaje / 100));
        }
    }
}
