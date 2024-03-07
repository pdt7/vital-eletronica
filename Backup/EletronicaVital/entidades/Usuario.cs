using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vital.entidades
{
    public class Usuario : PessoaFisica
    {

        public static string ADMINISTRADOR = "X";
        
        protected string login;
        protected string senha;
        protected int idUsuario;
        protected DateTime dataValidade;
        protected TipoUsuario usuarioTipo;
        public List<Funcionalidade> funcionalidades;
        public string administrador;
        public bool permiteAlterarDados;

        public List<Funcionalidade> Funcionalidades
        {
            get { return funcionalidades; }
            set { funcionalidades = value; }
        }

        public DateTime DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public TipoUsuario UsuarioTipo
        {
            get { return usuarioTipo; }
            set { usuarioTipo = value; }
        }

        public string Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public bool isAdministrador()
        {
            if (ADMINISTRADOR.Equals(administrador))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PermiteAlterarDados
        {
            get { return permiteAlterarDados;  }
            set { permiteAlterarDados = value; }
        }

    }
}
