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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);

        }
        public int x;
        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                DataTable table2 = new DataTable();
                DataTable table3 = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd1 = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();
                MySqlCommand cmd3 = new MySqlCommand();
                cmd.Connection = cnx;
                cmd1.Connection = cnx;
                cmd2.Connection = cnx;
                cmd3.Connection = cnx;

                cmd.CommandText = "SELECT alimentation.id_equip_clé as 'Equipement',alimentation.nom_station_clé as 'Station',equipement.idi_section_clé as 'Section de gestion',equipement.id_direction as 'Direction',alimentation.Date,alimentation.quantité,alimentation.index_horaire as 'Index horaire',alimentation.nom_du_conducteur as 'Nom du conducteur' FROM equipement RIGHT JOIN alimentation ON equipement.id_equip = alimentation.id_equip_clé  ";
                cmd1.CommandText = "Select id_section from section_gestion";
                cmd2.CommandText = "SELECT id_equip from equipement ";
                cmd3.CommandText = "SELECT id_direction from direction ";

                cnx.Open();
                table.Load(cmd.ExecuteReader());
                table1.Load(cmd1.ExecuteReader());
                table2.Load(cmd2.ExecuteReader());
                table3.Load(cmd3.ExecuteReader());

                cnx.Close();

            

                comboBox2.DataSource = table1;
                comboBox3.DataSource = table2;
                comboBox4.DataSource = table3;

                comboBox2.DisplayMember = "id_section";
                comboBox2.ValueMember = "id_section";
                comboBox3.DisplayMember = "id_equip";
                comboBox3.ValueMember = "id_equip";
                comboBox4.DisplayMember = "id_direction";
                comboBox4.ValueMember = "id_direction";

                DataRow newRow = table.NewRow();
                String q = "quantité";

                newRow[5] = table.Compute("Sum([" + q + "])", "");
                newRow[0] = "TOTALE";









                table.Rows.Add(newRow);
                x = table.Rows.IndexOf(newRow);
                dataGridView1.DataSource = table;

                this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
                

               
            }
            catch (MySqlException A) { MessageBox.Show(A.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f8 = new Form12();
            f8.Show();
            f8.TopMost = true;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.Rows[x].Cells[5].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x].Cells[5].Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView1.Rows[x].Cells[0].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x].Cells[0].Style.Font = new Font("Arial", 12, FontStyle.Bold);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    DataTable table = new DataTable();
                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);


                    cmd.CommandText = "SELECT alimentation.id_equip_clé as 'Equipement',alimentation.nom_station_clé as 'Station',equipement.idi_section_clé as 'Section de gestion',equipement.id_direction as 'Dirfection',alimentation.Date,alimentation.quantité,alimentation.index_horaire as 'Index horaire',alimentation.nom_du_conducteur as 'Nom du conducteur' FROM equipement RIGHT JOIN alimentation ON equipement.id_equip = alimentation.id_equip_clé    where Date >= @date1 AND Date<@date2   ";

                    cnx.Open();
                    table.Load(cmd.ExecuteReader());

                    cnx.Close();
                    try
                    {


                        DataRow newRow = table.NewRow();
                        String q = "quantité";

                        newRow[5] = table.Compute("Sum([" + q + "])", "");
                        newRow[0] = "TOTALE";





                        table.Rows.Add(newRow);

                        x = table.Rows.IndexOf(newRow);



                        
                        dataGridView1.DataSource = table;


                        this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                        dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";

                       
                        


                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }

                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    label5.Visible = true;
                    comboBox2.Visible = true;
                    label7.Visible = false;
                    comboBox4.Visible = false;
                    label6.Visible = false;
                    comboBox3.Visible = false;
                    DataTable table = new DataTable();
                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@sect", ((object)comboBox2.Text) ?? DBNull.Value);


                    cmd.CommandText = "SELECT alimentation.id_equip_clé as 'Equipement',alimentation.nom_station_clé as 'Station',equipement.idi_section_clé as 'Section de gestion',equipement.id_direction as 'Dirfection',alimentation.Date,alimentation.quantité,alimentation.index_horaire as 'Index horaire',alimentation.nom_du_conducteur as 'Nom du conducteur' FROM equipement RIGHT JOIN alimentation ON equipement.id_equip = alimentation.id_equip_clé    where Date >= @date1 AND Date<@date2   AND equipement.idi_section_clé= @sect";

                    cnx.Open();
                    table.Load(cmd.ExecuteReader());

                    cnx.Close();
                    try
                    {


                        DataRow newRow = table.NewRow();
                        String q = "quantité";

                        newRow[5] = table.Compute("Sum([" + q + "])", "");
                        newRow[0] = "TOTALE";





                        table.Rows.Add(newRow);

                        x = table.Rows.IndexOf(newRow);




                        dataGridView1.DataSource = table;


                        this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                        dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";





                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }

                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }
            }
            else if(comboBox1.SelectedIndex == 2)
            {

                try
                {
                    label6.Visible = true;
                    comboBox3.Visible = true;
                    label7.Visible = false;
                    comboBox4.Visible = false;
                    label5.Visible = false;
                    comboBox2.Visible = false;
                    DataTable table = new DataTable();
                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@equip", ((object)comboBox3.Text) ?? DBNull.Value);


                    cmd.CommandText = "SELECT alimentation.id_equip_clé as 'Equipement',alimentation.nom_station_clé as 'Station',equipement.idi_section_clé as 'Section de gestion',equipement.id_direction as 'Dirfection',alimentation.Date,alimentation.quantité,alimentation.index_horaire as 'Index horaire',alimentation.nom_du_conducteur as 'Nom du conducteur' FROM equipement RIGHT JOIN alimentation ON equipement.id_equip = alimentation.id_equip_clé    where Date >= @date1 AND Date<@date2   AND alimentation.id_equip_clé= @equip";

                    cnx.Open();
                    table.Load(cmd.ExecuteReader());

                    cnx.Close();
                    try
                    {


                        DataRow newRow = table.NewRow();
                        String q = "quantité";

                        newRow[5] = table.Compute("Sum([" + q + "])", "");
                        newRow[0] = "TOTALE";





                        table.Rows.Add(newRow);

                        x = table.Rows.IndexOf(newRow);




                        dataGridView1.DataSource = table;


                        this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                        dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";





                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }

                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }







            }else if(comboBox1.SelectedIndex == 3)
            {



                try
                {
                    label7.Visible = true;
                    comboBox4.Visible = true;
                    label6.Visible = false;
                    comboBox3.Visible = false;
                    label5.Visible =false;
                    comboBox2.Visible = false;
                    DataTable table = new DataTable();
                    MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@direc", ((object)comboBox4.Text) ?? DBNull.Value);


                    cmd.CommandText = "SELECT alimentation.id_equip_clé as 'Equipement',alimentation.nom_station_clé as 'Station',equipement.idi_section_clé as 'Section de gestion',equipement.id_direction as 'Dirfection',alimentation.Date,alimentation.quantité,alimentation.index_horaire as 'Index horaire',alimentation.nom_du_conducteur as 'Nom du conducteur' FROM equipement RIGHT JOIN alimentation ON equipement.id_equip = alimentation.id_equip_clé    where Date >= @date1 AND Date<@date2   AND equipement.id_direction=@direc";

                    cnx.Open();
                    table.Load(cmd.ExecuteReader());

                    cnx.Close();
                    try
                    {


                        DataRow newRow = table.NewRow();
                        String q = "quantité";

                        newRow[5] = table.Compute("Sum([" + q + "])", "");
                        newRow[0] = "TOTALE";





                        table.Rows.Add(newRow);

                        x = table.Rows.IndexOf(newRow);




                        dataGridView1.DataSource = table;


                        this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                        dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";





                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }

                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
