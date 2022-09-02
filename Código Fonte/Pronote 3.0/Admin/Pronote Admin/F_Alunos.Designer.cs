
namespace Pronote_Admin
{
    partial class F_Alunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Alunos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsm_tools = new System.Windows.Forms.ToolStrip();
            this.tv_alunos = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tranferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_gerenciar = new System.Windows.Forms.ToolStripButton();
            this.tsb_arquivar = new System.Windows.Forms.ToolStripButton();
            this.tsb_transferir = new System.Windows.Forms.ToolStripButton();
            this.tsb_remover = new System.Windows.Forms.ToolStripButton();
            this.tsb_recup = new System.Windows.Forms.ToolStripButton();
            this.tsb_atualizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsm_tools.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tv_alunos);
            this.splitContainer1.Size = new System.Drawing.Size(535, 352);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            // 
            // tsm_tools
            // 
            this.tsm_tools.BackColor = System.Drawing.Color.Teal;
            this.tsm_tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsm_tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsm_tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_gerenciar,
            this.tsb_arquivar,
            this.tsb_transferir,
            this.tsb_remover,
            this.tsb_recup,
            this.tsb_atualizar});
            this.tsm_tools.Location = new System.Drawing.Point(-7, 0);
            this.tsm_tools.Name = "tsm_tools";
            this.tsm_tools.Size = new System.Drawing.Size(32, 348);
            this.tsm_tools.TabIndex = 0;
            this.tsm_tools.Text = "Ferramentas";
            // 
            // tv_alunos
            // 
            this.tv_alunos.ContextMenuStrip = this.contextMenuStrip1;
            this.tv_alunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_alunos.Location = new System.Drawing.Point(0, 0);
            this.tv_alunos.Name = "tv_alunos";
            this.tv_alunos.Size = new System.Drawing.Size(498, 348);
            this.tv_alunos.TabIndex = 0;
            this.tv_alunos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_alunos_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranferirToolStripMenuItem,
            this.arquvarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // tranferirToolStripMenuItem
            // 
            this.tranferirToolStripMenuItem.Name = "tranferirToolStripMenuItem";
            this.tranferirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tranferirToolStripMenuItem.Text = "Transferir";
            // 
            // arquvarToolStripMenuItem
            // 
            this.arquvarToolStripMenuItem.Name = "arquvarToolStripMenuItem";
            this.arquvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arquvarToolStripMenuItem.Text = "Arquivar";
            this.arquvarToolStripMenuItem.Click += new System.EventHandler(this.arquvarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(29, 20);
            this.tsb_add.Text = "Novo Aluno";
            this.tsb_add.Click += new System.EventHandler(this.tsb_add_Click);
            // 
            // tsb_gerenciar
            // 
            this.tsb_gerenciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_gerenciar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_gerenciar.Image")));
            this.tsb_gerenciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_gerenciar.Name = "tsb_gerenciar";
            this.tsb_gerenciar.Size = new System.Drawing.Size(29, 20);
            this.tsb_gerenciar.Text = "Gerenciar Alunos";
            // 
            // tsb_arquivar
            // 
            this.tsb_arquivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_arquivar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_arquivar.Image")));
            this.tsb_arquivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_arquivar.Name = "tsb_arquivar";
            this.tsb_arquivar.Size = new System.Drawing.Size(29, 20);
            this.tsb_arquivar.Text = "Arquivar";
            this.tsb_arquivar.Click += new System.EventHandler(this.tsb_arquivar_Click);
            // 
            // tsb_transferir
            // 
            this.tsb_transferir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_transferir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_transferir.Image")));
            this.tsb_transferir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_transferir.Name = "tsb_transferir";
            this.tsb_transferir.Size = new System.Drawing.Size(29, 20);
            this.tsb_transferir.Text = "Transferir";
            this.tsb_transferir.Click += new System.EventHandler(this.tsb_transferir_Click);
            // 
            // tsb_remover
            // 
            this.tsb_remover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_remover.Image = ((System.Drawing.Image)(resources.GetObject("tsb_remover.Image")));
            this.tsb_remover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_remover.Name = "tsb_remover";
            this.tsb_remover.Size = new System.Drawing.Size(29, 20);
            this.tsb_remover.Text = "Remover";
            this.tsb_remover.Click += new System.EventHandler(this.tsb_remover_Click);
            // 
            // tsb_recup
            // 
            this.tsb_recup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_recup.Image = ((System.Drawing.Image)(resources.GetObject("tsb_recup.Image")));
            this.tsb_recup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_recup.Name = "tsb_recup";
            this.tsb_recup.Size = new System.Drawing.Size(29, 20);
            this.tsb_recup.Text = "Recuperação";
            // 
            // tsb_atualizar
            // 
            this.tsb_atualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_atualizar.Image")));
            this.tsb_atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_atualizar.Name = "tsb_atualizar";
            this.tsb_atualizar.Size = new System.Drawing.Size(29, 20);
            this.tsb_atualizar.Text = "Atualizar";
            this.tsb_atualizar.Click += new System.EventHandler(this.tsb_atualizar_Click);
            // 
            // F_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 352);
            this.Controls.Add(this.splitContainer1);
            this.Name = "F_Alunos";
            this.Text = "Gerenciar Alunos";
            this.Load += new System.EventHandler(this.F_Alunos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsm_tools.ResumeLayout(false);
            this.tsm_tools.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tsm_tools;
        private System.Windows.Forms.TreeView tv_alunos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tranferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_gerenciar;
        private System.Windows.Forms.ToolStripButton tsb_arquivar;
        private System.Windows.Forms.ToolStripButton tsb_transferir;
        private System.Windows.Forms.ToolStripButton tsb_remover;
        private System.Windows.Forms.ToolStripButton tsb_recup;
        private System.Windows.Forms.ToolStripButton tsb_atualizar;
    }
}