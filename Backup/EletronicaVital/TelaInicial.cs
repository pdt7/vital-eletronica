﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vital.formularios;
using Vital.relatorios;
using Vital.entidades;

namespace Vital
{
    public partial class TelaInicial : Form
    {
        public Usuario usuarioLogado;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCadastroCliente cadastro = new FormularioCadastroCliente();
            cadastro.ShowDialog();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial.ActiveForm.Close();
        }


        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisa = new PesquisaCliente();
            pesquisa.ShowDialog();

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            FormularioIdentificacao identificacao = new FormularioIdentificacao();
            identificacao.ShowDialog();
            if (identificacao.DialogResult.Equals(DialogResult.Cancel))
            {
                this.Close();
            }
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCadastroCliente form = new FormularioCadastroCliente();
            form.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCadastroOrdemServico form = new FormularioCadastroOrdemServico();
            form.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesq = new PesquisaCliente();
            pesq.ShowDialog();

        }

        private void balançoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioBalancoCaixa balanco = new FormularioBalancoCaixa();
            balanco.ShowDialog();
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaOrdemServico os = new PesquisaOrdemServico();
            os.ShowDialog();
        }
    }
}
