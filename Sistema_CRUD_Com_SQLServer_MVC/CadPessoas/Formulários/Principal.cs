using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsandoBD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cadPessoa().Show();
            toolStripStatusLabel1.Text = "Cadastrando pessoa...";
        }

        private void deleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new delPessoa().Show();
            toolStripStatusLabel1.Text = "Deletando pessoa...";
        }

        private void atualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new updPessoa().Show();
            toolStripStatusLabel1.Text = "Atualizando pessoa...";
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new selPessoa().Show();
            toolStripStatusLabel1.Text = "Selecionando pessoa...";
        }
    }
}
