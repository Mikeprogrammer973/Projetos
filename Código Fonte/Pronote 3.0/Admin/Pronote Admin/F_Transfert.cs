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
    public partial class F_Transfert : Form
    {
        private string[] turmas;
        private string mat;
        public F_Transfert(string escola,string matricula)
        {
            InitializeComponent();
            this.mat = matricula;
            DataTable info = Banco.Select("SELECT * FROM turmas WHERE code_escola = '" + escola + "'");
            if (info.Rows.Count > 0)
            {
                this.turmas = new string[info.Rows.Count];
                for (int t = 0; t < info.Rows.Count; t++)
                {
                    this.turmas[t] = info.Rows[t].Field<string>("code_turma");
                    cbb_turmaD.Items.Add(info.Rows[0].Field<string>("nome_turma"));
                }
            }
            else
            {
                cbb_turmaD.Text = "---";
            }
        }

        private void btn_transfert_Click(object sender, EventArgs e)
        {
            if(cbb_turmaD.Text == "---" || cbb_turmaD.Text == "")
            {
                MessageBox.Show("Turma Inválida!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Admin.Transferir_Aluno(this.mat, this.turmas[cbb_turmaD.Items.IndexOf(cbb_turmaD.SelectedItem)]);
                MessageBox.Show("Aluno Transferido Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
