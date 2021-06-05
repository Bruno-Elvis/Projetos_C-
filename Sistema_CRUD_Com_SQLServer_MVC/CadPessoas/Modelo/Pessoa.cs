using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsandoBD
{
    // Classe que representa o modelo de nossa aplicação
    // modelagem do negócio.cadastro de pessoas.
    public class Pessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

    }
}
