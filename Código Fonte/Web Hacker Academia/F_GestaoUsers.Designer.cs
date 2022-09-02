
namespace Web_Hacker_Academia
{
    partial class F_GestaoUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.cbb_nivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_novo_usuario = new System.Windows.Forms.Button();
            this.btn_salver_alteracoes = new System.Windows.Forms.Button();
            this.btn_exluir_usuario = new System.Windows.Forms.Button();
            this.btn_close_window = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nível:";
            // 
            // cbb_status
            // 
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cbb_status.Location = new System.Drawing.Point(126, 192);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(108, 21);
            this.cbb_status.TabIndex = 15;
            // 
            // cbb_nivel
            // 
            this.cbb_nivel.FormattingEnabled = true;
            this.cbb_nivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbb_nivel.Location = new System.Drawing.Point(14, 192);
            this.cbb_nivel.Name = "cbb_nivel";
            this.cbb_nivel.Size = new System.Drawing.Size(106, 21);
            this.cbb_nivel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(125, 141);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(109, 20);
            this.tb_username.TabIndex = 11;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 90);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(222, 20);
            this.tb_nome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 38);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(118, 20);
            this.tb_id.TabIndex = 18;
            this.tb_id.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(16, 141);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '#';
            this.tb_senha.Size = new System.Drawing.Size(104, 20);
            this.tb_senha.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close_window);
            this.panel1.Controls.Add(this.btn_exluir_usuario);
            this.panel1.Controls.Add(this.btn_salver_alteracoes);
            this.panel1.Controls.Add(this.btn_novo_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 32);
            this.panel1.TabIndex = 22;
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.Location = new System.Drawing.Point(240, 6);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgv_users.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(323, 241);
            this.dgv_users.TabIndex = 23;
            this.dgv_users.SelectionChanged += new System.EventHandler(this.dgv_users_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "A = Ativo | B = Bloqueado | D = Desligado ";
            // 
            // btn_novo_usuario
            // 
            this.btn_novo_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_usuario.Location = new System.Drawing.Point(12, 6);
            this.btn_novo_usuario.Name = "btn_novo_usuario";
            this.btn_novo_usuario.Size = new System.Drawing.Size(126, 23);
            this.btn_novo_usuario.TabIndex = 0;
            this.btn_novo_usuario.Text = "Novo Usuário";
            this.btn_novo_usuario.UseVisualStyleBackColor = true;
            this.btn_novo_usuario.Click += new System.EventHandler(this.btn_novo_usuario_Click);
            // 
            // btn_salver_alteracoes
            // 
            this.btn_salver_alteracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salver_alteracoes.Location = new System.Drawing.Point(143, 6);
            this.btn_salver_alteracoes.Name = "btn_salver_alteracoes";
            this.btn_salver_alteracoes.Size = new System.Drawing.Size(156, 23);
            this.btn_salver_alteracoes.TabIndex = 1;
            this.btn_salver_alteracoes.Text = "Salvar Alterações";
            this.btn_salver_alteracoes.UseVisualStyleBackColor = true;
            this.btn_salver_alteracoes.Click += new System.EventHandler(this.btn_salver_alteracoes_Click);
            // 
            // btn_exluir_usuario
            // 
            this.btn_exluir_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exluir_usuario.Location = new System.Drawing.Point(305, 6);
            this.btn_exluir_usuario.Name = "btn_exluir_usuario";
            this.btn_exluir_usuario.Size = new System.Drawing.Size(135, 23);
            this.btn_exluir_usuario.TabIndex = 2;
            this.btn_exluir_usuario.Text = "Excluir Usuário";
            this.btn_exluir_usuario.UseVisualStyleBackColor = true;
            this.btn_exluir_usuario.Click += new System.EventHandler(this.btn_exluir_usuario_Click);
            // 
            // btn_close_window
            // 
            this.btn_close_window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close_window.Location = new System.Drawing.Point(446, 4);
            this.btn_close_window.Name = "btn_close_window";
            this.btn_close_window.Size = new System.Drawing.Size(117, 23);
            this.btn_close_window.TabIndex = 3;
            this.btn_close_window.Text = "Fechar Janela";
            this.btn_close_window.UseVisualStyleBackColor = true;
            this.btn_close_window.Click += new System.EventHandler(this.btn_close_window_Click);
            // 
            // F_GestaoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 285);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_status);
            this.Controls.Add(this.cbb_nivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuários";
            this.Load += new System.EventHandler(this.F_GestaoUsers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.ComboBox cbb_nivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_salver_alteracoes;
        private System.Windows.Forms.Button btn_novo_usuario;
        private System.Windows.Forms.Button btn_exluir_usuario;
        private System.Windows.Forms.Button btn_close_window;
    }
}