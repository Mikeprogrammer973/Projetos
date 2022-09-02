using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Pronote_Admin
{
    public partial class F_Homepage : Form
    {
        private string selected = "nada";
        public F_Homepage()
        {
            InitializeComponent();
        }

        public void Atualizar(string id)
        {
            tv_escolas.Nodes.Clear();
                    DataTable escolas = Banco.Select("SELECT * FROM escolas WHERE code_adm_escola = '" + id + "' AND status = 'C'");
                    if (escolas.Rows.Count > 0)
                    {
                        for (int e = 0; e < escolas.Rows.Count; e++)
                        {
                            tv_escolas.Nodes.Add(escolas.Rows[e].Field<string>("nome_escola"));
                            tv_escolas.Nodes[e].Nodes.Add("Info");
                            tv_escolas.Nodes[e].Nodes[0].Nodes.Add(escolas.Rows[e].Field<string>("code_escola"));
                            //
                            tv_escolas.Nodes[e].Nodes.Add("Turmas");
                            DataTable turmas = Banco.Select("SELECT * FROM turmas WHERE code_escola = '" + escolas.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                            if (turmas.Rows.Count > 0)
                            {
                                for (int t = 0; t < turmas.Rows.Count; t++)
                                {
                                    tv_escolas.Nodes[e].Nodes[1].Nodes.Add(turmas.Rows[t].Field<string>("nome_turma"));
                                    tv_escolas.Nodes[e].Nodes[1].Nodes[t].Nodes.Add(turmas.Rows[t].Field<string>("code_turma"));
                                }
                            }
                            else
                            {
                                tv_escolas.Nodes[e].Nodes[1].Nodes.Add("Nenhum");
                            }
                            //
                            tv_escolas.Nodes[e].Nodes.Add("Alunos");
                            DataTable alunos = Banco.Select("SELECT * FROM alunos WHERE code_escola = '" + escolas.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                            if (alunos.Rows.Count > 0)
                            {
                                for (int a = 0; a < alunos.Rows.Count; a++)
                                {
                                    tv_escolas.Nodes[e].Nodes[2].Nodes.Add(alunos.Rows[a].Field<string>("nome_completo"));
                                    tv_escolas.Nodes[e].Nodes[2].Nodes[a].Nodes.Add(alunos.Rows[a].Field<string>("matricula"));
                                }
                            }
                            else
                            {
                                tv_escolas.Nodes[e].Nodes[2].Nodes.Add("Nenhum");
                            }
                            //
                            tv_escolas.Nodes[e].Nodes.Add("Professores");
                            DataTable profs = Banco.Select("SELECT * FROM profs WHERE code_escola = '" + escolas.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                            if (profs.Rows.Count > 0)
                            {
                                for (int p = 0; p < profs.Rows.Count; p++)
                                {
                                    tv_escolas.Nodes[e].Nodes[3].Nodes.Add(profs.Rows[p].Field<string>("nome_completo"));
                                    tv_escolas.Nodes[e].Nodes[3].Nodes[p].Nodes.Add(profs.Rows[p].Field<string>("code_prof"));
                                }
                            }
                            else
                            {
                                tv_escolas.Nodes[e].Nodes[3].Nodes.Add("Nenhum");
                            }
                            //
                            tv_escolas.Nodes[e].Nodes.Add("Disciplinas");
                            DataTable mat = Banco.Select("SELECT * FROM cargos_prof WHERE code_escola = '" + escolas.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                            if (mat.Rows.Count > 0)
                            {
                                for (int m = 0; m < mat.Rows.Count; m++)
                                {
                                    tv_escolas.Nodes[e].Nodes[4].Nodes.Add(mat.Rows[m].Field<string>("nome_disciplina"));
                                    tv_escolas.Nodes[e].Nodes[4].Nodes[m].Nodes.Add(mat.Rows[m].Field<string>("code_disciplina"));
                                }
                            }
                            else
                            {
                                tv_escolas.Nodes[e].Nodes[4].Nodes.Add("Nenhuma");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Escola Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            tv_escolas.Nodes.Add("Nova Escola");
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Turmas _Turmas = new F_Turmas();
            _Turmas.ShowDialog();
            Atualizar(Admin.id);
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }

        private void l_cadastro_Click(object sender, EventArgs e)
        {
            F_Cadastrar cadastrar = new F_Cadastrar();
            cadastrar.ShowDialog();
        }

        private void l_login_Click(object sender, EventArgs e)
        {
            F_Login login = new F_Login();
            login.ShowDialog();
            if(Admin.logado)
            {
               splitContainer2.SplitterDistance = 205;
               l_login.Visible = false;
               l_cadastro.Visible = false;
               tsm_tools.Visible = true;
               menuStrip1.Visible = true;
               contextMenuStrip1.Visible = true;
                splitContainer2.FixedPanel = FixedPanel.Panel2;
               pictureBox1.Image = Admin.image;
                //tv_escolas.BackColor = Color.White;
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
                Atualizar(Admin.id);
            }
        }

        private void F_Homepage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Admin.image;
            splitContainer2.SplitterDistance = 25;
            tsm_tools.Visible = false;
            menuStrip1.Visible = false;
            contextMenuStrip1.Enabled = false;
            contextMenuStrip1.Visible = false;
            pictureBox2.Location = new Point((this.Width / 2) - (pictureBox2.Width / 2), (this.Height / 2) - (pictureBox2.Width / 2));
            pictureBox2.Visible = false;
        }


        private void tsb_refresh_Click(object sender, EventArgs e)
        {
            Atualizar(Admin.id);
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F_NovaEscola f_NovaEscola = new F_NovaEscola();
            f_NovaEscola.ShowDialog();
            Atualizar(Admin.id);
        }

        private void novaEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovaEscola f_NovaEscola = new F_NovaEscola();
            f_NovaEscola.ShowDialog();
            Atualizar(Admin.id);
        }

        private void Arquivar()
        {
            if (MessageBox.Show("Deseja Arquivar Essa Escola?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Arquivar_Escola(Selected());
                MessageBox.Show("Escola Com o Código " + Selected() + " Foi Arquivada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Atualizar(Admin.id);
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }
        private void Remover()
        {
            if (MessageBox.Show("Deseja Remover Essa Escola?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Remove_Escola(Selected());
                MessageBox.Show("Escola Com o Código " + Selected() + " Foi Removida Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Atualizar(Admin.id);
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }

        private void tsb_arquivar_Click(object sender, EventArgs e)
        {
            Arquivar();
        }

        private void tv_escolas_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (tv_escolas.Nodes[tv_escolas.Nodes.Count-1].IsSelected)
            {
                F_NovaEscola f_NovaEscola = new F_NovaEscola();
                f_NovaEscola.ShowDialog();
                Atualizar(Admin.id);
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
            if (tv_escolas.Nodes.Count > 1)
            {
                for (int es = 0; es < tv_escolas.Nodes.Count; es++)
                {
                    if (tv_escolas.Nodes[es].IsSelected)
                    {
                        tsb_arquivar.Enabled = true;
                        tsb_remover.Enabled = true;
                        contextMenuStrip1.Enabled = true;
                        return;
                    }
                }
            }
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;          
        }

        private string Selected()
        {
            for (int es = 0; es < tv_escolas.Nodes.Count; es++)
            {
                if (tv_escolas.Nodes[es].IsSelected)
                {
                    this.selected = tv_escolas.Nodes[es].Nodes[0].Nodes[0].Text;
                }
            }
            return this.selected;
        }

        private void tsb_remover_Click(object sender, EventArgs e)
        {
            Remover();            
        }

        private void arquivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivar();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void tsb_recup_Click(object sender, EventArgs e)
        {
            F_Recuperar recuperar = new F_Recuperar("escola", Admin.id);
            recuperar.ShowDialog();
            Atualizar(Admin.id);
        }

        private void tsb_gerenciar_Click(object sender, EventArgs e)
        {
            F_Gerenciador f_Gerenciador = new F_Gerenciador("escola", Admin.id);
            f_Gerenciador.ShowDialog();
            Atualizar(Admin.id);
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Estatistiques _Estatistiques = new F_Estatistiques();
            _Estatistiques.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Alunos _Alunos = new F_Alunos();
            _Alunos.ShowDialog();
            Atualizar(Admin.id);
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }
    }
}
