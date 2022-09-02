using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Hacker_Academia
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string user = tb_user.Text;
            string senha = tb_senha.Text;

            if(user == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou Senha incorreta!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "SELECT * FROM users WHERE username = '"+user+"' AND senha = '"+senha+"'";
                dt = Banco.Select(sql);
                if(dt.Rows.Count == 1)
                {
                    form1.l_acesso.Text = dt.Rows[0].Field<string>("senha");
                    form1.l_userLogado.Text = dt.Rows[0].Field<string>("username");
                    form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                    Globals.nivel = dt.Rows[0].Field<Int32>("level");
                    Globals.logado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
