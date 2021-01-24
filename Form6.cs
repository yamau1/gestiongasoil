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
using System.IO;

namespace GUI_V_2
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }
        private byte[] img;
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && Nom.Text != "")
            {
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True;Allow User Variables=True");
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd1 = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();
                MySqlCommand cmd3 = new MySqlCommand();
                MySqlCommand cmd4 = new MySqlCommand();
                cmd1.Connection = cnx;
                cmd.Connection = cnx;
                cmd2.Connection = cnx;
                cmd3.Connection = cnx;
                cmd4.Connection = cnx;




                String dt;

                if (dateser.Checked) { dt = dateser.Value.ToString("yyyy-MM-dd"); }
                else dt = null;



                cmd.Parameters.AddWithValue("@ID", ((object)id.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nom", ((object)Nom.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Date_Fabrication", ((object)year.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@date_mise_en_service", ((object)dt) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_direction", ((object)direction.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_famille_clé", ((object)famille.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@idi_section_clé", ((object)section.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Type_Modèle_clé", ((object)modele.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_fournisseur_equip_clé", ((object)fournisseur.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id_Marque_clé", ((object)marque.SelectedValue) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Num_SERIE", ((object)numserie.Text) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@img", ((object)img) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@constructeur", ((object)constructeur.SelectedValue) ?? DBNull.Value);


                cmd1.Parameters.AddWithValue("@manuel", ((object)Mnl.SelectedValue) ?? DBNull.Value);
                cmd2.Parameters.AddWithValue("@type2", ((object)type22.SelectedValue) ?? DBNull.Value);
                cmd3.Parameters.AddWithValue("@type3", ((object)type33.SelectedValue) ?? DBNull.Value);






                try
                {
                    cmd.CommandText = "INSERT INTO equipement VALUES  (@ID,@Nom,@Date_Fabrication,@date_mise_en_service,@id_direction,@id_famille_clé,@idi_section_clé,@Type_Modèle_clé,@Num_SERIE,@id_Marque_clé,@id_fournisseur_equip_clé,@constructeur,@img )";
                    cmd1.CommandText = "INSERT INTO doc_equi VALUES ('manuel','" + id.Text + "',@manuel) on duplicate key update id_doc_clé=@manuel  ";
                    cmd2.CommandText = "INSERT INTO doc_equi VALUES ('type2','" + id.Text + "',@type2) on duplicate key update id_doc_clé=@type2  ";
                    cmd3.CommandText = "INSERT INTO doc_equi VALUES ('type3','" + id.Text + "',@type3) on duplicate key update id_doc_clé=@type3  ";
                    cmd4.CommandText = " delete from doc_equi where (id_doc_clé is null )";

                    cnx.Open();





                    if (cmd.ExecuteNonQuery() == 0) { MessageBox.Show("Aucune Modification Effectuée", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                    else MessageBox.Show("Modification Terminé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();






                    cnx.Close();
                    
                    this.Close();
                   

                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }


            }
            else MessageBox.Show("Veuillez Saisir ID et Nom", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choisir une Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                img = File.ReadAllBytes(opf.FileName);
                pictureBox1.Image = Image.FromFile(opf.FileName);

                linkLabel1.Visible = true;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            for (int i = 1950; i <= Int32.Parse(DateTime.Now.Year.ToString()); i++)
            {

                year.Items.Add(i);
            }


            DataTable table1 = new DataTable();
            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT id_direction  from direction ;" +
                "SELECT id_Famille  from famille;" +
            "SELECT id_section  from section_gestion ;" + "SELECT id_modele from modele_equip;" +
            "SELECT id_fournisseur_equip from fournisseur_equip;" +
            "SELECT id_Constructeur from constructeur;" + "SELECT Marque_clé from marque_equip;" +

           "SELECT id_doc from documentation where type='manuel';" +
            "SELECT id_doc from documentation where type='type2';" +
            "SELECT id_doc from documentation where type='type3'";

            cnx.Open();


            da.Fill(ds);


            direction.DataSource = ds.Tables[0];
            famille.DataSource = ds.Tables[1];
            section.DataSource = ds.Tables[2];
            modele.DataSource = ds.Tables[3];
            fournisseur.DataSource = ds.Tables[4];
            constructeur.DataSource = ds.Tables[5];
            marque.DataSource = ds.Tables[6];
            Mnl.DataSource = ds.Tables[7];
            type22.DataSource = ds.Tables[8];
            type33.DataSource = ds.Tables[9];

            direction.ValueMember = "id_direction";
            famille.ValueMember = "id_Famille";
            section.ValueMember = "id_section";
            modele.ValueMember = "id_modele";
            fournisseur.ValueMember = "id_fournisseur_equip";
            constructeur.ValueMember = "id_Constructeur";
            marque.ValueMember = "Marque_clé";
            Mnl.ValueMember = "id_doc";
            type22.ValueMember = "id_doc";
            type33.ValueMember = "id_doc";

            direction.ResetText();
            direction.SelectedIndex = -1;
            famille.ResetText();
            famille.SelectedIndex = -1;
            modele.ResetText();
            modele.SelectedIndex = -1;
            fournisseur.ResetText();
            fournisseur.SelectedIndex = -1;
            constructeur.ResetText();
            constructeur.SelectedIndex = -1;
            marque.ResetText();
            marque.SelectedIndex = -1;
            section.ResetText();
            section.SelectedIndex = -1;
            Mnl.ResetText();
            Mnl.SelectedIndex = -1;
            type22.ResetText();
            type22.SelectedIndex = -1;
            type33.ResetText();
            type33.SelectedIndex = -1;





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
