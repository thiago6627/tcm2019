using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Sistema_Clínica_de_Estética.Forms
{
    public partial class Estoque : Form
    {
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-44K49R1\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public Estoque()
        {
            InitializeComponent();
            comando.Connection = crown;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread menu = new Thread(menuprincipal);
            menu.SetApartmentState(ApartmentState.STA);
            menu.Start();
        }

        private void menuprincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=1";
            SqlDataReader dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown1.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=2";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown2.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=3";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown3.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=4";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown4.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=5";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown5.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=6";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown6.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

            }

            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=7";
             dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown7.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=8";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown8.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=9";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown9.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=10";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown10.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=11";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown11.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=12";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown12.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=13";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown13.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=14";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown14.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=15";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown15.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=16";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown16.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=17";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown17.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=18";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown18.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=19";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown19.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=20";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown20.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=21";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown21.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=22";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown22.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=23";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown23.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=24";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown24.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=25";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown25.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=26";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown26.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=27";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown27.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=28";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown28.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=29";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown29.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=30";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown30.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=31";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown31.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=32";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown32.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


            }
            crown.Open();
            comando.CommandText = "select e.qtatual from tbl_estoque as e where codprodt=33";
            dr = comando.ExecuteReader();


            if (dr.Read())
            {
                numericUpDown33.Text = dr["qtatual"].ToString();
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();

                 
            }
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            crown.Open();           
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown2.Text) + "' where codprodt=2";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown3.Text) + "' where codprodt=3";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown4.Text) + "' where codprodt=4";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown5.Text) + "' where codprodt=5";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown6.Text) + "' where codprodt=6";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown7.Text) + "' where codprodt=7";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown8.Text) + "' where codprodt=8";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown9.Text) + "' where codprodt=9";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown10.Text) + "' where codprodt=10";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown11.Text) + "' where codprodt=11";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown12.Text) + "' where codprodt=12";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown13.Text) + "' where codprodt=13";
            comando.ExecuteNonQuery();

            crown.Close();
            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown14.Text) + "' where codprodt=14";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown15.Text) + "' where codprodt=15";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown16.Text) + "' where codprodt=16";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown17.Text) + "' where codprodt=17";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown18.Text) + "' where codprodt=18";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown19.Text) + "' where codprodt=19";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown20.Text) + "' where codprodt=20";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown21.Text) + "' where codprodt=21";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown22.Text) + "' where codprodt=22";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown23.Text) + "' where codprodt=23";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown24.Text) + "' where codprodt=24";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown25.Text) + "' where codprodt=25";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown26.Text) + "' where codprodt=26";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown27.Text) + "' where codprodt=27";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown28.Text) + "' where codprodt=28";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown29.Text) + "' where codprodt=29";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown30.Text) + "' where codprodt=30";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown31.Text) + "' where codprodt=31";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown32.Text) + "' where codprodt=32";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown33.Text) + "' where codprodt=33";
            comando.ExecuteNonQuery();
            crown.Close();

            crown.Open();
            comando.CommandText = "update tbl_estoque  set qtatual = '" + int.Parse(numericUpDown1.Text) + "' where codprodt=1";
            comando.ExecuteNonQuery();
            crown.Close();

            MessageBox.Show("Estoque atualizado", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}