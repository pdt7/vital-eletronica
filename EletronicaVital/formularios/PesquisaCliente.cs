﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vital.entidades;
using Vital.controladores;
using Vital.formularios;
using System.Web.UI.WebControls;


namespace Vital.formularios
{
    public partial class PesquisaCliente : Form
    {
        ControladorCliente controladorCliente;

        public PesquisaCliente()
        {
            InitializeComponent();
            controladorCliente = new ControladorCliente();
            Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
        }

        private void PesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vitalDataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.vitalDataSet1.cliente);
            // TODO: This line of code loads data into the 'svcDataSet.obra' table. You can move, or remove it, as needed.
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {

            //A ordem dos numeros dos arrays depende da ordem das colunas na tabela
            try{
                dataGridCliente.Rows.Clear();

                string valor = textValor.Text;
                Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
                List<Cliente> listaClientes = controladorCliente.consultarCliente(valor);
                foreach (Cliente cliente in listaClientes)
                {
                    PopulateForm(cliente);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void PopulateForm(Cliente cliente)
        {

            int n = dataGridCliente.Rows.Add();

            dataGridCliente.Rows[n].Cells[0].Value = cliente.Nome;
            dataGridCliente.Rows[n].Cells[1].Value = cliente.Telefone;
            dataGridCliente.Rows[n].Cells[2].Value = cliente.Endereco;
            dataGridCliente.Rows[n].Cells[3].Value = cliente.Numero;
            dataGridCliente.Rows[n].Cells[4].Value = cliente.Bairro;
            dataGridCliente.Rows[n].Cells[5].Value = cliente.Cidade;
            dataGridCliente.Rows[n].Cells[6].Value = cliente.IdCliente;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            int n = dataGridCliente.SelectedRows.Count;
            if (n == 1)
            {
                int indice = dataGridCliente.CurrentRow.Index;
                int idCliente = Convert.ToInt32(dataGridCliente.Rows[indice].Cells[6].Value);
                FormularioCadastroCliente cadastroCliente = new FormularioCadastroCliente();
                Cliente cliente = controladorCliente.consultarClientePorId(idCliente);
                cadastroCliente.cliente = cliente;
                cadastroCliente.ShowDialog();
            }
            else if (n == 0)
            {
                MessageBox.Show("É necessário selecionar um Cliente.");
            }
            else
            {
                MessageBox.Show("Favor selecionar somente um Cliente.");
            }
            dataGridCliente.Rows.Clear();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            int n = dataGridCliente.SelectedRows.Count;
            if (n == 1)
            {
                int idCliente = Convert.ToInt32(dataGridCliente.Rows[0].Cells[6].Value);
                MessageBox.Show(controladorCliente.remover(idCliente));
            }
            else if (n == 0)
            {
                MessageBox.Show("É necessário selecionar um cliente.");
            }
            else
            {
                MessageBox.Show("Favor selecionar somente um cliente.");
            }
            dataGridCliente.Rows.Clear();

        }

        private void comboBoxObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy(this.vitalDataSet1.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {
            pesquisar_Click(sender, e);
        }


      }
}
