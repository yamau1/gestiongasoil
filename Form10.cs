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
using System.Threading.Tasks;
using System.Threading;

namespace GUI_V_2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            
        }

        private void Form10_Load(object sender, EventArgs e)
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



            cmd.CommandText = "SELECT STOCK FROM station where id_station=1 ";
            cmd1.CommandText = "SELECT STOCK FROM station where id_station=2 ";
            cmd2.CommandText = "SELECT STOCK FROM station where id_station=3 ";
            cmd3.CommandText = "SELECT STOCK FROM station where id_station=4 ";


            cnx.Open();
            table.Load(cmd.ExecuteReader());
            table1.Load(cmd1.ExecuteReader());
            table2.Load(cmd2.ExecuteReader());
            table3.Load(cmd3.ExecuteReader());
            cnx.Close();

            Double stock =Math.Round( Convert.ToDouble( table.Rows[0][0]),1);
            Double percent = (stock * 100) / 30000;
            Double per2= Math.Round(percent, 1);


            for (int i = 1; i <= percent; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
            label1.Text = stock.ToString() + "   Litres";
            label2.Text = per2.ToString() + "  %";


            Double stock1 = Math.Round(Convert.ToDouble(table1.Rows[0][0]), 1);
            Double percent1 = (stock1 * 100) / 12000;
            Double per21 = Math.Round(percent1, 1);


            for (int j = 1; j <= percent1; j++)
            {
                Thread.Sleep(5);
                circularProgressBar2.Value = j;
                circularProgressBar2.Update();
            }
            label4.Text = stock1.ToString() + "   Litres";
            label3.Text = per21.ToString() + "  %";


            Double stock2 = Math.Round(Convert.ToDouble(table2.Rows[0][0]), 1);
            Double percent2 = (stock2 * 100) / 30000;
            Double per22 = Math.Round(percent2, 1);


            for (int k= 1; k<= percent2; k++)
            {
                Thread.Sleep(5);
                circularProgressBar6.Value = k;
                circularProgressBar6.Update();
            }
            label12.Text = stock2.ToString() + "   Litres";
            label11.Text = per22.ToString() + "  %";


            Double stock3 = Math.Round(Convert.ToDouble(table3.Rows[0][0]), 1);
            Double percent3 = (stock3 * 100) / 8000;
            Double per23 = Math.Round(percent3, 1);


            for (int m = 1; m <= percent3; m++)
            {
                Thread.Sleep(5);
                circularProgressBar5.Value = m;
                circularProgressBar5.Update();
            }
            label10.Text = stock3.ToString() + "   Litres";
            label9.Text = per23.ToString() + "  %";




        }


        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularProgressBar6_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
