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
    public partial class F_Gerenciador : Form
    {
        public string type, id;
        public F_Gerenciador(string type, string id)
        {
            InitializeComponent();
            this.type = type;
            this.id = id;
        }

        private void SetSelected()
        {
            if(dgv_dates_view.Rows.Count > 0)
            {
                dgv_dates_view.Select();
            }
            else
            {
                Limpar();
            }
        }

        private void dgv_dates_view_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            btn_add.Enabled = false;
            btn_alterar.Enabled = false;
            btn_arquivar.Enabled = false;
            btn_remover.Enabled = false;

            if (dgv_dates_view.SelectedRows.Count > 0)
            {
                btn_add.Enabled = true;
                btn_alterar.Enabled = true;
                btn_arquivar.Enabled = true;
                btn_remover.Enabled = true;

                DataTable info;
                switch (this.type)
                {
                    case "escola":
                        info = Banco.Select("SELECT * FROM escolas WHERE code_escola = '" + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + "'");
                        if(info.Rows.Count == 1)
                        {
                            textBox1.Text = info.Rows[0].Field<string>("code_escola");
                            textBox3.Text = info.Rows[0].Field<string>("nome_escola");
                            textBox2.Text = Banco.Select("SELECT * FROM alunos WHERE code_escola = '" + info.Rows[0].Field<string>("code_escola") + "'").Rows.Count.ToString();
                            textBox4.Text = Banco.Select("SELECT * FROM profs WHERE code_escola = '" + info.Rows[0].Field<string>("code_escola") + "'").Rows.Count.ToString();
                            comboBox1.Text = info.Rows[0].Field<string>("status") == "C" ? "Ativa" : "Arquivada";
                            MemoryStream ms = new MemoryStream((Byte[])info.Rows[0].ItemArray[4]);
                            pictureBox1.Image = null;
                            //pictureBox1.Image = Image.FromStream(ms);
                        }
                        break;
                    case "turma":
                        info = Banco.Select("SELECT * FROM turmas WHERE code_turma = '" + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + "'");
                        if (info.Rows.Count == 1)
                        {
                            textBox1.Text = info.Rows[0].Field<string>("code_turma");
                            textBox3.Text = info.Rows[0].Field<string>("nome_turma");
                            textBox2.Text = Banco.Select("SELECT * FROM alunos WHERE code_turma = '" + info.Rows[0].Field<string>("code_turma") + "'").Rows.Count.ToString();
                            textBox4.Text = Banco.Select("SELECT * FROM cargos_prof WHERE code_turma = '" + info.Rows[0].Field<string>("code_turma") + "'").Rows.Count.ToString();
                            comboBox1.Text = info.Rows[0].Field<string>("status") == "C" ? "Ativa" : "Arquivada";
                            MemoryStream ms = new MemoryStream((Byte[])info.Rows[0].ItemArray[3]);
                            pictureBox1.Image = null;
                            //pictureBox1.Image = Image.FromStream(ms);
                        }
                        break;
                }
            }
                
                
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            switch (this.type)
            {
                case "escola":
                    F_NovaEscola f_NovaEscola = new F_NovaEscola();
                    f_NovaEscola.ShowDialog();
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_escola as 'Código', nome_escola as 'Nome' FROM escolas WHERE code_adm_escola = '" + this.id + "'");
                    
                    break;
                case "turma":
                    F_NovaTurma f_NovaTurma = new F_NovaTurma(this.id);
                    f_NovaTurma.ShowDialog();
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_turma as 'Código', nome_turma as 'Nome' FROM turmas WHERE code_escola = '" + this.id + "'");

                    break;
                case "nota":
                    break;
                case "media":
                    break;
            }
            Limpar();
            SetSelected();
        }

        private void btn_arquivar_Click(object sender, EventArgs e)
        {
            
            switch (this.type)
            {
                case "escola":
                    if (MessageBox.Show("Deseja Arquivar Essa Escola?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Admin.Arquivar_Escola(dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Escola Com o Código " + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + " Foi Arquivada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_escola as 'Código', nome_escola as 'Nome' FROM escolas WHERE code_adm_escola = '" + this.id + "'");
                    
                    break;
                case "turma":
                    if (MessageBox.Show("Deseja Arquivar Essa Turma?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Admin.Arquivar_Turma(dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Turma Com o Código " + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + " Foi Arquivada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_turma as 'Código', nome_turma as 'Nome' FROM turmas WHERE code_escola = '" + this.id + "'");
                    
                    break;
                case "nota":
                    break;
                case "media":
                    break;
            }
            Limpar();
            SetSelected();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            
            switch (this.type)
            {
                case "escola":
                    if (MessageBox.Show("Deseja Remover Essa Escola?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Admin.Remove_Escola(dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Escola Com o Código " + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + " Foi Removida Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_escola as 'Código', nome_escola as 'Nome' FROM escolas WHERE code_adm_escola = '" + this.id + "'");
                    
                    break;
                case "turma":
                    if (MessageBox.Show("Deseja Remover Essa Turma?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Admin.Remove_Turma(dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Turma Com o Código " + dgv_dates_view.SelectedRows[0].Cells[0].Value.ToString() + " Foi Removida Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_turma as 'Código', nome_turma as 'Nome' FROM turmas WHERE code_escola = '" + this.id + "'");
                    
                    break;
                case "nota":
                    break;
                case "media":
                    break;
            }
            Limpar();
            SetSelected();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {//Exibir Imagem Escolhida                
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "escola":
                    if(textBox3.Text == "")
                    {
                        MessageBox.Show("Nome Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Focus();
                    }
                    else
                    {        
                            MemoryStream sm = new MemoryStream();
                            //pictureBox1.Image.Save(sm, ImageFormat.Png);
                            Byte[] bim = sm.ToArray();
                            Banco.Update("UPDATE escolas SET nome_escola = '" + textBox3.Text + "',status = '" + (comboBox1.Text == "Ativa" ? "C" : "A") + "',foto_perfil_escola = '" + bim + "' WHERE code_escola = '" + textBox1.Text + "'");
                            MessageBox.Show("Alterações Salvas Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_dates_view.DataSource = Banco.Select("SELECT code_escola as 'Código', nome_escola as 'Nome' FROM escolas WHERE code_adm_escola = '" + this.id + "'");
                            
                    }
                    
                    break;
                case "turma":
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Nome Inválido!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Focus();
                    }
                    else
                    {
                        MemoryStream sm = new MemoryStream();
                        //pictureBox1.Image.Save(sm, ImageFormat.Png);
                        Byte[] bim = sm.ToArray();
                        Banco.Update("UPDATE turmas SET nome_turma = '" + textBox3.Text + "',status = '" + (comboBox1.Text == "Ativa" ? "C" : "A") + "',foto_perfil_escola = '" + bim + "' WHERE code_escola = '" + textBox1.Text + "'");
                        MessageBox.Show("Alterações Salvas Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_dates_view.DataSource = Banco.Select("SELECT code_turma as 'Código', nome_turma as 'Nome' FROM turmas WHERE code_escola = '" + this.id + "'");

                    }

                    break;
                case "nota":
                    break;
                case "media":
                    break;
            }
            Limpar();
            SetSelected();
        }

        private void F_Gerenciador_Load(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "escola":
                    label1.Text = "Código:";
                    label2.Text = "Nome:";
                    label3.Text = "Qtd. Alunos:";
                    label4.Text = "Qtd. Professores:";
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_escola as 'Código', nome_escola as 'Nome' FROM escolas WHERE code_adm_escola = '" + this.id + "'");
                    break;
                case "turma":
                    label1.Text = "Código:";
                    label2.Text = "Nome:";
                    label3.Text = "Qtd. Alunos:";
                    label4.Text = "Qtd. Disciplinas:";
                    dgv_dates_view.DataSource = Banco.Select("SELECT code_turma as 'Código', nome_turma as 'Nome' FROM turmas WHERE code_escola = '" + this.id + "'");
                    break;
                case "nota":
                    tb_desc.Enabled = true;
                    break;
                case "media":
                    tb_desc.Enabled = true;
                    break;
            }
            SetSelected();
        }

        private void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            tb_desc.Clear();
            btn_arquivar.Enabled = false;
            btn_remover.Enabled = false;
            btn_alterar.Enabled = false;
            pictureBox1.Image = null;
        }
    }
}
