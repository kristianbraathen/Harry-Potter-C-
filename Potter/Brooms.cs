using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potter
{
    public class Brooms
    {
        public List<Brooms> brooms { get; set; }

        public string BroomName { get; set; }
        public int Speed { get; set; }
        public Brooms(string broomName,int speed)
        {
            Speed = speed;
            BroomName = broomName;
        }

    }
}
