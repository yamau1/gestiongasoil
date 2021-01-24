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
    public partial class Form5 : Form
    {
        
        
        public Form5()
        {
            InitializeComponent();
            
        }
        public String direc;
        public String fam;
        public String mode;
        public String sec;
        public String cons;
        public String fourn;
        public String marq;
        public String datemi;
        public String datefa;
        public String idd;
        public String Nomm;
        public String manuel11;
        public String type222;
        public String type333;


        public byte[] img;
        public byte[] pdf1;
        



        private void Form5_Load(object sender, EventArgs e)
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
            "SELECT id_section  from section_gestion ;"+ "SELECT id_modele from modele_equip;" +
            "SELECT id_fournisseur_equip from fournisseur_equip;" +
            "SELECT id_Constructeur from constructeur;" + "SELECT Marque_clé from marque_equip;"+ 
            "SELECT image from equipement where id_equip ='" + idd+ "' ;"
            + "SELECT id_doc_clé  from doc_equi where  id_equip_clé ='" + idd+ "' AND type='manuel';"
            + "SELECT id_doc_clé  from doc_equi where  id_equip_clé ='" + idd + "'  AND type='type2';"
            + "SELECT id_doc_clé  from doc_equi where  id_equip_clé ='" + idd + "'  AND type='type3';"
            + "SELECT image from equipement where id_equip ='" + idd+ "'; "+
            "SELECT id_doc from documentation where type='manuel';"+
            "Select id_doc_clé from doc_equi where doc_equi.id_equip_clé = '"+idd+"' AND doc_equi.type = 'manuel'; "+
            "Select id_doc_clé from doc_equi where doc_equi.id_equip_clé = '" + idd + "' AND doc_equi.type = 'type2';"+
            "Select id_doc_clé from doc_equi where doc_equi.id_equip_clé = '" + idd + "' AND doc_equi.type = 'type3';"+
            "SELECT id_doc from documentation where type='type2';"+
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
            Mnl.DataSource = ds.Tables[12];
            type22.DataSource= ds.Tables[16];
            type33.DataSource = ds.Tables[17];

            



            if (ds.Tables[13].Rows.Count != 0)
            {

                manuel11 = ds.Tables[13].Rows[0][0].ToString();


            }
            else manuel11 = DBNull.Value.ToString();

            if (ds.Tables[14].Rows.Count != 0)
            {

                type222 = ds.Tables[14].Rows[0][0].ToString();


            }
            else type222 = DBNull.Value.ToString();

            if (ds.Tables[15].Rows.Count != 0)
            {

                type333 = ds.Tables[15].Rows[0][0].ToString();


            }
            else type333 = DBNull.Value.ToString();

            try
            {
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



                direction.SelectedValue = direc;
                famille.SelectedValue = fam;
                modele.SelectedValue = mode;
                fournisseur.SelectedValue = fourn;
                constructeur.SelectedValue = cons;
                marque.SelectedValue = marq;
                section.SelectedValue = sec;
                Mnl.SelectedValue = manuel11;
                type22.SelectedValue = type222;
                type33.SelectedValue = type333;
                year.SelectedIndex = year.FindStringExact(datefa);

                dateser.Text = datemi;

                id.Text = idd;
                Nom.Text = Nomm;


            }
            catch (Exception c) { MessageBox.Show(c.Message); }














            

            if (ds.Tables[7].Rows[0][0] != System.DBNull.Value)
            {
                byte[] img = (byte[])ds.Tables[7].Rows[0][0];
                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);
               
            }




            if (ds.Tables[8].Rows.Count!= 0)
            {
                
                manuel.Visible = false;

            }
            else voirpdf1.Visible = false;

            if (ds.Tables[9].Rows.Count != 0)
            {

                type2.Visible = false;

            }
            else voirpdf2.Visible = false;

            if (ds.Tables[10].Rows.Count != 0)
            {

                type3.Visible = false;

            }
            else voirpdf3.Visible = false;


            if (ds.Tables[11].Rows[0][0] != System.DBNull.Value)
            {
                img = (byte[])ds.Tables[11].Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
               
                pictureBox1.Image = Image.FromStream(ms);
               
                
                
            }
            




            cnx.Close();
            da.Dispose();

            if (pictureBox1.Image == null)
                linkLabel1.Visible = false;
        }


        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void axAcroPDF3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                using (Font myFont = new Font("Century Gothic", 17))
                {
                   e.Graphics.DrawString("No image!", myFont, Brushes.Black, new Point(2, 2));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void type3_Click(object sender, EventArgs e)
        {

        }

        private void dateser_ValueChanged(object sender, EventArgs e)
        {

        }

        private void section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void manuel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (id.Text !="" && Nom.Text != "")
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
                    cmd.CommandText = "UPDATE equipement SET id_equip=@ID,designation_equip=@Nom,Date_Fabrication=@Date_Fabrication,date_mise_en_service=@date_mise_en_service,id_direction=@id_direction,id_famille_clé=@id_famille_clé,idi_section_clé=@idi_section_clé,Type_Modèle_clé=@Type_Modèle_clé,Num_SERIE=@Num_SERIE,id_fournisseur_equip_clé=@id_fournisseur_equip_clé,id_Marque_clé=@id_Marque_clé,id_Constructeur_clé=@constructeur,image=@img where id_equip='" + idd + "'";
                    cmd1.CommandText = "INSERT INTO doc_equi VALUES ('manuel','" +idd + "',@manuel) on duplicate key update id_doc_clé=@manuel  ";
                    cmd2.CommandText = "INSERT INTO doc_equi VALUES ('type2','" + idd + "',@type2) on duplicate key update id_doc_clé=@type2  ";
                    cmd3.CommandText = "INSERT INTO doc_equi VALUES ('type3','" + idd + "',@type3) on duplicate key update id_doc_clé=@type3  ";
                    cmd4.CommandText = " delete from doc_equi where (id_doc_clé is null )";


                    cnx.Open();

                    






                    if (cmd.ExecuteNonQuery() == 0) { MessageBox.Show("Aucune Modification Effectuée", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                    else MessageBox.Show("Modification Terminé","Information",MessageBoxButtons.OK,MessageBoxIcon.Information) ;


                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();




                    cnx.Close();
                    this.Close();

                    





                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }


            }
            else MessageBox.Show("Veuillez Saisir ID et Nom","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
          
        }

        private void voirpdf2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.id_equip = idd;
            f4.toolStripMenuItem2.PerformClick();
            f4.TopMost = true;
            f4.Text = Nomm;

            f4.Show();
        }

        private void voirpdf3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.id_equip = idd;
            f4.toolStripMenuItem3.PerformClick();
            f4.TopMost = true;
            f4.Text = Nomm;
            f4.Show();
        }

        private void voirpdf1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.id_equip = idd;
            f4.manuelToolStripMenuItem.PerformClick();
            f4.TopMost = true;
            f4.Text = Nomm;
            

            f4.Show();
            
        }

        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (pictureBox1.Image != null)
            {
                DialogResult dg = MessageBox.Show("Vous voulez ignorer cette image ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dg == DialogResult.Yes)
                {
                    img = null;
                    pictureBox1.Image = null;
                    linkLabel1.Visible = false;

                }
            }
            else MessageBox.Show("no image !");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Vous voulez supprimer cet élément ?", "Alerte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True;Allow User Variables=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cnx.Open();
                cmd.CommandText = "DELETE FROM equipement where id_equip='" + idd + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                
                this.Close();
               




            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


       

        
    }
}
