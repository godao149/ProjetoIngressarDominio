using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ProjetoIngressarDominio
{
    class ConfigIP
    {
        public bool Ping(string host, int attempts, int timeout)
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

            System.Net.NetworkInformation.PingReply pingReply;

            for (int i = 0; i < attempts; i++)
            {
                try
                {
                    pingReply = ping.Send(host, timeout);

                    // If there is a successful ping then return true.
                    if (pingReply != null &&
                        pingReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                        return true;
                }
                catch
                {
                    // Do nothing and let it try again until the attempts are exausted.
                    // Exceptions are thrown for normal ping failurs like address lookup
                    // failed.  For this reason we are supressing errors.
                }
            }

            // Return false if we can't successfully ping the server after several attempts.
            return false;
        }

        public string ObterIpUsuario()

        {

            IPHostEntry IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            var IpLocal = IPHostEntry.AddressList.Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Last().ToString();

            return IpLocal;

        }
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));


        }
        public bool Verifica(string ip)
        {
            Form1 menu = new Form1();
            
            try
            {
                if (ValidateIPv4(ip))
                {
                    menu.SetIP(ip);
                    return true;
                }
                else MessageBox.Show("Ip Inválido");
                return false;
            }
            catch
            {
                MessageBox.Show("Erro na validacao de IP");
                return false;
            }



        }

    }
}
