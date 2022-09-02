using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronote_Admin
{
    public partial class F_Turmas : Form
    {
        public F_Turmas()
        {
            InitializeComponent();
        }

        private void Atualizar(string id)
        {
            tv_turmas.Nodes.Clear();

            DataTable escolas = Banco.Select("SELECT * FROM escolas WHERE code_adm_escola = '" + id + "' AND status = 'C'");

            if(escolas.Rows.Count > 0)
            {
                //Exibindo Escolas
                for(int e = 0; e < escolas.Rows.Count; e++)
                {
                    tv_turmas.Nodes.Add(escolas.Rows[e].Field<string>("nome_escola"));

                    //Exibindo Código da Escola
                    tv_turmas.Nodes[e].Nodes.Add("Info");
                    tv_turmas.Nodes[e].Nodes[0].Nodes.Add(escolas.Rows[e].Field<string>("code_escola"));

                    //Nova Turma
                    tv_turmas.Nodes[e].Nodes.Add("Nova Turma");

                    //Exibindo Turmas da Escola
                    DataTable turmas = Banco.Select("SELECT * FROM turmas WHERE code_escola = '"+ escolas.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                    if(turmas.Rows.Count > 0)
                    {
                        for(int t = 0; t < turmas.Rows.Count; t++)
                        {
                            tv_turmas.Nodes[e].Nodes.Add(turmas.Rows[t].Field<string>("nome_turma"));

                            //Exibindo Código da Turma
                            tv_turmas.Nodes[e].Nodes[t + 2].Nodes.Add("Código");
                            tv_turmas.Nodes[e].Nodes[t + 2].Nodes[0].Nodes.Add(turmas.Rows[t].Field<string>("code_turma"));

                            //Exibindo Alunos da Turma
                            tv_turmas.Nodes[e].Nodes[t + 2].Nodes.Add("Alunos");
                            DataTable alunos = Banco.Select("SELECT * FROM alunos WHERE code_turma = '" + turmas.Rows[t].Field<string>("code_turma") + "'");
                            if(alunos.Rows.Count > 0)
                            {
                                for(int a = 0; a < alunos.Rows.Count; a++)
                                {
                                    tv_turmas.Nodes[e].Nodes[t + 2].Nodes[1].Nodes.Add(alunos.Rows[a].Field<string>("nome_completo"));
                                }
                            }
                            else
                            {
                                tv_turmas.Nodes[e].Nodes[t + 2].Nodes[1].Nodes.Add("Nenhum Aluno Disponível!");
                            }

                            //Exibindo Profs da Turma
                            tv_turmas.Nodes[e].Nodes[t + 2].Nodes.Add("Professores");
                            DataTable profs = Banco.Select("SELECT * FROM profs WHERE code_escola = '" + escolas.Rows[e].Field<string>("code_escola") + "'");
                            if (profs.Rows.Count > 0)
                            {
                                for (int p = 0; p < profs.Rows.Count; p++)
                                {
                                    tv_turmas.Nodes[e].Nodes[t + 2].Nodes[2].Nodes.Add(profs.Rows[p].Field<string>("nome_completo"));

                                    //Exibindo Cargos do Prof
                                    DataTable cargos = Banco.Select("SELECT * FROM cargos_prof WHERE code_prof = '" + profs.Rows[p].Field<string>("code_prof") + "' AND code_turma '" + turmas.Rows[t].Field<string>("code_turma") + "' AND status = 'C'");
                                    if(cargos.Rows.Count > 0)
                                    {
                                        for(int c = 0; c < cargos.Rows.Count; c++)
                                        {
                                            tv_turmas.Nodes[e].Nodes[t + 2].Nodes[2].Nodes[p].Nodes.Add(cargos.Rows[c].Field<string>("nome_disciplina"));
                                        }
                                    }
                                    else
                                    {
                                        tv_turmas.Nodes[e].Nodes[t + 2].Nodes[2].Nodes[p].Nodes.Add("Nenhum Cargo Disponível!");
                                    }
                                }
                            }
                            else
                            {
                                tv_turmas.Nodes[e].Nodes[t + 2].Nodes[2].Nodes.Add("Nenhum Professor Disponível!");
                            }
                        }
                    }
                    else
                    {
                       // MessageBox.Show("Nenhuma Turma Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Escola Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsb_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar(Admin.id);
        }

        private void F_Turmas_Load(object sender, EventArgs e)
        {
            Atualizar(Admin.id);
            contextMenuStrip1.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            tsb_add.Enabled = false;
            tsb_gerenciar.Enabled = false;
        }



        private void tsb_add_Click(object sender, EventArgs e)
        {
            F_NovaTurma f_Nova = new F_NovaTurma(Selected());
            f_Nova.ShowDialog();
            Atualizar(Admin.id);
            //tsb_gerenciar.Enabled = false;
            //tsb_add.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;

        }

        private void tv_turmas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tsb_gerenciar.Enabled = false;
            tsb_add.Enabled = false;
            for (int esc = 0; esc < tv_turmas.Nodes.Count; esc++)
            {
                if (tv_turmas.Nodes[esc].IsSelected)
                {
                    tsb_gerenciar.Enabled = true;
                    tsb_add.Enabled = true;
                }
                if (tv_turmas.Nodes[esc].Nodes[1].IsSelected)
                {
                    F_NovaTurma f_NovaTurma = new F_NovaTurma(tv_turmas.Nodes[esc].Nodes[0].Nodes[0].Text);
                    f_NovaTurma.ShowDialog();
                    Atualizar(Admin.id);
                    //tsb_gerenciar.Enabled = false;
                    //tsb_add.Enabled = false;
                    tsb_arquivar.Enabled = false;
                    tsb_remover.Enabled = false;
                    contextMenuStrip1.Enabled = false;
                }
                if (tv_turmas.Nodes[esc].Nodes.Count > 2)
                {
                    for (int t = 2; t < tv_turmas.Nodes[esc].Nodes.Count; t++)
                    {
                        if (tv_turmas.Nodes[esc].Nodes[t].IsSelected)
                        {
                            tsb_arquivar.Enabled = true;
                            tsb_remover.Enabled = true;
                            contextMenuStrip1.Enabled = true;
                            tsb_gerenciar.Enabled = false;
                            tsb_add.Enabled = false;
                            return;
                        }
                    }

                    tsb_arquivar.Enabled = false;
                    tsb_remover.Enabled = false;
                    contextMenuStrip1.Enabled = false;

                }
            }
        }

        private string Selected()
        {
            string code = "";
            for (int esc = 0; esc < tv_turmas.Nodes.Count; esc++)
            {
                if (tv_turmas.Nodes[esc].IsSelected)
                {
                    code = tv_turmas.Nodes[esc].Nodes[0].Nodes[0].Text;
                }
                
                if (tv_turmas.Nodes[esc].Nodes.Count > 2)
                {
                    for (int t = 2; t < tv_turmas.Nodes[esc].Nodes.Count; t++)
                    {
                        if (tv_turmas.Nodes[esc].Nodes[t].IsSelected)
                        {
                            code = tv_turmas.Nodes[esc].Nodes[t].Nodes[0].Nodes[0].Text;
                        }
                    }

                }
            }
            return code;
        }

        private void Arquivar()
        {
            if (MessageBox.Show("Deseja Arquivar Essa Turma?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Arquivar_Turma(Selected());
                MessageBox.Show("Turma Com o Código " + Selected() + " Foi Arquivada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Atualizar(Admin.id);
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }
        private void Remover()
        {
            if (MessageBox.Show("Deseja Remover Essa Turma?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Remove_Turma(Selected());
                MessageBox.Show("Turma Com o Código " + Selected() + " Foi Removida Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void arquivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivar();
        }

        private void tsb_remover_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void tsb_recup_Click(object sender, EventArgs e)
        {
            F_Recuperar recuperar = new F_Recuperar("turma", Admin.id);
            recuperar.ShowDialog();
            Atualizar(Admin.id);
            //tsb_gerenciar.Enabled = false;
            //tsb_add.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }

        private void tsb_gerenciar_Click(object sender, EventArgs e)
        {
            F_Gerenciador f_Gerenciador = new F_Gerenciador("turma",Selected());
            f_Gerenciador.ShowDialog();
            Atualizar(Admin.id);
            //tsb_gerenciar.Enabled = false;
            //tsb_add.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            contextMenuStrip1.Enabled = false;
        }
    }
}    

