using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
            /*
     
            1. 
            Person classi yaratmalisiz 
            id, 
            name, 
            surname, 
            birthdate, 
            country , 
            city 
            */
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
