using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Hsitorico_Calculadora : Form
    {
        public Hsitorico_Calculadora()
        {
            InitializeComponent();
            rtbHistorico.Text = Historico.CarregarHistorico();
        }

        private void Hsitorico_Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void rtbHistorico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            Historico.LimparHistorico();
            rtbHistorico.Text = "Histórico apagado.";
        }
    }
}
