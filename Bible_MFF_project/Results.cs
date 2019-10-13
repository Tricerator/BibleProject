using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible_MFF_project
{

   
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();

            foreach (int key in XMLParser.resultsDictionary.Keys)
            {
                List<string> strList;
                XMLParser.resultsDictionary.TryGetValue(key, out strList);
                foreach (string st in strList)
                {
                    string[] fields = st.Split('/');
           //         int start;
             //       int len = int.Parse(fields[1]);
              //      if (!int.TryParse(fields[0], out start)) {
            //            string[] indexes = fields[0].Split(' ');
                        richTextBox_results.Text += fields[2] + Environment.NewLine;
                    /*   //              foreach (string ind in indexes)
                        {
                            if (ind == "") continue;
                            richTextBox_results.Select(richTextBox_results.Text.Length + int.Parse(ind), len);
                            richTextBox_results.SelectionColor = Color.Yellow;
                        }
                    } else { 
                    richTextBox_results.Text += fields[2] + Environment.NewLine;
                    richTextBox_results.Select(richTextBox_results.Text.Length + start, len);
                    richTextBox_results.SelectionColor = Color.Yellow;
                         } */
                }
            }
           


            //richTextBox_results.Text = XMLParser.resultsDictionaryToString();
            if (richTextBox_results.Text == "")
            {
                richTextBox_results.Text = "Hledaný výraz nenalezen";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            new Menu().Show();
            this.Close();
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(richTextBox_results.Text);
                    }
                }
            }
        }

        private void richTextBox_results_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_changeSeek_Click(object sender, EventArgs e)
        {
            richTextBox_results.Clear();
            Searcher temp = new Searcher();

        }

        

        private void Results_Load(object sender, EventArgs e)
        {

        }

        private void button_newSearch(object sender, EventArgs e)
        {
            Searcher searcher = new Searcher();

            this.Close();
            searcher.Show();
            

        }
    }
}
