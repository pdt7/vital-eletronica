using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vital.entidades;
using Vital.repositorio;

namespace Vital.controladores
{
    class ControladorUsuario
    {
        UsuarioDAO usuarioDAO;

        public ControladorUsuario()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public Usuario verificaLogin(string login, string senha)
        {
            Usuario usuario = new UsuarioDAO().consultaUsuarioLogin(login);
            if (usuario != null && usuario.Senha.Equals(senha))
            {
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public string cadastrarUsuario(string nome, string login, string senha)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Login = login;
                usuario.Senha = senha;
                usuario.Nome = nome;

                usuarioDAO.cadastrarUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar o usuario: " + ex.Message);
            }
            return "Usuário cadastrado com sucesso.";
        }

    }
}
