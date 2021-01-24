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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox1.MaxLength = 5;
            textBox2.MaxLength = 5;
            textBox3.MaxLength = 5;
            textBox4.MaxLength = 5;
            textBox5.MaxLength = 5;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Visible = false;
                textBox5.Visible = false;
                label4.Visible = true;
                label3.Visible = true;
                label2.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                comboBox2.Visible = false;
                label11.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;




            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label6.Visible = true;
                textBox5.Visible = true;
                comboBox2.Visible = true;
                label11.Visible = true;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;


            }
        }

        private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            try
            {
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True;Allow User Variables=True");
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd1 = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();
                MySqlCommand cmd3 = new MySqlCommand();
                MySqlCommand cmd4 = new MySqlCommand();
                MySqlCommand cmd5 = new MySqlCommand();
          
                cmd1.Connection = cnx;
                cmd.Connection = cnx;
                cmd2.Connection = cnx;
                cmd3.Connection = cnx;
                cmd4.Connection = cnx;
                cmd5.Connection = cnx;
               

                cmd.Parameters.AddWithValue("@nord", ((object)textBox1.Text) ?? DBNull.Value);
                cmd1.Parameters.AddWithValue("@sud", ((object)textBox4.Text) ?? DBNull.Value);
                cmd2.Parameters.AddWithValue("@snvi", ((object)textBox3.Text) ?? DBNull.Value);
                cmd3.Parameters.AddWithValue("@iveco", ((object)textBox2.Text) ?? DBNull.Value);
                cmd4.Parameters.AddWithValue("@equip", ((object)textBox5.Text) ?? DBNull.Value);
                



                cmd.CommandText = "INSERT INTO `approvisionnement`  VALUES (NULL, current_timestamp(), @nord,'Station nord');" + "UPDATE station SET STOCK=STOCK+@nord where id_station =1 ";
                cmd1.CommandText = "INSERT INTO `approvisionnement`  VALUES (NULL, current_timestamp(), @sud,'Station sud');" + "UPDATE station SET STOCK=STOCK+@sud where id_station =3";
                cmd2.CommandText = "INSERT INTO `approvisionnement`  VALUES (NULL, current_timestamp(), @snvi,'Camion SNVI');" + "UPDATE station SET STOCK=STOCK+@snvi where id_station =2";
                cmd3.CommandText = "INSERT INTO `approvisionnement`  VALUES (NULL, current_timestamp(), @iveco,'Camion IVECO');" + "UPDATE station SET STOCK=STOCK+@iveco where id_station =4";
                cmd4.CommandText = "INSERT INTO `approvisionnement`  VALUES (NULL, current_timestamp(), @equip,'" + comboBox2.SelectedValue + "')";
                cmd5.CommandText = "DELETE FROM approvisionnement where litres_approvisionnement is NULL OR litres_approvisionnement=0 ";
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
                    {
                        cnx.Open();
                       
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();



                        cnx.Close();
                        MessageBox.Show("Sauvegardé avec succées");
                        this.Close();

                    }
                    else { MessageBox.Show("veuillez remplir le formulaire correctement !"); }

                }else
                {
                    if(textBox5.Text!="")
                    {


                        cnx.Open();
                        cmd4.ExecuteNonQuery();
                        cmd5.ExecuteNonQuery();
                        cnx.Close();
                        MessageBox.Show("Sauvegardé avec succées");
                        this.Close();
                        


                    } else { MessageBox.Show("veuillez remplir le formulaire correctement !"); }

                }
                
            }
            catch (MySqlException x) {
                if (x.Number == 4025)
                {
                    MessageBox.Show("Stock limité vérifiez vos donnnées","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

              }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
