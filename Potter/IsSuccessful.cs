using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Successful
    {
        public static bool IsSuccessful(int maxValue)
        {

            Random rand = new Random();
            _ = rand.Next(0, maxValue) == 2;
            if (rand.Next(0, maxValue) % 2 == 0)
            {
                return true;
            }
            else { return false; }


        }
    }
}
