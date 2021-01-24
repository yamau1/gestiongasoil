using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class NouveauForm : Form
    {
        public NouveauForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ajouter f6 = new Ajouter();
            f6.Show();
            f6.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            f8.TopMost = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.TopMost = true;
            f7.Show();
        }
    }
}
