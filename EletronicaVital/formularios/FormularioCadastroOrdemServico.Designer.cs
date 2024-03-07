﻿namespace Vital.formularios
{
    partial class FormularioCadastroOrdemServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.inputDataSaida = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vitalDataSet1 = new Vital.vitalDataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxObs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textSintoma = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAparelho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidademedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.vitalDataSet = new Vital.vitalDataSet();
            this.vitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Vital.vitalDataSet1TableAdapters.clienteTableAdapter();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.orcamentoTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.orcamentoTextBox);
            this.groupBoxProduto.Controls.Add(this.label10);
            this.groupBoxProduto.Controls.Add(this.textValor);
            this.groupBoxProduto.Controls.Add(this.inputDataSaida);
            this.groupBoxProduto.Controls.Add(this.comboBoxCliente);
            this.groupBoxProduto.Controls.Add(this.label9);
            this.groupBoxProduto.Controls.Add(this.label4);
            this.groupBoxProduto.Controls.Add(this.inputDataEntrada);
            this.groupBoxProduto.Controls.Add(this.label8);
            this.groupBoxProduto.Controls.Add(this.label7);
            this.groupBoxProduto.Controls.Add(this.richTextBoxObs);
            this.groupBoxProduto.Controls.Add(this.label6);
            this.groupBoxProduto.Controls.Add(this.textModelo);
            this.groupBoxProduto.Controls.Add(this.textSintoma);
            this.groupBoxProduto.Controls.Add(this.textMarca);
            this.groupBoxProduto.Controls.Add(this.label2);
            this.groupBoxProduto.Controls.Add(this.textAparelho);
            this.groupBoxProduto.Controls.Add(this.label5);
            this.groupBoxProduto.Controls.Add(this.label3);
            this.groupBoxProduto.Controls.Add(this.label1);
            this.groupBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxProduto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(734, 348);
            this.groupBoxProduto.TabIndex = 0;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Ordem de Serviço";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(614, 303);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 26);
            this.textValor.TabIndex = 32;
            // 
            // inputDataSaida
            // 
            this.inputDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDataSaida.Location = new System.Drawing.Point(614, 216);
            this.inputDataSaida.Name = "inputDataSaida";
            this.inputDataSaida.Size = new System.Drawing.Size(100, 26);
            this.inputDataSaida.TabIndex = 31;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCliente.DataSource = this.clienteBindingSource;
            this.comboBoxCliente.DisplayMember = "nome";
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(94, 130);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(620, 28);
            this.comboBoxCliente.TabIndex = 5;
            this.comboBoxCliente.ValueMember = "id_cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.vitalDataSet1;
            // 
            // vitalDataSet1
            // 
            this.vitalDataSet1.DataSetName = "vitalDataSet1";
            this.vitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor (R$)";
            // 
            // inputDataEntrada
            // 
            this.inputDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDataEntrada.Location = new System.Drawing.Point(614, 180);
            this.inputDataEntrada.Name = "inputDataEntrada";
            this.inputDataEntrada.Size = new System.Drawing.Size(100, 26);
            this.inputDataEntrada.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data Saída";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data Entrada";
            // 
            // richTextBoxObs
            // 
            this.richTextBoxObs.Location = new System.Drawing.Point(15, 183);
            this.richTextBoxObs.Name = "richTextBoxObs";
            this.richTextBoxObs.Size = new System.Drawing.Size(482, 59);
            this.richTextBoxObs.TabIndex = 6;
            this.richTextBoxObs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Modelo";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(94, 64);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(620, 26);
            this.textModelo.TabIndex = 3;
            // 
            // textSintoma
            // 
            this.textSintoma.Location = new System.Drawing.Point(94, 96);
            this.textSintoma.Name = "textSintoma";
            this.textSintoma.Size = new System.Drawing.Size(620, 26);
            this.textSintoma.TabIndex = 4;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(460, 32);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(254, 26);
            this.textMarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marca";
            // 
            // textAparelho
            // 
            this.textAparelho.Location = new System.Drawing.Point(94, 32);
            this.textAparelho.Name = "textAparelho";
            this.textAparelho.Size = new System.Drawing.Size(290, 26);
            this.textAparelho.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sintoma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aparelho";
            // 
            // unidademedidaBindingSource
            // 
            this.unidademedidaBindingSource.DataMember = "unidade_medida";
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoLimpar.Location = new System.Drawing.Point(16, 367);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 26);
            this.botaoLimpar.TabIndex = 10;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoCancelar.Location = new System.Drawing.Point(640, 367);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(96, 26);
            this.botaoCancelar.TabIndex = 12;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoCadastrar.Location = new System.Drawing.Point(538, 367);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(96, 26);
            this.botaoCadastrar.TabIndex = 11;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // vitalDataSet
            // 
            this.vitalDataSet.DataSetName = "vitalDataSet";
            this.vitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vitalDataSetBindingSource
            // 
            this.vitalDataSetBindingSource.DataSource = this.vitalDataSet;
            this.vitalDataSetBindingSource.Position = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoAtualizar.Location = new System.Drawing.Point(538, 367);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(96, 26);
            this.botaoAtualizar.TabIndex = 13;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = true;
            this.botaoAtualizar.Visible = false;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // orcamentoTextBox
            // 
            this.orcamentoTextBox.Location = new System.Drawing.Point(15, 268);
            this.orcamentoTextBox.Name = "orcamentoTextBox";
            this.orcamentoTextBox.Size = new System.Drawing.Size(482, 61);
            this.orcamentoTextBox.TabIndex = 33;
            this.orcamentoTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Orçamento";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FormularioCadastroOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 406);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.groupBoxProduto);
            this.Name = "FormularioCadastroOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Ordem de Serviço";
            this.Load += new System.EventHandler(this.FormularioCadastroProduto_Load);
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.TextBox textAparelho;

        private System.Windows.Forms.BindingSource unidademedidaBindingSource;
        private System.Windows.Forms.BindingSource obraBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textSintoma;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.RichTextBox richTextBoxObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker inputDataEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.BindingSource vitalDataSetBindingSource;
        private vitalDataSet vitalDataSet;
        private vitalDataSet1 vitalDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Vital.vitalDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DateTimePicker inputDataSaida;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox orcamentoTextBox;
    }
}