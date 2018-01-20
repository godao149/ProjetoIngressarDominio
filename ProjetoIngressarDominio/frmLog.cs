using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIngressarDominio
{
    public partial class frmLog : Form
    {
        //Form1 form = new Form1();
        //Comandos cmd = new Comandos();

        public frmLog()
        {
            InitializeComponent();
        }
        public frmLog(string log)
        {
            InitializeComponent();
            richTextBox1.Text = log;
        }
        public frmLog(Form1 frm)
        {
            InitializeComponent();
            Form1 form = new Form1();
            form = frm;
            

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

     /*   public void RichTextBoxLog(string entrada)
        {
            //Form1 form = new Form1();
            //richTextBox1.Text += Convert.ToString(entrada);//form.log.Refresh();
            richTextBox1.Text = "teste";//Convert.ToString(entrada);
        }*/
            private void frmLog_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
