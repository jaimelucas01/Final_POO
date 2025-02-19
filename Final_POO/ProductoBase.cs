using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    public abstract class ProductoBase
    {
        public required int ID { get; set; }
        public required string Nombre { get; set; }
        public required string Marca { get; set; }
        public required decimal Precio { get; set; }
        public required int Stock { get; set; }

        protected ProductoBase() 
        {
            ID = new Random().Next(1, 10000);
        }
    }
}
