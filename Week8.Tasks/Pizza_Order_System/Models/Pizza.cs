using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order_System.Models
{
    class Pizza<TypeOfPizza>
    {
        public TypeOfPizza TypeOfPiz { get; set; }
        public Size SizeOfPizza { get; set; }
        public decimal Count { get; set; }
        public List<string> Additions { get; set; }
    }

    class TypeOfPizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }

    enum Size
    {
        Small =10,
        Medium=20,
        Large=30
    }

}
