using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class MatchHandler
    {
        public HomeTeam HomeTeam;
        public AwayTeam AwayTeam;
        
       
        public bool WonMatch { get; set; }
        public MatchHandler()
        {
            HomeTeam = new HomeTeam();
            AwayTeam= new AwayTeam();
           
            Random random = new Random();
            var turn = random.Next(0, 2);
            while (true)
            {
                if(turn % 2 == 0)
                {
                    Console.WriteLine(" Go Home team");
                    
                  
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine(" Go Away team");
                    
                    Console.ReadLine();
                   
                }
                turn++;
            }
        }
        

        



        
      
       
    }
}
