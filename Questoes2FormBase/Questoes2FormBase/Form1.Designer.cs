namespace Questoes2FormBase
{
    partial class Form1
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
            this.OpcaoA = new System.Windows.Forms.RadioButton();
            this.OpcaoB = new System.Windows.Forms.RadioButton();
            this.OpcaoC = new System.Windows.Forms.RadioButton();
            this.OpcaoD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(275, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pergunta";
            // 
            // OpcaoA
            // 
            this.OpcaoA.AutoSize = true;
            this.OpcaoA.Enabled = false;
            this.OpcaoA.Location = new System.Drawing.Point(308, 243);
            this.OpcaoA.Name = "OpcaoA";
            this.OpcaoA.Size = new System.Drawing.Size(85, 17);
            this.OpcaoA.TabIndex = 1;
            this.OpcaoA.Text = "radioButton1";
            this.OpcaoA.UseVisualStyleBackColor = true;
            // 
            // OpcaoB
            // 
            this.OpcaoB.AutoSize = true;
            this.OpcaoB.Location = new System.Drawing.Point(308, 266);
            this.OpcaoB.Name = "OpcaoB";
            this.OpcaoB.Size = new System.Drawing.Size(85, 17);
            this.OpcaoB.TabIndex = 2;
            this.OpcaoB.Text = "radioButton2";
            this.OpcaoB.UseVisualStyleBackColor = true;
            // 
            // OpcaoC
            // 
            this.OpcaoC.AutoSize = true;
            this.OpcaoC.Location = new System.Drawing.Point(308, 289);
            this.OpcaoC.Name = "OpcaoC";
            this.OpcaoC.Size = new System.Drawing.Size(85, 17);
            this.OpcaoC.TabIndex = 3;
            this.OpcaoC.Text = "radioButton3";
            this.OpcaoC.UseVisualStyleBackColor = true;
            // 
            // OpcaoD
            // 
            this.OpcaoD.AutoSize = true;
            this.OpcaoD.Location = new System.Drawing.Point(308, 312);
            this.OpcaoD.Name = "OpcaoD";
            this.OpcaoD.Size = new System.Drawing.Size(85, 17);
            this.OpcaoD.TabIndex = 4;
            this.OpcaoD.Text = "radioButton4";
            this.OpcaoD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(637, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.OpcaoD);
            this.Controls.Add(this.OpcaoC);
            this.Controls.Add(this.OpcaoB);
            this.Controls.Add(this.OpcaoA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OpcaoA;
        private System.Windows.Forms.RadioButton OpcaoB;
        private System.Windows.Forms.RadioButton OpcaoC;
        private System.Windows.Forms.RadioButton OpcaoD;
        private System.Windows.Forms.Button btnNext;
    }
}

