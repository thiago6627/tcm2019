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
    public partial class Sessões : Form
    {
        public Sessões()
        {
            InitializeComponent();
        }

        private void Sessões_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread menu = new Thread(menuprincipal);
            menu.Start();
        }

        private void menuprincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
