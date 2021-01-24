using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI_V_2
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;
            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 10;
        }
        private String actuel;
        public String pass;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            


            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();



            cmd.Connection = cnx;
            cmd1.Connection = cnx;



            cmd.Parameters.AddWithValue("@pass", ((object)pass) ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@pass", ((object)pass) ?? DBNull.Value);



            cmd.CommandText = "SELECT motpasse_utilisateur from utilisateur where designation=@pass";
                

            cmd1.CommandText = "UPDATE utilisateur set motpasse_utilisateur='"+ textBox2.Text + "'  where designation=@pass ";
            cnx.Open();
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                     actuel = rdr.GetString(0);
                  

                    MessageBox.Show(actuel);
                   

                }
            }
            cnx.Close();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text.Equals(actuel) && textBox2.Text.Equals(textBox3.Text))
                {
                    cnx.Open();
                    cmd1.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("Modification terminée avec succés");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();


                }
                else if ((textBox1.Text.Equals(actuel) == false)) { MessageBox.Show("Mot passe incorrect !"); }

                else if (textBox2.Text.Equals(textBox3.Text) == false) { MessageBox.Show("Mots de passes sont pas identique!"); }

            }
            else MessageBox.Show(" Vauillez saisir correctement vos données");



        }

        private void Password_Load(object sender, EventArgs e)
        {
            

        }
    }
}
