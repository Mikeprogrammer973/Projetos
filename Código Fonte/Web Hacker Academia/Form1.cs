using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Hacker_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_acesso.Text = "0";
            l_userLogado.Text = "...";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globals.logado = false;
            Globals.nivel = 0;
        }                

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logado)
            {
                if (Globals.nivel >= 3)
                {
                    //Procedimentos
                }
                else
                {
                    MessageBox.Show("Acesso negado! Somente para Nível de Acesso 3!", "Restrict Zone", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.Show();
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logado)
            {
                if (Globals.nivel >= 2)
                {
                    F_Cadastro _Cadastro = new F_Cadastro();
                    _Cadastro.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado! Somente para Nível de Acesso 2!", "Restrict Zone", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.Show();
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logado)
            {
                if (Globals.nivel >= 2)
                {
                    F_GestaoUsers gestaoUsers = new F_GestaoUsers();
                    gestaoUsers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado! Somente para Nível de Acesso 2!", "Restrict Zone", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.Show();
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logado)
            {
               
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.Show();
            }
        }
    }
}
