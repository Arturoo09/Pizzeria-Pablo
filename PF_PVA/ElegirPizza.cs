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
    public partial class ElegirPizza : Form
    {
        Database database = new Database();
        int mode;
        List<ItemPedido> listaPedido = new List<ItemPedido>();
        decimal precioTotal = 0;

        public ElegirPizza(int mode, List<ItemPedido> lp)
        {
            InitializeComponent();
            InicializarPizzas();
            this.mode = mode;
            listaPedido = lp;
        }

        private void InicializarPizzas()
        {
            try
            {
                clbElegirPizza.Items.Clear();

                List<string> listaPizzas = new List<string>();

                SqlDataReader lectorSQL;

                lectorSQL = database.LeerBBDD("nombre", "Pizzas", null);

                while (lectorSQL.Read())
                {
                    listaPizzas.Add(lectorSQL["nombre"].ToString());
                }

                lectorSQL.Close();

                foreach (string pizza in listaPizzas)
                {
                    clbElegirPizza.Items.Add(pizza);
                }

                lectorSQL.Close();
            }
            catch
            {
                MessageBox.Show("Ha habido un error al cargar el formulario 'Elegir Pizza'", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAnadirPedido_Click(object sender, EventArgs e)
        {
            if(mode == 0)
            {
                if (clbElegirPizza.CheckedItems.Count > 2)
                {
                    List<string> listaPizzas = new List<string>();

                    foreach (object pizzas in clbElegirPizza.CheckedItems)
                    {
                        listaPizzas.Add(pizzas.ToString());
                    }

                    string pizzasSeleccionadas = string.Join(", ", listaPizzas);

                    ItemPedido nuevaPizza = new ItemPedido
                    {
                        nombre = "OFERTA 50%",
                        descripcion = pizzasSeleccionadas,
                        precio = decimal.Parse(lblPrecioOk.Text.Replace("€", "")),
                        cantidad = 1
                    };

                    listaPedido.Add(nuevaPizza);

                    MessageBox.Show("Se ha anadido la OFERTA 50% a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiene que seleccionar al menos 3 pizzas", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (clbElegirPizza.CheckedItems.Count == 2)
                {
                    ItemPedido nuevaPizza = new ItemPedido
                    {
                        nombre = "OFERTA 2X1",
                        descripcion = clbElegirPizza.CheckedItems[0].ToString() + " & " +
                        clbElegirPizza.CheckedItems[1].ToString(),
                        precio = decimal.Parse(lblPrecioOk.Text.Replace("€", "")),
                        cantidad = 1
                    };

                    listaPedido.Add(nuevaPizza);

                    MessageBox.Show("Se ha anadido la OFERTA 2x1 a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiene que seleccionar 2 pizzas", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbElegirPizza.Items.Count; i++)
            {
                clbElegirPizza.SetItemChecked(i, false);
            }
            lblTotal.Visible = false;
            lblPrecio.Visible = false;
            lblPrecioOk.Visible = false;
        }

        private void clbElegirPizza_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (mode == 0 && clbElegirPizza.CheckedItems.Count >= 2)
            {
                SqlDataReader lectorSQL;
                precioTotal = 0;

                foreach(int i in clbElegirPizza.CheckedIndices)
                {
                    lectorSQL = database.LeerBBDD("precio", "Pizzas", "WHERE id = '" + (i + 1) + "'");
                    while (lectorSQL.Read())
                    {
                        precioTotal += decimal.Parse(lectorSQL["precio"].ToString());
                    }
                }

                lectorSQL = database.LeerBBDD("precio", "Pizzas", "WHERE id = '" + (e.Index + 1) + "'");
                while (lectorSQL.Read())
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        precioTotal += decimal.Parse(lectorSQL["precio"].ToString());
                    }
                    else
                    {
                        precioTotal -= decimal.Parse(lectorSQL["precio"].ToString());
                    }
                }

                lectorSQL.Close();
                lblTotal.Visible = true;
                lblPrecio.Visible = true;
                lblPrecioOk.Visible = true;
                lblPrecio.Text = precioTotal + "€";
                lblPrecioOk.Text = Math.Round(precioTotal / 2, 2) + "€";
            }

            if (mode == 1 && clbElegirPizza.CheckedItems.Count == 2 && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Solo puedes seleccionar 2 pizzas!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = e.CurrentValue;
            }

            if(mode == 1 && clbElegirPizza.CheckedItems.Count == 1 && e.NewValue == CheckState.Checked)
            {
                SqlDataReader lectorSQL;
                decimal precioPizza1 = 0;
                decimal precioPizza2 = 0;
                precioTotal = 0;

                lectorSQL = database.LeerBBDD("precio", "Pizzas", "WHERE id = '" + (clbElegirPizza.CheckedIndices[0] + 1) + "'");
                while (lectorSQL.Read())
                {
                    precioTotal += decimal.Parse(lectorSQL["precio"].ToString());
                    precioPizza1 = decimal.Parse(lectorSQL["precio"].ToString());
                }

                lectorSQL = database.LeerBBDD("precio", "Pizzas", "WHERE id = '" + (e.Index + 1) + "'");
                while (lectorSQL.Read())
                {
                    precioTotal += decimal.Parse(lectorSQL["precio"].ToString());
                    precioPizza2 = decimal.Parse(lectorSQL["precio"].ToString());
                }

                lectorSQL.Close();
                lblTotal.Visible = true;
                lblPrecio.Visible = true;
                lblPrecioOk.Visible = true;
                lblPrecio.Text = precioTotal + "€";
                if(precioPizza1 > precioPizza2)
                {
                    lblPrecioOk.Text = precioPizza1 + "€";
                }
                else
                {
                    lblPrecioOk.Text = precioPizza2 + "€";
                }
            }
        }
    }
}
