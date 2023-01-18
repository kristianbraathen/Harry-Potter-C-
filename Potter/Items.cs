using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Items
    {
        public string ItemName { get; set; }
        public string Description { get; set; }

        public int Damage { get; set; }
        public int RestoreHP { get; set; }
        public int Price { get; set; }

        public Items(string itemName, string description, int damage, int restoreHP, int price)
        {
            ItemName = itemName;
            Description = description;
            Damage = damage;
            RestoreHP = restoreHP;
            Price = price;
        }
        public string Print()
        {
            return "Name: " + ItemName + "Description:  " + Description + "Damage: " + Damage + "Restoring Hp: " + RestoreHP + "Price: " + Price;
        }
    }
}
