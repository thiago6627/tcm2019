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

namespace Sistema_Clínica_de_Estética.Forms.Alterar
{
    public partial class AlterarFunc : Form
    {
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-FKUTHPP\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();

        public AlterarFunc()
        {
            InitializeComponent();
            comando.Connection = crown;
            crown.Open();
            comando.CommandText = "select * from tbl_funcionario where cpffunc  = '" + "000.000.000-00"  + "'";
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

                if ( k == "Masculino                     ") 
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
              
            }
          
        }


        private void Button2_Click(object sender, EventArgs e)
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
                comando.CommandText = "update tbl_funcionario  set nmfunc ='" + txt_nome.Text + "', cargo = '" + comboBox1.SelectedItem + "', salario ='" + txt_pag.Text + "',enderecofunc ='" + txt_end.Text + "',emailfunc ='" + txt_email.Text + "', cpffunc = '" + txt_cpf.Text + "', rgfunc ='" + txt_rg.Text + "',dataadim ='" + dataa.Text + "',telfunc='" + txt_tel.Text + "', celfunc='" + txt_cel.Text + "',datanasc='" + txt_datan.Text + "', sexo='" + s + "' where cpffunc='" + "000.000.000-00"/*maskedtextbox1 do Form consfunc*/+ "'";
                comando.ExecuteNonQuery();
                crown.Close();

                MessageBox.Show("Mudanças aplicadas com sucesso!","Alteração",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarFunc_Load(object sender, EventArgs e)
        {

        }

        private void Dataa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_datan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Txt_end_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Txt_pag_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Txt_tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Txt_rg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    } 
}

