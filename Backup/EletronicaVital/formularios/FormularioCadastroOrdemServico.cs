using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vital.controladores;
using Vital.entidades;
using Vital.relatorios;
using Vital.util;

namespace Vital.formularios
{
    public partial class FormularioCadastroOrdemServico : Form
    {
        ControladorOrdemServico controladorOrdemServico;

        public int idProduto;
        public int idCategoria;
        public int idUnidadeMedida;
        public OrdemServico ordemServico = null;
        public Cliente cliente = null;

        public FormularioCadastroOrdemServico()
        {
            InitializeComponent();
            controladorOrdemServico = new ControladorOrdemServico();
        }

        private void FormularioCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vitalDataSet1.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.vitalDataSet1.cliente);
            if (ordemServico != null)
            {
                atualizarDados(ordemServico);
                botaoAtualizar.Visible = true;
                botaoCadastrar.Visible = false;

            }
            if (cliente != null) 
            {
                comboBoxCliente.SelectedValue = cliente.IdCliente;
            }
            AplicarEventos(textValor);
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            ManipulaCampos.LimparCampos(this.groupBoxProduto);
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string aparelho = textAparelho.Text;
                string sintoma = textSintoma.Text;
                string marca = textMarca.Text;
                string modelo = textModelo.Text;
                int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                DateTime dataEntrada = Convert.ToDateTime(inputDataEntrada.Text);
                DateTime dataSaida = Convert.ToDateTime(inputDataSaida.Text);
                string obs = richTextBoxObs.Text;
                double valor = 0;
                try
                {
                    valor = Convert.ToDouble(textValor.Text.Replace("R", "").Replace("$", ""));
                }
                catch (Exception ex)
                {
                    throw new Exception("Valor preenchido de forma incorreta. Preencha com máscara XXXX,XX.");
                }
                if (aparelho == "")
                {
                    throw new Exception("O campo aparelho precisa ser informado!");
                }
                try
                {
                    int idOrdem = controladorOrdemServico.cadastrar(aparelho, marca, modelo, sintoma, obs,
                        dataEntrada, dataSaida, valor, idCliente);
                    MessageBox.Show ("Ordem de Serviço cadastrada com sucesso!!!");
                    OrdemServico ordem = new OrdemServico();
                    ordem.IdOrdemServico = idOrdem;
                    ordem.Aparelho = aparelho;
                    ordem.Cliente = (new ControladorCliente()).consultarClientePorId(idCliente);
                    ordem.DataEntrada = dataEntrada;
                    ordem.DataSaida = dataSaida;
                    ordem.Marca = marca;
                    ordem.Modelo = modelo;
                    ordem.Obs = obs;
                    ordem.Sintoma = sintoma;
                    ordem.Valor = valor;

                    ManipulaCampos.LimparCampos(groupBoxProduto);
                    DocumentoOrdemServico documento = new DocumentoOrdemServico(ordem);
                    documento.ShowDialog();
                }
                catch (Exception ex)
                {
                   MessageBox.Show( "Não foi possível cadastrar a Ordem de Serviço!!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void atualizarDados(OrdemServico ordem)
        {
            comboBoxCliente.SelectedValue = ordem.Cliente.IdCliente;
            textAparelho.Text = ordem.Aparelho;
            textSintoma.Text = ordem.Sintoma;
            textMarca.Text = ordem.Marca;
            textModelo.Text = ordem.Modelo;
            inputDataEntrada.Value = ordem.DataEntrada;
            inputDataSaida.Value = ordem.DataSaida;
            richTextBoxObs.Text = ordem.Obs;
            textValor.Text = ManipulaCampos.formataValorMoeda(ordem.Valor + "");
        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string aparelho = textAparelho.Text;
                string sintoma = textSintoma.Text;
                string marca = textMarca.Text;
                string modelo = textModelo.Text;
                DateTime dataEntrada = Convert.ToDateTime(inputDataEntrada.Text);
                DateTime dataSaida = Convert.ToDateTime(inputDataSaida.Text);
                int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                string obs = richTextBoxObs.Text;
                double valor = 0;
                try
                {

                    valor = Convert.ToDouble(textValor.Text.Replace("R", "").Replace("$", ""));
                }
                catch (Exception ex)
                {
                    throw new Exception("Valor preenchido de forma incorreta. Preencha com máscara XXXX,XX.");
                }

                if (aparelho == "")
                {
                    throw new Exception("O campo aparelho precisa ser informado!");
                }
                try
                {
                    OrdemServico ordem = new OrdemServico();
                    ordem.IdOrdemServico = ordemServico.IdOrdemServico;
                    ordem.Aparelho = aparelho;
                    ordem.Cliente = (new ControladorCliente()).consultarClientePorId(idCliente);
                    ordem.DataEntrada = dataEntrada;
                    ordem.DataSaida = dataSaida;
                    ordem.Marca = marca;
                    ordem.Modelo = modelo;
                    ordem.Obs = obs;
                    ordem.Sintoma = sintoma;
                    ordem.Valor = valor;
                    controladorOrdemServico.atualizar(ordem);
                    MessageBox.Show ("Ordem de Serviço atualizada com sucesso!!!");

                    ManipulaCampos.LimparCampos(groupBoxProduto);
                    DocumentoOrdemServico documento = new DocumentoOrdemServico(ordem);
                    documento.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível atualizar a Ordem de Serviço!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }






    private void RetornarMascara(object sender, EventArgs e)
    {
        TextBox txt = (TextBox)sender;
        txt.Text = double.Parse(txt.Text).ToString("C2");
    }
    //Função para retirar a mascara

    private void TirarMascara(object sender, EventArgs e)
    {
        TextBox txt = (TextBox)sender;
        txt.Text = txt.Text.Replace("$", "").Replace("R", "").Trim();
    }
    //Função para somente permitir números e virgula

    private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
    {
        TextBox txt = (TextBox)sender;
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
        {
            if (e.KeyChar == ',')
            {
                e.Handled = (txt.Text.Contains(','));
            }
            else
                e.Handled = true;
        }
    }
        //Aplica todas as funções aos respectivos eventos

    private void AplicarEventos(TextBox txt)
    {
        txt.Enter += TirarMascara;
        txt.Leave += RetornarMascara;
        txt.KeyPress += ApenasValorNumerico;
    }
    }
}
