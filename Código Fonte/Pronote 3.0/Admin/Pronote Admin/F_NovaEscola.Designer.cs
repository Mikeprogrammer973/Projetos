
namespace Pronote_Admin
{
    partial class F_NovaEscola
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
            this.tb_adm = new System.Windows.Forms.TextBox();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ccb_periodo = new System.Windows.Forms.ComboBox();
            this.nup_qtd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_adm
            // 
            this.tb_adm.Location = new System.Drawing.Point(203, 33);
            this.tb_adm.Name = "tb_adm";
            this.tb_adm.ReadOnly = true;
            this.tb_adm.Size = new System.Drawing.Size(161, 20);
            this.tb_adm.TabIndex = 1;
            this.tb_adm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(202, 72);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(161, 20);
            this.tb_code.TabIndex = 2;
            this.tb_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(202, 111);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(161, 20);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ccb_periodo
            // 
            this.ccb_periodo.FormattingEnabled = true;
            this.ccb_periodo.Items.AddRange(new object[] {
            "Mês",
            "Bimestre",
            "Trimestre",
            "Semestre",
            "Ano",
            "Temporada"});
            this.ccb_periodo.Location = new System.Drawing.Point(202, 150);
            this.ccb_periodo.Name = "ccb_periodo";
            this.ccb_periodo.Size = new System.Drawing.Size(161, 21);
            this.ccb_periodo.TabIndex = 4;
            this.ccb_periodo.Text = "Digite ou Selecione...";
            // 
            // nup_qtd
            // 
            this.nup_qtd.Location = new System.Drawing.Point(202, 194);
            this.nup_qtd.Name = "nup_qtd";
            this.nup_qtd.Size = new System.Drawing.Size(161, 20);
            this.nup_qtd.TabIndex = 5;
            this.nup_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Período:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtd. de Período:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 233);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(184, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(202, 233);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clique aqui para escolher...";
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_foto.Image = global::Pronote_Admin.Properties.Resources.desenho;
            this.pb_foto.Location = new System.Drawing.Point(12, 12);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(184, 202);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 0;
            this.pb_foto.TabStop = false;
            this.pb_foto.Click += new System.EventHandler(this.pb_foto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.PNG)|*PNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pronote_Admin.Properties.Resources.loading_003;
            this.pictureBox1.Location = new System.Drawing.Point(170, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // F_NovaEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nup_qtd);
            this.Controls.Add(this.ccb_periodo);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.tb_adm);
            this.Controls.Add(this.pb_foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovaEscola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Escola";
            this.Load += new System.EventHandler(this.F_NovaEscola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.TextBox tb_adm;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ComboBox ccb_periodo;
        private System.Windows.Forms.NumericUpDown nup_qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}