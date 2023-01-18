using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Character 
    {

        public Wands ActiveWand;
        public List<Wands> MyWandList;
        public List<Character> MyCharacter;
        public List<Pets> MyPets;
        public List<Brooms> MyBrooms;
        public Brooms ActiveBroom;
        public List<Inventory> MyInventoryLists;
        public string CharacterName { get; set; }
        public string House { get; set; }
        public int HP { get; private set; }
        public int Coins { get; set; }
      
      
       
      
        public Character(string charactername , string house, int hp , int coins) 
           
        {
            CharacterName = charactername;
            House = house;
            HP = hp;
            Coins = coins;

            MyWandList = new List<Wands>();
            MyPets = new List<Pets>();
            MyBrooms = new List<Brooms>();
            MyInventoryLists = new List<Inventory>();
           


        }
        public void ChoosenWand()
        {
            PrintWand();
            
            Console.WriteLine($" Which Wand do you chose ? ");
            var wandInput = Console.ReadLine();
            var chosenwand = MyWandList.FirstOrDefault(wand => wand.ItemName == wandInput);
            Console.WriteLine($" You have chosen : {chosenwand.ItemName} \n");

        }
        public void ChoosenBroom()
        {
            PrintBroom();
            Console.WriteLine($"Which Broom do you chose? ");
            var broomInput = Console.ReadLine();
            var chosenBroom = MyBrooms.FirstOrDefault(broom => broom.BroomName == broomInput);
            Console.WriteLine($"You have chosen : {chosenBroom.BroomName} \n");

        }



        public void BuyWand(Wands items)
        {
           
              MyWandList.Add(items);
             ActiveWand = MyWandList[0];

        }
       
    
        public void BuyPet(Pets items)
        {
            MyPets.Add(items);
           
        }
        public void BuyBroom(Brooms item)
        {
            MyBrooms.Add(item);
            ActiveBroom = MyBrooms[0];

        }
       

       
        public void PrintWand() 
        {
            foreach (var wand in MyWandList)
            {
                Console.WriteLine($" Wand : {wand.ItemName}");
            }
            
        } 
        public void PrintPet()
        {
            foreach(var pet in MyPets)
            {
                Console.WriteLine($" Pet :{pet.Name}");
            }
        }
        public void PrintBroom()
        {
            foreach( var broom in MyBrooms)
            {
                Console.WriteLine($"Brooms : {broom.BroomName}");
            }
        }


        public void PrintInventory()
        {

           
            PrintWand();
            PrintPet();
            PrintBroom();


        }
        public void TakeDamage(Voldemort voldemort)
        {

            var enemyDamage = voldemort.RandDamage();
            HP -= enemyDamage;
            Console.WriteLine($"Voldemort did  {enemyDamage} damage to {CharacterName} ({HP} HP left) \n");
            
        }
        public Wands WandAttack() 
        {
            var wand = ActiveWand;
            return wand;
            
        }
    }
    
}
