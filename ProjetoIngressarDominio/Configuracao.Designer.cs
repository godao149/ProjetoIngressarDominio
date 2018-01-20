using System.Windows.Forms;

namespace ProjetoIngressarDominio
{
    partial class frmConfiguracao
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdmDom = new System.Windows.Forms.TextBox();
            this.txtSenhaDom = new System.Windows.Forms.TextBox();
            this.txtAdmLocal = new System.Windows.Forms.TextBox();
            this.txtSenhaLocal = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adm. Dominio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha Adm.Dom.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adm. Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha Adm.Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dominio";
            // 
            // txtAdmDom
            // 
            this.txtAdmDom.Location = new System.Drawing.Point(157, 52);
            this.txtAdmDom.Name = "txtAdmDom";
            this.txtAdmDom.Size = new System.Drawing.Size(144, 22);
            this.txtAdmDom.TabIndex = 5;
            this.txtAdmDom.TextChanged += new System.EventHandler(this.txtAdmDom_TextChanged);
            // 
            // txtSenhaDom
            // 
            this.txtSenhaDom.Location = new System.Drawing.Point(157, 102);
            this.txtSenhaDom.Name = "txtSenhaDom";
            this.txtSenhaDom.PasswordChar = '*';
            this.txtSenhaDom.Size = new System.Drawing.Size(144, 22);
            this.txtSenhaDom.TabIndex = 6;
            this.txtSenhaDom.UseSystemPasswordChar = true;
            // 
            // txtAdmLocal
            // 
            this.txtAdmLocal.Location = new System.Drawing.Point(157, 149);
            this.txtAdmLocal.Name = "txtAdmLocal";
            this.txtAdmLocal.Size = new System.Drawing.Size(144, 22);
            this.txtAdmLocal.TabIndex = 7;
            // 
            // txtSenhaLocal
            // 
            this.txtSenhaLocal.Location = new System.Drawing.Point(157, 198);
            this.txtSenhaLocal.Name = "txtSenhaLocal";
            this.txtSenhaLocal.PasswordChar = '*';
            this.txtSenhaLocal.Size = new System.Drawing.Size(144, 22);
            this.txtSenhaLocal.TabIndex = 8;
            this.txtSenhaLocal.UseSystemPasswordChar = true;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(96, 254);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(205, 22);
            this.txtDominio.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(33, 322);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDominio);
            this.Controls.Add(this.txtSenhaLocal);
            this.Controls.Add(this.txtAdmLocal);
            this.Controls.Add(this.txtSenhaDom);
            this.Controls.Add(this.txtAdmDom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConfiguracao";
            this.Text = "Configuracao";
            this.Load += new System.EventHandler(this.Configuracao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtSenhaDom;
        public System.Windows.Forms.TextBox txtAdmLocal;
        public System.Windows.Forms.TextBox txtSenhaLocal;
        public System.Windows.Forms.TextBox txtDominio;
        internal TextBox txtAdmDom;
    }
}