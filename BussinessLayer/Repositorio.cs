using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public sealed class Repositorio
    {
        public List<Orders> orders { get; set; } = new List<Orders>();
        public List<bebida> bebidas { get; set; } = new List<bebida>();
        public List<postre> postres { get; set; } = new List<postre>();
        public List<platofuerte> platofuertes { get; set; } = new List<platofuerte>();
        public List<entrada> entradas { get; set; } = new List<entrada>();

        public static Repositorio Instancia {get;}=new Repositorio();

        public Repositorio()
        {

        }
    }
}
