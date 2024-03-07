using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Vital.entidades;
using Vital.util;
using System.Windows.Forms;
using INFIT.docs;

namespace Vital.repositorio
{
    class OrdemServicoDAO : DAO
    {

        public int cadastrar(OrdemServico ordemServico)
        {

            int idOrdemServico = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                String strCmd = " INSERT INTO ordem_servico(aparelho, marca, modelo, sintoma, observacoes, " +
                                   " info_adicional, data_entrada, data_saida, valor, id_cliente, orcamento) " +
                                " VALUES (@aparelho, @marca, @modelo, @sintoma, @observacoes, " +
                                " @info_adicional, @data_entrada, @data_saida, @valor, @id_cliente, @orcamento);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@aparelho", ordemServico.Aparelho);
                cmd.Parameters.AddWithValue("@marca", ordemServico.Marca);
                cmd.Parameters.AddWithValue("@modelo", ordemServico.Modelo);
                cmd.Parameters.AddWithValue("@sintoma", ordemServico.Sintoma);
                cmd.Parameters.AddWithValue("@observacoes", ordemServico.Obs);
                cmd.Parameters.AddWithValue("@info_adicional", "");
                cmd.Parameters.AddWithValue("@data_entrada", ordemServico.DataEntrada);
                cmd.Parameters.AddWithValue("@data_saida", ordemServico.DataSaida);
                cmd.Parameters.AddWithValue("@valor", ordemServico.Valor);
                cmd.Parameters.AddWithValue("@id_cliente", ordemServico.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@orcamento", ordemServico.Orcamento);

                OpenConnection();
                idOrdemServico = Insere(cmd, strCmd);
                CloseConnection();
                return idOrdemServico;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar a Ordem de Serviço. Favor contactar o suporte!!!");
            }
        }

        public OrdemServico consultarOrdemServicoPorCodigo(int idOrdem)
        {
            try
            {
                string strCmd = " SELECT * FROM ORDEM_SERVICO" +
                                " WHERE id_ordem_servico=@id_ordem_servico;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ordem_servico", idOrdem);
                OpenConnection();
                MySqlDataReader dataReader = Pesquisa(cmd, strCmd);
                List<OrdemServico> lista = new List<OrdemServico>();
                lista = PopulaOrdemServico(dataReader);
                if (lista != null && lista.Count > 0)
                {
                    return lista.First<OrdemServico>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível localizar o produto pela ID informada." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }



        public List<OrdemServico> consultarOrdemServico(string valorPesquisa, bool cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                string strCmd = " SELECT c.*, os.* FROM cliente c, ordem_servico os ";
                if (cliente)
                {
                    strCmd += " WHERE c.nome like '%" + valorPesquisa + "%' ";
                }
                else
                {
                    strCmd += " WHERE os.id_ordem_servico = @id_ordem_servico";
                    cmd.Parameters.AddWithValue("@id_ordem_servico", valorPesquisa);
                }
                strCmd += " and c.id_cliente = os.id_cliente order by nome";

                OpenConnection();
                MySqlDataReader dataReader = Pesquisa(cmd, strCmd);
                List<OrdemServico> listaOrdemServico = new List<OrdemServico>();
                listaOrdemServico = PopulaOrdemServicoCliente(dataReader);
                if (listaOrdemServico != null && listaOrdemServico.Count > 0)
                {
                    return listaOrdemServico;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível localizar as ordem de serviço pelo nome fornecido." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private List<OrdemServico> PopulaOrdemServicoCliente(MySqlDataReader dataReader)
        {
            List<OrdemServico> ordemServicos = new List<OrdemServico>();

            while (dataReader.Read())
            {
                try
                {
                    OrdemServico os = new OrdemServico();
                    os.Aparelho = dataReader["aparelho"].ToString();
                    os.IdOrdemServico = Convert.ToInt32(dataReader["id_ordem_servico"]);
                    os.Marca = dataReader["marca"].ToString();
                    os.Sintoma = dataReader["sintoma"].ToString();
                    os.Obs = dataReader["observacoes"].ToString();
                    os.Modelo = dataReader["modelo"].ToString();
                    os.DataEntrada = Convert.ToDateTime(dataReader["data_entrada"]);
                    os.DataSaida = Convert.ToDateTime(dataReader["data_saida"]);
                    os.Valor = Convert.ToDouble(dataReader["valor"]);
                    os.Orcamento = dataReader["orcamento"].ToString();

                    Cliente cliente = new Cliente();
                    cliente.Nome = dataReader["nome"].ToString();
                    cliente.Telefone = dataReader["telefone"].ToString();
                    os.Cliente = cliente;

                    ordemServicos.Add(os);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return ordemServicos;
        }

        private List<OrdemServico> PopulaOrdemServico(MySqlDataReader dataReader)
        {
            List<OrdemServico> ordemServicos = new List<OrdemServico>();

            while (dataReader.Read())
            {
                try
                {
                    OrdemServico os = new OrdemServico();
                    os.Aparelho = dataReader["aparelho"].ToString();
                    os.IdOrdemServico = Convert.ToInt32(dataReader["id_ordem_servico"]);
                    os.Marca = dataReader["marca"].ToString();
                    os.Sintoma = dataReader["sintoma"].ToString();
                    os.Obs = dataReader["observacoes"].ToString();
                    os.Modelo = dataReader["modelo"].ToString();
                    os.DataEntrada = Convert.ToDateTime(dataReader["data_entrada"]);
                    os.DataSaida = Convert.ToDateTime(dataReader["data_saida"]);
                    os.Valor = Convert.ToDouble(dataReader["valor"]);
                    os.Orcamento = dataReader["orcamento"].ToString();

                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(dataReader["id_cliente"]);
                    os.Cliente = cliente;

                    ordemServicos.Add(os);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return ordemServicos;
        }

        
        public decimal consultarApurado(DateTime inicio, DateTime fim)
        {

            decimal valor = 0M;
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                String strCmd = " SELECT SUM(VALOR) AS apurado FROM ORDEM_SERVICO " + 
                                " WHERE DATA_SAIDA BETWEEN @dataInicio AND @dataFim;";

                cmd.Parameters.Clear();

                string dataInicio = ManipulaData.FormatarData(inicio, ManipulaData.HORA_INICIAL);
                string dataFim = ManipulaData.FormatarData(fim, ManipulaData.HORA_FINAL);

                cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                cmd.Parameters.AddWithValue("@dataFim", dataFim);
                OpenConnection();
                MySqlDataReader dataReader = Pesquisa(cmd, strCmd);

                if (dataReader.Read() && !dataReader["apurado"].ToString().Equals(""))
                {
                    string consulta = dataReader["apurado"].ToString().Replace(".", ",");
                    valor = Convert.ToDecimal(consulta);
                }
                
                CloseConnection();
                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar o valor apurado. Favor contactar o suporte!!!" + ex.Message);
            }
        }

        public void remover(int idOs)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ordem_servico", idOs);
                string strCmd = " DELETE FROM ordem_servico " +
                                " WHERE id_ordem_servico=@id_ordem_servico; ";
                OpenConnection();
                ExecutaComando(cmd, strCmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível remover a ordem de Serviço." + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void atualizar(OrdemServico ordem)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                String strCmd = "UPDATE ordem_servico set aparelho=@aparelho, marca=@marca, modelo=@modelo, sintoma=@sintoma, observacoes=@observacoes, " +
                                " info_adicional=@info_adicional, data_entrada=@data_entrada, data_saida=@data_saida, valor=@valor, id_cliente=@id_cliente, " +
                                " orcamento=@orcamento WHERE id_ordem_servico =@id_ordem_servico;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@aparelho", ordem.Aparelho);
                cmd.Parameters.AddWithValue("@marca", ordem.Marca);
                cmd.Parameters.AddWithValue("@modelo", ordem.Modelo);
                cmd.Parameters.AddWithValue("@sintoma", ordem.Sintoma);
                cmd.Parameters.AddWithValue("@observacoes", ordem.Obs);
                cmd.Parameters.AddWithValue("@info_adicional", "");
                cmd.Parameters.AddWithValue("@data_entrada", ordem.DataEntrada);
                cmd.Parameters.AddWithValue("@data_saida", ordem.DataSaida);
                cmd.Parameters.AddWithValue("@valor", ordem.Valor);
                cmd.Parameters.AddWithValue("@id_cliente", ordem.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@id_ordem_servico", ordem.IdOrdemServico);
                cmd.Parameters.AddWithValue("@orcamento", ordem.Orcamento);

                OpenConnection();
                ExecutaComando(cmd, strCmd);
                CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
