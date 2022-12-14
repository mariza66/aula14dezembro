namespace aula_14dezembro
{
    partial class inpulabol
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
            this.labelMensagem = new System.Windows.Forms.Label();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(124, 187);
            this.labelMensagem.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(60, 24);
            this.labelMensagem.TabIndex = 0;
            this.labelMensagem.Text = "label1";
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(469, 72);
            this.botaoLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(138, 42);
            this.botaoLimpar.TabIndex = 1;
            this.botaoLimpar.Text = "limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(128, 76);
            this.inputSenha.Margin = new System.Windows.Forms.Padding(6);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(180, 29);
            this.inputSenha.TabIndex = 2;
            this.inputSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verificaCaracter);
            // 
            // inpulabol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 307);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.labelMensagem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "inpulabol";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.inpulabol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox inputSenha;
    }
}

