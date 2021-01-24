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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(1);

        }
        public int x;
        private void Form9_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;

            cmd.CommandText = "Select date_approvisionnement as 'Date',litres_approvisionnement as 'La quantité délivrée',Destination FROM approvisionnement ";
            cnx.Open();
            table.Load(cmd.ExecuteReader());
         
            cnx.Close();

            DataRow newRow = table.NewRow();
            String q = "La quantité délivrée";

            newRow[1] = table.Compute("Sum([" + q + "])", "");
            newRow[2] = "";


            table.Rows.Add(newRow);

           x=  table.Rows.IndexOf(newRow);


            dataGridView1.DataSource = table;
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);

            dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f8= new Form8();
            f8.Show();
            f8.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vous étes sur ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                try
                {

                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {


                        if (oneCell.Selected)
                        {
                            int rowindx = oneCell.RowIndex;







                            DateTime date = Convert.ToDateTime(dataGridView1.Rows[rowindx].Cells[0].Value.ToString());
                            Double quantité = (Double)dataGridView1.Rows[rowindx].Cells[1].Value;
                            String destination = dataGridView1.Rows[rowindx].Cells[2].Value.ToString();
                            string s = date.ToString("yyyy-MM-dd HH:mm:ss");



                            dataGridView1.Rows.RemoveAt(rowindx);



                            DataTable table = new DataTable();
                            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                            MySqlCommand cmd = new MySqlCommand();
                            MySqlCommand cmd1 = new MySqlCommand();
                            cmd.Connection = cnx;
                            cmd1.Connection = cnx;
                            cmd1.Parameters.AddWithValue("@quantité", ((object)quantité) ?? DBNull.Value);
                            cmd1.Parameters.AddWithValue("@dest", ((object)destination) ?? DBNull.Value);





                            string query = string.Format("DELETE FROM approvisionnement WHERE date_approvisionnement = '{0}' AND litres_approvisionnement = {1} AND Destination = '{2}'", s, quantité, destination);
                            cmd.CommandText = query;
                            cmd1.CommandText = "UPDATE station SET STOCK=STOCK-@quantité where nom_station=@dest";
                            cnx.Open();
                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();
                            cnx.Close();

                        }
                    }
                }
                catch (MySqlException x) { MessageBox.Show(x.Message); }
            }
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
                    cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value) ;
                    cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);


                    cmd.CommandText = "Select date_approvisionnement as 'Date',litres_approvisionnement as 'La quantité délivrée',Destination FROM approvisionnement   where date_approvisionnement >= @date1 AND date_approvisionnement < @date2   ";

                    cnx.Open();
                    table.Load(cmd.ExecuteReader());
                   
                    cnx.Close();
                    try
                    {
                       
                        DataRow newRow = table.NewRow();
                        String q = "La quantité délivrée";

                        newRow[1] = table.Compute("Sum([" + q + "])", "");
                        newRow[2] = "";


                 table.Rows.Add(newRow);

                        x = table.Rows.IndexOf(newRow);
                        dataGridView1.DataSource = table;
                        this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);


                    }
                    catch (Exception c) { MessageBox.Show(c.Message); }

                    }
                catch (MySqlException x) { MessageBox.Show(x.Message); }
                
            }else if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;


                DataTable table = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@dest", ((object)comboBox2.Text) ?? DBNull.Value);

                cmd.CommandText = "Select date_approvisionnement as 'Date',litres_approvisionnement as 'La quantité délivrée',Destination FROM approvisionnement   where date_approvisionnement >= @date1 AND date_approvisionnement < @date2 AND Destination =@dest";
                cnx.Open();
                table.Load(cmd.ExecuteReader());

                cnx.Close();

                DataRow newRow = table.NewRow();
                String q = "La quantité délivrée";

                newRow[1] = table.Compute("Sum([" + q + "])", "");
                newRow[2] = "";


                table.Rows.Add(newRow);

                x = table.Rows.IndexOf(newRow);
                dataGridView1.DataSource = table;
                this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);


            }

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Rows[x].Cells[1].Style.BackColor = Color.Yellow;
            dataGridView1.Rows[x].Cells[1].Style.Font = new Font("Arial", 12, FontStyle.Bold);

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.Parameters.AddWithValue("@date1", ((object)dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@date2", ((object)dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@dest", ((object)comboBox2.Text) ?? DBNull.Value);

            cmd.CommandText = "Select date_approvisionnement as 'Date',litres_approvisionnement as 'La quantité délivrée',Destination FROM approvisionnement   where date_approvisionnement >= @date1 AND date_approvisionnement < @date2 AND Destination =@dest";
            cnx.Open();
            table.Load(cmd.ExecuteReader());

            cnx.Close();

            DataRow newRow = table.NewRow();
            String q = "La quantité délivrée";

            newRow[1] = table.Compute("Sum([" + q + "])", "");
            newRow[2] = "";


            table.Rows.Add(newRow);

            x = table.Rows.IndexOf(newRow);
            dataGridView1.DataSource = table;
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this , new EventArgs());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this, new EventArgs());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
