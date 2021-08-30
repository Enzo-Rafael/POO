
namespace _3A2ENZO10
{
    partial class Formgastos
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
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.txtS4 = new System.Windows.Forms.TextBox();
            this.calculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(82, 25);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 20);
            this.txtS1.TabIndex = 0;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(82, 51);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(100, 20);
            this.txtS2.TabIndex = 1;
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(82, 77);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(100, 20);
            this.txtS3.TabIndex = 2;
            this.txtS3.TextChanged += new System.EventHandler(this.S3_TextChanged);
            // 
            // txtS4
            // 
            this.txtS4.Location = new System.Drawing.Point(82, 103);
            this.txtS4.Name = "txtS4";
            this.txtS4.Size = new System.Drawing.Size(100, 20);
            this.txtS4.TabIndex = 3;
            // 
            // calculo
            // 
            this.calculo.Location = new System.Drawing.Point(82, 129);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(100, 51);
            this.calculo.TabIndex = 4;
            this.calculo.Text = "Calcular";
            this.calculo.UseVisualStyleBackColor = true;
            this.calculo.Click += new System.EventHandler(this.calculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Semana 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semana 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semana 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semana 4";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(82, 186);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 9;
            // 
            // Formgastos
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.txtS4);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Name = "Formgastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.TextBox txtS4;
        private System.Windows.Forms.Button calculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresultado;
    }
}