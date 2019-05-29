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
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Dia da Noiva");
                comboBox4.Items.Add("Dia da Noivo");
                comboBox4.Items.Add("Dia de SPA");
                comboBox4.Items.Add("Depilação Egípcia");
                comboBox4.Items.Add("Cabelo e Maquiagem");
                comboBox4.Items.Add("Emagrecimento e Nutrição Estética");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
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
            }
            else if (comboBox3.SelectedItem == "Não cadastrado")
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    }
