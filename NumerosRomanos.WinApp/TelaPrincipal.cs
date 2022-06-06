using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosRomanos.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private Conversor conversor = new Conversor();
        public TelaPrincipal()
        {
            InitializeComponent();
            labelNumeroRomano.Text = string.Empty;
            labelAviso.Text = string.Empty;
            
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
            var numeroRomano = textNumero.Text;
            var validado = conversor.ValidarNumeroRomano(numeroRomano);
            if (validado == true)
            {
                var numeroDecimal = conversor.Converter(numeroRomano);
                labelNumeroRomano.Text = Convert.ToString(numeroDecimal);
        }
            else
            {
                labelAviso.Text = "ESTE NUMERO É INVALIDO!!!";
            }
}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            labelNumeroRomano.Text = string.Empty;
            labelAviso.Text = string.Empty;
            textNumero.Clear();
        }
    }
}
