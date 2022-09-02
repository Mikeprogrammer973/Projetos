
namespace Pronote_Admin
{
    partial class F_Profs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Profs));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novoProfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsm_tools = new System.Windows.Forms.ToolStrip();
            this.tv_profs = new System.Windows.Forms.TreeView();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_gerenciar = new System.Windows.Forms.ToolStripButton();
            this.tsb_aquivar = new System.Windows.Forms.ToolStripButton();
            this.tsb_remover = new System.Windows.Forms.ToolStripButton();
            this.tsb_recup = new System.Windows.Forms.ToolStripButton();
            this.tsb_atualizar = new System.Windows.Forms.ToolStripButton();
            this.gerenciarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsm_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProfToolStripMenuItem,
            this.gerenciarProfessoresToolStripMenuItem,
            this.arquivarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 92);
            // 
            // novoProfToolStripMenuItem
            // 
            this.novoProfToolStripMenuItem.Name = "novoProfToolStripMenuItem";
            this.novoProfToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.novoProfToolStripMenuItem.Text = "Novo Professor";
            // 
            // arquivarToolStripMenuItem
            // 
            this.arquivarToolStripMenuItem.Name = "arquivarToolStripMenuItem";
            this.arquivarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.arquivarToolStripMenuItem.Text = "Arquivar";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsm_tools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tv_profs);
            this.splitContainer1.Size = new System.Drawing.Size(558, 333);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 1;
            // 
            // tsm_tools
            // 
            this.tsm_tools.BackColor = System.Drawing.Color.Teal;
            this.tsm_tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsm_tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsm_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_gerenciar,
            this.tsb_aquivar,
            this.tsb_remover,
            this.tsb_recup,
            this.tsb_atualizar});
            this.tsm_tools.Location = new System.Drawing.Point(2, 0);
            this.tsm_tools.Name = "tsm_tools";
            this.tsm_tools.Size = new System.Drawing.Size(24, 329);
            this.tsm_tools.TabIndex = 0;
            this.tsm_tools.Text = "Ferramentas";
            // 
            // tv_profs
            // 
            this.tv_profs.ContextMenuStrip = this.contextMenuStrip1;
            this.tv_profs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_profs.Location = new System.Drawing.Point(0, 0);
            this.tv_profs.Name = "tv_profs";
            this.tv_profs.Size = new System.Drawing.Size(520, 329);
            this.tv_profs.TabIndex = 0;
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(21, 20);
            this.tsb_add.Text = "Novo Professor";
            // 
            // tsb_gerenciar
            // 
            this.tsb_gerenciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_gerenciar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_gerenciar.Image")));
            this.tsb_gerenciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_gerenciar.Name = "tsb_gerenciar";
            this.tsb_gerenciar.Size = new System.Drawing.Size(21, 20);
            this.tsb_gerenciar.Text = "Gerenciar Professores";
            // 
            // tsb_aquivar
            // 
            this.tsb_aquivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_aquivar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_aquivar.Image")));
            this.tsb_aquivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_aquivar.Name = "tsb_aquivar";
            this.tsb_aquivar.Size = new System.Drawing.Size(21, 20);
            this.tsb_aquivar.Text = "Arquivar";
            // 
            // tsb_remover
            // 
            this.tsb_remover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_remover.Image = ((System.Drawing.Image)(resources.GetObject("tsb_remover.Image")));
            this.tsb_remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_remover.Name = "tsb_remover";
            this.tsb_remover.Size = new System.Drawing.Size(21, 20);
            this.tsb_remover.Text = "Remover";
            // 
            // tsb_recup
            // 
            this.tsb_recup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_recup.Image = ((System.Drawing.Image)(resources.GetObject("tsb_recup.Image")));
            this.tsb_recup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_recup.Name = "tsb_recup";
            this.tsb_recup.Size = new System.Drawing.Size(21, 20);
            this.tsb_recup.Text = "Recuperação";
            // 
            // tsb_atualizar
            // 
            this.tsb_atualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_atualizar.Image")));
            this.tsb_atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_atualizar.Name = "tsb_atualizar";
            this.tsb_atualizar.Size = new System.Drawing.Size(21, 20);
            this.tsb_atualizar.Text = "Atualizar";
            // 
            // gerenciarProfessoresToolStripMenuItem
            // 
            this.gerenciarProfessoresToolStripMenuItem.Name = "gerenciarProfessoresToolStripMenuItem";
            this.gerenciarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gerenciarProfessoresToolStripMenuItem.Text = "Gerenciar Professores";
            // 
            // F_Profs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 333);
            this.Controls.Add(this.splitContainer1);
            this.Name = "F_Profs";
            this.Text = "Gerenciar Professores";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsm_tools.ResumeLayout(false);
            this.tsm_tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoProfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tsm_tools;
        private System.Windows.Forms.TreeView tv_profs;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_gerenciar;
        private System.Windows.Forms.ToolStripButton tsb_aquivar;
        private System.Windows.Forms.ToolStripButton tsb_remover;
        private System.Windows.Forms.ToolStripButton tsb_recup;
        private System.Windows.Forms.ToolStripButton tsb_atualizar;
    }
}