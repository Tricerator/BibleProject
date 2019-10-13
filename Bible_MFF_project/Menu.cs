using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible_MFF_project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searcher searcher = new Searcher();
            searcher.Show();
        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        ///
        //<div>Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/"         title="Flaticon">www.flaticon.com</a></div>

        //
        //
        //
        //
        //
        //
    }
}
