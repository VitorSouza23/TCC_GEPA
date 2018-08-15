namespace Gepa.Tools.EncryptAndDecryptTool
{
    partial class EncryptAndDescryptTool
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
            this.tbTextIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextOut = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDescrypt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto de Entrada:";
            // 
            // tbTextIn
            // 
            this.tbTextIn.Location = new System.Drawing.Point(16, 32);
            this.tbTextIn.Multiline = true;
            this.tbTextIn.Name = "tbTextIn";
            this.tbTextIn.Size = new System.Drawing.Size(772, 112);
            this.tbTextIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto de Sáida:";
            // 
            // tbTextOut
            // 
            this.tbTextOut.Location = new System.Drawing.Point(19, 228);
            this.tbTextOut.Multiline = true;
            this.tbTextOut.Name = "tbTextOut";
            this.tbTextOut.Size = new System.Drawing.Size(769, 127);
            this.tbTextOut.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(241, 173);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(103, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encriptografar";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDescrypt
            // 
            this.btnDescrypt.Location = new System.Drawing.Point(421, 173);
            this.btnDescrypt.Name = "btnDescrypt";
            this.btnDescrypt.Size = new System.Drawing.Size(105, 23);
            this.btnDescrypt.TabIndex = 5;
            this.btnDescrypt.Text = "Descriptografar";
            this.btnDescrypt.UseVisualStyleBackColor = true;
            this.btnDescrypt.Click += new System.EventHandler(this.btnDescrypt_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(354, 381);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(101, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copiar Saída";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // EncryptAndDescryptTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDescrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbTextOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTextIn);
            this.Controls.Add(this.label1);
            this.Name = "EncryptAndDescryptTool";
            this.Text = "Ferramenta de encriptção e descriptação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTextIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextOut;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDescrypt;
        private System.Windows.Forms.Button btnCopy;
    }
}

