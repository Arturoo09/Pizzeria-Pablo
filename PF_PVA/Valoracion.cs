using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class Valoracion : Form
    {
        public Valoracion()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtValoracion.Text != "")
            {
                this.Close();
                MessageBox.Show("Gracias por su valoración", "GRACIAS!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe rellenar el comentario", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
