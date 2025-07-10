using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesto
{
    public partial class thirteen : Form
    {
        public thirteen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            gorewach gorewach = new gorewach();
            gorewach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            gorewach gorewach = new gorewach();
            gorewach.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            fourteen fourteen = new fourteen();
            fourteen.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            gorewach gorewach = new gorewach();
            gorewach.Show();
        }
    }
}
