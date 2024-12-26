namespace M0A08D
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnDobro = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(308, 51);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(176, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btnDobro
            // 
            this.btnDobro.Location = new System.Drawing.Point(189, 121);
            this.btnDobro.Name = "btnDobro";
            this.btnDobro.Size = new System.Drawing.Size(214, 45);
            this.btnDobro.TabIndex = 2;
            this.btnDobro.Text = "Dobro";
            this.btnDobro.UseVisualStyleBackColor = true;
            this.btnDobro.Click += new System.EventHandler(this.btnDobro_Click);
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(259, 210);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(66, 24);
            this.lblResp.TabIndex = 3;
            this.lblResp.Text = "label2";
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResp.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDobro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 342);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.btnDobro);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnDobro;
        private System.Windows.Forms.Label lblResp;
    }
}

