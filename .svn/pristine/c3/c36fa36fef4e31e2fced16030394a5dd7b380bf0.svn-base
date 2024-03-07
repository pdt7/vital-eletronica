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
namespace Vital.relatorios
{
    public partial class DocumentoOrdemServico : Form
    {
        public DocumentoOrdemServico(OrdemServico ordem)
        {
            InitializeComponent();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[12];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("aparelho", ordem.Aparelho);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("marca", ordem.Marca);
            //string prazo = entrada.Prazo.Day + "/" + entrada.Prazo.Month + "/" + entrada.Prazo.Year;
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("numeroOrdem", ordem.IdOrdemServico + "");
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("modelo", ordem.Modelo);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("proprietario", ordem.Cliente.Nome);
            string endereco = ordem.Cliente.Endereco + ", " +ordem.Cliente.Numero;
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("endereco", endereco);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("cidade", ordem.Cliente.Cidade);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("bairro", ordem.Cliente.Bairro);
            //string dataCadastro = entrada.DataCadastro.Day + "/" + entrada.DataCadastro.Month + "/" + entrada.DataCadastro.Year;
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("sintoma", ordem.Sintoma);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("observacao", ordem.Obs);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("telefone", ordem.Cliente.Telefone);
            string dataRecebimento = ordem.DataEntrada.Day + "/" + ordem.DataEntrada.Month + "/" + ordem.DataEntrada.Year;
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("dataRecebimento", dataRecebimento);
            reportViewer1.LocalReport.SetParameters(p);
        }

        private void RelatorioDocumentoAF_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
