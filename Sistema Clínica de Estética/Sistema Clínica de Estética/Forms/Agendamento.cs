using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Clínica_de_Estética.Forms
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                if(radioButton2.Checked == true)
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Marque uma das opções", "Erro");
                }
            }
        }
    }
}
