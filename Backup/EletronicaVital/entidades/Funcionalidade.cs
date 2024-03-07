using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vital.entidades
{
    public class Funcionalidade
    {
        int idUsuario;
        string funcionalidade;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string DescFuncionalidade
        {
            get { return funcionalidade; }
            set { funcionalidade = value; }
        }

    }
}
