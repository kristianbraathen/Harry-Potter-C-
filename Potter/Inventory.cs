using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Inventory : Items
    {


       
        public int MagicSkills { get; set; }
        public string MagicalItems { get; set; }
       

        public Inventory(int magicSkills,  string magicalItems, string itemName, string description, int damage, int restoreHP, int price)
            : base(itemName, description, damage,restoreHP,price )
        {
            
            MagicSkills = magicSkills;
            MagicalItems = magicalItems;
            
        }
      




    }




}
