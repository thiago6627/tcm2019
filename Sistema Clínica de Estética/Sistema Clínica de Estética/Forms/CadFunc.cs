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
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread nf;
            nf = new Thread(novoform);
            nf.Start();
        }

        private void novoform()
        {
            Application.Run(new MenuPrincipal());
        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            txt_nome.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txt_nome.SelectionStart = txt_nome.Text.Length;
        }
        
        private void txt_datan_Click(object sender, EventArgs e)
        {
            txt_datan.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txt_datan.Text.Length <= 2)
            {
                txt_datan.SelectionStart = txt_datan.Text.Length;
            }
            else if (txt_datan.Text.Length >= 3 && txt_datan.Text.Length <= 4)
            {
                txt_datan.SelectionStart = txt_datan.Text.Length + 1;
            }
            else
            {
                txt_datan.SelectionStart = txt_datan.Text.Length + 2;
            }
        }

        private void txt_cpf_Click(object sender, EventArgs e)
        {
            txt_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = txt_cpf.Text;
            if (cpf.Length >= 4 && cpf.Length < 7)
            {
                txt_cpf.SelectionStart = cpf.Length + 1;
            }
            else if (cpf.Length >= 7 && cpf.Length < 10)
            {
                txt_cpf.SelectionStart = cpf.Length + 2;
            }
            else if (cpf.Length >= 10)
            {
                txt_cpf.SelectionStart = cpf.Length + 3;
            }
            else
            {
                txt_cpf.SelectionStart = cpf.Length;
            }
        }

        private void txt_rg_Click(object sender, EventArgs e)
        {
            txt_rg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rg = txt_rg.Text;
            if (rg.Length >= 3 && rg.Length <= 5)
            {
                txt_rg.SelectionStart = rg.Length + 1;
            }
            else if (rg.Length >= 6 && rg.Length <= 8)
            {
                txt_rg.SelectionStart = rg.Length + 2;
            }
            else if (rg.Length >= 9)
            {
                txt_rg.SelectionStart = rg.Length + 3;
            }
            else
            {
                txt_rg.SelectionStart = rg.Length;
            }
        }

        private void txt_cel_Click(object sender, EventArgs e)
        {
            txt_cel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txt_cel.Text.Length >= 1 && txt_cel.Text.Length <= 2)
            {
                txt_cel.SelectionStart = txt_cel.Text.Length + 1;
            }
            else if (txt_cel.Text.Length >= 3 && txt_cel.Text.Length <= 7)
            {
                txt_cel.SelectionStart = txt_cel.Text.Length + 3;
            }
            else if (txt_cel.Text.Length >= 8)
            {
                txt_cel.SelectionStart = txt_cel.Text.Length + 4;
            }
            else
            {
                txt_cel.SelectionStart = 0;
            }
        }

        private void txt_tel_Click(object sender, EventArgs e)
        {
            txt_tel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txt_tel.Text.Length >= 1 && txt_tel.Text.Length <= 2)
            {
                txt_tel.SelectionStart = txt_tel.Text.Length + 1;
            }
            else if (txt_tel.Text.Length >= 3 && txt_tel.Text.Length <= 6)
            {
                txt_tel.SelectionStart = txt_tel.Text.Length + 3;
            }
            else if (txt_tel.Text.Length >= 7)
            {
                txt_tel.SelectionStart = txt_tel.Text.Length + 4;
            }
            else
            {
                txt_tel.SelectionStart = 0;
            }
        }

        private void txt_pag_Click(object sender, EventArgs e)
        {
            txt_pag.SelectionStart = txt_pag.Text.Length;
        }

        private void txt_pag_TextChanged(object sender, EventArgs e)
        {
            if(txt_pag.Text.Length <= 3)
            {
                txt_pag.Text = "R$ ";
                txt_pag.SelectionStart = 3;
            }
        }

        private void dataa_Click(object sender, EventArgs e)
        {
            dataa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (dataa.Text.Length >= 3 && dataa.Text.Length <= 4)
            {
                dataa.SelectionStart = dataa.Text.Length + 1;
            }
            else if (dataa.Text.Length >= 5)
            {
                dataa.SelectionStart = dataa.Text.Length + 2;
            }
            else
            {
                dataa.SelectionStart = dataa.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text=="")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nome.Focus();
            }
            else if (txt_datan.MaskFull == false)
            {
                MessageBox.Show("Preencha a data de nascimento do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_datan.Focus();
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
            else { }
        }
    }
}
