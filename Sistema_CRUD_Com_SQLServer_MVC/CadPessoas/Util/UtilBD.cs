using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UsandoBD
{
    public class UtilBD
    {
        // String que define a conexão com nossa base de dados.
        string strConexao= @"Data Source=.\SQLEXPRESS;Initial Catalog=PessoasBD;Integrated Security=True;Pooling=False";

        // variavel usada para controle do retorno de ações executadas na base de dados.
        int linhasafetadas;

        //
        //CRUD - Create Retrive Update Delete
        //
        

        //
        // Método criado para realizar a inclusão de informações da Pessoa no banco de dados.
        //
        public int InserirPessoas(Pessoa p)
        {
            
            //Criando a conexão com o banco de dados.
            SqlConnection conexao = new SqlConnection(strConexao);

            //Abrindo a conexão
            conexao.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("INSERT INTO PESSOAS ");
            comando.Append("VALUES ('");
            comando.Append(p.Nome);
            comando.Append("','");
            comando.Append(p.Email);
            comando.Append("','");
            comando.Append(p.Endereco);
            comando.Append("')");

            //Montando o camando
            SqlCommand scComando = new SqlCommand(comando.ToString(),conexao);

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conexao.Close();

            return linhasafetadas; 
        }


        public int DeletaPessoa(int codigo)
        {
            //Criando a conexão com o banco de dados.
            SqlConnection conexao = new SqlConnection(strConexao);

            //Abrindo a conexão
            conexao.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("DELETE FROM PESSOAS ");
            //'?' curinga que representa um parametro que será recebido,
            comando.Append("WHERE CODIGO = @CODIGO");           

            //Montando o camando
            SqlCommand scComando = new SqlCommand(comando.ToString(), conexao);
            //Adicionando o parâmetro antes da execução
            scComando.Parameters.AddWithValue("@CODIGO",codigo);

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conexao.Close();

            return linhasafetadas; 
        }

        public int AtualizaPessoa(Pessoa p,int codigo)
        {
            //Criando a conexão com o banco de dados.
            SqlConnection conexao = new SqlConnection(strConexao);

            //Abrindo a conexão
            conexao.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("UPDATE PESSOAS SET nome=@NOME,email=@EMAIL,endereco=@ENDERECO ");
            //'?' curinga que representa um parametro que será recebido,
            comando.Append("WHERE CODIGO = @CODIGO");

            //Montando o camando
            SqlCommand scComando = new SqlCommand(comando.ToString(), conexao);
            //Adicionando o parâmetro antes da execução
            scComando.Parameters.AddWithValue("@CODIGO",codigo);
            scComando.Parameters.AddWithValue("@NOME", p.Nome);
            scComando.Parameters.AddWithValue("@EMAIL", p.Email);
            scComando.Parameters.AddWithValue("@ENDERECO", p.Endereco);

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conexao.Close();

            return linhasafetadas;
        }

        public Pessoa SelecionaPessoa(int codigo)
        {
            // Pessoa

            Pessoa p = new Pessoa();
            //Criando a conexão com o banco de dados.
            SqlConnection conexao = new SqlConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlDataReader sdr;

            //Abrindo a conexão
            conexao.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT CODIGO,NOME,EMAIL,ENDERECO FROM PESSOAS ");
            //'?' curinga que representa um parametro que será recebido,
            comando.Append("WHERE CODIGO = " + codigo);

           //Montando o camando
            SqlCommand scComando = new SqlCommand(comando.ToString(), conexao);
            //Adicionando o parâmetro antes da execução
            //scComando.Parameters.AddWithValue("@CODIGO", codigo);

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            sdr.Read();         
              
            p.Nome = sdr["nome"].ToString();
            p.Email = sdr["email"].ToString();
            p.Endereco = sdr["endereco"].ToString();
            

            conexao.Close();

            return p;
        }

    }
}
