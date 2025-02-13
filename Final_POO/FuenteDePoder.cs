using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public class FuenteDePoder : ProductoInformatico
    {
        public int PotenciaW { get; set; }

        public FuenteDePoder(string nombre, string marca, decimal precio, int stock, int potenciaW)
            : base(nombre, marca, precio, stock, "Fuente de Poder")
        {
            PotenciaW = potenciaW;
        }

        public override decimal CalcularDescuento(decimal porcentaje)
        {
            return Precio - (Precio * (porcentaje / 100));
        }
    }
}
