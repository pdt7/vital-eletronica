﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vital.entidades
{
    public class OrdemServico
    {
        private int idOrdemServico;
        private string aparelho;
        private string marca;
        private string modelo;
        private string sintoma;
        private string obs;
        private DateTime dataEntrada;
        private DateTime dataSaida;
        private Cliente cliente;
        private double valor;
        private string orcamento;

        public int IdOrdemServico
        {
            get { return idOrdemServico; }
            set { idOrdemServico = value; }
        }

        public string Aparelho
        {
            get { return aparelho; }
            set { aparelho = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Sintoma
        {
            get { return sintoma; }
            set { sintoma = value; }
        }

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        public string Orcamento
        {
            get { return orcamento; }
            set { orcamento = value; }
        }

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        public DateTime DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
