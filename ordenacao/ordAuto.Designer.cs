
namespace ordenacao
{
    partial class ordAuto
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
            this.lblTempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.ListBox();
            this.lbLong = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(119, 392);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(13, 13);
            this.lblTempo.TabIndex = 21;
            this.lblTempo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tempo de execução:";
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(190, 83);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(135, 26);
            this.btnInsertion.TabIndex = 17;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(190, 51);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(135, 26);
            this.btnSelection.TabIndex = 16;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(190, 19);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(135, 26);
            this.btnBubble.TabIndex = 14;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(12, 19);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(135, 26);
            this.btnAleatorio.TabIndex = 12;
            this.btnAleatorio.Text = "Gerar Dados";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Longitude";
            // 
            // lbLat
            // 
            this.lbLat.FormattingEnabled = true;
            this.lbLat.Location = new System.Drawing.Point(12, 128);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(135, 251);
            this.lbLat.TabIndex = 26;
            this.lbLat.SelectedIndexChanged += new System.EventHandler(this.lbLat_SelectedIndexChanged_1);
            // 
            // lbLong
            // 
            this.lbLong.FormattingEnabled = true;
            this.lbLong.Location = new System.Drawing.Point(190, 128);
            this.lbLong.Name = "lbLong";
            this.lbLong.Size = new System.Drawing.Size(135, 251);
            this.lbLong.TabIndex = 27;
            this.lbLong.SelectedIndexChanged += new System.EventHandler(this.lbLong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantidade de Dados ";
            // 
            // lblNDados
            // 
            this.lblNDados.Location = new System.Drawing.Point(12, 67);
            this.lblNDados.Name = "lblNDados";
            this.lblNDados.Size = new System.Drawing.Size(135, 20);
            this.lblNDados.TabIndex = 29;
            this.lblNDados.Text = "0";
            this.lblNDados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ordAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 413);
            this.Controls.Add(this.lblNDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLong);
            this.Controls.Add(this.lbLat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnAleatorio);
            this.Name = "ordAuto";
            this.Text = "Ordenação Automática";
            this.Load += new System.EventHandler(this.ordAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbLat;
        private System.Windows.Forms.ListBox lbLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNDados;
    }
}