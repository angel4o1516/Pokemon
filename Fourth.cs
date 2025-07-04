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
    public partial class Fourth : Form
    {
        public Fourth()
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
            Fifth fifth = new Fifth();  
            fifth.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            gorewach gorewach = new gorewach();
            gorewach.Show();
        }
    }
}
