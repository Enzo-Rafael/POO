
namespace ProjetoAreas
{
    partial class FrmPrincipal
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
            this.btnretangulo = new System.Windows.Forms.Button();
            this.btnquadrado = new System.Windows.Forms.Button();
            this.btntriangulo = new System.Windows.Forms.Button();
            this.btntrapezio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretangulo
            // 
            this.btnretangulo.Location = new System.Drawing.Point(26, 21);
            this.btnretangulo.Name = "btnretangulo";
            this.btnretangulo.Size = new System.Drawing.Size(123, 35);
            this.btnretangulo.TabIndex = 0;
            this.btnretangulo.Text = "Retângulo";
            this.btnretangulo.UseVisualStyleBackColor = true;
            this.btnretangulo.Click += new System.EventHandler(this.btnretangulo_Click);
            // 
            // btnquadrado
            // 
            this.btnquadrado.Location = new System.Drawing.Point(26, 62);
            this.btnquadrado.Name = "btnquadrado";
            this.btnquadrado.Size = new System.Drawing.Size(123, 33);
            this.btnquadrado.TabIndex = 1;
            this.btnquadrado.Text = "Quadrado";
            this.btnquadrado.UseVisualStyleBackColor = true;
            this.btnquadrado.Click += new System.EventHandler(this.btnquadrado_Click);
            // 
            // btntriangulo
            // 
            this.btntriangulo.Location = new System.Drawing.Point(26, 101);
            this.btntriangulo.Name = "btntriangulo";
            this.btntriangulo.Size = new System.Drawing.Size(123, 34);
            this.btntriangulo.TabIndex = 2;
            this.btntriangulo.Text = "Triângulo";
            this.btntriangulo.UseVisualStyleBackColor = true;
            this.btntriangulo.Click += new System.EventHandler(this.btntriangulo_Click);
            // 
            // btntrapezio
            // 
            this.btntrapezio.Location = new System.Drawing.Point(26, 141);
            this.btntrapezio.Name = "btntrapezio";
            this.btntrapezio.Size = new System.Drawing.Size(123, 35);
            this.btntrapezio.TabIndex = 3;
            this.btntrapezio.Text = "Trapézio";
            this.btntrapezio.UseVisualStyleBackColor = true;
            this.btntrapezio.Click += new System.EventHandler(this.btntrapezio_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 200);
            this.Controls.Add(this.btntrapezio);
            this.Controls.Add(this.btntriangulo);
            this.Controls.Add(this.btnquadrado);
            this.Controls.Add(this.btnretangulo);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretangulo;
        private System.Windows.Forms.Button btnquadrado;
        private System.Windows.Forms.Button btntriangulo;
        private System.Windows.Forms.Button btntrapezio;
    }
}

