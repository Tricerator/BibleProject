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
            richTextBox_results.Text = XMLParser.dataToString();
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
    }
}
