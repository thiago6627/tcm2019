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
        Thread nt;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoform);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoform()
        {
            Application.Run(new Forms.Agendamento());
        }
    }
}
