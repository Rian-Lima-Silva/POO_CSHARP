namespace Aula04_POO_AppInvestimento
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInvestimento = new System.Windows.Forms.TextBox();
            this.textBoxTaxa = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanto Deseja Investir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa Mensal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(8, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantos Meses:";
            // 
            // textBoxInvestimento
            // 
            this.textBoxInvestimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxInvestimento.Location = new System.Drawing.Point(12, 50);
            this.textBoxInvestimento.Name = "textBoxInvestimento";
            this.textBoxInvestimento.Size = new System.Drawing.Size(156, 23);
            this.textBoxInvestimento.TabIndex = 3;
            // 
            // textBoxTaxa
            // 
            this.textBoxTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTaxa.Location = new System.Drawing.Point(12, 122);
            this.textBoxTaxa.Name = "textBoxTaxa";
            this.textBoxTaxa.Size = new System.Drawing.Size(156, 23);
            this.textBoxTaxa.TabIndex = 4;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTempo.Location = new System.Drawing.Point(12, 195);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(156, 23);
            this.textBoxTempo.TabIndex = 5;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(225, 34);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(275, 394);
            this.listBoxResultado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(221, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TABELA DE RESULTADOS";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalcular.Location = new System.Drawing.Point(26, 267);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(107, 44);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.textBoxTaxa);
            this.Controls.Add(this.textBoxInvestimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.Text = "Investimentos  Rápido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInvestimento;
        private System.Windows.Forms.TextBox textBoxTaxa;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

