using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex05
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void brnConversor_Click(object sender, EventArgs e)

        {
            string nome;
            double dolar, real;
            nome = textNome.Text;
            dolar = Convert.ToDouble(textPreco.Text);

            real = dolar * 5.19;

            lblSaida.Text = nome+", "+dolar+" dolares é igual a "+real.ToString("#0.00")+" Reais";
        }
    }
}
