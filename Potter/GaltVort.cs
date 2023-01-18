using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class GaltVort
    {
        public Voldemort voldemort;
        public Character ActivePlayer;
        public MagicShop magicShop;
        public Spells Spells;
        public List<Character> MyCharacters;
        public List<Spells> MySpells;
        public List<Pets> MyPets;
        public Mail Mail;
        public QudditchMatch qudditch;
        public List<HomeTeam> homeTeam;
        public List<AwayTeam> awayTeam;
       

        public GaltVort()
        {
            MyCharacters = new List<Character>
            {
                 new Character("Harry Potter", "Griffindor", 200, 50),
                 new Character("Hermione Granger", "Griffindor", 200, 50),
                 new Character("Draco Malfoy", "Slytherin ", 200, 50)
            };

            voldemort = new Voldemort(100,0);

          



        }

        public void SelectCharacterData()
        {
            var characterHandler = new CharacterHandler(MyCharacters);
            ActivePlayer = characterHandler.SelectCharacters();
            Console.WriteLine($" You chose : {ActivePlayer.CharacterName}\n");
        }



        public void GameHandler()
        {
            var mail = new Mail();
            var spell = new Spells();
            var magicShop = new MagicShop(ActivePlayer);
            var fight = new FightArena();
            var quidditch = new QudditchMatch();
            var hometeam = new HomeTeam();
            var awayteam = new AwayTeam();
            SelectCharacterData();  

            while (true)
            {

                 
                Console.WriteLine(" 1: Go to Shop\n" +
                    " 2: Check inventory \n" +
                    " 3: Cast A Spell \n" +
                    " 4: Send Mail \n" +
                    " 5: Read Mail \n" +
                    " 6: Fight Voldemort \n" +
                    " 7: Quidditch \n "
                    );
                var useInput = Console.ReadLine();
                switch (useInput)
                {
                    case "1":
                        
                        magicShop.MagicShopMenu(ActivePlayer);
                        
                        break;
                    case "2":
                        ActivePlayer.PrintInventory();

                        break;
                    case "3":
                          spell.CastSpell();
                        break;
                    case "4":
                        mail.SendMail(ActivePlayer);
                        break;
                    case"5":
                        mail.ReadMail();
                        break;
                    case "6":
                        fight.FightHandler(voldemort,ActivePlayer);
                        break;
                    case "7":
                        quidditch.Match(hometeam,awayteam,ActivePlayer);
                        break;
                }






            }
        }
    }
}
