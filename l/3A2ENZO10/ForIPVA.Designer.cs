
namespace _3A2ENZO10
{
    partial class ForIPVA
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
            this.butcal = new System.Windows.Forms.Button();
            this.texr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbp = new System.Windows.Forms.RadioButton();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.rbtp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // butcal
            // 
            this.butcal.Location = new System.Drawing.Point(51, 127);
            this.butcal.Name = "butcal";
            this.butcal.Size = new System.Drawing.Size(135, 53);
            this.butcal.TabIndex = 0;
            this.butcal.Text = "CALCULAR";
            this.butcal.UseVisualStyleBackColor = true;
            this.butcal.Click += new System.EventHandler(this.button1_Click);
            // 
            // texr
            // 
            this.texr.Location = new System.Drawing.Point(63, 199);
            this.texr.Name = "texr";
            this.texr.Size = new System.Drawing.Size(100, 20);
            this.texr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IPVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor do Carro";
            // 
            // textv
            // 
            this.textv.Location = new System.Drawing.Point(63, 29);
            this.textv.Name = "textv";
            this.textv.Size = new System.Drawing.Size(100, 20);
            this.textv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // rbp
            // 
            this.rbp.AutoSize = true;
            this.rbp.Location = new System.Drawing.Point(13, 104);
            this.rbp.Name = "rbp";
            this.rbp.Size = new System.Drawing.Size(72, 17);
            this.rbp.TabIndex = 6;
            this.rbp.TabStop = true;
            this.rbp.Text = "C Pessoal";
            this.rbp.UseVisualStyleBackColor = true;
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(84, 104);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(63, 17);
            this.rbc.TabIndex = 7;
            this.rbc.TabStop = true;
            this.rbc.Text = "C Carga";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // rbtp
            // 
            this.rbtp.AutoSize = true;
            this.rbtp.Location = new System.Drawing.Point(153, 104);
            this.rbtp.Name = "rbtp";
            this.rbtp.Size = new System.Drawing.Size(70, 17);
            this.rbtp.TabIndex = 8;
            this.rbtp.TabStop = true;
            this.rbtp.Text = "T Público";
            this.rbtp.UseVisualStyleBackColor = true;
            // 
            // ForIPVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 238);
            this.Controls.Add(this.rbtp);
            this.Controls.Add(this.rbc);
            this.Controls.Add(this.rbp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texr);
            this.Controls.Add(this.butcal);
            this.Name = "ForIPVA";
            this.Text = "ForIPVA";
            this.Load += new System.EventHandler(this.ForIPVA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butcal;
        private System.Windows.Forms.TextBox texr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbp;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.RadioButton rbtp;
    }
}