using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vital.repositorio;
using Vital.entidades;

namespace Vital.controladores
{
    class ControladorOrdemServico
    {

        private OrdemServicoDAO ordemServicoDAO;

        public ControladorOrdemServico()
        {
            ordemServicoDAO = new OrdemServicoDAO();
        }

        public int cadastrar(string aparelho, string marca, string modelo, string sintoma, string observacao,
            DateTime dataEntrada, DateTime dataSaida, double valor, int idCliente, string orcamento)
        {
                OrdemServico os = new OrdemServico();
                os.Aparelho = aparelho;
                os.Marca = marca;
                os.Modelo = modelo;
                os.Sintoma = sintoma;
                os.Obs = observacao;
                os.DataEntrada = dataEntrada;
                os.DataSaida = dataSaida;
                os.Valor = valor;
                os.Orcamento = orcamento;
                
                Cliente cliente = new Cliente();
                cliente.IdCliente = idCliente;
                os.Cliente = cliente;
                
                return ordemServicoDAO.cadastrar(os);
        }

        public bool existeProdutoPorNome(string nome, int idObra)
        {
            try
            {
                return false;// return produtoDAO.consultarProdutoPorNome(nome, idObra) != null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o produto: " + ex.Message);
            }
        }

        public string atualizar(Cliente produto)
        {
            try
            {
                //produtoDAO.atualizar(produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o produto: " + ex.Message);
            }

            return "Produto atualizado com sucesso!!!";
        }

        public decimal consultarApurado(DateTime inicio, DateTime fim)
        {
            try
            {
                return ordemServicoDAO.consultarApurado(inicio, fim);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o Apurado: " + ex.Message);
            }
        }

        public List<OrdemServico> consultarOrdemServico(string valorConsulta, bool cliente)
        {
            try
            {
                return ordemServicoDAO.consultarOrdemServico(valorConsulta, cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar a Ordem de Serviço: " + ex.Message);
            }
        }

        public OrdemServico consultarOrdemServicoPorCodigo(int idOrdem)
        {
            try
            {
                return ordemServicoDAO.consultarOrdemServicoPorCodigo(idOrdem);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar a Ordem de Serviço: " + ex.Message);
            }
        }

        public string remover(int idOrdem)
        {
            try
            {
                ordemServicoDAO.remover(idOrdem);
                return "Ordem de Serviço removida com sucesso!!!";
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Remover a Ordem de Serviço: " + ex.Message);
            }
        }

        public void atualizar(OrdemServico ordem)
        {
            try
            {
                ordemServicoDAO.atualizar(ordem);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar a Ordem de Serviço: " + ex.Message);
            }

        }

    }
}
