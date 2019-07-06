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
    public partial class ConsFunc : Form
    {
        // SqlConnection crown = new SqlConnection("Data source = localhost; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-44K49R1\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public ConsFunc()
        {
            InitializeComponent();
            comando.Connection = crown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panel1.Visible = false;
            panel10.Visible = false;
            panel2.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            txt_cel.Visible = false;
            txt_cpf.Visible = false;
            txt_datan.Visible = false;
            txt_email.Visible = false;
            txt_end.Visible = false;
            txt_nome.Visible = false;
            txt_pag.Visible = false;
            txt_rg.Visible = false;
            txt_tel.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            dataa.Visible = false;
            comboBox1.Visible = false;
            label13.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label12.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("", crown);
                if (maskedTextBox1.Text == "   .   .   -")
                {
                    da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    crown.Close();
                }
                else
                {
                    da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario where cpffunc= '" + maskedTextBox1.Text + "' ";
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

        private void ConsFunc_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                if (crown.State == ConnectionState.Closed)
                {
                    SqlDataAdapter da = new SqlDataAdapter("", crown);
                    crown.Open();
                    da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    crown.Close();
                    dataGridView1.Columns["codfunc"].HeaderText = "Código";
                    dataGridView1.Columns["nmfunc"].HeaderText = "Nome";
                    dataGridView1.Columns["cargo"].HeaderText = "Cargo";
                    dataGridView1.Columns["salario"].HeaderText = "Salário";
                    dataGridView1.Columns["enderecofunc"].HeaderText = "Endereço";
                    dataGridView1.Columns["emailfunc"].HeaderText = "E-mail";
                    dataGridView1.Columns["cpffunc"].HeaderText = "CPF";
                    dataGridView1.Columns["rgfunc"].HeaderText = "RG";
                    dataGridView1.Columns["dataadim"].HeaderText = "Data de Admissão";
                    dataGridView1.Columns["telfunc"].HeaderText = "Telefone";
                    dataGridView1.Columns["celfunc"].HeaderText = "Celular";
                    dataGridView1.Columns["datanasc"].HeaderText = "Data de Nascimento";
                    dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                }
            }
            catch
            {
                MessageBox.Show("Falha na conexão com o banco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            panel10.Visible = true;
            panel2.Visible = true;
            panel9.Visible = true;
            panel8.Visible = true;
            panel7.Visible = true;
            panel6.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            panel3.Visible = true;
            txt_cel.Visible = true;
            txt_cpf.Visible = true;
            txt_datan.Visible = true;
            txt_email.Visible = true;
            txt_end.Visible = true;
            txt_nome.Visible = true;
            txt_pag.Visible = true;
            txt_rg.Visible = true;
            txt_tel.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            dataa.Visible = true;
            comboBox1.Visible = true;
            label13.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label12.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            crown.Open();
            comando.CommandText = "select * from tbl_funcionario where cpffunc = '" + maskedTextBox1.Text + "'";
            SqlDataReader dr = comando.ExecuteReader();

            string k;
            if (dr.Read())
            {               
                k = dr["sexo"].ToString();

                txt_nome.Text = dr["nmfunc"].ToString();
                txt_cel.Text = dr["celfunc"].ToString();
                txt_cpf.Text = dr["cpffunc"].ToString();
                txt_datan.Text = dr["datanasc"].ToString();
                txt_email.Text = dr["emailfunc"].ToString();
                txt_end.Text = dr["enderecofunc"].ToString();
                txt_pag.Text = dr["salario"].ToString();
                txt_rg.Text = dr["rgfunc"].ToString();
                txt_tel.Text = dr["telfunc"].ToString();
                comboBox1.SelectedItem = dr["cargo"].ToString();
                dataa.Text = dr["dataadim"].ToString();

                if (k == "Masculino                     ")
                {
                    radioButton1.Checked = true;
                }

                else
                {
                    radioButton2.Checked = true;
                }
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();


                SqlDataAdapter da = new SqlDataAdapter("", crown);
                crown.Open();
                da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                crown.Close();


               

            }

         }
         

        private void Button3_Click(object sender, EventArgs e)
        {
            crown.Open();
            comando.CommandText = "DELETE FROM tbl_funcionario where cpffunc ='" + maskedTextBox1.Text + "'";
            comando.ExecuteNonQuery();
            crown.Close();


            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();

            MessageBox.Show("Informações apagadas com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            panel1.Visible = false;
            panel10.Visible = false;
            panel2.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            txt_cel.Visible = false;
            txt_cpf.Visible = false;
            txt_datan.Visible = false;
            txt_email.Visible = false;
            txt_end.Visible = false;
            txt_nome.Visible = false;
            txt_pag.Visible = false;
            txt_rg.Visible = false;
            txt_tel.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            dataa.Visible = false;
            comboBox1.Visible = false;
            label13.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label12.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
           
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();
            }

            else if (txt_cpf.MaskFull == false)
            {
                MessageBox.Show("Preencha o campo CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cpf.Focus();
            }
            else if (txt_rg.MaskFull == false)
            {
                MessageBox.Show("Preencha o campo RG!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_rg.Focus();
            }
            else if (txt_cel.MaskFull == false)
            {
                MessageBox.Show("Preencha o campo celular!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cel.Focus();
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Selecione o sexo do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_pag.Text == "R$ ")
            {
                MessageBox.Show("Preencha o salário do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_pag.Focus();
                txt_pag.SelectionStart = 3;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o cargo do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dataa.MaskFull == false)
            {
                MessageBox.Show("Preencha a data de admissão do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataa.Focus();
            }
            else
            {
                string s;

                if (radioButton1.Checked == true)
                {
                    s = "Masculino";
                }
                else
                {
                    s = "Feminino";
                }

                crown.Open();
                comando.CommandText = "update tbl_funcionario  set nmfunc ='" + txt_nome.Text + "', cargo = '" + comboBox1.SelectedItem + "', salario ='" + txt_pag.Text + "',enderecofunc ='" + txt_end.Text + "',emailfunc ='" + txt_email.Text + "', cpffunc = '" + txt_cpf.Text + "', rgfunc ='" + txt_rg.Text + "',dataadim ='" + dataa.Text + "',telfunc='" + txt_tel.Text + "', celfunc='" + txt_cel.Text + "',datanasc='" + txt_datan.Text + "', sexo='" + s + "' where cpffunc='" + maskedTextBox1.Text + "'";
                comando.ExecuteNonQuery();
                crown.Close();

                MessageBox.Show("Mudanças aplicadas com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Visible = true;
             panel1.Visible = false;
            panel10.Visible = false;
            panel2.Visible = false;
            panel9.Visible = false;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;
            txt_cel.Visible = false;
            txt_cpf.Visible = false;
            txt_datan.Visible = false;
            txt_email.Visible = false;
            txt_end.Visible = false;
            txt_nome.Visible = false;
            txt_pag.Visible = false;
            txt_rg.Visible = false;
            txt_tel.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            dataa.Visible = false;
            comboBox1.Visible = false;
            label13.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label12.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            }



        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            crown.Open();
            comando.CommandText = "DELETE FROM tbl_funcionario where cpffunc ='" + maskedTextBox1.Text + "'";
            comando.ExecuteNonQuery();
            crown.Close();


            SqlDataAdapter da = new SqlDataAdapter("", crown);
            crown.Open();
            da.SelectCommand.CommandText = "SELECT * FROM tbl_funcionario";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            crown.Close();

            MessageBox.Show("Informações apagadas com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
