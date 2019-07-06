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
    public partial class Sessões : Form
    {
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-44K49R1\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public Sessões()
        {
            InitializeComponent();
            comando.Connection = crown;
        }

        private void Sessões_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now.Date;

            if (crown.State == ConnectionState.Closed)
            {
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                crown.Open();
                da.SelectCommand.CommandText = "SELECT a.data, a.hora,a.codsessao,a.cpfcli, s.nmserv,a.codserv from tbl_agendamento as a inner join tbl_servico as s on  a.codserv = s.codserv";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                crown.Close();
                dataGridView1.Columns["data"].HeaderText = "Data";
                dataGridView1.Columns["hora"].HeaderText = "Horário";
                dataGridView1.Columns["codsessao"].HeaderText = "Código";
                dataGridView1.Columns["cpfcli"].HeaderText = "CPF do Cliente";
                dataGridView1.Columns["nmserv"].HeaderText = "Serviço";
                dataGridView1.Columns["codserv"].HeaderText = "Cód. Serviço";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread menu = new Thread(menuprincipal);
            menu.Start();
        }

        private void menuprincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crown.State == ConnectionState.Closed)
            {
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                crown.Open();
                da.SelectCommand.CommandText = "SELECT a.data, a.hora,a.codsessao,a.cpfcli, s.nmserv,a.codserv from tbl_agendamento as a inner join tbl_servico as s on  a.codserv = s.codserv where data='" + dateTimePicker1.Value + "'";                                                       //  "SELECT * FROM tbl_agendamento where data='"+dateTimePicker1.Value+"' ";

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                crown.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            crown.Open();
            comando.CommandText = "DELETE FROM tbl_agendamento where  codsessao='" + txtcod.Text + "'";
            comando.ExecuteNonQuery();
            crown.Close();


            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "SELECT * FROM tbl_agendamento";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();

            MessageBox.Show("Informações apagadas com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

