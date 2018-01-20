using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.ServiceModel.Web;
using System.Runtime.Serialization.Formatters.Binary;
namespace ProjetoIngressarDominio
{
    public class Comandos
    {
        public int Qtd;
        //public string textLog;
        public static string text=string.Empty;
        public frmLog log = new frmLog(text.ToString() );
        //public frmLog Log { get => log; set => log = value; }
        
        //this.
        private string admDominio;
        private string senhaAdmDominio;
        private string admLocal;
        private string senhaAdmLocal;
        private string dominio;


        public string Dominio { get => dominio; set => dominio = value; }
        public string AdmDominio { get => admDominio; set => admDominio = value; }
        public string SenhaAdmDominio { get => senhaAdmDominio; set => senhaAdmDominio = value; }
        public string AdmLocal { get => admLocal; set => admLocal = value; }
        public string SenhaAdmLocal { get => senhaAdmLocal; set => senhaAdmLocal = value; }

        //Configuracao config; // Set by the property

        //public Configuracao Configuracao
        //{
        //    get { return config; }
        //    set { config = value; }
        //}

        public string argumento { get { return _argumento; } set { _argumento = value; } }

       

        //  public frmLog Log { get => Log1; set => Log1 = value; }
        //public frmLog Log1 { get => Log2; set => Log2 = value; }
        //  public frmLog Log2 { get => log2; set => log2 = value; }
        // public frmLog Log21 { get => log2; set => log2 = value; }

        private string _argumento;
        //Le e devolve a lista de IP
        

        public void Remover(string meuip)
        {
            //config = new Configuracao();

            try
            {
                Process netdom = new Process();
                Form1 form = new Form1();
                

                string txtAdmDom = frmConfiguracao.GetConfig("txtAdmDom");
                string txtSenhaDom = frmConfiguracao.GetConfig("txtSenhaDom");
                string txtAdmLocal = frmConfiguracao.GetConfig("txtAdmLocal");
                string txtSenhaLocal = frmConfiguracao.GetConfig("txtSenhaLocal");
                string txtDominio = frmConfiguracao.GetConfig("txtDominio");

                argumento = "remove " + meuip + " /domain:" + txtDominio + " /userd:" + txtAdmDom +
                " /passwordd: " + txtSenhaDom + " /usero:" + txtAdmLocal + " /passwordo:" + txtSenhaLocal + " /REBoot:15";

                netdom.StartInfo.FileName = "netdom.exe";
                netdom.StartInfo.Arguments = argumento;
                netdom.StartInfo.CreateNoWindow = true;
                netdom.StartInfo.UseShellExecute = false;
                netdom.StartInfo.RedirectStandardOutput = true;
                netdom.StartInfo.RedirectStandardInput = true;
                //netdom.StartInfo.RedirectStandardOutput = true;
                netdom.StartInfo.RedirectStandardError = true;

                netdom.Start();
                // frmLog log = new frmLog();
                text += " \n IP " + meuip + "\n";
                text += netdom.StandardError.ReadToEnd() + "\n\n";
                text += netdom.StandardOutput.ReadToEnd() + "\n\n";
                //log.ShowDialog();
                log.richTextBox1.Text = text.ToString();
                //form.log.ric(text.ToString());
                log.Refresh();
                
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Instale o pacote de Ferramentas RSAT");
            }
        }




        public void Ingressar(string meuip)
        {
            //config = new Configuracao();

            try
            {
                Process netdom = new Process();
                Form1 form = new Form1();



                string txtAdmDom = frmConfiguracao.GetConfig("txtAdmDom");
                string txtSenhaDom = frmConfiguracao.GetConfig("txtSenhaDom");
                string txtAdmLocal = frmConfiguracao.GetConfig("txtAdmLocal");
                string txtSenhaLocal = frmConfiguracao.GetConfig("txtSenhaLocal");
                string txtDominio = frmConfiguracao.GetConfig("txtDominio");

                argumento = "join " + meuip + " /domain:" + txtDominio + " /userd:" + txtAdmDom +
                " /passwordd: " + txtSenhaDom + " /usero:" + txtAdmLocal + " /passwordo:" + txtSenhaLocal + " /REBoot:15";

                netdom.StartInfo.FileName = "netdom.exe";
                netdom.StartInfo.Arguments = argumento;
                netdom.StartInfo.CreateNoWindow = true;
                netdom.StartInfo.UseShellExecute = false;
                netdom.StartInfo.RedirectStandardOutput = true;
                netdom.StartInfo.RedirectStandardInput = true;
                //netdom.StartInfo.RedirectStandardOutput = true;
                netdom.StartInfo.RedirectStandardError = true;

                netdom.Start();

                // text = netdom.StandardOutput.ReadToEnd();
                //log.ShowDialog();
                text += " \n IP " + meuip + "\n";
                text +=  netdom.StandardError.ReadToEnd()+ "\n\n" ;
                text +=  netdom.StandardOutput.ReadToEnd()+"\n\n" ;
                
                //log.ShowDialog();
                log.richTextBox1.Text = text.ToString();
                log.Refresh();

            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Instale o pacote de Ferramentas RSAT");
            }
        }


        public void Procurar()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Form1 menu = new Form1();
            ofd.Filter = "Cursor Files|*.txt";
            ofd.Title = "Selecione o arquivo";

            //StreamWriter lista;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(menu.caminho);
                StreamReader sr = new StreamReader(ofd.FileName);
                //lista = File.CreateText(menu.caminho);
                

                try
                {
                    sw.WriteLine(sr.ReadToEnd());
                    //sr.Close();
                    //sw.Close();
                    
                    sr.Dispose();
                    sw.Dispose();
                     sr.Close();
                    sw.Close();
                    Qtd = File.ReadAllLines(menu.caminho).Count();
                }

                catch (Exception e)
                {
                    MessageBox.Show("" + e);
                    sr.Close();
                    sw.Close();
                    sr.Dispose();
                    sw.Dispose();

                }
                finally
                {
                    sr.Close();
                    sw.Close();
                    sr.Dispose();
                    sw.Dispose();
                }
            }

        }
    }
}
