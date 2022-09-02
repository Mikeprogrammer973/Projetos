
namespace Pronote_Admin
{
    partial class F_Login
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
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_cadastro = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l_recupSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(13, 84);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(164, 20);
            this.tb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-vindo ao Pronote Admin!\r\nPor favor, digite a sua senha para continuar...\r\n";
            // 
            // l_cadastro
            // 
            this.l_cadastro.AutoSize = true;
            this.l_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_cadastro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_cadastro.Location = new System.Drawing.Point(16, 177);
            this.l_cadastro.Name = "l_cadastro";
            this.l_cadastro.Size = new System.Drawing.Size(52, 13);
            this.l_cadastro.TabIndex = 2;
            this.l_cadastro.Text = "Cadastrar";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(12, 124);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(164, 23);
            this.btn_logar.TabIndex = 3;
            this.btn_logar.Text = "Entrar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // l_recupSenha
            // 
            this.l_recupSenha.AutoSize = true;
            this.l_recupSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_recupSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_recupSenha.Location = new System.Drawing.Point(69, 177);
            this.l_recupSenha.Name = "l_recupSenha";
            this.l_recupSenha.Size = new System.Drawing.Size(108, 13);
            this.l_recupSenha.TabIndex = 5;
            this.l_recupSenha.Text = "Esqueci minha senha";
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 214);
            this.Controls.Add(this.l_recupSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.l_cadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_cadastro;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_recupSenha;
    }
}