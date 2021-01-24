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
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
        public string id_equip { get; set; }
        public string nom_equip { get; set; }

        public void manuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idequip = id_equip;
           
            String strm = idequip + "manuel.pdf";
            String path = Directory.GetCurrentDirectory() + "\\" + strm;
            
           
            



                DataTable table2 = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);



                cmd.CommandText = "SELECT file  from documentation ,doc_equi where  id_equip_clé ='" + idequip + "' AND id_doc_clé=id_doc AND doc_equi.type='manuel' ";
                cnx.Open();
                da.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    byte[] file = (byte[])table2.Rows[0][0];
                    FileStream fs = new FileStream(strm, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter br = new BinaryWriter(fs);
                    br.Write(file);
                    br.Close();
                    cnx.Close();
                    da.Dispose();
                axAcroPDF1.src = Directory.GetCurrentDirectory() + "\\" + strm;

            }
            else
                {
                    MessageBox.Show("Documentation n'existe pas ");
                    
                }

            
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string text = id_equip;
            String nomequip = nom_equip;
            String strm = text + "222.pdf";
            String path = Directory.GetCurrentDirectory() + "\\" + strm;
           
            
            



                DataTable table2 = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);



                cmd.CommandText = "SELECT designation_doc ,file  from documentation ,doc_equi where  id_equip_clé ='" + text + "' AND id_doc_clé=id_doc AND doc_equi.type='type2' ";
                cnx.Open();
                da.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    byte[] file = (byte[])table2.Rows[0][1];
                    FileStream fs = new FileStream(strm, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter br = new BinaryWriter(fs);
                    br.Write(file);
                    br.Close();

                    cnx.Close();
                    da.Dispose();
                    axAcroPDF1.src = Directory.GetCurrentDirectory() + "\\" + strm;
                }
                else MessageBox.Show("Documentation n'existe pas");

            


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string text = id_equip;
            String strm = text + "33.pdf";
            String path = Directory.GetCurrentDirectory() + "\\" + strm;
            
            



                DataTable table2 = new DataTable();
                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);



                cmd.CommandText = "SELECT designation_doc ,file  from documentation ,doc_equi where  id_equip_clé ='" + text + "' AND id_doc_clé=id_doc AND doc_equi.type='type3' ";
                cnx.Open();
                da.Fill(table2);
                if (table2.Rows.Count > 0)
                {
                    byte[] file = (byte[])table2.Rows[0][1];
                    FileStream fs = new FileStream(strm, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter br = new BinaryWriter(fs);
                    br.Write(file);
                    br.Close();

                    cnx.Close();
                    da.Dispose();
                axAcroPDF1.src = Directory.GetCurrentDirectory() + "\\" + strm;

            }
            else MessageBox.Show("Documentation n'existe pas");


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
            
        
    
}
