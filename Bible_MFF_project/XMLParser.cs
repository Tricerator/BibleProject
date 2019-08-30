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
        public static List<string> data = new List<string>();

        public static string dataToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in data)
            {
                sb.Append(line + Environment.NewLine);
                
            }

            return sb.ToString();

        }

        public static void readXML(string input, string path)
        {
            if (path.Length > 0)
            {
                parseXML(input, path);
            }
            else
            {
                string pathActual = Directory.GetCurrentDirectory();
                string folderPath = pathActual + "\\Translations\\Cesky";
                foreach (string file in Directory.EnumerateFiles(folderPath, "*.xml"))
                {
                    parseXML(input, file);
                }
            }


        }


        private static void parseXML(string input, string path)
        {

            string translation = "";
            string bookName = "";
            string bookNumber = "";

            int chapterNumber = 0;
            int verseNumber = 0;


            try
            {
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
                                bookNumber = myReader.GetAttribute("bnumber");
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
                        results = KMP.SearchKMP(line, input);
                        if (results.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            data.Add(translation + " " + bookNumber + " " + bookName + " " + chapterNumber + ":" + verseNumber + " " + line);
                        }


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Spatna cesta.");
                Console.WriteLine(e);
            }


        }

    }
}