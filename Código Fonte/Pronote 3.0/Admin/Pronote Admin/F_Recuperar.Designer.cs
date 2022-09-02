
namespace Pronote_Admin
{
    partial class F_Recuperar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_recup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_periode = new System.Windows.Forms.ComboBox();
            this.cbb_materia = new System.Windows.Forms.ComboBox();
            this.cbb_aluno = new System.Windows.Forms.ComboBox();
            this.cbb_turma = new System.Windows.Forms.ComboBox();
            this.cbb_escola = new System.Windows.Forms.ComboBox();
            this.clb_recup = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.05556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.94444F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clb_recup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 304);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_recup, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.46712F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.53287F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(181, 292);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_recup
            // 
            this.btn_recup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_recup.Location = new System.Drawing.Point(6, 250);
            this.btn_recup.Name = "btn_recup";
            this.btn_recup.Size = new System.Drawing.Size(169, 36);
            this.btn_recup.TabIndex = 0;
            this.btn_recup.Text = "Recuperar";
            this.btn_recup.UseVisualStyleBackColor = true;
            this.btn_recup.Click += new System.EventHandler(this.btn_recup_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_periode);
            this.panel1.Controls.Add(this.cbb_materia);
            this.panel1.Controls.Add(this.cbb_aluno);
            this.panel1.Controls.Add(this.cbb_turma);
            this.panel1.Controls.Add(this.cbb_escola);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 235);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Período:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escola:";
            // 
            // cbb_periode
            // 
            this.cbb_periode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_periode.FormattingEnabled = true;
            this.cbb_periode.Location = new System.Drawing.Point(4, 211);
            this.cbb_periode.Name = "cbb_periode";
            this.cbb_periode.Size = new System.Drawing.Size(162, 21);
            this.cbb_periode.TabIndex = 4;
            // 
            // cbb_materia
            // 
            this.cbb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_materia.FormattingEnabled = true;
            this.cbb_materia.Location = new System.Drawing.Point(4, 168);
            this.cbb_materia.Name = "cbb_materia";
            this.cbb_materia.Size = new System.Drawing.Size(162, 21);
            this.cbb_materia.TabIndex = 3;
            // 
            // cbb_aluno
            // 
            this.cbb_aluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_aluno.FormattingEnabled = true;
            this.cbb_aluno.Location = new System.Drawing.Point(4, 122);
            this.cbb_aluno.Name = "cbb_aluno";
            this.cbb_aluno.Size = new System.Drawing.Size(162, 21);
            this.cbb_aluno.TabIndex = 2;
            // 
            // cbb_turma
            // 
            this.cbb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_turma.FormattingEnabled = true;
            this.cbb_turma.Location = new System.Drawing.Point(4, 75);
            this.cbb_turma.Name = "cbb_turma";
            this.cbb_turma.Size = new System.Drawing.Size(162, 21);
            this.cbb_turma.TabIndex = 1;
            // 
            // cbb_escola
            // 
            this.cbb_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_escola.FormattingEnabled = true;
            this.cbb_escola.Location = new System.Drawing.Point(4, 29);
            this.cbb_escola.Name = "cbb_escola";
            this.cbb_escola.Size = new System.Drawing.Size(162, 21);
            this.cbb_escola.TabIndex = 0;
            this.cbb_escola.SelectedIndexChanged += new System.EventHandler(this.cbb_escola_SelectedIndexChanged);
            // 
            // clb_recup
            // 
            this.clb_recup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_recup.FormattingEnabled = true;
            this.clb_recup.Location = new System.Drawing.Point(196, 6);
            this.clb_recup.Name = "clb_recup";
            this.clb_recup.Size = new System.Drawing.Size(161, 292);
            this.clb_recup.TabIndex = 1;
            this.clb_recup.Click += new System.EventHandler(this.clb_recup_Click);
            // 
            // F_Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Recuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar";
            this.Load += new System.EventHandler(this.F_Recuperar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_recup;
        private System.Windows.Forms.CheckedListBox clb_recup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_periode;
        private System.Windows.Forms.ComboBox cbb_materia;
        private System.Windows.Forms.ComboBox cbb_aluno;
        private System.Windows.Forms.ComboBox cbb_turma;
        private System.Windows.Forms.ComboBox cbb_escola;
    }
}