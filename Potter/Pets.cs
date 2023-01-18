using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Pets
    {
       
        public string Name { get; set; }
        public int Price { get; set; }

        public List<Pets> PetsList {get; set; }
        public Pets( string name, int price)
        {
           
            Name = name;
            Price = price;
        }

    }
}
