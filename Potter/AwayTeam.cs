using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class AwayTeam
    {
     
        
            public List<AwayTeam> AwayTeams;

            public int Score { get; set; }

            public bool WonMatch { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }


            public AwayTeam(string name, string type)
            {
               
                Name = name;
                Type = type;
                

            }

        public AwayTeam()
        {
        }

       

       
    }
    

}
