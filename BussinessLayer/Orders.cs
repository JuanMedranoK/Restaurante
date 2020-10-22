using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    [Serializable]
    public class Orders
    {
        public int TableIndex { get; set; }
        public string Name { get; set; }
        public entrada Entry { get; set; } = new entrada();
        public platofuerte Dish { get; set; } = new platofuerte();
        public bebida Drinks { get; set; } = new bebida();
        public postre Dessert { get; set; } = new postre();

        public Orders(string name, entrada entry, platofuerte dish, bebida drinks, postre dessert)
        {
            this.Name = name;
            this.Entry = entry;
            this.Dish = dish;
            this.Drinks = drinks;
            this.Dessert = dessert;
        }
    }
}
