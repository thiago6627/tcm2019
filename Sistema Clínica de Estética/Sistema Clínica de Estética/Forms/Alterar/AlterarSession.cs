using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Clínica_de_Estética.Forms.Alterar
{
    public partial class AlterarSession : Form
    {
        public AlterarSession()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void AlterarSession_Load(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox4.Items.Clear();
            }
        }
    }
}
