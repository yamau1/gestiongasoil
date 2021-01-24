using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace GUI_V_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
            txtpass.MaxLength = 10;
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
           
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "")
            {
                DataTable table = new DataTable();

                MySqlConnection cnx = new MySqlConnection("datasource = localhost;username=root;password=;database=project1;convert zero datetime=True");
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cnx;



                cmd.CommandText = "SELECT motpasse_utilisateur from utilisateur where designation='" + txtuser.Text + "' ";


                cnx.Open();
                table.Load(cmd.ExecuteReader());
                cnx.Close();

                if (txtuser.Text == "Service de maintenance")
                {
                    String motpass = table.Rows[0][0].ToString();
                    if (txtpass.Text == motpass)
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Closed += (s, args) => this.Close();
                        f1.Show();
                        f1.TopMost = true;


                    }
                    else MessageBox.Show("Mot de passe incorrect!");

                }


                if (txtuser.Text == "Station nord")
                {
                    String motpass = table.Rows[0][0].ToString();
                    if (txtpass.Text == motpass)
                    {

                        this.Hide();
                        Stationnord sn = new Stationnord();
                        sn.Closed += (s, args) => this.Close();
                        sn.Show();
                        sn.TopMost = true;

                    }
                    else MessageBox.Show("Mot de passe incorrect!");

                }

                if (txtuser.Text == "Station sud")
                {
                    String motpass = table.Rows[0][0].ToString();
                    if (txtpass.Text == motpass)
                    {
                        this.Hide();
                        Stationsud ss = new Stationsud();
                        ss.Closed += (s, args) => this.Close();
                        ss.Show();
                        ss.TopMost = true;

                    }
                    else MessageBox.Show("Mot de passe incorrect!");



                }

                if (txtuser.Text == "Camion IVECO")
                {
                    String motpass = table.Rows[0][0].ToString();
                    if (txtpass.Text == motpass)
                    {
                        this.Hide();
                        Iveco iv = new Iveco();
                        iv.Closed += (s, args) => this.Close();
                        iv.Show();
                        iv.TopMost = true;


                    }
                    else MessageBox.Show("Mot de passe incorrect!");



                }

                if (txtuser.Text == "Camion SNVI")
                {
                    String motpass = table.Rows[0][0].ToString();
                    if (txtpass.Text == motpass)
                    {
                        this.Hide();
                        Snvi sn = new Snvi();
                        sn.Closed += (s, args) => this.Close();
                        sn.Show();
                        sn.TopMost = true;


                    }
                    else MessageBox.Show("Mot de passe incorrect!");


                }
            }
            else MessageBox.Show("Entrez nom utilisateur");
        }
    }
}
