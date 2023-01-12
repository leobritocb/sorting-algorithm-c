
namespace ordenacao
{
    partial class inicio
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
            this.btnAutomatica = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAutomatica
            // 
            this.btnAutomatica.Location = new System.Drawing.Point(55, 136);
            this.btnAutomatica.Name = "btnAutomatica";
            this.btnAutomatica.Size = new System.Drawing.Size(154, 25);
            this.btnAutomatica.TabIndex = 1;
            this.btnAutomatica.Text = "Ordenação automática";
            this.btnAutomatica.UseVisualStyleBackColor = true;
            this.btnAutomatica.Click += new System.EventHandler(this.btnAutomatica_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(55, 73);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(154, 25);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "Ordenação por arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por favor, Escolha uma opção";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.btnAutomatica);
            this.Name = "inicio";
            this.Text = "Ordenação";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutomatica;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Label label1;
    }
}

