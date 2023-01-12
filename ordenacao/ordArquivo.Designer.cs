
namespace ordenacao
{
    partial class ordArquivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArquivo = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.lbLong = new System.Windows.Forms.ListBox();
            this.lbLat = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNdados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(12, 12);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 26);
            this.btnArquivo.TabIndex = 0;
            this.btnArquivo.Text = "Abrir Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(10, 41);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(145, 56);
            this.lblPath.TabIndex = 1;
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(188, 19);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(135, 26);
            this.btnBubble.TabIndex = 3;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(188, 51);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(135, 26);
            this.btnSelection.TabIndex = 5;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(188, 83);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(135, 26);
            this.btnInsertion.TabIndex = 6;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // lbLong
            // 
            this.lbLong.FormattingEnabled = true;
            this.lbLong.Location = new System.Drawing.Point(188, 131);
            this.lbLong.Name = "lbLong";
            this.lbLong.Size = new System.Drawing.Size(135, 251);
            this.lbLong.TabIndex = 33;
            this.lbLong.SelectedIndexChanged += new System.EventHandler(this.lbLong_SelectedIndexChanged);
            // 
            // lbLat
            // 
            this.lbLat.FormattingEnabled = true;
            this.lbLat.Location = new System.Drawing.Point(10, 131);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(135, 251);
            this.lbLat.TabIndex = 32;
            this.lbLat.SelectedIndexChanged += new System.EventHandler(this.lbLat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Latitude";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(117, 395);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(13, 13);
            this.lblTempo.TabIndex = 29;
            this.lblTempo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tempo de execução:";
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(248, 388);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(75, 26);
            this.btnCriarArquivo.TabIndex = 34;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(5, 98);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(118, 13);
            this.lbl1.TabIndex = 35;
            this.lbl1.Text = "Quantidade de dados:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNdados
            // 
            this.lblNdados.Location = new System.Drawing.Point(118, 97);
            this.lblNdados.Name = "lblNdados";
            this.lblNdados.Size = new System.Drawing.Size(53, 15);
            this.lblNdados.TabIndex = 36;
            this.lblNdados.Text = "0";
            this.lblNdados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ordArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 418);
            this.Controls.Add(this.lblNdados);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.lbLong);
            this.Controls.Add(this.lbLat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnArquivo);
            this.Name = "ordArquivo";
            this.Text = "Ordenação por Arquivo";
            this.Load += new System.EventHandler(this.ordArquivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.ListBox lbLong;
        private System.Windows.Forms.ListBox lbLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNdados;
    }
}