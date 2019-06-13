using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;


namespace Sistema_Clínica_de_Estética.Forms
{
    
    public partial class ConsCli : Form
    {
        SqlConnection crown = new SqlConnection("Data source = localhost; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public ConsCli()
        {
            InitializeComponent();
            comando.Connection = crown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                if (maskedTextBox1.Text == "   .   .   -")
                {
                    da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    crown.Close();
                }
                else
                {
                    da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente where cpfcli= '" + maskedTextBox1.Text + "' ";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    crown.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("NENHUMA INFORMAÇÃO ENCONTRADA");
            }
        }
        void FillDataGridView()
        {
            if (crown.State == ConnectionState.Closed)
                crown.Open();
            SqlDataAdapter da = new SqlDataAdapter("", crown);
            da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();
        }

        private void ConsCli_Load(object sender, EventArgs e)
        {
            if (crown.State == ConnectionState.Closed)
            {
                crown.Open();
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                crown.Close();
            }
            dataGridView1.Columns["nmcli"].HeaderText = "Nome";
            dataGridView1.Columns["emailcli"].HeaderText = "E-mail";
            dataGridView1.Columns["cpfcli"].HeaderText = "CPF";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
            dataGridView1.Columns["ntel"].HeaderText = "Telefone";

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTextBox1.Text;
            maskedTextBox1.Text = cpf;
            if (cpf.Length >= 4 && cpf.Length < 7)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 1;
            }
            else if (cpf.Length >= 7 && cpf.Length < 10)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 2;
            }
            else if (cpf.Length >= 10)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 3;
            }
            else
            {
                maskedTextBox1.SelectionStart = cpf.Length;
            }
        }

        private void menuprincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread menu = new Thread(menuprincipal);
            menu.Start();
        }
    }
}

   

