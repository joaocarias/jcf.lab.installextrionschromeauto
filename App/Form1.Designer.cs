namespace App
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
            this.tbValorUm = new System.Windows.Forms.TextBox();
            this.lbValorUm = new System.Windows.Forms.Label();
            this.lbValorDois = new System.Windows.Forms.Label();
            this.tbValorDois = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.InstallExtension = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbValorUm
            // 
            this.tbValorUm.Location = new System.Drawing.Point(69, 67);
            this.tbValorUm.Name = "tbValorUm";
            this.tbValorUm.Size = new System.Drawing.Size(100, 20);
            this.tbValorUm.TabIndex = 0;
            // 
            // lbValorUm
            // 
            this.lbValorUm.AutoSize = true;
            this.lbValorUm.Location = new System.Drawing.Point(69, 48);
            this.lbValorUm.Name = "lbValorUm";
            this.lbValorUm.Size = new System.Drawing.Size(40, 13);
            this.lbValorUm.TabIndex = 1;
            this.lbValorUm.Text = "Valor 1";
            // 
            // lbValorDois
            // 
            this.lbValorDois.AutoSize = true;
            this.lbValorDois.Location = new System.Drawing.Point(210, 48);
            this.lbValorDois.Name = "lbValorDois";
            this.lbValorDois.Size = new System.Drawing.Size(40, 13);
            this.lbValorDois.TabIndex = 3;
            this.lbValorDois.Text = "Valor 2";
            // 
            // tbValorDois
            // 
            this.tbValorDois.Location = new System.Drawing.Point(210, 67);
            this.tbValorDois.Name = "tbValorDois";
            this.tbValorDois.Size = new System.Drawing.Size(100, 20);
            this.tbValorDois.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(210, 93);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(77, 164);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(34, 13);
            this.lbTexto.TabIndex = 5;
            this.lbTexto.Text = "Texto";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(80, 138);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // InstallExtension
            // 
            this.InstallExtension.Location = new System.Drawing.Point(424, 66);
            this.InstallExtension.Name = "InstallExtension";
            this.InstallExtension.Size = new System.Drawing.Size(75, 23);
            this.InstallExtension.TabIndex = 7;
            this.InstallExtension.Text = "Instalar";
            this.InstallExtension.UseVisualStyleBackColor = true;
            this.InstallExtension.Click += new System.EventHandler(this.InstallExtension_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(515, 67);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 8;
            this.btnUninstall.Text = "Desinstalar";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 216);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.InstallExtension);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbValorDois);
            this.Controls.Add(this.tbValorDois);
            this.Controls.Add(this.lbValorUm);
            this.Controls.Add(this.tbValorUm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValorUm;
        private System.Windows.Forms.Label lbValorUm;
        private System.Windows.Forms.Label lbValorDois;
        private System.Windows.Forms.TextBox tbValorDois;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button InstallExtension;
        private System.Windows.Forms.Button btnUninstall;
    }
}

