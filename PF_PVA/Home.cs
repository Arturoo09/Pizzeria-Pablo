using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class Home : Form
    {
        Database database = new Database();
        bool signOutFlag = false;
        
        List<ItemPedido> listaPedido = new List<ItemPedido>();

        public static List<string> listaIngredientes;
 
        public static string lblContador1;
        public static string nombrePP;
        public static decimal precioPP;

        public Home()
        {
            InitializeComponent();
            InicializarPizzas();
            InicializarIngredientes();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que quieres cerrar sesion?", "¿SEGURO?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    signOutFlag = true;
                    this.Close();
                    Application.OpenForms["LogIn"].Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Ha habido un error al cerrar la sesion!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (signOutFlag == false)
            {
                Application.Exit();
            }
        }

        private void imgPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

                SqlDataReader lectorId;
                lectorId = database.LeerBBDD("TOP 1 id", "Pedidos", "ORDER BY id DESC");
                int id = 1;
                if (lectorId.HasRows)
                {
                    lectorId.Read();
                    id = Convert.ToInt32(lectorId.GetValue(0)) + 1;
                }

                database.InsertarBBDD("[dbo].[Pedidos] ([id], [cliente_id], [fecha_pedido], [direccion_entrega], [total])",
                    id + ", " + LogIn.id_usuario + "," + "N'" + fechaActual +"'" + ",N'Calle Ejemplo 123', CAST(99.99 AS Decimal(8, 2))");

                Pedido pedido = new Pedido(listaPedido, id, listaPersonalizada);
                pedido.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido crear el pedido!" + "\n\nError: " + ex, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InicializarPizzas()
        {
            SqlDataReader lectorSQL;

            for (int i = 1; i <= 8; i++)
            {
                lectorSQL = database.LeerBBDD("nombre, descripcion, precio", "Pizzas",
                "WHERE id = '" + i + "'");

                while (lectorSQL.Read())
                {
                    ItemPedido item = new ItemPedido
                    {
                        nombre = lectorSQL["nombre"].ToString(),
                        descripcion = lectorSQL["descripcion"].ToString(),
                        precio = decimal.Parse(lectorSQL["precio"].ToString())
                    };

                    listaPedido.Add(item);
                }
                lectorSQL.Close();
            }

            database.CerrarConexion();
        }

        private void btnAñadirPedidoPizzasPersonalizadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbxIngredientes.CheckedItems.Count != 0)
                {
                    PedirItem(9, lblNombre.Text);
                }
                else
                {
                    MessageBox.Show("Primero debes seleccionar al menos 1 ingrediente!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha habido un error al cargar el pedido!" + "\n\nError: " + ex, "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ItemPedido> listaPersonalizada = new List<ItemPedido>();

        private void PedirItem(int id, string nombre)
        {
            switch (id)
            {
                case 1:
                    listaPedido[0].cantidad++;
                    MessageBox.Show("Se ha anadido Margarita a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 2:
                    listaPedido[1].cantidad++;
                    MessageBox.Show("Se ha anadido Napolitana a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 3:
                    listaPedido[2].cantidad++;
                    MessageBox.Show("Se ha anadido Siciliana a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 4:
                    listaPedido[3].cantidad++;
                    MessageBox.Show("Se ha anadido Hawaiana a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 5:
                    listaPedido[4].cantidad++;
                    MessageBox.Show("Se ha anadido Barbacoa a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 6:
                    listaPedido[5].cantidad++;
                    MessageBox.Show("Se ha anadido Cuatro Quesos a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 7:
                    listaPedido[6].cantidad++;
                    MessageBox.Show("Se ha anadido Pepperoni a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case 8:
                    listaPedido[7].cantidad++;
                    MessageBox.Show("Se ha anadido Vegetariana a el pedido correctamente", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case 9: // Para pizzas personalizadas

                    listaIngredientes = new List<string>();

                    foreach (object ingredientes in clbxIngredientes.CheckedItems)
                    {
                        listaIngredientes.Add(ingredientes.ToString());
                    }

                    string listaSeleccionados = string.Join(", ", listaIngredientes);

                    ItemPedido nuevaPizza = new ItemPedido
                    {
                        nombre = lblNombre.Text,
                        descripcion = listaSeleccionados,
                        precio = decimal.Parse(lblPrecioPP.Text),
                        cantidad = 1
                    };

                    precioPP = decimal.Parse(lblPrecioPP.Text);
                    nombrePP = lblNombre.Text;
                    listaPersonalizada.Add(nuevaPizza);

                    bool hayPersonalizada = false;

                    foreach (ItemPedido i in listaPedido)
                    {
                        if (i.nombre == nombrePP)
                        {
                            hayPersonalizada = true;
                            MessageBox.Show("Ya hay una pizza con el nombre: " + nombre, "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    if(!hayPersonalizada)
                    {
                        listaPedido.Add(nuevaPizza);
                        MessageBox.Show("Se ha añadido " + nombre + " a el pedido correctamente", "OK",
                            MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    break;
            }

            int totalProductos = 0;
            for (int i = 0; i < listaPedido.Count; i++)
            {
                totalProductos += listaPedido[i].cantidad;
            }
            lblContador.Text = totalProductos.ToString();

            lblContador1 = lblContador.Text;
        }

        private void btnP1Compra_Click(object sender, EventArgs e)
        {
            PedirItem(1, null);
        }

        private void btnP2Compra_Click(object sender, EventArgs e)
        {
            PedirItem(2, null);
        }

        private void btnP3Compra_Click(object sender, EventArgs e)
        {
            PedirItem(3, null);
        }

        private void btnP4Compra_Click(object sender, EventArgs e)
        {
            PedirItem(4, null);
        }

        private void btnP5Compra_Click(object sender, EventArgs e)
        {
            PedirItem(5, null);
        }

        private void btnP6Compra_Click(object sender, EventArgs e)
        {
            PedirItem(6, null);
        }

        private void btnP7Compra_Click(object sender, EventArgs e)
        {
            PedirItem(7, null);
        }

        private void btnP8Compra_Click(object sender, EventArgs e)
        {
            PedirItem(8, null);
        }

        private void InicializarIngredientes()
        {
            try
            {
                clbxIngredientes.Items.Clear();

                List<string> listaIngredientes = new List<string>();

                SqlDataReader lector_ingredientes;

                lector_ingredientes = database.LeerBBDD("nombre", "Ingredientes", null);

                while (lector_ingredientes.Read())
                {
                    listaIngredientes.Add(lector_ingredientes["nombre"].ToString());
                }

                lector_ingredientes.Close();
                database.CerrarConexion();

                foreach (string ingrediente in listaIngredientes)
                {
                    clbxIngredientes.Items.Add(ingrediente);
                }
            }
            catch
            { 
                MessageBox.Show("Ha habido un error al cargar el formulario 'Home'", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void clbxIngredientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (clbxIngredientes.CheckedItems.Count == 5 && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Solo puedes seleccionar hasta 5 ingredientes!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.NewValue = e.CurrentValue;
            }
        }

        private void btnLimpiarIngredientes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbxIngredientes.Items.Count; i++)
            {
                clbxIngredientes.SetItemChecked(i, false);
            }
        }

        private void btnCambiarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                lblNombre.Text = txtNombre.Text;
                txtNombre.Clear();
                txtNombre.Focus();
            }
            catch
            {
                MessageBox.Show("No se ha podido cambiar el nombre de tu Pizza Personalizada!!", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnCambiarNombre_Click(null, null);
            }
        }

        private void imgHistorial_Click(object sender, EventArgs e)
        {
            HistorialPedidos historialPedidos = new HistorialPedidos();
            historialPedidos.Show();
        }

        private void btnO1Compra_Click(object sender, EventArgs e)
        {
            ElegirPizza elegirPizza = new ElegirPizza(0, listaPedido);
            elegirPizza.Show();

            int totalProductos = 0;
            for (int i = 0; i < listaPedido.Count; i++)
            {
                totalProductos += listaPedido[i].cantidad;
            }

            totalProductos += 1;
            lblContador.Text = totalProductos.ToString();

            lblContador1 = lblContador.Text;
        }

        private void btnO2Compra_Click(object sender, EventArgs e)
        {
            ElegirPizza elegirPizza = new ElegirPizza(1, listaPedido);
            elegirPizza.Show();

            int totalProductos = 0;
            for (int i = 0; i < listaPedido.Count; i++)
            {
                totalProductos += listaPedido[i].cantidad;
            }

            totalProductos += 1;
            lblContador.Text = totalProductos.ToString();

            lblContador1 = lblContador.Text;
        }
    }
}
