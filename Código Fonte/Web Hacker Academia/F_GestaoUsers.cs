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
    public partial class F_GestaoUsers : Form
    {
        public F_GestaoUsers()
        {
            InitializeComponent();
        }

        private void F_GestaoUsers_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = Banco.GetAllUsersIdName();
            dgv_users.Columns[0].Width = 100;
            dgv_users.Columns[1].Width = 200;
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_users_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int count_linhas = dataGrid.SelectedRows.Count;
            if(count_linhas > 0)
            {
                string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                DataTable data = Banco.GetDadosUser(id);
                tb_id.Text = data.Rows[0].Field<Int32>("id").ToString();
                tb_nome.Text = data.Rows[0].Field<string>("nome");
                tb_username.Text = data.Rows[0].Field<string>("username");
                tb_senha.Text = data.Rows[0].Field<string>("senha");
                cbb_nivel.Text = data.Rows[0].Field<Int32>("level").ToString();
                cbb_status.Text = data.Rows[0].Field<string>("status");
            }            
        }

        private void btn_novo_usuario_Click(object sender, EventArgs e)
        {
            F_Cadastro _Cadastro = new F_Cadastro();
            _Cadastro.ShowDialog();
            dgv_users.DataSource = Banco.GetAllUsersIdName();
        }

        private void btn_salver_alteracoes_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();

            if (MessageBox.Show("Deseja alterar os dados do(a) usuário(a) " + tb_username.Text + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (tb_nome.Text != "")
                {
                    if (tb_username.Text != "")
                    {
                        if (tb_senha.Text != "")
                        {
                            if (cbb_nivel.Text != "")
                            {
                                if (cbb_nivel.Text == "1" || cbb_nivel.Text == "2" || cbb_nivel.Text == "3")
                                {
                                    if (cbb_status.Text != "")
                                    {
                                        if (cbb_status.Text == "A" || cbb_status.Text == "B" || cbb_status.Text == "D")
                                        {
                                            int line = dgv_users.SelectedRows[0].Index;
                                            User.id = int.Parse(tb_id.Text);
                                            User.nome = tb_nome.Text;
                                            User.username = tb_username.Text;
                                            User.senha = tb_senha.Text;
                                            User.status = cbb_status.Text;
                                            User.level = int.Parse(cbb_nivel.Text);

                                            Banco.UpdateUser(User);
                                            dgv_users.DataSource = Banco.GetAllUsersIdName();
                                            dgv_users.CurrentCell = dgv_users[0, line];
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
        }

        private void btn_exluir_usuario_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o(a) usuário(a) "+tb_username.Text+"?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Banco.RemoveUser(tb_id.Text);
                dgv_users.DataSource = Banco.GetAllUsersIdName();
            }
        }
    }
}
