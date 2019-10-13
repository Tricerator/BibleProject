using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestBible
{
    public class UnitTest1
    {
        [Fact]
        public void KMPBasicSearch()
        {
              Assert.NotEmpty(Bible_MFF_project.KMP.SearchKMP("Dej mi medajli, nebo nedej mi medajli", "dej"));
              Assert.NotEmpty(Bible_MFF_project.KMP.SearchKMP("Dej mi medajli, nebo nedej mi medajli", "daj"));
       //       Assert.NonEmpty(Bible_MFF_project.KMP.SearchKMP("Dej mi medajli, nebo nedej mi medajli", ""));
                
        }
        [Fact]
        public void splitVerse()
        {
            // Init the trie structure. As an optional parameter we can put the approximate
            // size of the trie to allocate memory just once for all nodes.
            Bible_MFF_project.AhoCorasick ahoAlg = new Bible_MFF_project.AhoCorasick();
            List<string> patterns = new List<string>();
            patterns.Add("ama");
            patterns.Add("atuj");
            patterns.Add("j");

            for (int i = 0; i < patterns.Count; i++)
            {
                ahoAlg.addString(patterns[i], i); // Add all patterns to the structure
            }
            // Prepare algorithm for work (calculates all links in the structure):
            ahoAlg.BuildAC();

            // Process the text. Output might be different; in my case, it's a count of
            // matches. We could instead return a structure with more detailed information.
            List<int> Matches = ahoAlg.ProcessLine("	Pamatujjjj ");
            Assert.Equal(6, Matches.Count);
            int[] results = { 2, 4, 7, 8, 9, 10 };
            Assert.Equal(results, Matches.ToArray());
        }
    }
}
