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
    public partial class F_NovoAluno : Form
    {
        private string escola;
        private string[] turmas;
        public F_NovoAluno(string escola)
        {
            InitializeComponent();
            this.escola = escola;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_escola.Text == "---" || tb_escola.Text == "")
            {
                MessageBox.Show("Escola Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(tb_matricula.Text == "")
                {
                    MessageBox.Show("Matrícula Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Banco.Select("SELECT * FROM alunos WHERE matricula = '"+tb_matricula.Text+"'").Rows.Count > 0)
                    {
                        MessageBox.Show("Aluno Existente!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(cbb_turma.Text == "---" || cbb_turma.Text == "")
                        {
                            MessageBox.Show("Turma Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if(tb_nome.Text == "")
                            {
                                MessageBox.Show("Nome Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Inserindo Novo Aluno
                                MemoryStream sm = new MemoryStream();
                                pb_foto.Image.Save(sm, ImageFormat.Png);
                                Byte[] bim = sm.ToArray();
                                Admin.Add_Aluno(tb_matricula.Text, this.escola, tb_nome.Text, this.turmas[cbb_turma.Items.IndexOf(cbb_turma.SelectedItem)], bim);
                                this.Close();
                            }
                        }
                    }
                }
            }
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

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            DataTable info = Banco.Select("SELECT * FROM escolas WHERE code_escola = '" + this.escola + "'");
            if(info.Rows.Count > 0)
            {
                tb_escola.Text = info.Rows[0].Field<string>("nome_escola");
            }
            else
            {
                tb_escola.Text = "---";
            }
            info = Banco.Select("SELECT * FROM turmas WHERE code_escola = '" + this.escola + "'");
            if (info.Rows.Count > 0)
            {
                this.turmas = new string[info.Rows.Count];
                for(int t = 0; t < info.Rows.Count; t++)
                {
                    this.turmas[t] = info.Rows[t].Field<string>("code_turma");
                    cbb_turma.Items.Add(info.Rows[0].Field<string>("nome_turma"));
                }
            }
            else
            {
                cbb_turma.Text = "---";
            }
            bool ct = false;
            do
            {               
                Random rand = new Random();
                int code_r = rand.Next(0, 10000000) * 7;
                if (Banco.Select("SELECT * FROM alunos WHERE matricula = '" + code_r.ToString() + "'").Rows.Count > 0)
                {
                    ct = false;
                }
                else
                {
                    ct = true;
                    tb_matricula.Text = code_r.ToString();
                }
            } while (!ct); 

        }
    }
}
