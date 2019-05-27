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

namespace Sistema_Clínica_de_Estética
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.DimGray;
                textBox1.Text = "Usuário";
            }
            else
            {

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuário")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.White;
            }
            else
            {

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.White;
            }
            else
            {

            }
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.ForeColor = Color.DimGray;
                textBox2.Text = "Senha";
            }
            else
            {

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ForeColor = Color.White;
            textBox2.PasswordChar = '*';
        }
        Thread nt;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "admin")
            {
                /*MenuPrincipal menu = new MenuPrincipal();
                menu.ShowDialog();*/
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!", "Usuário/Senha Inválidos", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void novoform()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
