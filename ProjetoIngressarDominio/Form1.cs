using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProjetoIngressarDominio
{
    public partial class Form1 : Form
    {

        internal Comandos myClass = new Comandos();

        public Form1()
        {
            InitializeComponent();


        }


        public string caminho = System.IO.Path.GetTempPath() + "temp.txt";
        private string ipv4;

        public void SetIP(string ipv)
        {
            ipv4 = ipv;

        }

        public string GetIP()
        {

            return ipv4;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string AdmDom { get; set; }
        internal Comandos MyClass { get => myClass; set => myClass = value; }

        private void button_Ingressar(object sender, EventArgs e)
        {
            SetIP(txtIP.Text);
            ConfigIP confIP = new ConfigIP();

            frmConfiguracao config = new frmConfiguracao();
            Comandos cmd = new Comandos();
            //cmd.Log = new frmLog();
            if (rdoIP.Checked && confIP.Verifica(GetIP()))
            {
                cmd.log.Show();
                cmd.Ingressar(GetIP());
                lblStatus.Text = GetIP();
                //cmd.ingressar(config.SenhaDom(),AdmDom,config.AdmLocal(),config.SenhaLocal(),config.Dominio(), GetIP());
            }
            else if (rdoLista.Checked)
            {
                frmConfiguracao configuracao = new frmConfiguracao();
                StreamReader sr = new StreamReader(caminho);
                ///Comandos cmd = new Comandos();
                try
                {
                    var listaip = listaIP();
                    string resultIP = string.Empty;
                    cmd.log.Show();
                    progressBar1.Value = 0;
                    progressBar1.Maximum = listaip.Count;
                    foreach (var lista in listaip)
                    {
                        resultIP = sr.ReadLine();
                        if (string.IsNullOrEmpty(lista)) { progressBar1.Value += 1; continue; }
                        lblStatus.Text = resultIP;
                        cmd.Ingressar(lista);
                        cmd.log.Refresh();
                        progressBar1.Value += 1;
                    }



                    // sr.Dispose();
                }
                catch (System.ArgumentNullException)
                {

                    caminho = System.IO.Path.GetTempPath() + "temp.txt";
                }

            }
        }


        private void button_Procurar(object sender, EventArgs e)
        {
            Comandos cmd = new Comandos();
            cmd.Procurar();
            lblQtdIp.Text = cmd.Qtd.ToString() + " IPs";
        }

        private void button_Configuracao(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            config.ShowDialog();
        }

        private void button_Remover(object sender, EventArgs e)
        {
            SetIP(txtIP.Text);
            ConfigIP confIP = new ConfigIP();

            frmConfiguracao config = new frmConfiguracao();
            Comandos cmd = new Comandos();
            //cmd.Log = new frmLog();
            if (rdoIP.Checked && confIP.Verifica(GetIP()))
            {
                cmd.log.Show();
                cmd.Remover(GetIP());
                lblStatus.Text = GetIP();
                //cmd.ingressar(config.SenhaDom(),AdmDom,config.AdmLocal(),config.SenhaLocal(),config.Dominio(), GetIP());
            }
            else if (rdoLista.Checked)
            {
                frmConfiguracao configuracao = new frmConfiguracao();
                StreamReader sr = new StreamReader(caminho);
                ///Comandos cmd = new Comandos();
                try
                {
                    var listaip = listaIP();
                    string resultIP = string.Empty;
                    cmd.log.Show();
                    progressBar1.Value = 0;
                    progressBar1.Maximum = listaip.Count;
                    foreach (var lista in listaip)
                    {
                        resultIP = sr.ReadLine();
                        if (string.IsNullOrEmpty(lista)) { progressBar1.Value += 1; continue; }
                        lblStatus.Text = resultIP;
                        cmd.Remover(lista);
                        cmd.log.Refresh();
                        progressBar1.Value += 1;


                    }
                    // sr.Dispose();
                }
                catch (System.ArgumentNullException)
                {

                    caminho = System.IO.Path.GetTempPath() + "temp.txt";
                }

            }
        }

        public List<string> listaIP()
        {
            StreamReader sr = new StreamReader(caminho);
            Comandos cmd = new Comandos();
            List<string> iptexto = new List<string>();
            int qtd = File.ReadAllLines(caminho).Count();
            for (int i = 1; i <= qtd; i++)
            {
                //foreach (string ips in sr.ReadToEnd().ToString() ) {

                iptexto.Add(sr.ReadLine());

            }

            sr.Dispose();
            return iptexto;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            config.ShowDialog();
        }

        private void rdoLista_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
