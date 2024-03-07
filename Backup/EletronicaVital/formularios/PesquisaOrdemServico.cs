using System;
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
using Vital.util;


namespace Vital.formularios
{
    public partial class PesquisaOrdemServico : Form
    {
        ControladorOrdemServico controladorOrdemServico;

        public PesquisaOrdemServico()
        {
            InitializeComponent();
            controladorOrdemServico = new ControladorOrdemServico();
            Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
        }

        private void PesquisaProduto_Load(object sender, EventArgs e)
        {
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {

            //A ordem dos numeros dos arrays depende da ordem das colunas na tabela
            try{
                dataGridCliente.Rows.Clear();

                string valor = textValor.Text;
                Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
                List<OrdemServico> listaOrdemServico = controladorOrdemServico.consultarOrdemServico(valor, true);
                foreach (OrdemServico os in listaOrdemServico)
                {
                    PopulateForm(os);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pesquisar_ClickOS(object sender, EventArgs e)
        {

            //A ordem dos numeros dos arrays depende da ordem das colunas na tabela
            try
            {
                dataGridCliente.Rows.Clear();

                string valor = textOs.Text;
                Usuario usuario = ((TelaInicial)Application.OpenForms[0]).usuarioLogado;
                List<OrdemServico> listaOrdemServico = controladorOrdemServico.consultarOrdemServico(valor, false);
                foreach (OrdemServico os in listaOrdemServico)
                {
                    PopulateForm(os);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void PopulateForm(OrdemServico os)
        {

            int n = dataGridCliente.Rows.Add();

            dataGridCliente.Rows[n].Cells[0].Value = os.IdOrdemServico;
            dataGridCliente.Rows[n].Cells[1].Value = os.Cliente.Nome;
            dataGridCliente.Rows[n].Cells[2].Value = os.Aparelho;
            dataGridCliente.Rows[n].Cells[3].Value = os.Marca;
            dataGridCliente.Rows[n].Cells[4].Value = os.Modelo;
            dataGridCliente.Rows[n].Cells[5].Value = os.DataEntrada;
            dataGridCliente.Rows[n].Cells[6].Value = os.DataSaida;
            dataGridCliente.Rows[n].Cells[7].Value = ManipulaCampos.formataValorMoeda(os.Valor.ToString());
            dataGridCliente.Rows[n].Cells[9].Value = os.Cliente.Telefone;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            int n = dataGridCliente.SelectedRows.Count;
            if (n == 1)
            {
                int indice = dataGridCliente.CurrentRow.Index;
                int idOrdem = Convert.ToInt32(dataGridCliente.Rows[indice].Cells[0].Value);
                FormularioCadastroOrdemServico formulario = new FormularioCadastroOrdemServico();
                OrdemServico ordem = controladorOrdemServico.consultarOrdemServicoPorCodigo(idOrdem);
                formulario.ordemServico = ordem;
                formulario.ShowDialog();
            }
            else if (n == 0)
            {
                MessageBox.Show("É necessário selecionar um item.");
            }
            else
            {
                MessageBox.Show("Favor selecionar somente um item.");
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
                int idOs = Convert.ToInt32(dataGridCliente.Rows[0].Cells[0].Value);
                MessageBox.Show(controladorOrdemServico.remover(idOs));
            }
            else if (n == 0)
            {
                MessageBox.Show("É necessário selecionar um item.");
            }
            else
            {
                MessageBox.Show("Favor selecionar somente um item.");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pesquisar_ClickOS(sender, e);
        }


      }
}
