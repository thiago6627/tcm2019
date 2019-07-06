using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sistema_Clínica_de_Estética.Forms.Alterar
{
    public partial class AlterarCli : Form
    {
        SqlConnection crown = new SqlConnection("Data source = DESKTOP-FKUTHPP\\SQLEXPRESS; Initial Catalog = TcmClinica; user =sa; password=1234567");
        SqlCommand comando = new SqlCommand();
        public AlterarCli()
        {
            InitializeComponent();
            comando.Connection = crown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (maskedTextBox2.Text.Length >= 1 && maskedTextBox2.Text.Length <= 2)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 1;
            }
            else if (maskedTextBox2.Text.Length >= 3 && maskedTextBox2.Text.Length <= 7)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 3;
            }
            else if (maskedTextBox2.Text.Length >= 8)
            {
                maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length + 4;
            }
            else
            {
                maskedTextBox2.SelectionStart = 0;
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = maskedTextBox1.Text;
            maskedTextBox1.Text = cpf;
            if (cpf.Length >= 4 && cpf.Length < 7)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 1;
            }
            else if (cpf.Length >= 7 && cpf.Length < 10)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 2;
            }
            else if (cpf.Length >= 10)
            {
                maskedTextBox1.SelectionStart = cpf.Length + 3;
            }
            else
            {
                maskedTextBox1.SelectionStart = cpf.Length;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string s;

            if (radioButton4.Checked == true)
            {
                s = "Masculino";
            }
            else
            {
                s = "Feminino";
            }

            crown.Open();
            comando.CommandText = "update tbl_cliente  set nmcli = '" + txt_nome.Text + "', emailcli='" + txt_email.Text + "',ntel ='" + maskedTextBox2.Text + "',sexo='" + s + "' where cpfcli='"+"000.000.000-00" +/* text box do outro form com o cpf informado */"'";
            comando.ExecuteNonQuery();
            crown.Close();

            MessageBox.Show("Alteração aplicada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void AlterarCli_Load(object sender, EventArgs e)
        {
            crown.Open();
            comando.CommandText = "select * from tbl_cliente where cpfcli  = '" + "000.000.000-00"/* text box do outro form com o cpf informado */  + "'";
            SqlDataReader dr = comando.ExecuteReader();

            string k;
            if (dr.Read())
            {
                k = dr["sexo"].ToString();

                txt_nome.Text = dr["nmcli"].ToString();
                maskedTextBox2.Text = dr["ntel"].ToString();
                txt_email.Text = dr["emailcli"].ToString();
                maskedTextBox1.Text = dr["cpfcli"].ToString();


                if (k == "Masculino                     ")  /* <<<<< tem que deixar com esses espaços  */
                {
                    radioButton4.Checked = true;
                }

                else
                {
                    radioButton5.Checked = true;
                }
                dr.Close();
                comando.ExecuteNonQuery();
                crown.Close();
            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
