using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vital.entidades
{
    public class Entrada
    {
        int id_entrada;
        string prazo;
        string transporte;
        string local;
        string condicaoPagamento;
        int num_cp;
        string notaFiscal;
        string solicitante;
        string observacao;
        string destino;
        DateTime dataCadastro;

        public int IdEntrada
        {
            get { return id_entrada; }
            set { id_entrada = value; }
        }

        public string Prazo
        {
            get { return prazo; }
            set { prazo = value; }
        }

        public string Transporte
        {
            get { return transporte; }
            set { transporte = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public string CondicaoPagamento
        {
            get { return condicaoPagamento; }
            set { condicaoPagamento = value; }
        }

        public int Num_CP
        {
            get { return num_cp; }
            set { num_cp = value; }
        }

        public string NotaFiscal
        {
            get { return notaFiscal; }
            set { notaFiscal = value; }
        }

        public string Solicitante
        {
            get { return solicitante; }
            set { solicitante = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
    }
}
