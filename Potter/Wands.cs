using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Wands : Items
    {
        public List<Wands> WandList { get; set; }

        public Wands(string itemname, string description, int damage, int restoreHP, int price)
            : base(itemname, description, damage, restoreHP, price)
        {

        }
       
    }
}
