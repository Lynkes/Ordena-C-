﻿namespace WinForms_OrdenaSegundaChava
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_qtdDados = new System.Windows.Forms.TextBox();
            this.button_gerar = new System.Windows.Forms.Button();
            this.button_abrirArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_aplicarAlgoritmo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_console = new System.Windows.Forms.TextBox();
            this.panel_algoritmo = new System.Windows.Forms.Panel();
            this.textBox_console2 = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_algoritmo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de dados";
            // 
            // textBox_qtdDados
            // 
            this.textBox_qtdDados.Location = new System.Drawing.Point(138, 29);
            this.textBox_qtdDados.Name = "textBox_qtdDados";
            this.textBox_qtdDados.Size = new System.Drawing.Size(100, 23);
            this.textBox_qtdDados.TabIndex = 1;
            this.textBox_qtdDados.TextChanged += new System.EventHandler(this.textBox_qtdDados_TextChanged);
            // 
            // button_gerar
            // 
            this.button_gerar.Location = new System.Drawing.Point(12, 62);
            this.button_gerar.Name = "button_gerar";
            this.button_gerar.Size = new System.Drawing.Size(101, 23);
            this.button_gerar.TabIndex = 2;
            this.button_gerar.Text = "Gerar";
            this.button_gerar.UseVisualStyleBackColor = true;
            this.button_gerar.Click += new System.EventHandler(this.button_gerar_Click);
            // 
            // button_abrirArquivo
            // 
            this.button_abrirArquivo.Location = new System.Drawing.Point(135, 62);
            this.button_abrirArquivo.Name = "button_abrirArquivo";
            this.button_abrirArquivo.Size = new System.Drawing.Size(103, 23);
            this.button_abrirArquivo.TabIndex = 3;
            this.button_abrirArquivo.Text = "Abrir Arquivo";
            this.button_abrirArquivo.UseVisualStyleBackColor = true;
            this.button_abrirArquivo.Click += new System.EventHandler(this.button_abrirArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dados Gerados ou Carregados";
            // 
            // textBox_dados
            // 
            this.textBox_dados.HideSelection = false;
            this.textBox_dados.Location = new System.Drawing.Point(12, 135);
            this.textBox_dados.Multiline = true;
            this.textBox_dados.Name = "textBox_dados";
            this.textBox_dados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_dados.Size = new System.Drawing.Size(166, 187);
            this.textBox_dados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algoritmo de ordenação";
            // 
            // button_aplicarAlgoritmo
            // 
            this.button_aplicarAlgoritmo.Location = new System.Drawing.Point(19, 59);
            this.button_aplicarAlgoritmo.Name = "button_aplicarAlgoritmo";
            this.button_aplicarAlgoritmo.Size = new System.Drawing.Size(94, 23);
            this.button_aplicarAlgoritmo.TabIndex = 8;
            this.button_aplicarAlgoritmo.Text = "Aplicar";
            this.button_aplicarAlgoritmo.UseVisualStyleBackColor = true;
            this.button_aplicarAlgoritmo.Click += new System.EventHandler(this.button_aplicarAlgoritmo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Console de resposta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_console
            // 
            this.textBox_console.Location = new System.Drawing.Point(19, 132);
            this.textBox_console.Multiline = true;
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.ReadOnly = true;
            this.textBox_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_console.Size = new System.Drawing.Size(294, 424);
            this.textBox_console.TabIndex = 10;
            this.textBox_console.TextChanged += new System.EventHandler(this.textBox_console_TextChanged);
            // 
            // panel_algoritmo
            // 
            this.panel_algoritmo.Controls.Add(this.label5);
            this.panel_algoritmo.Controls.Add(this.textBox_console2);
            this.panel_algoritmo.Controls.Add(this.textBoxTempo);
            this.panel_algoritmo.Controls.Add(this.checkedListBox1);
            this.panel_algoritmo.Controls.Add(this.button_limpar);
            this.panel_algoritmo.Controls.Add(this.textBox_console);
            this.panel_algoritmo.Controls.Add(this.label3);
            this.panel_algoritmo.Controls.Add(this.label4);
            this.panel_algoritmo.Controls.Add(this.button_aplicarAlgoritmo);
            this.panel_algoritmo.Enabled = false;
            this.panel_algoritmo.Location = new System.Drawing.Point(254, 3);
            this.panel_algoritmo.Name = "panel_algoritmo";
            this.panel_algoritmo.Size = new System.Drawing.Size(776, 559);
            this.panel_algoritmo.TabIndex = 11;
            // 
            // textBox_console2
            // 
            this.textBox_console2.Location = new System.Drawing.Point(319, 132);
            this.textBox_console2.Multiline = true;
            this.textBox_console2.Name = "textBox_console2";
            this.textBox_console2.ReadOnly = true;
            this.textBox_console2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_console2.Size = new System.Drawing.Size(292, 424);
            this.textBox_console2.TabIndex = 14;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(623, 132);
            this.textBoxTempo.Multiline = true;
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.ReadOnly = true;
            this.textBoxTempo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTempo.Size = new System.Drawing.Size(147, 206);
            this.textBoxTempo.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "bolha",
            "selecao",
            "insercao",
            "agitacao",
            "pente",
            "shake"});
            this.checkedListBox1.Location = new System.Drawing.Point(623, 344);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(147, 112);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(129, 59);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 11;
            this.button_limpar.Text = "Limpar Console";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Original";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 574);
            this.Controls.Add(this.panel_algoritmo);
            this.Controls.Add(this.textBox_dados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_abrirArquivo);
            this.Controls.Add(this.button_gerar);
            this.Controls.Add(this.textBox_qtdDados);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenação de 2ª chave";
            this.panel_algoritmo.ResumeLayout(false);
            this.panel_algoritmo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_qtdDados;
        private Button button_gerar;
        private Button button_abrirArquivo;
        private Label label2;
        private TextBox textBox_dados;
        private Label label3;
        private Button button_aplicarAlgoritmo;
        private Label label4;
        private TextBox textBox_console;
        private Panel panel_algoritmo;
        private OpenFileDialog openFileDialog1;
        private Button button_limpar;
        private CheckedListBox checkedListBox1;
        private EventHandler textBox_dados_TextChanged;
        private EventHandler checkedListBox1_SelectedIndexChanged;
        private TextBox textBoxTempo;
        private TextBox textBox_console2;
        private Label label5;
    }
}