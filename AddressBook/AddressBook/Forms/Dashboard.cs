using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook.Forms;

namespace AddressBook.Forms
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People ppl = new People();

            ppl.Show();
            this.Hide();
        }

        private void CompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies comp = new Companies();

            comp.Show();
            this.Hide();
        }
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searches src = new Searches();

            src.Show();
            this.Hide();

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
