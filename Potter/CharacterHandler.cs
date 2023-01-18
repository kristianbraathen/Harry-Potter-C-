using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class CharacterHandler
    {
        
        public List<Character> MyCharacters { get; set; }
        
        public CharacterHandler(List<Character> characters)
        {
                MyCharacters = characters;
           


        }
        public void PrintCharacter()
        {
            foreach(var character in MyCharacters)
            {
                Console.WriteLine($" {character.CharacterName}, from the house of {character.House}  HP {character.HP}\n"
                 
                  );
                

            }
            Console.WriteLine(" Please enter  character name: ");
        }
        public Character SelectCharacters()
        {

            Console.WriteLine($" Greetings! Which Character do you wish to play\n");

            PrintCharacter();
            var charInput = Console.ReadLine();
                
                var ChosenChar = MyCharacters.FirstOrDefault(character => character.CharacterName == charInput);
                 
                //Console.WriteLine($" You have chosen : {ChosenChar.CharacterName}");
                return ChosenChar;
            }
        
        
    }
    }
