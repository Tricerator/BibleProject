using System;

using System.IO;

using System.Windows.Forms;

namespace Bible_MFF_project
{
    /// <summary>
    /// This form is for getting params for searching, it collects them 
    /// and sends them to SetterOfSearch
    /// </summary>
    public partial class Searcher : Form
    {
        public Searcher()
        {
            InitializeComponent();
            XMLParser.clearAll();
           

            foreach (string file in Directory.EnumerateDirectories("../../Translations")) {
               
                listBox_languages.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
        }
        /// <summary>
        /// This method collects params after button_search click and sends them to setter
        /// </summary>
        public void sendDataToSetterOfSearch()
        {
            try { 
            SetterOfSearch stOfSearch = new SetterOfSearch();
            //mode
            stOfSearch.ExactMatch = checkBox_exact_match.Checked;
            stOfSearch.SmallLetters = checkBox_toSmallLetters.Checked;
            stOfSearch.WithoutDiacritics = checkBox_WithoutDiacritic.Checked;
            stOfSearch.MultiplePatterns = checkBox_MultiplePatterns.Checked;
            stOfSearch.FlexibleWordsPosition = checkBox_flexibleWordsPosition.Checked;

            //language
            stOfSearch.language = listBox_languages.SelectedItem.ToString();
            //translation
            foreach(string transl in checkedListBox_translation.CheckedItems)
            {
                stOfSearch.add_translaltion(transl);

            }

            //Books
            //todo

            //searchedPattern
            stOfSearch.SearchedPattern = textBox_Input.Text.TrimEnd('\r','\n');

            stOfSearch.parseData();
            stOfSearch.callSearch();

            }catch (NullReferenceException)
            {
                Warning warning = new Warning();
                warning.ShowDialog();

            }

        }
        /// <summary>
        /// Final Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_search_Click(object sender, EventArgs e)
        {
            sendDataToSetterOfSearch();
            if(checkedListBox_translation.CheckedItems.Count == 0)
            {
               
            }else { 
            this.Hide();
    //       string input = textBoxInput.Text;
      //     XMLParser.readXML(input,"");
           
            Results result = new Results();
            result.Show();
            }
            // R1.tex
            //        textBox_Result.Text = XMLParser.dataToString();
            //       if (textBox_Result.Text == "")
            //        {
            //          textBox_Result.Text = "Hledaný výraz nenalezen";

            //    }
            //    textBox_result = 
            //  this.Hide();
            //  Results R1 = new Results();
            //  R1.Show();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this method is interactive, for language it gives the possibility to chose
        /// a translation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox_languages.GetItemText(listBox_languages.SelectedItem);
            // checkedListBox_translation.Items.Add(text);
            checkedListBox_translation.Items.Clear();
            foreach (string file in Directory.EnumerateFiles("../../Translations/"+text))
            {
                checkedListBox_translation.Items.Add(Path.GetFileNameWithoutExtension(file));
           //     checkItems.Add();
            }


        }

        private void checkedListBox_translation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// This checkbox allows  user to check or uncheck all the possibilities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_translationAll.Checked)
            {
                for (int i = 0; i < checkedListBox_translation.Items.Count; i++)
                {
                    checkedListBox_translation.SetItemChecked(i,true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox_translation.Items.Count; i++)
                {
                    checkedListBox_translation.SetItemChecked(i, false);
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Exact match mean the string as is. I will use KMP search for that type of 
        /// inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_exact_match_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_exact_match.Checked)
            {
                checkBox_MultiplePatterns.Checked = false;
                checkBox_exact_match.Checked = true;
            }
        }


        private void ltranslation_Click(object sender, EventArgs e)
        {

        }

        private void label_mode_Click(object sender, EventArgs e)
        {

        }

        private void Searcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Menu().Show();
        }

        private void Searcher_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Multiple patterns leads to classical Aho/Corasick pattern searching algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_MultiplePatterns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_exact_match.Checked)
            {
                checkBox_exact_match.Checked = false;
                checkBox_flexibleWordsPosition.Checked = false;
            }
        }
        /// <summary>
        /// Flexible words means that I need to find the whole sentence but it does not have to be 
        /// word by word in a row.
        /// Example: 
        /// Pattern to find : Abraham said
        /// Verse found     : Then said their father Abraham to them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_flexibleWordsPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_flexibleWordsPosition.Checked)
            {
                checkBox_exact_match.Checked = false;
                checkBox_MultiplePatterns.Checked = false;
            }
        }
    }
}
 
