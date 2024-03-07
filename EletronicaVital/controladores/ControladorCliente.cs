using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vital.repositorio;
using Vital.entidades;

namespace Vital.controladores
{
    class ControladorCliente
    {

        private ClienteDAO clienteDAO;

        public ControladorCliente()
        {
            clienteDAO = new ClienteDAO();
        }

        public string cadastrar(string nome, string cidade, string endereco, string bairro, string telefone,
            string complemento, int numero)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Cidade = cidade;
                cliente.Endereco = endereco;
                cliente.Bairro = bairro;
                cliente.Telefone = telefone;
                cliente.Numero = numero;
                cliente.Complemento = complemento;
                clienteDAO.cadastrar(cliente);
            }
            catch (Exception ex)
            {
                return "Não foi possível cadastrar o cliente: " + ex.Message;
            }

            return "Cliente cadastrado com sucesso!!!";
        }

        public string atualizarQuantidade(int idProduto, float quantidade)
        {
            try
            {
                Cliente cliente = consultarClientePorId(idProduto);
                //produto.Quantidade = produto.Quantidade + quantidade;
                //produtoDAO.atualizarQuantidade(produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Cliente: " + ex.Message);
            }

            return "Cliente atualizado com sucesso!!!";
        }


        public bool existeProdutoPorNome(string nome, int idObra)
        {
            try
            {
                return false;// return produtoDAO.consultarProdutoPorNome(nome, idObra) != null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o Cliente: " + ex.Message);
            }
        }

        public string atualizar(Cliente cliente)
        {
            try
            {
                clienteDAO.atualizar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o cliente!!");
            }

            return "Cliente atualizado com sucesso!!!";
        }

        public Cliente consultarClientePorId(int idCliente)
        {
            try
            {
                return clienteDAO.consultarClientePorId(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o Cliente: " + ex.Message);
            }
        }

        public Cliente consultarUltimoCliente()
        {
            try
            {
                return clienteDAO.consultarUltimoCliente();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o último Cliente.");
            }
        }

        public List<Cliente> consultarCliente(string valorConsulta)
        {
            try
            {
                return clienteDAO.consultarCliente(valorConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o Cliente: " + ex.Message);
            }
        }

        public bool existeClienteCadastrado(string telefone)
        {
            try
            {
                return clienteDAO.existeClienteCadastrado(telefone);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Consultar o Cliente: " + ex.Message);
            }
        }

        public string remover(int idCliente)
        {
            try
            {
                clienteDAO.remover(idCliente);
                return "Cliente removido com sucesso!!!";
            }
            catch (Exception ex)
            {
                return "Não foi possível Remover o Cliente.";
            }
        }

        public string atualizar(string nome, string cidade, string endereco, string bairro, string telefone,
            string complemento, int numero)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Cidade = cidade;
                cliente.Endereco = endereco;
                cliente.Bairro = bairro;
                cliente.Telefone = telefone;
                cliente.Numero = numero;
                cliente.Complemento = complemento;
                clienteDAO.atualizar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o Cliente: " + ex.Message);
            }

            return "Cliente atualizado com sucesso!!!";
        }

    }
}
