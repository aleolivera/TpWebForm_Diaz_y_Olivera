using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int ID { get; set; }
        public string descripcion { get; set; }

        public Marca() { }
        public Marca(int IDMarca, string descripcion)
        {
            this.ID = IDMarca;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
