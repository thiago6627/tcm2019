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
    public partial class RegPag : Form
    {
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-44K49R1\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public RegPag()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "select p.vlpag,p.codpag,p.formapag,p.cpfcli,p.datapag,c.nmcli from tbl_cliente as c inner join tbl_pagamento as p on p.cpfcli = c.cpfcli where datapag='" + dateTimePicker1.Value + "'";

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();
        }


        private void RegPag_Load(object sender, EventArgs e)
        {
            if (crown.State == ConnectionState.Closed)
            {
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                crown.Open();
                da.SelectCommand.CommandText = "select p.vlpag,p.codpag,p.formapag,p.cpfcli,p.datapag,c.nmcli from tbl_cliente as c inner join tbl_pagamento as p on p.cpfcli = c.cpfcli";
 
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                crown.Close();

                dataGridView1.Columns["vlpag"].HeaderText = "Valor";
                dataGridView1.Columns["codpag"].HeaderText = "Código";
                dataGridView1.Columns["formapag"].HeaderText = "Forma de Pagamento";
                dataGridView1.Columns["cpfcli"].HeaderText = "CPF do Cliente";
                dataGridView1.Columns["datapag"].HeaderText = "Data";
                dataGridView1.Columns["nmcli"].HeaderText = "Nome";
            }
        }
    }
}