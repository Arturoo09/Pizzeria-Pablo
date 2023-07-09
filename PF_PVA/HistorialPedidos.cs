using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class HistorialPedidos : Form
    {
        Database database = new Database();

        public HistorialPedidos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            SqlDataReader lectorSQL;
            bool es_administrador = false;

            lectorSQL = database.LeerBBDD("es_administrador", "Usuarios",
                "WHERE id = " + LogIn.id_usuario);
            while (lectorSQL.Read())
            {
                if (lectorSQL["es_administrador"].ToString() == "True")
                {
                    es_administrador = true;
                }
            }

            if (es_administrador == true)
            {
                lectorSQL = database.LeerBBDD("*", "Pedidos", null);

                while (lectorSQL.Read())
                {
                    ListViewItem lvi = new ListViewItem(lectorSQL["id"].ToString());
                    lvi.SubItems.Add(lectorSQL["cliente_id"].ToString());
                    lvi.SubItems.Add(((DateTime)lectorSQL["fecha_pedido"]).ToString("dd-MM-yyyy"));
                    lvi.SubItems.Add(lectorSQL["direccion_entrega"].ToString());
                    lvi.SubItems.Add(lectorSQL["total"].ToString() + "€");

                    lvHistorial.Items.Add(lvi);
                }

                lectorSQL.Close();
                database.CerrarConexion();
            }
            else
            {
                lectorSQL = database.LeerBBDD("*", "Pedidos",
                "WHERE cliente_id = " + LogIn.id_usuario);

                while (lectorSQL.Read())
                {
                    ListViewItem lvi = new ListViewItem(lectorSQL["id"].ToString());
                    lvi.SubItems.Add(lectorSQL["cliente_id"].ToString());
                    lvi.SubItems.Add(((DateTime)lectorSQL["fecha_pedido"]).ToString("dd-MM-yyyy"));
                    lvi.SubItems.Add(lectorSQL["direccion_entrega"].ToString());
                    lvi.SubItems.Add(lectorSQL["total"].ToString() + "€");

                    lvHistorial.Items.Add(lvi);
                }

                lectorSQL.Close();
                database.CerrarConexion();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
