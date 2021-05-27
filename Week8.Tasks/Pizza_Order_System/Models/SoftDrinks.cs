using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order_System.Models
{
    class SoftDrinks<TypeOfDrink>
    {
        public TypeOfDrink TypeOfSok { get; set; }
        public decimal Count { get; set; }
    }

    class TypeOfDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
