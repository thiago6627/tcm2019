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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread nt = new Thread(novoform);
            nt.Start();
        }

        private void novoform()
        {
            Application.Run(new Forms.txt__recebido());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread ff = new Thread(formFuncionario);
            ff.Start();
        }

        private void formFuncionario()
        {
            Application.Run(new Forms.CadFunc());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread cc = new Thread(formConsCli);
            cc.Start();
        }

        private void formConsCli()
        {
            Application.Run(new Forms.ConsCli());
        }
    }
}
