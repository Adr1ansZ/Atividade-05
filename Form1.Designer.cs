namespace Atividade_05
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
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.bntcalc = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblresposta = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(102, 143);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(34, 13);
            this.lblbase.TabIndex = 0;
            this.lblbase.Text = "Base:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(102, 233);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(37, 13);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura:";
            // 
            // bntcalc
            // 
            this.bntcalc.Location = new System.Drawing.Point(320, 286);
            this.bntcalc.Name = "bntcalc";
            this.bntcalc.Size = new System.Drawing.Size(75, 23);
            this.bntcalc.TabIndex = 2;
            this.bntcalc.Text = "Calcular:";
            this.bntcalc.UseVisualStyleBackColor = true;
            this.bntcalc.Click += new System.EventHandler(this.bntcalc_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(102, 379);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(32, 13);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "Área:";
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.Location = new System.Drawing.Point(182, 378);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(0, 13);
            this.lblresposta.TabIndex = 4;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(163, 136);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(163, 226);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.bntcalc);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Button bntcalc;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblresposta;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
    }
}

