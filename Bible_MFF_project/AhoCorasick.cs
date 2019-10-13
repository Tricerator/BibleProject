using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_MFF_project
{
    /// <summary>
    /// 
    /// </summary>
    public class AhoCorasick
    {       List<ACVertex> trie;
            List<int> Wlength;
            int size = 0;
            int root = 0;

            public AhoCorasick()
            {
                trie = new List<ACVertex>();
                Wlength = new List<int>();
                initialisation();
            }

            private void initialisation()
            {
            trie.Add(new ACVertex());
        
             size++;
            }
        public void addString(string s, int wordNumber)
        {
            int currentVertex = root;
            for (int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                if (!trie[currentVertex].Children.ContainsKey(c))
                {
                    trie.Add(new ACVertex());

                    trie[size].SuffixLink = -1; 
                    trie[size].Parent = currentVertex;
                    trie[size].ParentChar = c;
                    trie[currentVertex].Children[c] = size;
                    size++;
                }
                currentVertex = (int)trie[currentVertex].Children[c]; 
            }
            trie[currentVertex].Leaf = true;
            trie[currentVertex].WordNumber = wordNumber;
            Wlength.Add(s.Length);

        }


        public void BuildAC()
        {
            Queue<int> vertexQueue = new Queue<int>();
            vertexQueue.Enqueue(root);
            while (vertexQueue.Count > 0)
            {
                int currentVertex = vertexQueue.Dequeue();
                CalcSuffLink(currentVertex);

                foreach (char key in trie[currentVertex].Children.Keys)
                {
                    vertexQueue.Enqueue((int)trie[currentVertex].Children[key]);
                }
            }
        }

        public void CalcSuffLink(int vertex)
        {

            if (vertex == root)
            {
                trie[vertex].SuffixLink = root;
                trie[vertex].EndWordLink = root;
                return;
            }
            if (trie[vertex].Parent == root)
            {
                trie[vertex].SuffixLink = root;
                if (trie[vertex].Leaf) trie[vertex].EndWordLink = vertex;
                else trie[vertex].EndWordLink = trie[trie[vertex].SuffixLink].EndWordLink;
                return;
            }
            int curBetterVertex = trie[trie[vertex].Parent].SuffixLink;
            char chVertex = trie[vertex].ParentChar;
            
            while (true)
            {
                if (trie[curBetterVertex].Children.ContainsKey(chVertex))
                {
                    trie[vertex].SuffixLink = (int)trie[curBetterVertex].Children[chVertex];
                    break;
                }
                if (curBetterVertex == root)
                {
                    trie[vertex].SuffixLink = root;
                    break;
                }
                curBetterVertex = trie[curBetterVertex].SuffixLink; // Go back by sufflink
            }
            if (trie[vertex].Leaf) trie[vertex].EndWordLink = vertex;
            else trie[vertex].EndWordLink = trie[trie[vertex].SuffixLink].EndWordLink;
        }


        public List<int> ProcessLine(string line)
        {
            List<int> indexOfMatches = new List<int>();
            int currentState = root;
            for (int j = 0; j < line.Length; j++)
            {
                while (true)
                {
                    if (trie[currentState].Children.ContainsKey(line[j]))
                    {
                        currentState = (int)trie[currentState].Children[line[j]];
                        break;
                    }
                    if (currentState == root) break;
                    currentState = trie[currentState].SuffixLink;
                }
                int checkState = currentState;

                while (true)
                {
                    checkState = trie[checkState].EndWordLink;

                    if (checkState == root) break;

                    int indexOfMatch = j + 1 - Wlength[trie[checkState].WordNumber];
                    indexOfMatches.Add(indexOfMatch);
                    checkState = trie[checkState].SuffixLink;
                }
            }

            return indexOfMatches;
        }



    }




}
