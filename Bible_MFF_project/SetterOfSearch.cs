using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible_MFF_project
{
    public class SetterOfSearch
    {

        // mode
        public bool ExactMatch { get; set; }
        
        public bool FlexibleWordsPosition { get; set; }
        public bool MultiplePatterns { get; set; }
        public bool SmallLetters { get; set; }
        public bool WithoutDiacritics { get; set; }


        //translation
        private List<string> translations = new List<string>();
        //language
        public string language { get; set; }

        //books
        private List<string> books = new List<string>();

        //searchedPattern
        public string SearchedPattern { get; set; }

        public List<string> patterns = new List<string>();





        public SetterOfSearch()
        {

            ExactMatch = true;
            FlexibleWordsPosition = false;
            SmallLetters = false;
            WithoutDiacritics = false;
            MultiplePatterns = false;
            SearchedPattern = "";
        }

        public void add_translaltion(string str)
        {
            translations.Add(str);
        }
        public void callSearch()
        {

            parseData();

            string pathActual = Directory.GetCurrentDirectory();
            string folderPath = pathActual + "\\..\\..\\Translations\\" + language;
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.xml"))
            {
                string name = Path.GetFileName(file);
                if (translations.Contains(name.Substring(0, name.Length - 4)))
                {
                    XMLParser.parseXML(patterns, file);

                }
                else continue;
            }
        



    }
        
        
        
        public void parseData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SearchedPattern);
            if (WithoutDiacritics)
            {
                string tmp = TransformImput.RemoveDiacritics(sb.ToString());
                sb.Clear();
                sb.Append(tmp);
                XMLParser.setWithoutDiacritics(true);
                
            }
            if (SmallLetters)
            {
                string tmp = TransformImput.ToLower(sb.ToString());
                sb.Clear();
                sb.Append(tmp);
                XMLParser.setToSmall(true);

            }

            if (FlexibleWordsPosition)
            {
                sb.Replace(',', ' ');
                sb.Replace('.', ' ');

               
                patterns = sb.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                XMLParser.setAlgorithm("AhoCorasick-All");
            
            }
            else if (ExactMatch)
            {
                patterns.Add(sb.ToString());
                XMLParser.setAlgorithm("KMP");
            }
            else if (MultiplePatterns)
            {
                XMLParser.setAlgorithm("AhoCorasick-MP");
                patterns = sb.ToString().Split( new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }

            


        }
    }

}
