using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public abstract class ProductoBase
    {
        public int ID { get; set; } = 0;
        public string Nombre { get; set; } = "";
        public string Marca { get; set; } = "";
        public int Stock { get; set; } = 0;
        public decimal Precio { get; set; } = 0;

        protected ProductoBase() 
        {
            ID = new Random().Next(1, 10000);
        }
    }
}
