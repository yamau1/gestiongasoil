using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace GUI_V_2


{
    public partial class Stationnord : Form
    {
        public Stationnord()
        {
            InitializeComponent();
        }
    


    private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                

                MenuVertical.Width = 55;
                

            }
            else
                MenuVertical.Width = 250;
        }

        


        


        
       

        private void FormPanel(object Formhijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            panel.Visible = true;
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            TopMost = true;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            FormPanel(new equipement());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            FormPanel(new NouveauForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPanel(new Form9());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPanel(new equipement());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormPanel(new NouveauForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.station = "Station nord";
            FormPanel(f13);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Password f14 = new Password();
            f14.pass = "Station nord";
            FormPanel(f14);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Vous voulez déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)

            {
                this.Hide();
                FormLogin sn = new FormLogin();
                sn.Closed += (s, args) => this.Close();
                
                sn.Show();
                sn.TopMost = true;
            }
        }
    }   }






    


