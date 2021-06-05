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
    public partial class delPessoa : Form
    {
        public delPessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nova instância da classe que acessa a base de dados.
            UtilBD bd = new UtilBD();

            if (bd.DeletaPessoa(Convert.ToInt32(textBox1.Text)) == 1)
            {
                MessageBox.Show("Pessoa excluída com sucesso.");

            } 
        }
    }
}
