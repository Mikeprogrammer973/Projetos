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
    public partial class F_Alunos : Form
    {
        public F_Alunos()
        {
            InitializeComponent();
        }

        private void Atualizar()
        {
            tv_alunos.Nodes.Clear();
            DataTable escola = Banco.Select("SELECT * FROM escolas WHERE code_adm_escola = '" + Admin.id + "' AND status = 'C'");
            if (escola.Rows.Count > 0)
            {
                for (int e = 0; e < escola.Rows.Count; e++)
                {
                    tv_alunos.Nodes.Add(escola.Rows[e].Field<string>("nome_escola"));
                    tv_alunos.Nodes[e].Nodes.Add("Info");
                    tv_alunos.Nodes[e].Nodes[0].Nodes.Add(escola.Rows[e].Field<string>("code_escola"));
                    tv_alunos.Nodes[e].Nodes.Add("Novo Aluno");

                    DataTable aluno = Banco.Select("SELECT * FROM alunos WHERE code_escola = '" + escola.Rows[e].Field<string>("code_escola") + "' AND status = 'C'");
                    if (aluno.Rows.Count > 0)
                    {
                        for (int a = 0; a < aluno.Rows.Count; a++)
                        {
                            tv_alunos.Nodes[e].Nodes.Add(aluno.Rows[a].Field<string>("nome_completo"));
                            tv_alunos.Nodes[e].Nodes[a + 2].Nodes.Add("Matrícula");
                            tv_alunos.Nodes[e].Nodes[a + 2].Nodes[0].Nodes.Add(aluno.Rows[a].Field<string>("matricula"));
                            tv_alunos.Nodes[e].Nodes[a + 2].Nodes.Add("Turma");
                            tv_alunos.Nodes[e].Nodes[a + 2].Nodes[1].Nodes.Add(Banco.Select("SELECT * FROM turmas WHERE code_turma = '" + aluno.Rows[a].Field<string>("code_turma") + "'").Rows[0].Field<string>("nome_turma"));
                        }
                    }
                    else
                    {
                        //
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Escola Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void F_Alunos_Load(object sender, EventArgs e)
        {
            Atualizar();
            tsb_gerenciar.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            tsb_add.Enabled = false;
            tsb_transferir.Enabled = false;
        }

        private string Selected()
        {
            string code = "";
            for (int s = 0; s < tv_alunos.Nodes.Count; s++)
            {
                if (tv_alunos.Nodes[s].IsSelected)
                {
                    code = tv_alunos.Nodes[s].Nodes[0].Nodes[0].Text;
                }
                else
                {

                    for (int a = 2; a < tv_alunos.Nodes[s].Nodes.Count; a++)
                    {

                        if (tv_alunos.Nodes[s].Nodes[a].IsSelected)
                        {
                            code = tv_alunos.Nodes[s].Nodes[a].Nodes[0].Nodes[0].Text;
                        }
                    }
                }
            }
            return code;
        }

        private void tv_alunos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int s = 0; s < tv_alunos.Nodes.Count; s++)
            {
                if (tv_alunos.Nodes[s].Nodes[1].IsSelected)
                {
                    F_NovoAluno _NovoAluno = new F_NovoAluno(tv_alunos.Nodes[s].Nodes[0].Nodes[0].Text);
                    _NovoAluno.ShowDialog();
                    Atualizar();
                    tsb_gerenciar.Enabled = false;
                    tsb_arquivar.Enabled = false;
                    tsb_remover.Enabled = false;
                    tsb_add.Enabled = false; 
                    tsb_transferir.Enabled = false;
                }
                if (tv_alunos.Nodes[s].Nodes[0].IsSelected)
                {                    
                    tsb_gerenciar.Enabled = false;
                    tsb_arquivar.Enabled = false;
                    tsb_remover.Enabled = false;
                    tsb_add.Enabled = false;
                    tsb_transferir.Enabled = false;
                }
                if (tv_alunos.Nodes[s].IsSelected)
                {
                    tsb_gerenciar.Enabled = true;
                    tsb_add.Enabled = true;
                    tsb_arquivar.Enabled = false;
                    tsb_remover.Enabled = false;
                    tsb_transferir.Enabled = false;
                    contextMenuStrip1.Enabled = false;
                }
                else
                {

                    for (int a = 2; a < tv_alunos.Nodes[s].Nodes.Count; a++)
                    {

                        if (tv_alunos.Nodes[s].Nodes[a].IsSelected)
                        {
                            contextMenuStrip1.Enabled = true;
                            tsb_arquivar.Enabled = true;
                            tsb_remover.Enabled = true;
                            tsb_transferir.Enabled = true;
                            tsb_gerenciar.Enabled = false;
                            tsb_add.Enabled = false;
                            return;
                        }
                    }
                    //tsb_gerenciar.Enabled = false;
                }
            }
            contextMenuStrip1.Enabled = false;
        }

        private void tsb_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_Novo = new F_NovoAluno(Selected());
            f_Novo.ShowDialog();
            Atualizar();
            tsb_gerenciar.Enabled = false;
            tsb_arquivar.Enabled = false;
            tsb_remover.Enabled = false;
            tsb_add.Enabled = false;
            tsb_transferir.Enabled = false;

        }

        private void Arquivar()
        {
            if (MessageBox.Show("Deseja Arquivar Essa Aluno?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Arquivar_Aluno(Selected());
                MessageBox.Show("Aluno Com a Matrícula " + Selected() + " Foi Arquivada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Atualizar();
                tsb_gerenciar.Enabled = false;
                tsb_transferir.Enabled = false;
                tsb_add.Enabled = false;
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }
        private void Remover()
        {
            if (MessageBox.Show("Deseja Remover Essa Aluno?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Admin.Remove_Aluno(Selected());
                MessageBox.Show("Aluno Com a Matrícula " + Selected() + " Foi Removida Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Atualizar();
                tsb_gerenciar.Enabled = false;
                tsb_transferir.Enabled = false;
                tsb_arquivar.Enabled = false;
                tsb_remover.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }

        private void tsb_arquivar_Click(object sender, EventArgs e)
        {
            Arquivar();
        }

        private void arquvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivar();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void tsb_remover_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void tsb_transferir_Click(object sender, EventArgs e)
        {
            string code = "";
            for (int s = 0; s < tv_alunos.Nodes.Count; s++)
            {
                    for (int a = 2; a < tv_alunos.Nodes[s].Nodes.Count; a++)
                    {

                        if (tv_alunos.Nodes[s].Nodes[a].IsSelected)
                        {
                            code = tv_alunos.Nodes[s].Nodes[0].Nodes[0].Text;
                        }
                    }
            }
            F_Transfert _Transfert = new F_Transfert(code,Selected());
            _Transfert.ShowDialog();
        }
    }
}
