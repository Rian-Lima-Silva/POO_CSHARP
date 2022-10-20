namespace IMC_ValorClassifcar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelClassificar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelResTest = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label_img_BP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPeso.Location = new System.Drawing.Point(180, 25);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(136, 29);
            this.textBoxPeso.TabIndex = 0;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalcular.Location = new System.Drawing.Point(180, 126);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(136, 40);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPeso.Location = new System.Drawing.Point(12, 25);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(162, 24);
            this.labelPeso.TabIndex = 2;
            this.labelPeso.Text = "Digite o seu Peso:";
            // 
            // labelClassificar
            // 
            this.labelClassificar.AutoSize = true;
            this.labelClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelClassificar.Location = new System.Drawing.Point(332, 30);
            this.labelClassificar.Name = "labelClassificar";
            this.labelClassificar.Size = new System.Drawing.Size(161, 24);
            this.labelClassificar.TabIndex = 3;
            this.labelClassificar.Text = "Sua Classificação:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 246);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxAltura.Location = new System.Drawing.Point(180, 78);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(136, 29);
            this.textBoxAltura.TabIndex = 6;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAltura.Location = new System.Drawing.Point(9, 78);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(165, 24);
            this.labelAltura.TabIndex = 7;
            this.labelAltura.Text = "Digite a sua Altura:";
            // 
            // labelResTest
            // 
            this.labelResTest.AutoSize = true;
            this.labelResTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelResTest.Location = new System.Drawing.Point(499, 30);
            this.labelResTest.Name = "labelResTest";
            this.labelResTest.Size = new System.Drawing.Size(118, 24);
            this.labelResTest.TabIndex = 8;
            this.labelResTest.Text = "------------------";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(16, 137);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(132, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // label_img_BP
            // 
            this.label_img_BP.Image = ((System.Drawing.Image)(resources.GetObject("label_img_BP.Image")));
            this.label_img_BP.Location = new System.Drawing.Point(499, 25);
            this.label_img_BP.Name = "label_img_BP";
            this.label_img_BP.Size = new System.Drawing.Size(147, 44);
            this.label_img_BP.TabIndex = 10;
            this.label_img_BP.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_img_BP);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelResTest);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelClassificar);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxPeso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelClassificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelResTest;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label_img_BP;
    }
}

