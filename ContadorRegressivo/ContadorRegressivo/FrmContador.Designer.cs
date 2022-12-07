namespace ContadorRegressivo
{
    partial class FrmContador
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
            this.components = new System.ComponentModel.Container();
            this.txtTempoFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempoFinal
            // 
            this.txtTempoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTempoFinal.Location = new System.Drawing.Point(89, 21);
            this.txtTempoFinal.Name = "txtTempoFinal";
            this.txtTempoFinal.Size = new System.Drawing.Size(174, 26);
            this.txtTempoFinal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(53, 77);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(325, 120);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnStart.Location = new System.Drawing.Point(289, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ContadorRegressivo.Properties.Resources.menu_02;
            this.pictureBox.Location = new System.Drawing.Point(89, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(247, 224);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Contador
            // 
            this.Contador.Interval = 1000;
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // FrmContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 305);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempoFinal);
            this.Controls.Add(this.pictureBox);
            this.Name = "FrmContador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador Regressivo";
            this.Load += new System.EventHandler(this.FrmContador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer Contador;
    }
}

