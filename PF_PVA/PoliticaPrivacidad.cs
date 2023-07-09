using System;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class PoliticaPrivacidad : Form
    {
        public PoliticaPrivacidad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoliticaPrivacidad_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        private void rbtnNoAceptar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        private void rbtnAceptar_CheckedChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        public int flag = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            flag = 1;
            this.Close();
        }
    }
}
