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
            this.VerificarCEP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerificarCEP
            // 
            this.VerificarCEP.Location = new System.Drawing.Point(12, 12);
            this.VerificarCEP.Name = "VerificarCEP";
            this.VerificarCEP.Size = new System.Drawing.Size(75, 23);
            this.VerificarCEP.TabIndex = 0;
            this.VerificarCEP.Text = "Verificar";
            this.VerificarCEP.UseVisualStyleBackColor = true;
            // 
            // BuscarCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerificarCEP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuscarCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar CEP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerificarCEP;
    }
}

