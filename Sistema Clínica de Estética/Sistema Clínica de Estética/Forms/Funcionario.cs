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
    public partial class Funcionario : Form
    {
        public Funcionario()
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
    }
}
