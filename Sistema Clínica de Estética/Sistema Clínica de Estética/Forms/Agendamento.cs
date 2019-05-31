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

namespace Sistema_Clínica_de_Estética.Forms
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
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
            if(comboBox1.SelectedIndex == -1)
            {
                label11.Visible = false;
                comboBox4.Visible = false;
            }
            else
            {
                label11.Visible = true;
                comboBox4.Visible = true;
            }
            if(comboBox1.SelectedIndex == 0)
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
            if(comboBox3.SelectedItem == "Cadastrado")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                maskedTextBox5.Focus();
            }
            else if (comboBox3.SelectedItem == "Não cadastrado")
            {
                panel2.Visible = false;
                panel3.Visible = true;
                textBox2.Focus();
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || maskedTextBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Insira o sexo do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maskedTextBox2.MaskFull == false)
            {
                MessageBox.Show("Preencha o telefone por completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox2.Focus();
            }
            else if (maskedTextBox1.MaskFull == false)
            {
                MessageBox.Show("Preencha o CPF por completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskedTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Cliente cadastrado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
                dateTimePicker1.Enabled = true;

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
            if(radioButton1.Checked == true)
            {
                panel1.Visible = true;
                panel5.Visible = false;
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
                maskedTextBox9.Enabled = true;
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
                textBox12.Enabled = true;
                textBox11.Enabled = true;
            }
            else { }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label21.Visible = true;
                comboBox5.Visible = true;
                maskedTextBox9.Enabled = true;
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
                textBox12.Enabled = true;
                textBox11.Enabled = true;
                label23.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void maskedTextBox6_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox7.Text == "" || maskedTextBox6.Text == "")
            {

            }
            else
            {
                double valor = double.Parse(maskedTextBox7.Text);
                double recebido = double.Parse(maskedTextBox6.Text);
                double troco = recebido - valor;
                if(troco >= 0)
                {
                    textBox3.Text = "R$ " + troco.ToString("0");
                }
                else
                {
                    MessageBox.Show("Insira os valores corretamente!","Erro");
                }
            }
        }

        private void maskedTextBox7_Click(object sender, EventArgs e)
        {
            maskedTextBox7.SelectionStart = 3;
        }

        private void maskedTextBox7_Enter(object sender, EventArgs e)
        {
            maskedTextBox7.SelectionStart = 3;
        }

        private void maskedTextBox6_Click(object sender, EventArgs e)
        {
            maskedTextBox6.SelectionStart = 3;
        }

        private void maskedTextBox6_Enter(object sender, EventArgs e)
        {
            maskedTextBox6.SelectionStart = 2;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.SelectionStart = textBox3.SelectionStart + textBox3.SelectionLength;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            textBox3.Text = "";
        }

        private void maskedTextBox9_Enter(object sender, EventArgs e)
        {
            maskedTextBox9.SelectionStart = 3;
        }

        private void maskedTextBox9_Click(object sender, EventArgs e)
        {
            maskedTextBox9.SelectionStart = 3;
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            maskedTextBox3.SelectionStart = 0;
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            maskedTextBox3.SelectionStart = 0;
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            maskedTextBox4.SelectionStart = 0;
        }

        private void maskedTextBox4_Enter(object sender, EventArgs e)
        {
            maskedTextBox4.SelectionStart = 0;
        }

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
            else if (radioButton1.Checked==false && (maskedTextBox9.Text == "" || maskedTextBox3.Text == "" || textBox12.Text == "" || maskedTextBox4.Text == "" || textBox11.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked == false && (maskedTextBox3.MaskFull == false))
            {
                MessageBox.Show("Preencha o número do cartão POR COMPLETO!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked == false && (maskedTextBox4.MaskFull == false))
            {
                MessageBox.Show("Preencha a data de vencimento CORRETAMENTE!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked == false && (textBox11.TextLength < 3))
            {
                MessageBox.Show("Preencha o código de segurança CORRETAMENTE", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioButton1.Checked==true &&(maskedTextBox6.Text=="" || maskedTextBox7.Text=="" || textBox3.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox5.MaskFull == false)
            {
                MessageBox.Show("Insira o CPF do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
                dateTimePicker1.Enabled = true;

            }
        }

        private void maskedTextBox5_Click(object sender, EventArgs e)
        {
            maskedTextBox5.SelectionStart = 0;
        }

        private void maskedTextBox5_Enter(object sender, EventArgs e)
        {
            maskedTextBox5.SelectionStart = 0;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            textBox12.Text = textBox12.Text.ToUpper();
        }
    }
    }
