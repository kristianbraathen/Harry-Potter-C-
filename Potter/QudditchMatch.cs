using Potter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Potter.Successful;


namespace Potter
{
    public class QudditchMatch
    {
        public List<HomeTeam> HomeTeam;
        public List<AwayTeam> AwayTeam;
        public List<Brooms> brooms;
        public int Score;
        public bool WonMatch { get; internal set; }
        public QudditchMatch()
        {
            HomeTeam = new List<HomeTeam>
            {
                new HomeTeam("Ron","Chaser"),
                new HomeTeam("John","Chaser"),
                new HomeTeam("Paul","Chaser"),
                new HomeTeam("George","Beater"),
                new HomeTeam("Ringo","Beater"),
                new HomeTeam("Billy Preston", "Keeper"),
                new HomeTeam("Harry","Seeker")

             };
            AwayTeam = new List<AwayTeam>
            {
                new AwayTeam("Don","Chaser"),
                new AwayTeam("Mick","Chaser"),
                new AwayTeam("Keith","Chaser"),
                new AwayTeam("Bill","Beater"),
                new AwayTeam("Brian","Beater"),
                new AwayTeam("Charlie", "Keeper"),
                new AwayTeam("M Taylor","Seeker")

            };
           
        }

             public void Match(HomeTeam HomeTeam, AwayTeam AwayTeam,Character character)
             {
                character.ChoosenBroom();
              Console.WriteLine("Qudditch Match !! Let's Go! ");
                 
              


             if (HomeTeam.Score >= 100 || AwayTeam.Score >= 100)
             {
                Console.WriteLine(" Team won match");
                
                   WonMatch = true;
             }

             else
             {
                
                  WonMatch = false;
             }

             while (!HomeTeam.WonMatch && !AwayTeam.WonMatch)
                {
                   

                Console.WriteLine("1: Try to catch snitch \n" +
                    "2: Try to score goal \n");
                if(HomeTeam.Score <= 100)
                {
                    Console.WriteLine("Home Team to Go");
                    var userInput = Console.ReadLine();
                    switch(userInput)
                    {
                        case "1":
                            Console.WriteLine();
                            TryToCatchSnitch();
                            
                            HomeTeam.Score += Score;
                            HomeTeam.WonMatch = WonMatch;
                            PrintScore(HomeTeam, AwayTeam);
                           
                            break;
                        case "2":
                            TryToScoreGoal();
                            Console.WriteLine($"Score :{Score}\n");
                            HomeTeam.Score += Score ;
                            HomeTeam.WonMatch = WonMatch;
                            PrintScore(HomeTeam, AwayTeam);
                            break;

                    }
                   
                }
                else
                {
                    HomeTeam.WonMatch = true;
                    Console.WriteLine("Home Team Won");
                }
                if (AwayTeam.Score <= 100)
                {
                    Console.WriteLine("Away Team to go");
                    var userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            TryToCatchSnitch();
                            AwayTeam.Score += Score;
                            AwayTeam.WonMatch = WonMatch;
                            PrintScore(HomeTeam, AwayTeam);
                            break;
                        case "2":
                            TryToScoreGoal();
                            Console.WriteLine($"Score :{Score} \n");
                            AwayTeam.Score += Score ;
                            AwayTeam.WonMatch = WonMatch;
                            PrintScore(HomeTeam, AwayTeam);
                            
                            break;

                    }

                }
                else
                {
                    AwayTeam.WonMatch = true;
                    Console.WriteLine("Away Team Won");
                }

                
                }
             } 

        
        public void TryToCatchSnitch()
        {
            var success = IsSuccessful(20);
            if (success == true) 
            {
                Score = 100;
                WonMatch = true;
                Console.WriteLine(" You caught a Snitch , won the game \n");
               
            }
            else 
            {
                WonMatch = false;
                Console.WriteLine(" Swing and a Miss \n");
            }

            

        }
        public void TryToScoreGoal()
        {
            var success = IsSuccessful(5);
            if (success == true)
            {
                
                Random random = new Random();
                Score = random.Next(1, 5);
                Console.WriteLine("You Scored a Goal \n");

            }
            else
            {
                WonMatch = false;
                Console.WriteLine(" Swing and a Miss \n");
                Score = 0;
            }
            
        }
        public static void PrintScore(HomeTeam homeTeam, AwayTeam awayTeam)
        {
            Console.WriteLine($"Home Team : {homeTeam.Score} \n" +
                              $"Away Team : {awayTeam.Score}\n");
        }


    }

}


