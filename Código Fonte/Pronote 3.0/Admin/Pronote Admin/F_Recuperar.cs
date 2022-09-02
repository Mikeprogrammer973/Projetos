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
    public partial class F_Recuperar : Form
    {
        private string type, id;
        private string[] info,escolas,turmas,alunos,materias;

        private void cbb_escola_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "turma":
                    this.clb_recup.Items.Clear();
                    DataTable data = Banco.Select("SELECT * FROM turmas WHERE code_escola = '" + this.escolas[cbb_escola.Items.IndexOf(cbb_escola.SelectedItem)] + "' AND status = 'A'");
                    if(data.Rows.Count > 0)
                    {
                        this.info = new string[data.Rows.Count];
                        for(int t = 0; t < data.Rows.Count; t++)
                        {
                            this.info[t] = data.Rows[t].Field<string>("code_turma");
                            this.clb_recup.Items.Add(data.Rows[t].Field<string>("nome_turma"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Recuperação Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        public F_Recuperar(string type, string id)
        {
            InitializeComponent();
            this.type = type;
            this.id = id;
        }

        private void btn_recup_Click(object sender, EventArgs e)
        {

            if(clb_recup.Items.Count == 0)
            {
                MessageBox.Show("Nenhuma Recuperação Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                if(clb_recup.SelectedItems.Count > 0)
                {
                    for (int c = 0; c < clb_recup.Items.Count; c++)
                    {
                        Admin.Recuperar(this.type, this.info[clb_recup.Items.IndexOf(clb_recup.Items[c])]);
                    }
                    MessageBox.Show("Recuperações Realizadas Com Sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum Item Selecionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clb_recup_Click(object sender, EventArgs e)
        {
            if (clb_recup.Items.Count == 0)
            {
                MessageBox.Show("Nenhuma Recuperação Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void F_Recuperar_Load(object sender, EventArgs e)
        {
            DataTable data = null;
            switch (this.type)
            {
                case "escola":
                    cbb_aluno.Enabled = false;
                    cbb_escola.Enabled = false;
                    cbb_materia.Enabled = false;
                    cbb_periode.Enabled = false;
                    cbb_turma.Enabled = false;

                    data = Banco.Select("SELECT * FROM escolas WHERE code_adm_escola = '" + this.id + "' AND status = 'A'");
                    this.info = new string[data.Rows.Count];

                    if(data.Rows.Count > 0)
                    {
                        clb_recup.Items.Clear();
                        for(int c = 0; c < data.Rows.Count; c++)
                        {
                            this.info[c] = data.Rows[c].Field<string>("code_escola");
                            clb_recup.Items.Add(data.Rows[c].Field<string>("nome_escola"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Recuperação Disponível!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                case "turma":
                    data = Banco.Select("SELECT * FROM escolas WHERE code_adm_escola = '" + this.id + "' AND status = 'C'");
                    if(data.Rows.Count > 0)
                    {
                        this.escolas = new string[data.Rows.Count];
                        for(int s = 0; s < data.Rows.Count; s++)
                        {
                            this.escolas[s] = data.Rows[s].Field<string>("code_escola");
                            this.cbb_escola.Items.Add(data.Rows[s].Field<string>("nome_escola"));
                        }
                    }
                    cbb_aluno.Enabled = false;
                    cbb_materia.Enabled = false;
                    cbb_periode.Enabled = false;
                    cbb_turma.Enabled = false;
                    break;
                case "aluno":
                    cbb_aluno.Enabled = false;
                    cbb_materia.Enabled = false;
                    cbb_periode.Enabled = false;
                    break;
                case "prof":
                    cbb_aluno.Enabled = false;
                    cbb_materia.Enabled = false;
                    cbb_periode.Enabled = false;
                    cbb_turma.Enabled = false;
                    break;
                case "materia":
                    cbb_aluno.Enabled = false;
                    cbb_materia.Enabled = false;
                    cbb_periode.Enabled = false;
                    break;
            }
        }
    }
}
