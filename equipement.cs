using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;




namespace GUI_V_2
{
    public partial class equipement : Form
    {


        public equipement()
        {
            InitializeComponent();
           
            {
                combofiltre.DisplayMember = "Text";
                combofiltre.ValueMember = "Value";

                var items = new[] {
    new { Text = "ID", Value = "id_equip" },
    new { Text = "Nom", Value = "designation_equip" },
    new { Text = "Direction", Value = "id_direction" },
    new { Text = "Famille", Value = "id_famille_clé" },
    new { Text = "Section de gestion", Value = "idi_section_clé" },
    new { Text = "Numero de série", Value = "Num_SERIE" },
    new { Text = "libellé section de gestion", Value = "Libellé_sec_ges" }
                                };

                combofiltre.DataSource = items;


            }

            

        }
    
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }
        private void textrech_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Equipement_load(object sender, EventArgs e)
        {


            try
            {

                DataTable table = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;

                cmd.CommandText = "Select id_equip as ID,designation_equip as Nom ,Date_Fabrication as 'Date de fabrication' ,date_mise_en_service as 'Date mise en service' ,id_direction as 'Direction' ,id_famille_clé as Famille,idi_section_clé as 'section de gestion',Type_Modèle_clé as Modele ,Num_SERIE as 'Num de SERIE' ,id_Marque_clé as marque ,id_fournisseur_equip_clé as fournisseur ,id_Constructeur_clé as constructeur   from equipement ";
                cnx.Open();
                table.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Date de fabrication"].Visible = false;

                cnx.Close();
                linkimage();
                linkdoc();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doc_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.TopMost = true;
            f7.Show();

           
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "linkimage")
                {

                    string text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    String nomequip = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();

                    DataTable table1 = new DataTable();
                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);



                    cmd.CommandText = "SELECT image from equipement where id_equip ='" + text + "' ";
                    cnx.Open();
                    da.Fill(table1);
                    
                   

                    if  (table1.Rows[0][0] != System.DBNull.Value)
                    {
                        byte[] img = (byte[])table1.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);
                        ImageView frm = new ImageView();
                        frm.pictureBox1.Image = Image.FromStream(ms);
                        frm.Text = nomequip;
                        frm.Show();
                        frm.TopMost = true;
                        cnx.Close();
                        da.Dispose();
                    }
                    else MessageBox.Show("image n'existe pas !");



                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "linkdoc")
                {
                    string text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    String nomequip = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();
                    Form4 f4 = new Form4();
                    f4.Text = nomequip;
                    f4.id_equip = text;
                    f4.nom_equip = nomequip;
                    f4.Show();
                    f4.TopMost = true;

                }

            }
            
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }




        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,

                LineAlignment = StringAlignment.Center
            };
            //get the size of the string
            Size textSize = TextRenderer.MeasureText(rowIdx, this.Font);
            //if header width lower then string width then resize
            if (grid.RowHeadersWidth < textSize.Width + 40)
            {
                grid.RowHeadersWidth = textSize.Width + 40;
            }
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {

        }

       public void textrech_TextChanged(object sender, EventArgs e)

        {

            try
            {
                DataTable table = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1; convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;

                cmd.CommandText = "Select id_equip as ID,designation_equip as Nom ,Date_Fabrication as 'Date de fabrication' ,date_mise_en_service as 'Date mise en service' ,id_direction as 'Direction' ,id_famille_clé as Famille,idi_section_clé as 'section de gestion',Type_Modèle_clé as Modele ,Num_SERIE as 'Num de SERIE' ,id_Marque_clé as marque ,id_fournisseur_equip_clé as fournisseur ,id_Constructeur_clé as constructeur from equipement ,section_gestion WHERE " + combofiltre.SelectedValue + " like '%" + textrech.Text + "%' ";

                cnx.Open();
                table.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = table;

                cnx.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }


        }



        private void combofiltre_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void combofiltre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textrech_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void linkimage()
        {
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(link);
            link.HeaderText = "Image";
            link.Name = "linkimage";

            link.Text = "Voir image";

            link.UseColumnTextForLinkValue = true;

        }
        public String man;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            

            String nomequip = dataGridView1.Rows[e.RowIndex].Cells["Nom"].Value.ToString();

             String datem = dataGridView1.Rows[e.RowIndex].Cells["Date mise en service"].Value.ToString();

            
                String datefab = dataGridView1.Rows[e.RowIndex].Cells["Date de fabrication"].Value.ToString();
                string direction = dataGridView1.Rows[e.RowIndex].Cells["Direction"].Value.ToString();
                String famille = dataGridView1.Rows[e.RowIndex].Cells["Famille"].Value.ToString();
                String sec = dataGridView1.Rows[e.RowIndex].Cells["section de gestion"].Value.ToString();
                String modele = dataGridView1.Rows[e.RowIndex].Cells["Modele"].Value.ToString();
                String numserie = dataGridView1.Rows[e.RowIndex].Cells["Num de SERIE"].Value.ToString();
                string marque = dataGridView1.Rows[e.RowIndex].Cells["marque"].Value.ToString();
                String fournisseur = dataGridView1.Rows[e.RowIndex].Cells["fournisseur"].Value.ToString();
                String constructeur = dataGridView1.Rows[e.RowIndex].Cells["constructeur"].Value.ToString();
           


            try
            {
                
            

            Form5 f5 = new Form5();
            f5.Text = nomequip;
            f5.idd = id;
            f5.Nomm = nomequip;
            f5.datemi = datem;
            f5.datefa = datefab;
            f5.direc = direction;
            f5.fam = famille;
            f5.sec = sec ;
            f5.mode = modele;
            f5.numserie.Text = numserie;
            f5.marq= marque;
            f5.fourn= fournisseur;
            f5.cons = constructeur;
          


            f5.Show();




            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void combodoc()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

            combo.HeaderText = "Documentation";
            combo.Name = "combo";
            ArrayList row = new ArrayList();
            row.Add("Manuel");
            row.Add("2");
            row.Add("3");
            combo.Items.AddRange(row.ToArray());
            dataGridView1.Columns.Add(combo);
        }
        private void linkdoc()
        {
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(link);
            link.HeaderText = "Documentation";
            link.Name = "linkdoc";

            link.Text = "Voir pdf";

            link.UseColumnTextForLinkValue = true;



        }

        private void Ajout_Click(object sender, EventArgs e)
        {
            Ajouter f6 = new Ajouter();
            f6.Show();
            f6.TopMost = true;
        }
    }
}







        






