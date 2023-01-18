using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class FightArena
    {    

        public void FightHandler(Voldemort voldemort, Character character)
        {
            character.ChoosenWand();
            while (voldemort.HP >= 0 && character.HP >= 0)
            {
                if (voldemort.HP <= 0)
                {
                    Console.WriteLine($"{character.CharacterName} Won \n");
                   
                    return;
                    


                }
                else
                {
                    voldemort.AttackCharacter(character);
                    Console.ReadLine();

                }
                if(character.HP <= 0)
                {
                    Console.WriteLine("Voldemort Won \n");
                    return;
                }
                else
                {
                    voldemort.TakeDamage(character);
                    Console.ReadLine();
                }
                
               
               
               


            }
        }
    }
}
