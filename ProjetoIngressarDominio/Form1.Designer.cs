namespace ProjetoIngressarDominio
{
    partial class Form1
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
            this.rdoIP = new System.Windows.Forms.RadioButton();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.rdoLista = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQtdIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoIP
            // 
            this.rdoIP.AutoSize = true;
            this.rdoIP.Checked = true;
            this.rdoIP.Location = new System.Drawing.Point(30, 86);
            this.rdoIP.Name = "rdoIP";
            this.rdoIP.Size = new System.Drawing.Size(17, 16);
            this.rdoIP.TabIndex = 0;
            this.rdoIP.TabStop = true;
            this.rdoIP.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(53, 86);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(148, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdoLista
            // 
            this.rdoLista.AutoSize = true;
            this.rdoLista.Location = new System.Drawing.Point(30, 146);
            this.rdoLista.Name = "rdoLista";
            this.rdoLista.Size = new System.Drawing.Size(102, 21);
            this.rdoLista.TabIndex = 2;
            this.rdoLista.TabStop = true;
            this.rdoLista.Text = "Lista de IPs";
            this.rdoLista.UseVisualStyleBackColor = true;
            this.rdoLista.CheckedChanged += new System.EventHandler(this.rdoLista_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Procurar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ingressar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Ingressar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Remover);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Configurações";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Configuracao);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "...";
            // 
            // lblQtdIp
            // 
            this.lblQtdIp.AutoSize = true;
            this.lblQtdIp.Location = new System.Drawing.Point(154, 146);
            this.lblQtdIp.Name = "lblQtdIp";
            this.lblQtdIp.Size = new System.Drawing.Size(20, 17);
            this.lblQtdIp.TabIndex = 9;
            this.lblQtdIp.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 432);
            this.Controls.Add(this.lblQtdIp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoLista);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.rdoIP);
            this.Name = "Form1";
            this.Text = "Ingressa Dominio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQtdIp;
        public System.Windows.Forms.RadioButton rdoLista;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

