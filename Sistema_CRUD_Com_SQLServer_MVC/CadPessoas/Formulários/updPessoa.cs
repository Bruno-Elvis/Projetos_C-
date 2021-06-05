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
    public partial class updPessoa : Form
    {
        public updPessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nova instância da classe que acessa a base de dados.
            UtilBD bd = new UtilBD();
            //Criando classe que contém os dados de pessoa
            Pessoa p = new Pessoa();

            //Preenchendo o objeto com as informações
            p.Nome = textBox1.Text;
            p.Email = textBox2.Text;
            p.Endereco = textBox3.Text;

            if (bd.AtualizaPessoa(p,Convert.ToInt32(textBox4.Text)) == 1)
            {
                MessageBox.Show("Pessoa Atualizada com sucesso.");                

            } 

        }
    }
}
