using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronote_Admin
{
    public partial class F_NovaTurma : Form
    {
        private string escola;
        public F_NovaTurma(string id)
        {
            InitializeComponent();
            this.escola = id;
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

        private void F_NovaTurma_Load(object sender, EventArgs e)
        {
            if(this.escola != "")
            {
                tb_escola.Text = Banco.Select("SELECT nome_escola FROM escolas WHERE code_escola = '" + this.escola + "'").Rows[0].Field<string>("nome_escola");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_code.Text == "")
            {
                MessageBox.Show("Código Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(tb_nome.Text == "")
                {
                    MessageBox.Show("Nome Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Banco.Select("SELECT * FROM turmas WHERE code_turma = '"+tb_code.Text+"'").Rows.Count > 0)
                    {
                        MessageBox.Show("Turma Existente!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Inserindo Nova Turma
                        MemoryStream ms = new MemoryStream();
                        pb_foto.Image.Save(ms, ImageFormat.Png);
                        Byte[] bim = ms.ToArray();

                        Admin.Add_Turma(this.escola, tb_code.Text, tb_nome.Text, bim);
                        this.Close();
                    }
                }
            }
        }
    }
}
