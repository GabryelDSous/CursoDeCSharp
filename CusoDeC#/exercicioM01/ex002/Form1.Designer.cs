namespace ex002
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
            this.txtMeu = new System.Windows.Forms.Label();
            this.txtBrasil = new System.Windows.Forms.Label();
            this.txtBrasileiro = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMeu
            // 
            this.txtMeu.AutoSize = true;
            this.txtMeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeu.Location = new System.Drawing.Point(100, 98);
            this.txtMeu.Name = "txtMeu";
            this.txtMeu.Size = new System.Drawing.Size(74, 31);
            this.txtMeu.TabIndex = 0;
            this.txtMeu.Text = "MEU";
            this.txtMeu.Visible = false;
            // 
            // txtBrasil
            // 
            this.txtBrasil.AutoSize = true;
            this.txtBrasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrasil.Location = new System.Drawing.Point(205, 98);
            this.txtBrasil.Name = "txtBrasil";
            this.txtBrasil.Size = new System.Drawing.Size(111, 31);
            this.txtBrasil.TabIndex = 1;
            this.txtBrasil.Text = "BRASIL";
            this.txtBrasil.Visible = false;
            // 
            // txtBrasileiro
            // 
            this.txtBrasileiro.AutoSize = true;
            this.txtBrasileiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrasileiro.Location = new System.Drawing.Point(339, 98);
            this.txtBrasileiro.Name = "txtBrasileiro";
            this.txtBrasileiro.Size = new System.Drawing.Size(178, 31);
            this.txtBrasileiro.TabIndex = 2;
            this.txtBrasileiro.Text = "BRASILEIRO";
            this.txtBrasileiro.Visible = false;
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(211, 256);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(132, 48);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "INICIAR";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 362);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtBrasileiro);
            this.Controls.Add(this.txtBrasil);
            this.Controls.Add(this.txtMeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMeu;
        private System.Windows.Forms.Label txtBrasil;
        private System.Windows.Forms.Label txtBrasileiro;
        private System.Windows.Forms.Button btnClick;
    }
}

