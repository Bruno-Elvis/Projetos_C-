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
    public partial class cadPessoa : Form
    {
        public cadPessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criando nova instância da classe de acesso ao banco de dados.
            UtilBD bd = new UtilBD();

            // Criando um novo objeto do tipo pessoa, que receberá os dados.
            Pessoa p = new Pessoa();

            //Preenchendo o objeto.
            p.Nome = textBox1.Text;
            p.Email = textBox2.Text;
            p.Endereco = textBox3.Text;


            if (bd.InserirPessoas(p) == 1)
            {
                MessageBox.Show("Pessoa cadastrada com sucesso.");
                LimpaCampos();
                
            } 
            

         }
         
        
         public void LimpaCampos()
         {
             textBox1.Text = "";
             textBox2.Text = "";             
             textBox3.Text = "";         
         }

         private void textBox3_TextChanged(object sender, EventArgs e)
         {

         }

         private void textBox2_TextChanged(object sender, EventArgs e)
         {

         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private void label2_Click(object sender, EventArgs e)
         {

         }

         private void label1_Click(object sender, EventArgs e)
         {

         }


    }
}
