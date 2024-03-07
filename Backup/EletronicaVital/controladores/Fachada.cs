using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vital.entidades;
using Vital.repositorio;

namespace Vital.controladores
{
    class Fachada
    {
        public Fachada()
        {
        }
        
        public Usuario RecuperaUsuario(string login, string senha)
        {
            ControladorUsuario controladorUsuario = new ControladorUsuario();
            entidades.Usuario usuario = controladorUsuario.verificaLogin(login, senha);
            return usuario;
        }

    }
}
