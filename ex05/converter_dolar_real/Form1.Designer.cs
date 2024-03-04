
namespace ex05
{
    partial class frmTelaPrincipal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.brnConversor = new System.Windows.Forms.Button();
            this.lblPrecoReal = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(172, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(232, 58);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(144, 22);
            this.textNome.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(107, 110);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(118, 16);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço em dolar:";
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(231, 104);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(145, 22);
            this.textPreco.TabIndex = 3;
            // 
            // brnConversor
            // 
            this.brnConversor.Location = new System.Drawing.Point(242, 160);
            this.brnConversor.Name = "brnConversor";
            this.brnConversor.Size = new System.Drawing.Size(117, 49);
            this.brnConversor.TabIndex = 4;
            this.brnConversor.Text = "Conversão monetaria";
            this.brnConversor.UseVisualStyleBackColor = true;
            this.brnConversor.Click += new System.EventHandler(this.brnConversor_Click);
            // 
            // lblPrecoReal
            // 
            this.lblPrecoReal.AutoSize = true;
            this.lblPrecoReal.Location = new System.Drawing.Point(185, 236);
            this.lblPrecoReal.Name = "lblPrecoReal";
            this.lblPrecoReal.Size = new System.Drawing.Size(109, 16);
            this.lblPrecoReal.TabIndex = 5;
            this.lblPrecoReal.Text = "Preco em real:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(301, 236);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 16);
            this.lblSaida.TabIndex = 6;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(790, 371);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblPrecoReal);
            this.Controls.Add(this.brnConversor);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTelaPrincipal";
            this.Text = "Conversor de dolar em real";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Button brnConversor;
        private System.Windows.Forms.Label lblPrecoReal;
        private System.Windows.Forms.Label lblSaida;
    }
}

