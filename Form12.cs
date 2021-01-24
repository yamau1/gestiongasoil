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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            textBox1.MaxLength = 5;
        }
        public string st;
        private void Form12_Load(object sender, EventArgs e)
        {

            DataTable table1 = new DataTable();
            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            cmd.CommandText = "SELECT id_equip from equipement";
            cnx.Open();
            table1.Load(cmd.ExecuteReader());
            cnx.Close();
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "id_equip";
            comboBox1.ValueMember = "id_equip";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True;Allow User Variables=True");
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd1 = new MySqlCommand();


                cmd1.Connection = cnx;
                cmd.Connection = cnx;



                cmd.Parameters.AddWithValue("@equip", ((object)comboBox1.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@quantité", ((object)textBox1.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@conducteur", ((object)textBox2.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@index", ((object)textBox3.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@st", ((object)st) ?? DBNull.Value);
                cmd1.Parameters.AddWithValue("@st", ((object)st) ?? DBNull.Value);
                cmd1.Parameters.AddWithValue("@quantité", ((object)textBox1.Text) ?? DBNull.Value);






                cmd.CommandText = "INSERT INTO `alimentation`  VALUES (NULL,@equip,1 , current_timestamp(),@quantité,@conducteur,@index,@st)";

                cmd1.CommandText = "UPDATE station SET STOCK=STOCK-@quantité where nom_station=@st ";



                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();




                    cnx.Close();
                    MessageBox.Show("Sauvegardé avec succées");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("veuillez remplir le formulaire correctement");
                }

            }catch (MySqlException x) {
                if (x.Number == 1452) MessageBox.Show("code équipement incorrect");
                else MessageBox.Show(x.Message);
                 
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
