using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace GUI_V_2
{
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();


            
    }
        public byte[] pdf1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            type.Items.Add("manuel");
            type.Items.Add("type1");
            type.Items.Add("type2");
        }

        private void button1_Click(object sender, EventArgs e)
        {  
        OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choisir un fichier(*.pdf)|*.pdf";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                pdf1 = File.ReadAllBytes(opf.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(id.Text) && !String.IsNullOrEmpty(nom.Text) && type.SelectedItem != null && pdf1 != null)
            {

                try
                {


                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True;Allow User Variables=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;

                    cmd.Parameters.AddWithValue("@ID", ((object)id.Text) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nom", ((object)nom.Text) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Type", ((object)type.SelectedItem) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@pdf1", ((object)pdf1) ?? DBNull.Value);
                    cmd.CommandText = "INSERT INTO documentation (id_doc,designation_doc,type,file) VALUES (@ID,@Nom,@Type,@pdf1)";
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Insertion Terminée", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (MySqlException r) { MessageBox.Show(r.Message); }
                this.Close();
            }
            else MessageBox.Show("veuillez saisir tous les informations");

            
            

        }
    }
}
