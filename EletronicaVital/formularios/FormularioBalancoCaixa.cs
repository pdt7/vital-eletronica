using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vital.util;
using Vital.controladores;
using Vital.entidades;

namespace Vital.formularios
{
    public partial class FormularioBalancoCaixa : Form
    {
        ControladorOrdemServico ordemServico;

        public Cliente cliente = null;

        public FormularioBalancoCaixa()
        {
            InitializeComponent();
            ordemServico = new ControladorOrdemServico();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botaoConsultar_Click_1(object sender, EventArgs e)
        {
            DateTime dataInicio = Convert.ToDateTime(inputDataInicio.Value);
            DateTime dataFim = Convert.ToDateTime(inputDataFim.Value);
            decimal valorApurado = ordemServico.consultarApurado(dataInicio, dataFim);
            textBoxApurado.Text = ManipulaCampos.formataValorMoeda(valorApurado.ToString());
        }

    }
}
