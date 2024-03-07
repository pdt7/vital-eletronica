using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vital.entidades
{
    public class Cliente
    {
        private int idCliente;
        private string nome;
        private string endereco;
        private string cidade;
        private string bairro;
        private string telefone;
        private string complemento;
        private int numero;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
