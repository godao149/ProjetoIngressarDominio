using System.Collections;
using System.Collections.Generic;
using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Windows.Forms;
using ConfigurationErrorsException = System.Exception;

namespace ProjetoIngressarDominio
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetConfig("txtAdmDom", txtAdmDom.Text);
            SetConfig("txtSenhaDom", txtSenhaDom.Text);
            SetConfig("txtAdmLocal", txtAdmLocal.Text);
            SetConfig("txtSenhaLocal", txtSenhaLocal.Text);
            SetConfig("txtDominio", txtDominio.Text);

            //frmConfiguracao.ActiveForm.Close();

            if (txtAdmDom.Text.Equals(""))
                MessageBox.Show("Insira o nome do Administrador de Dominio");
            //        else
            //          cmd.userdom = AdmDom();

            if (txtSenhaDom.Text.Equals(""))
                MessageBox.Show("Insira a senha do Administrador de Dominio");
            //    else
            //      cmd.passdom = PassDom();

            if (txtAdmLocal.Text.Equals(""))
                MessageBox.Show("Insira o nome do Administrador Local");
            //else
            //  cmd.useradm = AdmLoc();

            if (txtSenhaLocal.Text.Equals(""))
                MessageBox.Show("Insira a senha do Administrador Local");
            //            else
            //              cmd.passwdadm = PassLoc();

            if (txtDominio.Text.Equals(""))
                MessageBox.Show("Insira o nome de Dominio");
            //        else           
            //          cmd.domain = getDomain();

            if (!txtAdmDom.Text.Equals("") && !txtAdmLocal.Text.Equals("") && !txtDominio.Text.Equals("") && !txtSenhaDom.Text.Equals("") && !txtSenhaLocal.Text.Equals(""))
                frmConfiguracao.ActiveForm.Close();

            //{
            //    Comandos c = new Comandos
            //    {
            //        AdmDominio = txtAdmDom.Text,
            //        AdmLocal = txtAdmLocal.Text,
            //        SenhaAdmDominio = txtSenhaDom.Text,
            //        SenhaAdmLocal = txtSenhaLocal.Text,
            //        Dominio = txtDominio.Text
            //    };
            //    Form1 form1 = new Form1();
            //    form1.myClass = c;


            //    Hide();

        }
        /*public string AdmDom()
        {
            string usuario = txtAdmDom.Text;
            return usuario;
        }
        public string SenhaDom()
        {
            string senha = txtSenhaDom.Text;
            return senha;
        }
        public string AdmLocal()
        {
            string usuario = txtAdmLocal.Text;
            return usuario;
        }
        public string SenhaLocal()
        {
            string senha = txtSenhaLocal.Text;
            return senha;
        }
        public string Dominio()
        {
            string dominio = txtDominio.Text;
            return dominio;
        }*/

        private void txtAdmDom_TextChanged(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            if (!txtAdmDom.Equals("")) {
                menu.AdmDom = txtAdmDom.Text;
            }
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            txtAdmDom.Text = GetConfig("txtAdmDom");
            txtSenhaDom.Text = GetConfig("txtSenhaDom");
            txtAdmLocal.Text = GetConfig("txtAdmLocal");
            txtSenhaLocal.Text = GetConfig("txtSenhaLocal");
            txtDominio.Text = GetConfig("txtDominio");


        }

        public static void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        public static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
