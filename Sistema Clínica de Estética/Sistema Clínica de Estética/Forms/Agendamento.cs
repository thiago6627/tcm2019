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
    public partial class txt__recebido : Form
    {
        SqlConnection crown = new SqlConnection("Data source = localhost; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();

        public txt__recebido()
        {
            InitializeComponent();
            comando.Connection = crown;
        }
        Thread nt;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoform);
            nt.Start();
        }

        private void novoform()
        {
            Application.Run(new MenuPrincipal());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                label11.Visible = false;
                comboBox4.Visible = false;
            }
            else
            {
                label11.Visible = true;
                comboBox4.Visible = true;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Lipo Carbox");
                comboBox4.Items.Add("Heccus");
                comboBox4.Items.Add("Plataforma Vibratória");
                comboBox4.Items.Add("Spectra");
                comboBox4.Items.Add("Massagem");
                comboBox4.Items.Add("Lipomassagem");
                comboBox4.Items.Add("Drenagem Linfática");
                comboBox4.Items.Add("Reflexologia Podal");
                comboBox4.Items.Add("Shiatsu");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Dermaroller");
                comboBox4.Items.Add("Peeling Vulcanice");
                comboBox4.Items.Add("Peeling de Diamante");
                comboBox4.Items.Add("Peeling");
                comboBox4.Items.Add("Peeling Amazônico");
                comboBox4.Items.Add("Eletrolifting");
                comboBox4.Items.Add("Hidratação Facial");
                comboBox4.Items.Add("Limpeza de Pele");
                comboBox4.Items.Add("Spectra");

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Dia da Noiva");
                comboBox4.Items.Add("Dia do Noivo");
                comboBox4.Items.Add("Dia de SPA");
                comboBox4.Items.Add("Depilação Egípcia");
                comboBox4.Items.Add("Cabelo e Maquiagem");
                comboBox4.Items.Add("Emagrecimento e Nutrição Estética");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox4.Text = "";
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Bronzeamento Artificial");
                comboBox4.Items.Add("Depilação");
                comboBox4.Items.Add("Salão de Beleza");
                comboBox4.Items.Add("Maquiagem Definitiva");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Cadastrado")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                maskedTextBox5.Focus();
            }
            else if (comboBox3.SelectedItem == "Não cadastrado")
            {
                panel2.Visible = false;
                panel3.Visible = true;
                maskedTextBox6.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                panel6.Visible = true;
                button6.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox6.Text == "" || maskedTextBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Insira o sexo do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (maskedTextBox2.MaskFull == false)
            {
                MessageBox.Show("Preencha o telefone por completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (maskedTextBox2.Text.Length >= 1 && maskedTextBox2.Text.Length <= 2)
                {
                    maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 1;
                }
                else if (maskedTextBox2.Text.Length >= 3 && maskedTextBox2.Text.Length <= 7)
                {
                    maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 3;
                }
                else if (maskedTextBox2.Text.Length >= 8)
                {
                    maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 4;
                }
                else
                {
                    maskedTextBox2.SelectionStart = 0;
                }
                maskedTextBox2.Focus();
            }
            else if (maskedTextBox1.MaskFull == false)
            {
                MessageBox.Show("Preencha o CPF por completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                maskedTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
                dateTimePicker1.Enabled = true;
                button1.Enabled = true;

            }
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.MinDate = DateTime.Now.Date;
            this.dateTimePicker1.Value = DateTime.Now.Date;
            comboBox5.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel5.Visible = false;
                txt_valor.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.Visible = false;
                panel5.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label21.Visible = false;
                comboBox5.Visible = false;
                label23.Visible = false;
                textBox1.Visible = false;
                textBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
                maskedTextBox7.Enabled = true;
                maskedTextBox8.Enabled = true;
                textBox2.Focus();
            }
            else { }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label21.Visible = true;
                comboBox5.Visible = true;
                textBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
                maskedTextBox7.Enabled = true;
                maskedTextBox8.Enabled = true;
                label23.Visible = true;
                textBox1.Visible = true;
                textBox2.Focus();
            }
            else { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            txt_recebido.Text = "";
            textBox3.Text = "";
        }
        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            maskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedTextBox3.Text.Length >= 5 && maskedTextBox3.Text.Length <=8)
            {
                maskedTextBox3.SelectionStart = maskedTextBox3.Text.Length + 1;
            }
            else if (maskedTextBox3.Text.Length >= 9 && maskedTextBox3.Text.Length <= 12)
            {
                maskedTextBox3.SelectionStart = maskedTextBox3.Text.Length + 2;
            }
            else if (maskedTextBox3.Text.Length >= 13)
            {
                maskedTextBox3.SelectionStart = maskedTextBox3.Text.Length + 3;
            }
            else
            {
                maskedTextBox3.SelectionStart = maskedTextBox3.Text.Length;
            }
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            maskedTextBox4.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedTextBox4.Text.Length >= 3)
            {
                maskedTextBox4.SelectionStart = maskedTextBox4.Text.Length + 1;
            }
            else
            {
                maskedTextBox4.SelectionStart = maskedTextBox4.Text.Length;
            }
        }
        string val;
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Selecione a forma de pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == false && radioButton6.Checked == false)
            {
                MessageBox.Show("Escolha 'Débito' ou 'Crédito'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked == false && (textBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox7.Text == "" || maskedTextBox4.Text == "" || maskedTextBox8.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked == false && (maskedTextBox3.MaskFull == false))
            {
                MessageBox.Show("Preencha o número do cartão POR COMPLETO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox3.Focus();
            }
            else if (radioButton1.Checked == false && (maskedTextBox4.MaskFull == false))
            {
                MessageBox.Show("Preencha a data de vencimento CORRETAMENTE!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox4.Focus();
            }
            else if (radioButton1.Checked == false && (maskedTextBox8.MaskFull == false))
            {
                MessageBox.Show("Preencha o código de segurança CORRETAMENTE", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox8.Focus();
            }
            else if (radioButton1.Checked == true && (txt_valor.Text == "" || txt_recebido.Text == "" || textBox3.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                crown.Open();
                string s;

                if (comboBox3.SelectedIndex==1)
                {
                    if (radioButton4.Checked == true)
                    {
                        s = "Masculino";
                    }
                    else
                    {
                        s = "Feminino";
                    }
                   
                    comando.CommandText = "INSERT INTO tbl_cliente (nmcli,emailcli,cpfcli,ntel,sexo) values ('" + maskedTextBox6.Text + "','" + textBox4.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','"+ s+"')";
                    comando.ExecuteNonQuery();
                }
                comando.CommandText = "INSERT INTO tbl_agendamento (data,hora) values ('" + dateTimePicker1.Value + "','" + comboBox2.SelectedItem + "')";
                
                if (radioButton1.Checked == true && radioButton2.Checked == false)
                {
                    val = txt_valor.Text.Replace("R$ ", "").Replace(',', '.');
                }
                else if (radioButton2.Checked == true && radioButton1.Checked == false)
                {
                    val = textBox2.Text.Replace("R$ ", "").Replace(',', '.');
                }
                else { }
                comando.CommandText = "INSERT INTO tbl_servico (nmserv,tiposerv,vlserv) values ('"+comboBox4.SelectedItem+"','"+comboBox1.SelectedItem+"','"+ val + "')";
                comando.ExecuteNonQuery();
                crown.Close();
                MessageBox.Show("Sessão agendada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox5.MaskFull == false)
            {
                MessageBox.Show("Insira o CPF do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox5.Focus();
                maskedTextBox5.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = maskedTextBox5.Text;
                maskedTextBox5.Text = cpf;
                if (cpf.Length >= 4 && cpf.Length < 7)
                {
                    maskedTextBox5.SelectionStart = cpf.Length + 1;
                }
                else if (cpf.Length >= 7 && cpf.Length < 10)
                {
                    maskedTextBox5.SelectionStart = cpf.Length + 2;
                }
                else if (cpf.Length >= 10)
                {
                    maskedTextBox5.SelectionStart = cpf.Length + 3;
                }
                else
                {
                    maskedTextBox5.SelectionStart = cpf.Length;
                }

            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
                dateTimePicker1.Enabled = true;
                button1.Enabled = true;
                panel7.Visible = true;

                if (crown.State == ConnectionState.Closed)
                    crown.Open();
                
                comando.CommandText = "SELECT * FROM tbl_cliente where cpfcli= '" + maskedTextBox1.Text + "' ";
                SqlDataReader dr = comando.ExecuteReader();
                
                if (dr.Read())
                {
                    maskedTextBox9.Text = dr["nmcli"].ToString();

                }
                
            }
        }

        private void maskedTextBox5_Click(object sender, EventArgs e)
        {
            maskedTextBox5.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTextBox5.Text;
            maskedTextBox5.Text = cpf;
            if (cpf.Length >= 4 && cpf.Length < 7)
            {
                maskedTextBox5.SelectionStart = cpf.Length + 1;
            }
            else if (cpf.Length >= 7 && cpf.Length < 10)
            {
                maskedTextBox5.SelectionStart = cpf.Length + 2;
            }
            else if (cpf.Length >= 10)
            {
                maskedTextBox5.SelectionStart = cpf.Length + 3;
            }
            else
            {
                maskedTextBox5.SelectionStart = cpf.Length;
            }
        }

        private void txt_valor_Enter(object sender, EventArgs e)
        {
            txt_valor.SelectionStart = 3 + (txt_valor.TextLength - 3);
        }

        private void txt_valor_Click(object sender, EventArgs e)
        {
            txt_valor.SelectionStart = 3 + (txt_valor.TextLength - 3);
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            if (txt_valor.TextLength <= 3)
            {
                txt_valor.Text = "R$ ";
                txt_valor.SelectionStart = 3 + (txt_valor.TextLength - 3);
            }
            else { }

            if (txt_valor.Text == "R$ " || txt_recebido.Text == "R$ ")
            {

            }
            else
            {
                string valor = txt_valor.Text;
                string recebido = txt_recebido.Text;
                double valores = double.Parse(valor.Replace("R$ ", ""));
                double recebidos = double.Parse(recebido.Replace("R$ ", ""));
                double troco = recebidos - valores;
                if (troco >= 0)
                {
                    textBox3.Text = "R$ " + troco.ToString("0.00");
                }
                else
                {
                    textBox3.Text = "";
                }
            }
        }

        private void txt_recebido_Enter(object sender, EventArgs e)
        {
            txt_recebido.SelectionStart = 3 + (txt_valor.TextLength - 3);
        }

        private void txt_recebido_Click(object sender, EventArgs e)
        {
            txt_recebido.SelectionStart = 3 + (txt_valor.TextLength - 3);
        }

        private void txt_recebido_TextChanged(object sender, EventArgs e)
        {
            if (txt_recebido.TextLength <= 3)
            {
                txt_recebido.Text = "R$ ";
                txt_recebido.SelectionStart = 3 + (txt_recebido.TextLength - 3);
            }
            else { }

            if (txt_valor.Text == "R$ " || txt_recebido.Text == "R$ ")
            {

            }
            else
            {
                string valor = txt_valor.Text;
                string recebido = txt_recebido.Text;
                double valores = double.Parse(valor.Replace("R$ ", ""));
                double recebidos = double.Parse(recebido.Replace("R$ ", ""));
                double troco = recebidos - valores;
                if (troco >= 0)
                {
                    textBox3.Text = "R$ " + troco.ToString("0.00");
                }
                else
                {
                    textBox3.Text = "";
                }
            }
        }

        private void maskedTextBox6_Click(object sender, EventArgs e)
        {
            maskedTextBox6.SelectionStart = maskedTextBox6.Text.Length;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedTextBox2.Text.Length >= 1 && maskedTextBox2.Text.Length <= 2)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 1;
            }
            else if (maskedTextBox2.Text.Length >= 3 && maskedTextBox2.Text.Length <= 7)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 3;
            }
            else if (maskedTextBox2.Text.Length >= 8)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 4;
            }
            else
            {
                maskedTextBox2.SelectionStart = 0;
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

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectionStart = 3 + (textBox2.TextLength - 3);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.SelectionStart = 3 + (textBox2.TextLength - 3);
        }

        decimal valor;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength <= 3)
            {
                textBox2.Text = "R$ ";
                textBox2.SelectionStart = 3 + (textBox2.TextLength - 3);
            }
            else { }

            if (textBox2.Text == "R$ ")
            {
                textBox1.Text = "";
            }
            else
            {
                valor = decimal.Parse(textBox2.Text.Replace("R$ ", ""));
                decimal valorParcelado;
                if (comboBox5.SelectedIndex == 0)
                {
                    valorParcelado = valor / 1;
                }
                else if (comboBox5.SelectedIndex == 1)
                {
                    valorParcelado = valor / 2;
                }
                else if (comboBox5.SelectedIndex == 2)
                {
                    valorParcelado = valor / 3;
                }
                else
                {
                    valorParcelado = valor / 4;
                }
                textBox1.Text = "R$ " + valorParcelado.ToString("0.00");
            }
        }

        private void maskedTextBox7_Click(object sender, EventArgs e)
        {
            maskedTextBox7.SelectionStart = maskedTextBox7.Text.Length;
        }
        
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal valorParcelado;
            if (comboBox5.SelectedIndex == 0)
            {
                valorParcelado = valor / 1;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                valorParcelado = valor / 2;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                valorParcelado = valor / 3;
            }
            else
            {
                valorParcelado = valor / 4;
            }
            textBox1.Text = "R$ " + valorParcelado.ToString("0.00");
        }

        private void maskedTextBox8_Click(object sender, EventArgs e)
        {
            maskedTextBox8.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox8.SelectionStart = maskedTextBox8.Text.Length;
        }

        private void maskedTextBox8_Enter(object sender, EventArgs e)
        {
            maskedTextBox8.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox8.SelectionStart = maskedTextBox8.Text.Length;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
