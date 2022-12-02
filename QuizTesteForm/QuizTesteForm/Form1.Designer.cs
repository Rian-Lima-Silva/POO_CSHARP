namespace QuizTesteForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.opcao1 = new System.Windows.Forms.RadioButton();
            this.opcao2 = new System.Windows.Forms.RadioButton();
            this.opcao3 = new System.Windows.Forms.RadioButton();
            this.opcao4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(97, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(253, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Proximo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcao1
            // 
            this.opcao1.AutoSize = true;
            this.opcao1.Location = new System.Drawing.Point(253, 311);
            this.opcao1.Name = "opcao1";
            this.opcao1.Size = new System.Drawing.Size(85, 17);
            this.opcao1.TabIndex = 2;
            this.opcao1.TabStop = true;
            this.opcao1.Text = "radioButton1";
            this.opcao1.UseVisualStyleBackColor = true;
            // 
            // opcao2
            // 
            this.opcao2.AutoSize = true;
            this.opcao2.Location = new System.Drawing.Point(253, 335);
            this.opcao2.Name = "opcao2";
            this.opcao2.Size = new System.Drawing.Size(85, 17);
            this.opcao2.TabIndex = 3;
            this.opcao2.TabStop = true;
            this.opcao2.Text = "radioButton2";
            this.opcao2.UseVisualStyleBackColor = true;
            // 
            // opcao3
            // 
            this.opcao3.AutoSize = true;
            this.opcao3.Location = new System.Drawing.Point(253, 358);
            this.opcao3.Name = "opcao3";
            this.opcao3.Size = new System.Drawing.Size(85, 17);
            this.opcao3.TabIndex = 3;
            this.opcao3.TabStop = true;
            this.opcao3.Text = "radioButton2";
            this.opcao3.UseVisualStyleBackColor = true;
            // 
            // opcao4
            // 
            this.opcao4.AutoSize = true;
            this.opcao4.Location = new System.Drawing.Point(253, 381);
            this.opcao4.Name = "opcao4";
            this.opcao4.Size = new System.Drawing.Size(85, 17);
            this.opcao4.TabIndex = 3;
            this.opcao4.TabStop = true;
            this.opcao4.Text = "radioButton2";
            this.opcao4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizTesteForm.Properties.Resources.Captura_da_Web_10_11_2022_9474_www_bing_com;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.opcao4);
            this.Controls.Add(this.opcao3);
            this.Controls.Add(this.opcao2);
            this.Controls.Add(this.opcao1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton opcao1;
        private System.Windows.Forms.RadioButton opcao2;
        private System.Windows.Forms.RadioButton opcao3;
        private System.Windows.Forms.RadioButton opcao4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

