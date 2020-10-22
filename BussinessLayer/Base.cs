using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    [Serializable]
    public class Base
    {
        public string Nombre { get; set; }

        public Base(string nombre)
        {
            this.Nombre = nombre;
        }
        public Base()
        {

        }
    }
}
