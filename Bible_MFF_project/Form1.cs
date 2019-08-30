using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible_MFF_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {

           
           string input = textBoxInput.Text;
           XMLParser.readXML(input,"");
            this.Hide();
            Results R1 = new Results();
            R1.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_language_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
        }
       
    }
}
 
