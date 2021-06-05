using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDAMENTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listaPaciente.ColumnCount = 15;
            listaPaciente.Columns[0].Name = "Nome";
            listaPaciente.Columns[1].Name = "CPF";
            listaPaciente.Columns[2].Name = "Identidade";
            listaPaciente.Columns[3].Name = "Data Nascimento";
            listaPaciente.Columns[4].Name = "Rua";
            listaPaciente.Columns[5].Name = "Bairro";
            listaPaciente.Columns[6].Name = "Cidade";
            listaPaciente.Columns[7].Name = "País";
            listaPaciente.Columns[8].Name = "Alergias";
            listaPaciente.Columns[9].Name = "Tipo Saguíneos";
            listaPaciente.Columns[10].Name = "Peso";
            listaPaciente.Columns[11].Name = "Altura";
            listaPaciente.Columns[12].Name = "IMC";
            listaPaciente.Columns[13].Name = "Data Cadastro";
            listaPaciente.Columns[14].Name = "Última consulta";
            listaPaciente.DefaultCellStyle.Font = new Font("Tahoma", 6);
            listaPaciente.DefaultCellStyle.ForeColor = Color.Blue;
            listaPaciente.DefaultCellStyle.BackColor = Color.Beige;
            listaPaciente.DefaultCellStyle.SelectionForeColor = Color.Black;
            listaPaciente.DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                listaPaciente.Rows.Clear();
                string linha = "";
                int contador = 0;

                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Texto|*.txt";

                if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamReader arquivo = new StreamReader(abrir.FileName);
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        string[] valores = linha.Split('|');
                        listaPaciente.Rows.Add(valores);
                        contador++;
                    }
                    
                    if (contador == 0)
                    {
                        MessageBox.Show("ARQUIVO DE TEXTO VAZIO!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO NO SISTEMA: " + erro.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
