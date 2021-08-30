
namespace ProjetoAreas
{
    partial class frmTrapezio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtbasemaior = new System.Windows.Forms.TextBox();
            this.txtbasemenor = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlado3 = new System.Windows.Forms.TextBox();
            this.txtlado4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BaseMaior:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BaseMenor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Área:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(15, 190);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(181, 44);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtbasemaior
            // 
            this.txtbasemaior.Location = new System.Drawing.Point(96, 23);
            this.txtbasemaior.Name = "txtbasemaior";
            this.txtbasemaior.Size = new System.Drawing.Size(100, 20);
            this.txtbasemaior.TabIndex = 5;
            this.txtbasemaior.Text = "0";
            this.txtbasemaior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbasemenor
            // 
            this.txtbasemenor.Location = new System.Drawing.Point(96, 50);
            this.txtbasemenor.Name = "txtbasemenor";
            this.txtbasemenor.Size = new System.Drawing.Size(100, 20);
            this.txtbasemenor.TabIndex = 6;
            this.txtbasemenor.Text = "0";
            this.txtbasemenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(96, 77);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 7;
            this.txtaltura.Text = "0";
            this.txtaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(284, 50);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 8;
            this.txtarea.Text = "0";
            this.txtarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(284, 77);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(100, 20);
            this.txtperimetro.TabIndex = 9;
            this.txtperimetro.Text = "0";
            this.txtperimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perimetro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lado4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lado3:";
            // 
            // txtlado3
            // 
            this.txtlado3.Location = new System.Drawing.Point(96, 103);
            this.txtlado3.Name = "txtlado3";
            this.txtlado3.Size = new System.Drawing.Size(100, 20);
            this.txtlado3.TabIndex = 13;
            this.txtlado3.Text = "0";
            this.txtlado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtlado4
            // 
            this.txtlado4.Location = new System.Drawing.Point(96, 129);
            this.txtlado4.Name = "txtlado4";
            this.txtlado4.Size = new System.Drawing.Size(100, 20);
            this.txtlado4.TabIndex = 14;
            this.txtlado4.Text = "0";
            this.txtlado4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTrapezio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 246);
            this.Controls.Add(this.txtlado4);
            this.Controls.Add(this.txtlado3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbasemenor);
            this.Controls.Add(this.txtbasemaior);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTrapezio";
            this.Text = "Trapézio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtbasemaior;
        private System.Windows.Forms.TextBox txtbasemenor;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlado3;
        private System.Windows.Forms.TextBox txtlado4;
    }
}