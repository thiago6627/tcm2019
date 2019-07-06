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
            nt.SetApartmentState(ApartmentState.STA);
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
            ff.SetApartmentState(ApartmentState.STA);
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
            cc.SetApartmentState(ApartmentState.STA);
            cc.Start();
        }

        private void formConsCli()
        {
            Application.Run(new Forms.ConsCli());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread session = new Thread(formSessoes);
            session.SetApartmentState(ApartmentState.STA);
            session.Start();
        }

        private void formSessoes()
        {
            Application.Run(new Forms.Sessões());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread stock = new Thread(formEstoque);
            stock.SetApartmentState(ApartmentState.STA);
            stock.Start();
        }

        private void formEstoque()
        {
            Application.Run(new Forms.Estoque());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread regpag = new Thread(formRegPag);
            regpag.SetApartmentState(ApartmentState.STA);
            regpag.Start();
        }

        private void formRegPag()
        {
            Application.Run(new Forms.RegPag());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread cons_func = new Thread(formConsFunc);
            cons_func.SetApartmentState(ApartmentState.STA);
            cons_func.Start();
        }

        private void formConsFunc()
        {
            Application.Run(new Forms.ConsFunc());
        }
    }
}
