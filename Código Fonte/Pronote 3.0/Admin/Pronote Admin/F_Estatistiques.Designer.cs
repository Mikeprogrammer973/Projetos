
namespace Pronote_Admin
{
    partial class F_Estatistiques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.cbb_escola = new System.Windows.Forms.ComboBox();
            this.cbb_turma = new System.Windows.Forms.ComboBox();
            this.cbb_periode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_linhas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_linhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_barras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            this.dgv_alunos.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgv_alunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(216, 12);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.ShowEditingIcon = false;
            this.dgv_alunos.Size = new System.Drawing.Size(417, 176);
            this.dgv_alunos.TabIndex = 0;
            // 
            // cbb_escola
            // 
            this.cbb_escola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_escola.FormattingEnabled = true;
            this.cbb_escola.Location = new System.Drawing.Point(12, 38);
            this.cbb_escola.Name = "cbb_escola";
            this.cbb_escola.Size = new System.Drawing.Size(198, 21);
            this.cbb_escola.TabIndex = 1;
            // 
            // cbb_turma
            // 
            this.cbb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_turma.FormattingEnabled = true;
            this.cbb_turma.Location = new System.Drawing.Point(12, 89);
            this.cbb_turma.Name = "cbb_turma";
            this.cbb_turma.Size = new System.Drawing.Size(198, 21);
            this.cbb_turma.TabIndex = 2;
            // 
            // cbb_periode
            // 
            this.cbb_periode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_periode.FormattingEnabled = true;
            this.cbb_periode.Location = new System.Drawing.Point(13, 141);
            this.cbb_periode.Name = "cbb_periode";
            this.cbb_periode.Size = new System.Drawing.Size(197, 21);
            this.cbb_periode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escola:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Período:";
            // 
            // chart_linhas
            // 
            this.chart_linhas.BackColor = System.Drawing.Color.SeaGreen;
            this.chart_linhas.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea3.Name = "ChartArea1";
            this.chart_linhas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_linhas.Legends.Add(legend3);
            this.chart_linhas.Location = new System.Drawing.Point(12, 203);
            this.chart_linhas.Name = "chart_linhas";
            this.chart_linhas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_linhas.Series.Add(series3);
            this.chart_linhas.Size = new System.Drawing.Size(300, 192);
            this.chart_linhas.TabIndex = 7;
            this.chart_linhas.Text = "chart1";
            // 
            // chart_barras
            // 
            this.chart_barras.BackColor = System.Drawing.Color.SeaGreen;
            this.chart_barras.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea4.Name = "ChartArea1";
            this.chart_barras.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_barras.Legends.Add(legend4);
            this.chart_barras.Location = new System.Drawing.Point(318, 203);
            this.chart_barras.Name = "chart_barras";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_barras.Series.Add(series4);
            this.chart_barras.Size = new System.Drawing.Size(315, 192);
            this.chart_barras.TabIndex = 8;
            this.chart_barras.Text = "chart2";
            // 
            // F_Estatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 405);
            this.Controls.Add(this.chart_barras);
            this.Controls.Add(this.chart_linhas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_periode);
            this.Controls.Add(this.cbb_turma);
            this.Controls.Add(this.cbb_escola);
            this.Controls.Add(this.dgv_alunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Estatistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_linhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_barras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.ComboBox cbb_escola;
        private System.Windows.Forms.ComboBox cbb_turma;
        private System.Windows.Forms.ComboBox cbb_periode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_linhas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_barras;
    }
}