
namespace _3A2ENZO10
{
    partial class ForREVISÃO
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
            this.buttoncalculo = new System.Windows.Forms.Button();
            this.textKM = new System.Windows.Forms.TextBox();
            this.textREVER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoncalculo
            // 
            this.buttoncalculo.Location = new System.Drawing.Point(12, 179);
            this.buttoncalculo.Name = "buttoncalculo";
            this.buttoncalculo.Size = new System.Drawing.Size(214, 39);
            this.buttoncalculo.TabIndex = 0;
            this.buttoncalculo.Text = "CALCULO";
            this.buttoncalculo.UseVisualStyleBackColor = true;
            this.buttoncalculo.Click += new System.EventHandler(this.buttoncalculo_Click);
            // 
            // textKM
            // 
            this.textKM.Location = new System.Drawing.Point(69, 58);
            this.textKM.Name = "textKM";
            this.textKM.Size = new System.Drawing.Size(100, 20);
            this.textKM.TabIndex = 1;
            // 
            // textREVER
            // 
            this.textREVER.Location = new System.Drawing.Point(69, 129);
            this.textREVER.Name = "textREVER";
            this.textREVER.Size = new System.Drawing.Size(100, 20);
            this.textREVER.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Km Restantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Km do Altomovel";
            // 
            // ForREVISÃO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textREVER);
            this.Controls.Add(this.textKM);
            this.Controls.Add(this.buttoncalculo);
            this.Name = "ForREVISÃO";
            this.Text = "ForREVISÃO";
            this.Load += new System.EventHandler(this.ForREVISÃO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncalculo;
        private System.Windows.Forms.TextBox textKM;
        private System.Windows.Forms.TextBox textREVER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}