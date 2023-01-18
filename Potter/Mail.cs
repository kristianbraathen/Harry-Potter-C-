using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Mail
    {
        public List<Pets> MyPets;
        public string Message { get; set; }
        public Mail(string message, List<Pets> myPet) { 
            Message = message;
            MyPets =  myPet;

        }
        public Mail()
        { 

        }   
        public void SendMail(Character character)
        {
            foreach (var pets in character.MyPets)
            {
                if (pets.Name == "Strigiformes")
                {
                    Console.WriteLine(" Write a message:");
                    var mailInput = Console.ReadLine();
                    Message = mailInput;

                }
                else
                {
                    Console.WriteLine("No can do. Need Owl ");
                }
            }

        }
        public void ReadMail()
        {
            Console.WriteLine($"{Message}\n");
        }

    }
}
