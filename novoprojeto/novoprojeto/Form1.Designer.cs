namespace novoprojeto
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.tbxNumero = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.Label();
            this.lblMsn = new System.Windows.Forms.Label();
            this.tbxNumero1 = new System.Windows.Forms.TextBox();
            this.tbxValor1 = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(583, 184);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // tbxNumero
            // 
            this.tbxNumero.AutoSize = true;
            this.tbxNumero.Location = new System.Drawing.Point(481, 106);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(44, 13);
            this.tbxNumero.TabIndex = 1;
            this.tbxNumero.Text = "Numero";
            // 
            // tbxValor
            // 
            this.tbxValor.AutoSize = true;
            this.tbxValor.Location = new System.Drawing.Point(481, 145);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(31, 13);
            this.tbxValor.TabIndex = 2;
            this.tbxValor.Text = "Valor";
            // 
            // lblMsn
            // 
            this.lblMsn.AutoSize = true;
            this.lblMsn.Location = new System.Drawing.Point(601, 232);
            this.lblMsn.Name = "lblMsn";
            this.lblMsn.Size = new System.Drawing.Size(35, 13);
            this.lblMsn.TabIndex = 3;
            this.lblMsn.Text = "label3";
            // 
            // tbxNumero1
            // 
            this.tbxNumero1.Location = new System.Drawing.Point(583, 99);
            this.tbxNumero1.Name = "tbxNumero1";
            this.tbxNumero1.Size = new System.Drawing.Size(100, 20);
            this.tbxNumero1.TabIndex = 4;
            // 
            // tbxValor1
            // 
            this.tbxValor1.Location = new System.Drawing.Point(583, 138);
            this.tbxValor1.Name = "tbxValor1";
            this.tbxValor1.Size = new System.Drawing.Size(100, 20);
            this.tbxValor1.TabIndex = 5;
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(647, 54);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(35, 13);
            this.lblDinheiro.TabIndex = 6;
            this.lblDinheiro.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.tbxValor1);
            this.Controls.Add(this.tbxNumero1);
            this.Controls.Add(this.lblMsn);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.btnJogar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label tbxNumero;
        private System.Windows.Forms.Label tbxValor;
        private System.Windows.Forms.Label lblMsn;
        private System.Windows.Forms.TextBox tbxNumero1;
        private System.Windows.Forms.TextBox tbxValor1;
        private System.Windows.Forms.Label lblDinheiro;
    }
}

