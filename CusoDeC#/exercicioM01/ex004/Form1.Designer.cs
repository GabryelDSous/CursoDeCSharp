namespace ex004
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
            this.caixaNum = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.valDigitado = new System.Windows.Forms.Label();
            this.valInteiro = new System.Windows.Forms.Label();
            this.valArredondado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Número Real";
            // 
            // caixaNum
            // 
            this.caixaNum.Location = new System.Drawing.Point(251, 9);
            this.caixaNum.Multiline = true;
            this.caixaNum.Name = "caixaNum";
            this.caixaNum.Size = new System.Drawing.Size(44, 25);
            this.caixaNum.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(301, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 25);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // valDigitado
            // 
            this.valDigitado.AutoSize = true;
            this.valDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDigitado.Location = new System.Drawing.Point(12, 59);
            this.valDigitado.Name = "valDigitado";
            this.valDigitado.Size = new System.Drawing.Size(0, 25);
            this.valDigitado.TabIndex = 3;
            this.valDigitado.Visible = false;
            // 
            // valInteiro
            // 
            this.valInteiro.AutoSize = true;
            this.valInteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valInteiro.Location = new System.Drawing.Point(12, 103);
            this.valInteiro.Name = "valInteiro";
            this.valInteiro.Size = new System.Drawing.Size(0, 25);
            this.valInteiro.TabIndex = 4;
            this.valInteiro.Visible = false;
            // 
            // valArredondado
            // 
            this.valArredondado.AutoSize = true;
            this.valArredondado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valArredondado.Location = new System.Drawing.Point(12, 156);
            this.valArredondado.Name = "valArredondado";
            this.valArredondado.Size = new System.Drawing.Size(0, 25);
            this.valArredondado.TabIndex = 5;
            this.valArredondado.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 227);
            this.Controls.Add(this.valArredondado);
            this.Controls.Add(this.valInteiro);
            this.Controls.Add(this.valDigitado);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.caixaNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisador de Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixaNum;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label valDigitado;
        private System.Windows.Forms.Label valInteiro;
        private System.Windows.Forms.Label valArredondado;
    }
}

