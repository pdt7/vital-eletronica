﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vital.controladores;
using Vital.entidades;

namespace Vital.formularios
{
    public partial class FormularioIdentificacao : Form
    {
        private controladores.Fachada fachada;

        public List<Funcionalidade> listaFuncionalidades = new List<Funcionalidade>();

        public FormularioIdentificacao()
        {
            InitializeComponent();
            fachada = new controladores.Fachada();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            string login = textUsuario.Text;
            string senha = textSenha.Text;
            entidades.Usuario user = fachada.RecuperaUsuario(login, senha);
            if (user != null)
            {
                TelaInicial telaInicial = (TelaInicial)Application.OpenForms[0];
                //ControladorFuncionalidade controlador = new ControladorFuncionalidade();
                this.DialogResult = DialogResult.OK;
                telaInicial.usuarioLogado = user;
            }
            else
            {
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
                MessageBox.Show("Usuário ou Senha incorretos!");
            }            

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            botaoCancelar.DialogResult = DialogResult.Cancel;
            botaoCancelar.DialogResult = DialogResult.Cancel;
        }

        private void inputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                botaoEntrar_Click(sender, e);
        }

    }
}
