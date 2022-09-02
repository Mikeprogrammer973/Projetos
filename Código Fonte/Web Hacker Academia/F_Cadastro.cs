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
    public partial class F_Cadastro : Form
    {
        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();

            if(tb_nome.Text != "")
            {
                if(tb_username.Text != "")
                {
                    if(tb_senha.Text != "")
                    {
                        if(cbb_nivel.Text != "")
                        {
                            if(cbb_nivel.Text == "1" || cbb_nivel.Text == "2" || cbb_nivel.Text == "3")
                            {
                                if(cbb_status.Text != "")
                                {
                                    if(cbb_status.Text == "A" || cbb_status.Text == "B" || cbb_status.Text == "D")
                                    {
                                        User.nome = tb_nome.Text;
                                        User.username = tb_username.Text;
                                        User.senha = tb_senha.Text;
                                        User.status = cbb_status.Text;
                                        User.level = int.Parse(cbb_nivel.Text);

                                        Banco.NovoUsuario(User);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Status incorreto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Status inválido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nível de Acesso incorreto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nível de Acesso inválido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username inválido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nome inválido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }                
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            cbb_nivel.Text = "";
            cbb_status.Text = "";
            tb_nome.Focus();
        }
    }
}
