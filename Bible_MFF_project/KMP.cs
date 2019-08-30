using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_MFF_project
{
    public class KMP
    {
        static int[] ReturnFunction;
        static bool AfterBuildingAutomat = false;
        static int KMPStep(string pattern, int state, char x)
        {
            while ((pattern[state] != x) && (state != 0))
            {
                state = ReturnFunction[state];
                if (AfterBuildingAutomat)
                {
                    break;
                }
            }
            if (pattern[state] == x)

            {
                state++;
            }

            return state;
        }

        static int[] BuildAutomat(string pattern)
        {
            ReturnFunction = new int[pattern.Length];
            ReturnFunction[0] = -1;
            if (pattern.Length > 1) ReturnFunction[1] = 0;
            int state = 0;

            for (int i = 2; i < pattern.Length; i++)
            {
                state = KMPStep(pattern, state, pattern[i - 1]);
                ReturnFunction[i] = state;
            }
            AfterBuildingAutomat = true;
            return ReturnFunction;

        }

        public static List<int> SearchKMP(string GivenText, string GivenPattern)
        {
            BuildAutomat(GivenPattern);
            int state = 0;
            List<int> indexes = new List<int>();

            for (int i = 0; i < GivenText.Length; i++)
            {
                state = KMPStep(GivenPattern, state, GivenText[i]);
                if (state == GivenPattern.Length)
                {
                    state--;
                    indexes.Add(i - GivenPattern.Length + 1);
                    state = ReturnFunction[state];
                }

            }
            return indexes;
        }
    }
}