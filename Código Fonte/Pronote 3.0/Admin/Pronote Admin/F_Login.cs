using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pronote_Admin
{
    public partial class F_Login : Form
    {
        F_Homepage home = new F_Homepage();
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            DataTable user = Banco.Select("SELECT * FROM adms WHERE code_adm = '" + tb_senha.Text + "' AND status = 'C'");
            if(user.Rows.Count == 1)
            {
                Admin.id = user.Rows[0].Field<string>("code_adm");
                Admin.nome = user.Rows[0].Field<string>("nome_completo");

                MemoryStream stm = new MemoryStream((byte[])user.Rows[0].ItemArray[2]);

                Admin.image = Image.FromStream(stm);
                home.splitContainer2.SplitterDistance = 205;
                home.l_login.Visible = false;
                home.l_cadastro.Visible = false;
                home.tsm_tools.Visible = true;
                home.menuStrip1.Visible = true;
                home.contextMenuStrip1.Visible = true;

                Admin.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário Não Encontrado!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
