
namespace Pronote_Admin
{
    partial class F_Transfert
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
            this.btn_transfert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_turmaD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_transfert
            // 
            this.btn_transfert.Location = new System.Drawing.Point(13, 80);
            this.btn_transfert.Name = "btn_transfert";
            this.btn_transfert.Size = new System.Drawing.Size(154, 23);
            this.btn_transfert.TabIndex = 1;
            this.btn_transfert.Text = "Transferir";
            this.btn_transfert.UseVisualStyleBackColor = true;
            this.btn_transfert.Click += new System.EventHandler(this.btn_transfert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turma Destino:";
            // 
            // cbb_turmaD
            // 
            this.cbb_turmaD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_turmaD.FormattingEnabled = true;
            this.cbb_turmaD.Location = new System.Drawing.Point(16, 43);
            this.cbb_turmaD.Name = "cbb_turmaD";
            this.cbb_turmaD.Size = new System.Drawing.Size(151, 21);
            this.cbb_turmaD.TabIndex = 3;
            // 
            // F_Transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 121);
            this.Controls.Add(this.cbb_turmaD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_transfert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Transfert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferença";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_transfert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_turmaD;
    }
}