using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_MFF_project
{
    public class ACVertex 
    {
        /// <summary>
        /// This structure serves as a keeper of the node
        /// </summary>
        public ACVertex()
            {
                Children = new Hashtable();
                Leaf = false;
                Parent = -1;
                SuffixLink = -1;
                WordNumber = -1;
                EndWordLink = -1;
            }

            public Hashtable Children;

            public bool Leaf;

            public int Parent;
            public char ParentChar;
            public int SuffixLink;
            public int EndWordLink;
            public int WordNumber;
        }
    }


