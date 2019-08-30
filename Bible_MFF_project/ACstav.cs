using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_MFF_project
{
    public class ACstav 
    {
            int jmeno { get; set; }
            public int? zkratka { get; set; }
            public int? zpet { get; set; }
            public string slovo { get; set; }

            public Dictionary<char, int?> dopredu; 
    //    ACstav()
    //    {   dopredu = new Dictionary<char, int?>();

      //  }
    }
}
