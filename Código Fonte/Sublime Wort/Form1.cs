using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sublime_Wort
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter SW_streamWriter = new StreamWriter(arquivo);
                    SW_streamWriter.Flush();
                    SW_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    SW_streamWriter.Write(this.richTextBox1.Text);
                    SW_streamWriter.Flush();
                    SW_streamWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\Thaise\source\repos\Projetos\C#\Sublime Wort";
            openFileDialog1.Filter = "(*.SW)|*.SW";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader SW_streamReader = new StreamReader(arquivo);
                    SW_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = SW_streamReader.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = SW_streamReader.ReadLine();
                    }
                    SW_streamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }


        private void Negrito()
        {
			string nome_fonte = richTextBox1.Font.Name;
			float tamnho_fonte = richTextBox1.Font.Size;
			bool b= richTextBox1.SelectionFont.Bold;
			bool i = richTextBox1.SelectionFont.Italic;
			bool u = richTextBox1.SelectionFont.Underline;
			
			richTextBox1.Font = new Font(nome_fonte, tamnho_fonte, FontStyle.Regular);
			
			if(b == false)
			{
				if(i == true && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
				}else if(i == false && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Underline);
				}else if(i == true && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Italic);
				}else if(i == false && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold);
				}				
			}else
			{
				if(i == true && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic | FontStyle.Underline);
				}else if(i == false && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Underline);
				}else if(i == true && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic);
				}
			}
        }
		
		 private void Italico()
        {
			string nome_fonte = richTextBox1.Font.Name;
			float tamnho_fonte = richTextBox1.Font.Size;
			bool b= richTextBox1.SelectionFont.Bold;
			bool i = richTextBox1.SelectionFont.Italic;
			bool u = richTextBox1.SelectionFont.Underline;
			
			richTextBox1.Font = new Font(nome_fonte, tamnho_fonte, FontStyle.Regular);
			
			if(i == false)
			{
				if(b == true && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
				}else if(b == false && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic | FontStyle.Underline);
				}else if(b == true && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Italic);
				}else if(i == false && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic);
				}				
			}else
			{
				if(b == true && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Underline);
				}else if(b == false && u == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Underline);
				}else if(b == true && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold);
				}
			}
        }
		
		 private void Sublinhado()
        {
			string nome_fonte = richTextBox1.Font.Name;
			float tamnho_fonte = richTextBox1.Font.Size;
			bool b= richTextBox1.SelectionFont.Bold;
			bool i = richTextBox1.SelectionFont.Italic;
			bool u = richTextBox1.SelectionFont.Underline;
			
			richTextBox1.Font = new Font(nome_fonte, tamnho_fonte, FontStyle.Regular);
			
			if(u == false)
			{
				if(i == true && b == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
				}else if(i == false && b == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold | FontStyle.Underline);
				}else if(i == true && b == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Underline| FontStyle.Italic);
				}else if(i == false && u == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Underline);
				}				
			}else
			{
				if(i == true && b == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic | FontStyle.Bold);
				}else if(i == false && b == true)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Bold);
				}else if(i == true && b == false)
				{
					richTextBox1.SelectionFont = new Font(nome_fonte, tamnho_fonte, FontStyle.Italic);
				}
			}
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
			Copiar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Sublinhado();
        }

        private void AlignLeft()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlignRight()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlignCenter()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;            
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            AlignLeft();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            AlignRight();
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            AlignCenter();
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string txt = richTextBox1.Text;
            leitura = new StringReader(txt);

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPag = 0;
            float posY = 0;
            int cont = 0;
            float margemLeft = e.MarginBounds.Left - 50;
            float margemTop = e.MarginBounds.Top - 50;

            if(margemLeft < 5)
            {
                margemLeft = 25;
            }
            if (margemTop < 5)
            {
                margemTop = 25;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            // Calculando n° de linhas por pag. usando as margems como referência
            linhasPag = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhasPag)
            {
                posY = (margemTop + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemLeft, posY, new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }

            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbb_fontes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome_fonte = cbb_fontes.SelectedText;
            richTextBox1.Font = new Font(, cbb_tam_fontes.SelectedText, richTextBox1.Font.Style);
        }
    }
}
