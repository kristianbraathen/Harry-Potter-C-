using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Spells
    {
       public List<Spells> SpellList;
        public string SpellName { get; private set; }


        public Spells(string spellName)
        {
            {
                SpellName = spellName;
               
                
               
            };

        }

        public Spells()
        {
             SpellList = new List<Spells>
             {

                new Spells("vingardium leviosa"),
                new Spells("hokus pokus")
             };
        }

        public void CastSpell()
        {
            foreach (var spell in SpellList)
            {
                Console.WriteLine($"{spell.SpellName}");

            }

            var spellinput = Console.ReadLine();
            var ChosenSpell = SpellList.FirstOrDefault(spell => spell.SpellName == spellinput);
            if (ChosenSpell == null)
            {

                Console.WriteLine("Nein,Nein,Nein,Bad Wizard");
            }
            else
            {
                Console.WriteLine($"{ChosenSpell.SpellName}");



                if (ChosenSpell.SpellName == "vingardium leviosa")
                {
                    Console.WriteLine("Look A Flippin Feather Is Flying ");
                }
                if (ChosenSpell.SpellName == "hokus pokus")
                {


                    string text = System.IO.File.ReadAllText(@"C:\Users\Krist\Downloads\fireworks.txt");
                    Console.Write(text);
                    Console.WriteLine();
                }
            }
        }

    }   
}
