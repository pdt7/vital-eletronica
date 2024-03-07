using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Vital.entidades;

namespace Vital.repositorio
{
    class FuncionalidadeDAO : DAO
    {
        public int cadastrar(Funcionalidade funcionalidade)
        {
            int idLancamento = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                string strCmd = " INSERT INTO usuarioFuncionalidade (id_usuario, funcionalidade) VALUES " + 
                                " (@idUsuario, @funcionalidade);";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idUsuario", funcionalidade.IdUsuario);
                cmd.Parameters.AddWithValue("@funcionalidade", funcionalidade.DescFuncionalidade);


                OpenConnection();
                idLancamento = Insere(cmd, strCmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar a Obra " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return idLancamento;
        }

        public void remover(int idUsuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                string strCmd = " DELETE FROM usuarioFuncionalidade " +
                                " WHERE id_usuario = @id_usuario; ";
                OpenConnection();
                ExecutaComando(cmd, strCmd);
            }
            catch
            {
                throw new Exception("Não foi possível remover a Obra.");
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool verificarEdicaoDadosPorIdUsuario(int idUsuario)
        {
            try
            {
                string strCmd = " SELECT 1 FROM usuarioFuncionalidade" +
                                " WHERE id_usuario=@id_usuario AND funcionalidade = 'alterarExcluirDados'";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                OpenConnection();
                MySqlDataReader dataReader = Pesquisa(cmd, strCmd);
                if (dataReader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível localizar a funcionalidade." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public List<Funcionalidade> consultarFuncionalidadePorIdUsuario(int idUsuario)
        {
            try
            {
                string strCmd = " SELECT * FROM usuarioFuncionalidade" +
                                " WHERE id_usuario=@id_usuario";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                OpenConnection();
                MySqlDataReader dataReader = Pesquisa(cmd, strCmd);
                List<Funcionalidade> listaFuncionalidades = new List<Funcionalidade>();
                listaFuncionalidades = Popula(dataReader);
                return listaFuncionalidades;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível localizar a funcionalidade." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private List<Funcionalidade> Popula(MySqlDataReader dataReader)
        {
            List<Funcionalidade> funcionalidades = new List<Funcionalidade>();

            while (dataReader.Read())
            {
                try
                {

                    Funcionalidade funcionalidade = new Funcionalidade();
                    funcionalidade.IdUsuario = Convert.ToInt32(dataReader["id_usuario"]);
                    funcionalidade.DescFuncionalidade = dataReader["funcionalidade"].ToString();
                    funcionalidades.Add(funcionalidade);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return funcionalidades;
        }

    }
}
