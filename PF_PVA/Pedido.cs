using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class Pedido : Form
    {
        Database database = new Database();
        List<ItemPedido> listaPedido = new List<ItemPedido>();
        List<ItemPedido> listaPizzasPersonalizadas = new List<ItemPedido>();
        public static List<ItemPedido> listaPedidoDefinitiva = new List<ItemPedido>();


        public int idPedido;
        public static decimal precioFinal;

        public Pedido(List<ItemPedido> lp, int id, List<ItemPedido> listaPP)
        {
            InitializeComponent();

            listaPedido = lp;
            idPedido = id;
            listaPizzasPersonalizadas = listaPP;

            AnadirItems();
            CalcularPrecio();
        }

        private void AnadirItems()
        {
            listView1.Items.Clear();

            foreach (ItemPedido i in listaPedido)
            {
                if (i.cantidad > 0)
                {
                    ListViewItem lvi = new ListViewItem(i.cantidad.ToString());
                    lvi.SubItems.Add(i.nombre);
                    lvi.SubItems.Add(i.descripcion);
                    lvi.SubItems.Add((i.precio * i.cantidad).ToString());

                    listView1.Items.Add(lvi);
                }

                int totalProductos = 0;
                for (int x = 0; x < listaPedido.Count; x++)
                {
                    totalProductos += listaPedido[x].cantidad;
                }
                Home.lblContador1 = totalProductos.ToString();
            }
        }

        private void CalcularPrecio()
        {
            decimal precioTotal = 0;

            foreach (ItemPedido i in listaPedido)
            {
                precioTotal += (i.precio * i.cantidad);
            }

            precioFinal = precioTotal;

            lblTotal.Text = "Total: " + precioTotal + "€";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btnMas.Visible = true;
                btnMenos.Visible = true;
                txtCant.Visible = true;

                txtCant.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            }

            else
            {
                btnMas.Visible = false;
                btnMenos.Visible = false;
                txtCant.Visible = false;
            }
        }

        private int BuscarPizza(string nombre)
        {
            int indice = 0;

            switch (nombre)
            {
                case "Margarita":
                    indice = 0;
                    break;

                case "Napolitana":
                    indice = 1;
                    break;

                case "Siciliana":
                    indice = 2;
                    break;

                case "Hawaiana":
                    indice = 3;
                    break;

                case "Barbacoa":
                    indice = 4;
                    break;

                case "Cuatro Quesos":
                    indice = 5;
                    break;

                case "Pepperoni":
                    indice = 6;
                    break;

                case "Vegetariana":
                    indice = 7;
                    break;

                default:
                    bool encontrado = false;

                    for (int i = 0; i < listaPedido.Count; i++)
                    {
                        if (listaPedido[i].nombre == nombre)
                        {
                            indice = i;
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        for (int i = 0; i < listaPizzasPersonalizadas.Count; i++)
                        {
                            if (listaPizzasPersonalizadas[i].nombre == nombre)
                            {
                                indice = 8 + i;
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    if (!encontrado)
                    {
                        MessageBox.Show("No se ha encontrado la pizza.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            return indice;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            int indice = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            int indicePizza = BuscarPizza(listView1.SelectedItems[0].SubItems[1].Text.ToString());

            listaPedido[indicePizza].cantidad++;
            AnadirItems();
            CalcularPrecio();
            listView1.Items[indice].Selected = true;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            int indicePizza = BuscarPizza(listView1.SelectedItems[0].SubItems[1].Text.ToString());

            listaPedido[indicePizza].cantidad--;

            if (listaPedido[indicePizza].cantidad == 0)
            {
                if (MessageBox.Show("¿Seguro que quiere eliminar este item por completo?", "Borrar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnMas.Visible = false;
                    btnMenos.Visible = false;
                    txtCant.Visible = false;

                    BorrarPizzaPersonalizada(listaPedido[indicePizza].nombre);

                }
                else
                {
                    listaPedido[indicePizza].cantidad++;
                }
                AnadirItems();
                CalcularPrecio();
            }
            else
            {
                AnadirItems();
                CalcularPrecio();
                listView1.Items[indice].Selected = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indicePizza = BuscarPizza(listView1.SelectedItems[0].SubItems[1].Text.ToString());

                if (MessageBox.Show("¿Seguro que quiere eliminar este item por completo?", "Borrar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaPedido[indicePizza].cantidad = 0;
                    BorrarPizzaPersonalizada(listaPedido[indicePizza].nombre);

                    btnMas.Visible = false;
                    btnMenos.Visible = false;
                    txtCant.Visible = false;

                    AnadirItems();
                    CalcularPrecio();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un ítem", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarPizzaPersonalizada(string nombre)
        {
            foreach (ItemPedido item in listaPizzasPersonalizadas)
            {
                if (item.nombre == nombre)
                {
                    listaPizzasPersonalizadas.Remove(item);
                    listaPedido.Remove(item);
                    break;
                }
            }
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Home.lblContador1 == "0")
                {
                    throw new Exception();
                }

                InsertarPizzasBBDD();
                AnadirDetallesPedido();

                this.Close();
                Pagar pagar = new Pagar(listaPedido, idPedido);
                pagar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe haber al menos un ítem para pagar!" + "\n\nError: " + ex, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarPizzasBBDD()
        {
            int cont = 0;

            foreach (ItemPedido item in listaPedido)
            {
                if (item.cantidad != 0)
                {
                    cont++;
                    listaPedidoDefinitiva.Add(item);
                }
            }

            for (int i = 0; i < cont; i++)
            {
                if (ComprobarPP(listaPedidoDefinitiva[i], listaPizzasPersonalizadas))
                {
                    SqlDataReader lectorId;
                    lectorId = database.LeerBBDD("TOP 1 id", "Pizzas_personalizadas", "ORDER BY id DESC");
                    int id_pp = 1;
                    if (lectorId.HasRows)
                    {
                        lectorId.Read();
                        id_pp = Convert.ToInt32(lectorId.GetValue(0)) + 1;
                    }

                    database.InsertarBBDD("[dbo].[Pizzas_personalizadas]([id], [nombre], [precio], [pedido_id])",
                        id_pp + ", '" + listaPedidoDefinitiva[i].nombre + "', CAST( 5.95 AS Decimal(5, 2)), " + idPedido);


                    List<string> listaIngredientesDefinitiva = listaPedidoDefinitiva[i].descripcion.Split(new string[] { ", " }, 
                        StringSplitOptions.None).ToList();

                    foreach (string ingrediente in listaIngredientesDefinitiva)
                    {
                        SqlDataReader lectorIdDetallesPP;

                        lectorIdDetallesPP = database.LeerBBDD("TOP 1 id", "Detalles_ingredientes_pizza_personalizada", "ORDER BY id DESC");
                        int id = 1;
                        if (lectorIdDetallesPP.HasRows)
                        {
                            lectorIdDetallesPP.Read();
                            id = Convert.ToInt32(lectorIdDetallesPP.GetValue(0)) + 1;
                        }

                        database.InsertarBBDD("[dbo].[Detalles_ingredientes_pizza_personalizada]([id], [pizza_personalizada_id], [ingrediente])",
                            id + ", " + id_pp + ", '" + ingrediente + "'");
                    }
                }
            }
        }

        private bool ComprobarPP(ItemPedido item, List<ItemPedido> listaPP)
        {
            foreach (ItemPedido i in listaPP)
            {
                if (i.nombre == item.nombre && i.descripcion == item.descripcion)
                {
                    return true;
                }
            }

            return false;
        }

        private void AnadirDetallesPedido()
        {
            foreach (ItemPedido item in listaPedidoDefinitiva)
            {
                SqlDataReader lectorIdDetallesPedido;

                lectorIdDetallesPedido = database.LeerBBDD("TOP 1 id", "Detalles_pedido", "ORDER BY id DESC");
                int id = 1;
                if (lectorIdDetallesPedido.HasRows)
                {
                    lectorIdDetallesPedido.Read();
                    id = Convert.ToInt32(lectorIdDetallesPedido.GetValue(0)) + 1;
                }

                if (ComprobarPP(item, listaPizzasPersonalizadas))
                {
                    SqlDataReader lector_id_pp;

                    lector_id_pp = database.LeerBBDD("id", "Pizzas_personalizadas",
                        "WHERE nombre = '" + item.nombre + "'");

                    int id_pp;

                    while (lector_id_pp.Read())
                    {
                        id_pp = int.Parse(lector_id_pp["id"].ToString());

                        database.InsertarBBDD("[dbo].[Detalles_pedido]([id], [pedido_id], [pizza_id], [cantidad])",
                            id + ", " + idPedido + ", " + id_pp + ", " + item.cantidad);
                    }
                }
                else
                {
                    SqlDataReader lector_id_pizza;

                    lector_id_pizza = database.LeerBBDD("id", "Pizzas",
                        "WHERE nombre = '" + item.nombre + "'");

                    int id_pizza;

                    while (lector_id_pizza.Read())
                    {
                        id_pizza = int.Parse(lector_id_pizza["id"].ToString());

                        database.InsertarBBDD("[dbo].[Detalles_pedido]([id], [pedido_id], [pizza_id], [cantidad])",
                            id + ", " + idPedido + ", " + id_pizza + ", " + item.cantidad);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("El pedido se eliminará por completo ¿Estas seguro?", "¿SEGURO?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    database.EliminarFilaBBDD("Pedidos", "WHERE id = " + idPedido);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ha habido un error al cerrar el pedido!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
