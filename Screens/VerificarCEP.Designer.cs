namespace BuscaCEP
{
    partial class BuscarCEP
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
            this.btnVerificarCEP = new System.Windows.Forms.Button();
            this.lblListaCEP = new System.Windows.Forms.Label();
            this.txtFileListaCEP = new System.Windows.Forms.TextBox();
            this.btnProcurarListaCEP = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtFileResultados = new System.Windows.Forms.TextBox();
            this.btnProcurarPasta = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnVerificarCEP
            // 
            this.btnVerificarCEP.Location = new System.Drawing.Point(463, 62);
            this.btnVerificarCEP.Name = "btnVerificarCEP";
            this.btnVerificarCEP.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarCEP.TabIndex = 0;
            this.btnVerificarCEP.Text = "Verificar";
            this.btnVerificarCEP.UseVisualStyleBackColor = true;
            this.btnVerificarCEP.Click += new System.EventHandler(this.VerificarCEP_Click);
            // 
            // lblListaCEP
            // 
            this.lblListaCEP.AutoSize = true;
            this.lblListaCEP.Location = new System.Drawing.Point(12, 9);
            this.lblListaCEP.Name = "lblListaCEP";
            this.lblListaCEP.Size = new System.Drawing.Size(131, 13);
            this.lblListaCEP.TabIndex = 1;
            this.lblListaCEP.Text = "Caminho da lista de CEPs:";
            // 
            // txtFileListaCEP
            // 
            this.txtFileListaCEP.Enabled = false;
            this.txtFileListaCEP.Location = new System.Drawing.Point(149, 6);
            this.txtFileListaCEP.Name = "txtFileListaCEP";
            this.txtFileListaCEP.Size = new System.Drawing.Size(308, 20);
            this.txtFileListaCEP.TabIndex = 2;
            // 
            // btnProcurarListaCEP
            // 
            this.btnProcurarListaCEP.Location = new System.Drawing.Point(463, 4);
            this.btnProcurarListaCEP.Name = "btnProcurarListaCEP";
            this.btnProcurarListaCEP.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarListaCEP.TabIndex = 3;
            this.btnProcurarListaCEP.Text = "Procurar";
            this.btnProcurarListaCEP.UseVisualStyleBackColor = true;
            this.btnProcurarListaCEP.Click += new System.EventHandler(this.btnProcurarListaCEP_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(26, 38);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(117, 13);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "Caminho do resultados:";
            // 
            // txtFileResultados
            // 
            this.txtFileResultados.Enabled = false;
            this.txtFileResultados.Location = new System.Drawing.Point(149, 35);
            this.txtFileResultados.Name = "txtFileResultados";
            this.txtFileResultados.Size = new System.Drawing.Size(308, 20);
            this.txtFileResultados.TabIndex = 5;
            // 
            // btnProcurarPasta
            // 
            this.btnProcurarPasta.Location = new System.Drawing.Point(463, 33);
            this.btnProcurarPasta.Name = "btnProcurarPasta";
            this.btnProcurarPasta.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarPasta.TabIndex = 6;
            this.btnProcurarPasta.Text = "Procurar";
            this.btnProcurarPasta.UseVisualStyleBackColor = true;
            this.btnProcurarPasta.Click += new System.EventHandler(this.btnProcurarPasta_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 62);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(445, 23);
            this.progressBar.TabIndex = 7;
            // 
            // BuscarCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 94);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnProcurarPasta);
            this.Controls.Add(this.txtFileResultados);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnProcurarListaCEP);
            this.Controls.Add(this.txtFileListaCEP);
            this.Controls.Add(this.lblListaCEP);
            this.Controls.Add(this.btnVerificarCEP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuscarCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarCEP;
        private System.Windows.Forms.Label lblListaCEP;
        private System.Windows.Forms.TextBox txtFileListaCEP;
        private System.Windows.Forms.Button btnProcurarListaCEP;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.TextBox txtFileResultados;
        private System.Windows.Forms.Button btnProcurarPasta;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

