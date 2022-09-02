using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pronote_Admin
{
    public partial class F_Cadastrar : Form
    {
        
        public F_Cadastrar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {//Exibir Imagem Escolhida                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Cadastrar_Load(object sender, EventArgs e)
        {//Setar Imagem Padrão
            pb_loading.Visible = false;
            pictureBox1.Image = Properties.Resources.desenho;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            pb_loading.Visible = true;
            btn_cadastrar.Enabled = false;
            btn_cancel.Enabled = false;

            //Processo Cadastrar

            if(tb_nome.Text == "")
            {
                MessageBox.Show("Nome Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nome.Focus();
            }
            else
            {
                if(tb_email.Text == "")
                {
                    MessageBox.Show("E-mail Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_email.Focus();
                }
                else
                {
                    if(tb_senha.Text == "")
                    {
                        MessageBox.Show("Senha Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_senha.Focus();
                    }
                    else
                    {
                        if(tb_confsenha.Text == "")
                        {
                            MessageBox.Show("Confirmação Requerida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_confsenha.Focus();
                        }
                        else
                        {
                            if(Banco.Select("SELECT * FROM adms WHERE email = '"+tb_email.Text+"'").Rows.Count > 0)
                            {
                                MessageBox.Show("E-mail Existente!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if(Banco.Select("SELECT * FROM adms WHERE code_adm = '"+tb_senha.Text+"'").Rows.Count > 0)
                                {
                                    MessageBox.Show("Usuário Existente!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //Cadastro
                                    MemoryStream sm = new MemoryStream();
                                    pictureBox1.Image.Save(sm, ImageFormat.Png);
                                    Byte[] bim = sm.ToArray();
                                    string sql = "INSERT INTO adms (code_adm,email,nome_completo,foto_perfil_adm) VALUES (@code,@email,@nome,@foto)";
                                    Banco.New_Admin(sql, tb_nome.Text, tb_senha.Text, tb_email.Text, bim);
                                    //MessageBox.Show("Cadastro Realizado Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    //F_Login login = new F_Login();
                                    //login.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            pb_loading.Visible = false;
            btn_cadastrar.Enabled = true;
            btn_cancel.Enabled = true;
        }
    }
}
