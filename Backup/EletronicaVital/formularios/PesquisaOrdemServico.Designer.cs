﻿namespace Vital.formularios
{
    partial class PesquisaOrdemServico
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textOs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vitalDataSet1 = new Vital.vitalDataSet1();
            this.clienteTableAdapter = new Vital.vitalDataSet1TableAdapters.clienteTableAdapter();
            this.ordemservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vitalDataSet2 = new Vital.vitalDataSet2();
            this.ordem_servicoTableAdapter = new Vital.vitalDataSet2TableAdapters.ordem_servicoTableAdapter();
            this.Ord_Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saída = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord_Serv,
            this.Cliente,
            this.Aparelho,
            this.Marca,
            this.Modelo,
            this.Entrada,
            this.Saída,
            this.Valor,
            this.id_os,
            this.Telefone});
            this.dataGridCliente.Location = new System.Drawing.Point(6, 16);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.Size = new System.Drawing.Size(945, 235);
            this.dataGridCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textOs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.pesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // textOs
            // 
            this.textOs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textOs.Location = new System.Drawing.Point(866, 36);
            this.textOs.Name = "textOs";
            this.textOs.Size = new System.Drawing.Size(97, 26);
            this.textOs.TabIndex = 7;
            this.textOs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número Ordem Serviço";
            // 
            // textValor
            // 
            this.textValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textValor.Location = new System.Drawing.Point(116, 36);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(311, 26);
            this.textValor.TabIndex = 2;
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged);
            // 
            // pesquisar
            // 
            this.pesquisar.Enabled = false;
            this.pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisar.Location = new System.Drawing.Point(866, 72);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(97, 26);
            this.pesquisar.TabIndex = 5;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente";
            // 
            // obraBindingSource
            // 
            this.obraBindingSource.DataMember = "obra";
            // 
            // fechar
            // 
            this.fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(885, 399);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(96, 26);
            this.fechar.TabIndex = 3;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 271);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.remover_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(783, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editar_Click);
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ordemservicoBindingSource
            // 
            this.ordemservicoBindingSource.DataMember = "ordem_servico";
            this.ordemservicoBindingSource.DataSource = this.vitalDataSet2;
            // 
            // vitalDataSet2
            // 
            this.vitalDataSet2.DataSetName = "vitalDataSet2";
            this.vitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordem_servicoTableAdapter
            // 
            this.ordem_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // Ord_Serv
            // 
            this.Ord_Serv.HeaderText = "Ord Serv";
            this.Ord_Serv.Name = "Ord_Serv";
            this.Ord_Serv.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Aparelho
            // 
            this.Aparelho.HeaderText = "Aparelho";
            this.Aparelho.Name = "Aparelho";
            this.Aparelho.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Saída
            // 
            this.Saída.HeaderText = "Saída";
            this.Saída.Name = "Saída";
            this.Saída.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // id_os
            // 
            this.id_os.HeaderText = "id_os";
            this.id_os.Name = "id_os";
            this.id_os.ReadOnly = true;
            this.id_os.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // PesquisaOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.groupBox1);
            this.Name = "PesquisaOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ordem de Serviço";
            this.Load += new System.EventHandler(this.PesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemservicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitalDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.BindingSource obraBindingSource;
        private vitalDataSet1 vitalDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Vital.vitalDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textOs;
        private System.Windows.Forms.Label label2;
        private vitalDataSet2 vitalDataSet2;
        private System.Windows.Forms.BindingSource ordemservicoBindingSource;
        private Vital.vitalDataSet2TableAdapters.ordem_servicoTableAdapter ordem_servicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord_Serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saída;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_os;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}