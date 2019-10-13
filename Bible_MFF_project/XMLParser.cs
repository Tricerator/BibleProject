using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Bible_MFF_project
{
    class XMLParser
    {



        public static SortedDictionary<int,List<string>> resultsDictionary = new SortedDictionary<int,List<string>>();
        private static List<string> outData = new List<string>();
        private static string algorithm;
        private static bool toSmall = false;
        private static bool withoutDiactritics = false;
        

        public static void clearAll()
        {
            resultsDictionary.Clear();         


        }
        public static void setToSmall(bool b)
        {
            toSmall = b;
        }
        public static void setWithoutDiacritics(bool b)
        {
            withoutDiactritics = b;
        }
        public static string resultsDictionaryToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(int key in resultsDictionary.Keys)
            {
                List<string> strList;
                resultsDictionary.TryGetValue(key, out strList);
                    foreach(string st in strList)
                {
                    sb.Append(st + Environment.NewLine);
                }
            }
            return sb.ToString();
        }

        private static string indexToString(List<int> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int index in list)
            {
                sb.Append(index + " ");
            }
            return sb.ToString();
        }


        public static void callSearchingAlgorithm(string algorithm, string line, List<string> pattern,
                                           string translation, string bookName, int bookNumber,
                                           int chapterNumber, int verseNumber, 
                                           bool small, bool notDiacritics)


            
        {
            string lineOrigin = line;
            if (small)
            {
                string tmp = TransformImput.ToLower(line);
                line = tmp;
                 
            }
            if (notDiacritics)
            {
                string tmp = TransformImput.RemoveDiacritics(line);
                line = tmp;
            }


            if(algorithm == "KMP")
            {

                List<int> results = new List<int>();
                string patt = pattern[0];
                results = KMP.SearchKMP(line, patt);
                if (results.Count == 0)
                {
                    return;
                }
                else
                {
                    int keyDictionary = createKeyNumber(bookNumber, chapterNumber, verseNumber);
                    string oneLine = indexToString(results) + "/" + patt.Length + "/" +
                       translation + " | " + bookName + " " + chapterNumber + ":" + verseNumber + " | " + lineOrigin;
                    addToDictionary(keyDictionary, oneLine);

                }
            }
            else if (algorithm == "AhoCorasick-MP")
            {
                AhoCorasick ahoAlg = new AhoCorasick();
               

                for (int i = 0; i < pattern.Count; i++)
                {
                    ahoAlg.addString(pattern[i], i); 
                }

                ahoAlg.BuildAC();

                List<int> Matches = ahoAlg.ProcessLine(line);
                if (Matches.Count == 0) return;
                else
                {
                    int keyDictionary = createKeyNumber(bookNumber, chapterNumber, verseNumber);
                    string oneLine = indexToString(Matches) + "/ " + "/" +
                       translation + " | " + bookName + " " + chapterNumber + ":" + verseNumber + " | " + lineOrigin;
                    addToDictionary(keyDictionary, oneLine);
                }

               
            }

        }

        public static void setAlgorithm(string algo)
        {
            algorithm = algo;

        }

        public static string dataToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in outData)
            {
                sb.Append(line + Environment.NewLine);
                
            }

            return sb.ToString();

        }
        private static void addToDictionary(int key, string line)
        {
            if (!resultsDictionary.TryGetValue(key, out outData))
            {
                outData = new List<String>();
                outData.Add(line);
                resultsDictionary.Add(key, outData);
            }
            else outData.Add(line);


        }
        private static string keyNumberToString( int number)
        {
            if (number < 10) return "00" + number;
            else if (number < 100) return "0" + number;
            else return "" + number;
        }
        private static int createKeyNumber(int bNumber, int cNumber, int vNumber)
        {
            
            return Convert.ToInt32(bNumber + keyNumberToString(cNumber)+keyNumberToString(vNumber));
        }


        public static void parseXML(List<string> input, string path)
        {

            if (toSmall)
            {
                List<string> tmpList = new List<string>();
                foreach (string s in input)
                {
                    tmpList.Add(TransformImput.ToLower(s));
                }
                input = tmpList;
            }
            if (withoutDiactritics)
            {
                List<string> tmpList = new List<string>();
                foreach (string s in input)
                {
                    tmpList.Add(TransformImput.RemoveDiacritics(s));
                }
                input = tmpList;

            }
            string translation = "";
            string bookName = "";


            int bookNumber = 0;
            int chapterNumber = 0;
            int verseNumber = 0;


                XmlReader myReader = XmlReader.Create(path);
                while (myReader.Read())
                {
                if (myReader.NodeType == XmlNodeType.Element)
                {
                    switch (myReader.Name)
                    {
                        case "XMLBIBLE":
                            translation = myReader.GetAttribute("biblename");
                            break;
                        case "BIBLEBOOK":
                            bookNumber = int.Parse(myReader.GetAttribute("bnumber"));
                            bookName = myReader.GetAttribute("bsname");
                            break;
                        case "CHAPTER":
                            chapterNumber = int.Parse(myReader.GetAttribute("cnumber"));
                            break;
                        case "VERS":
                            verseNumber = int.Parse(myReader.GetAttribute("vnumber"));

                            break;
                        default:
                            continue;
                    }
                }
                else if ((myReader.NodeType == XmlNodeType.Text) && (chapterNumber > 0))
                {
                    List<int> results = new List<int>();
                    string line = myReader.ReadContentAsString();

                    callSearchingAlgorithm(algorithm, line, input, translation, bookName, bookNumber, chapterNumber, verseNumber, toSmall, withoutDiactritics);
                }

                



            }

        }

    }

}
