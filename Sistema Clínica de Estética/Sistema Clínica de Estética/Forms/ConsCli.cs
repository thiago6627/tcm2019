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
        //SqlConnection crown = new SqlConnection("Data source = localhost; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-44K49R1\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
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
            catch
            {
                MessageBox.Show("Falha na conexão com o banco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsCli_Load(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Falha na conexão com o banco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel3.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            crown.Open();
            comando.CommandText = "select * from tbl_cliente where cpfcli  = '" + maskedTextBox1.Text  + "'";
            SqlDataReader dr = comando.ExecuteReader();
            
            string k;
            if (dr.Read())
            {
                
                k = dr["sexo"].ToString();

                
                txt_nome.Text = dr["nmcli"].ToString();
                maskedTextBox2.Text = dr["ntel"].ToString();
                txt_email.Text = dr["emailcli"].ToString();
                maskedTextBox3.Text = dr["cpfcli"].ToString();


                if (k == "Masculino                     ")
                {
                    radioButton4.Checked = true;
                }

                else
                {
                    radioButton5.Checked = true;
                }
            dr.Close();
            comando.ExecuteNonQuery();
            crown.Close();

                
            }
        }

        private void formAlterarCli()
        {
            Application.Run(new Alterar.AlterarCli());
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            crown.Open();
            comando.CommandText = "DELETE FROM tbl_cliente where cpfcli ='" + maskedTextBox1.Text + "'";
            comando.ExecuteNonQuery();
            crown.Close();


            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();

            MessageBox.Show("Informações apagadas com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string s;

            if (radioButton4.Checked == true)
            {
                s = "Masculino";
            }
            else
            {
                s = "Feminino";
            }

            
            crown.Open();
            comando.CommandText = "update tbl_cliente  set nmcli = '" + txt_nome.Text + "', emailcli='" + txt_email.Text + "',ntel ='" + maskedTextBox2.Text + "',sexo='" + s + "' where cpfcli='" + maskedTextBox1.Text + "'";
            comando.ExecuteNonQuery();
            crown.Close();

            MessageBox.Show("Alteração aplicada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);



            dataGridView1.Visible = true;
            panel3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "SELECT * FROM tbl_cliente";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panel3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

      
    }
}



