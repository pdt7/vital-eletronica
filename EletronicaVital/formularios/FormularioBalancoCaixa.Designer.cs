﻿namespace Vital.formularios
{
    partial class FormularioBalancoCaixa
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
            this.textBoxApurado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.inputDataFim = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.botaoConsultar = new System.Windows.Forms.Button();
            this.inputDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidademedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.textBoxApurado);
            this.groupBoxProduto.Controls.Add(this.label2);
            this.groupBoxProduto.Controls.Add(this.botaoCadastrar);
            this.groupBoxProduto.Controls.Add(this.inputDataFim);
            this.groupBoxProduto.Controls.Add(this.label8);
            this.groupBoxProduto.Controls.Add(this.botaoConsultar);
            this.groupBoxProduto.Controls.Add(this.inputDataInicio);
            this.groupBoxProduto.Controls.Add(this.label1);
            this.groupBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxProduto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(558, 134);
            this.groupBoxProduto.TabIndex = 0;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Consulta";
            // 
            // textBoxApurado
            // 
            this.textBoxApurado.Enabled = false;
            this.textBoxApurado.Location = new System.Drawing.Point(132, 92);
            this.textBoxApurado.Name = "textBoxApurado";
            this.textBoxApurado.Size = new System.Drawing.Size(123, 26);
            this.textBoxApurado.TabIndex = 25;
            this.textBoxApurado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Valor Apurado";
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoCadastrar.Location = new System.Drawing.Point(456, 92);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(96, 26);
            this.botaoCadastrar.TabIndex = 8;
            this.botaoCadastrar.Text = "Fechar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // inputDataFim
            // 
            this.inputDataFim.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDataFim.Location = new System.Drawing.Point(340, 31);
            this.inputDataFim.Name = "inputDataFim";
            this.inputDataFim.Size = new System.Drawing.Size(100, 26);
            this.inputDataFim.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data Final";
            // 
            // botaoConsultar
            // 
            this.botaoConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botaoConsultar.Location = new System.Drawing.Point(456, 31);
            this.botaoConsultar.Name = "botaoConsultar";
            this.botaoConsultar.Size = new System.Drawing.Size(96, 26);
            this.botaoConsultar.TabIndex = 9;
            this.botaoConsultar.Text = "Consultar";
            this.botaoConsultar.UseVisualStyleBackColor = true;
            this.botaoConsultar.Click += new System.EventHandler(this.botaoConsultar_Click_1);
            // 
            // inputDataInicio
            // 
            this.inputDataInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDataInicio.Location = new System.Drawing.Point(109, 31);
            this.inputDataInicio.Name = "inputDataInicio";
            this.inputDataInicio.Size = new System.Drawing.Size(100, 26);
            this.inputDataInicio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            // 
            // unidademedidaBindingSource
            // 
            this.unidademedidaBindingSource.DataMember = "unidade_medida";
            // 
            // FormularioBalancoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 158);
            this.Controls.Add(this.groupBoxProduto);
            this.Name = "FormularioBalancoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanço de Caixa";
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidademedidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoConsultar;
        private System.Windows.Forms.Button botaoCadastrar;
        
        private System.Windows.Forms.BindingSource categoriaBindingSource;

        private System.Windows.Forms.BindingSource unidademedidaBindingSource;
        private System.Windows.Forms.BindingSource obraBindingSource;
        private System.Windows.Forms.DateTimePicker inputDataInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inputDataFim;
        private System.Windows.Forms.TextBox textBoxApurado;
        private System.Windows.Forms.Label label2;
    }
}