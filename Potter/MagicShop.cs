using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
       
    public class MagicShop 

    {
        public List<Pets> Pets;
        public List<Wands> WandList;
        public Character Character;
        public List<Brooms> BroomsList;
       
       

        public MagicShop(Character character) 
        {
            
            Character = character;
            WandList = new List<Wands>
            {

            new Wands("Phoenix Wand", "This Wand helps your HP rise like a Phoenix", 30, 20, 5),
            new Wands("Unicorn Wand", "This Wand helps you see thing, you normally don't.", 40, 5, 10),
            new Wands("Magic Wand", "This is the most powerful of all Wands", 50, 10, 15),

            };
            Pets = new List<Pets>
            {
                new Pets("Strigiformes",10),
                new Pets("Rattus Rattus",10),
                new Pets("Felis Catus",10)
            };
            BroomsList = new List<Brooms>
            {
                new Brooms("Nimbus 2000",1000),
                new Brooms("Firebolt", 2000),
                new Brooms("Turbo XXX", 500)
            };


        }
      

        public void MagicShopMenu(Character character)
        {

           
            var run = true;
            while (run)
            {

                Console.WriteLine("Welcome to My Shop. What are you looking for this fine morning?\n\n" +
                    "  1: Pets \n" +
                    "  2: Wands \n" +
                    "  3: Brooms\n" +
                    "  x: Exit Shop");

                var input1 = Console.ReadLine();
                switch (input1)
                {
                    case "1":
                        Console.WriteLine("Pets, ay?\n");
                        SellPet(character);
                        break;
                    case "2":
                        Console.WriteLine("Wands you got it\n");
                        SellWand(character);
                        break;
                    case "3":
                        Console.WriteLine("Yes Okay, brooms it is \n");
                        SellBroom(character);
                        break;
                    case "x":
                        Console.WriteLine("Thank you come again \n");
                        run = false;
                        break;
                }

            }
        
        }
        public void SellWand(Character character)
        { 
            
            Console.WriteLine("I have three Wands you can buy\n");
            foreach(var wand in WandList)
            {
                Console.WriteLine($" Wand name: {wand.ItemName} \n Description: {wand.Description}  Damage: {wand.Damage} RestoringHP: {wand.RestoreHP} Price: {wand.Price}\n"  );
            }
            
            var wandinput = Console.ReadLine();
            var ChosenWand = WandList.FirstOrDefault(wand => wand.ItemName == wandinput);
           

            character.BuyWand(ChosenWand);
            Console.WriteLine($" You bought {ChosenWand.ItemName}");
           
            
        }
        public void SellPet(Character character)
        {
            Console.WriteLine("I Have 3 Pets you can buy\n");
            foreach(var pet in Pets)
            {
                Console.WriteLine($" Pet name: {pet.Name} Price: {pet.Price}");
            }
            var petinput = Console.ReadLine();
            var ChosenPet = Pets.FirstOrDefault(pet => pet.Name == petinput);
            character.BuyPet(ChosenPet);
            Console.WriteLine( $" You bought : {ChosenPet.Name}");
        }
        public void SellBroom(Character character)
        {
            Console.WriteLine("Which of these would you like? \n");
            foreach (var broom in BroomsList)
            {
                Console.WriteLine($" {broom.BroomName} Speed: {broom.Speed} ");
            }
                var broomInput = Console.ReadLine();
                var ChosenBroom = BroomsList.FirstOrDefault(broom => broom.BroomName == broomInput);
                character.BuyBroom(ChosenBroom);
                Console.WriteLine($" You bought: {ChosenBroom.BroomName}");
            
        }



    }
       

  
}
