using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pronote_Admin
{
    public partial class F_NovaEscola : Form
    {
        public F_NovaEscola()
        {
            InitializeComponent();
            tb_adm.Text = Admin.nome;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            btn_add.Enabled = false;
            btn_cancel.Enabled = false;
            if (tb_code.Text == "")
            {
                MessageBox.Show("Código Escola Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_code.Focus();
            }
            else 
            {
                if (tb_nome.Text == "")
                {
                    MessageBox.Show("Nome Escola Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nome.Focus();
                }
                else
                {
                    if (ccb_periodo.Text == "Digite ou Selecione..." || ccb_periodo.Text == "")
                    {
                        MessageBox.Show("Digite ou Selecione um Tipo de Período!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ccb_periodo.Focus();
                    }
                    else
                    {
                        if(nup_qtd.Value <= 0)
                        {
                            MessageBox.Show("Quantidade de Período Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(Banco.Select("SELECT * FROM escolas WHERE code_escola = '"+tb_code.Text+"'").Rows.Count > 0)
                            {
                                MessageBox.Show("Escola Exixtente!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream();
                                pb_foto.Image.Save(ms, ImageFormat.Png);
                                Byte[] bim = ms.ToArray();
                                Admin.Add_Escola(tb_code.Text, tb_nome.Text, Admin.id, ccb_periodo.Text, int.Parse(nup_qtd.Value.ToString()), bim);
                                //MessageBox.Show("Escola Adicionada Com Sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                return;
                            }
                        }
                    }
                }
                    
            }
            pictureBox1.Visible = false;
            btn_add.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void F_NovaEscola_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
