using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UsandoBD
{
    public partial class selPessoa : Form
    {
        public selPessoa()
        {
            InitializeComponent();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nova instância da classe que acessa a base de dados.
            UtilBD bd = new UtilBD();
            // Classe que irá conter os dados da aplicação.
            Pessoa p;
            p = bd.SelecionaPessoa(Convert.ToInt32(textBox4.Text));

            if (p == null)
            {
                MessageBox.Show("Não foi encontrado registros na tabela.");
            }
            else
            {
                textBox1.Text = p.Nome;
                textBox2.Text = p.Email;
                textBox3.Text = p.Endereco;
            }
            

           
        }
    }
}
