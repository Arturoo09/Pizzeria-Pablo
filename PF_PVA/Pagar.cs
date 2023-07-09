using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace PF_PVA
{
    public partial class Pagar : Form
    {
        Database database = new Database();

        List<ItemPedido> listaPedido = new List<ItemPedido>();
        public int idPedido;

        public Pagar(List<ItemPedido> lp, int id)
        {
            InitializeComponent();
            listaPedido = lp;
            idPedido = id;
        }

        private void Pagar_Load(object sender, EventArgs e)
        {
            SqlDataReader lector_usuario;

            lector_usuario = database.LeerBBDD("nombre, direccion, telefono","Usuarios","WHERE id = " + LogIn.id_usuario);

            string nombre;
            string email;
            string tlf;

            while (lector_usuario.Read())
            {
                nombre = lector_usuario["nombre"].ToString();
                email = lector_usuario["direccion"].ToString();
                tlf = lector_usuario["telefono"].ToString();

                txtNombre.Text = nombre;
                txtCorreo.Text = email;
                txtTelefono.Text = tlf;

                lblPrecioFinal.Text = Pedido.precioFinal.ToString();
            }

            lblPrecioFinal.Text = Pedido.precioFinal.ToString() + "€";

            lector_usuario.Close();
            database.CerrarConexion();

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtNumTrajeta.Text != "" && txtCaducidad.Text != ""
                && txtCodSeguridad.Text != "" && txtDirEntrega.Text != "")
            {

                decimal precioFinal = decimal.Parse(Pedido.precioFinal.ToString());
                string precioFinalStr = Convert.ToString(precioFinal, CultureInfo.InvariantCulture);

                database.ModificarBBDD("[dbo].[Pedidos]", "[total] = " + precioFinalStr, "WHERE [id] = " + idPedido);

                string nuevaDireccionEntrega = txtDirEntrega.Text;
                database.ModificarBBDD("[dbo].[Pedidos]", "[direccion_entrega] = '" + nuevaDireccionEntrega + "'", "WHERE [id] = " + idPedido);

                CrearFacturaExcel();

                listaPedido.Clear();
                Home.lblContador1 = "0";
                this.Close();

                Valoracion valoracion = new Valoracion();
                valoracion.Show();
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearFacturaExcel()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Add();
            Worksheet excelWorksheet = excelWorkbook.ActiveSheet;

            excelWorksheet.Cells[1, 1] = "FACTURA";
            excelWorksheet.Cells[2, 1] = "Nombre del Producto: ";
            excelWorksheet.Cells[3, 1] = "Cantidad: ";
            excelWorksheet.Cells[4, 1] = "Precio Unitario: ";
            excelWorksheet.Cells[5, 1] = "Total: ";

            excelWorksheet.Cells[7, 1] = "Total: " + lblPrecioFinal.Text;

            Range range1 = excelWorksheet.Cells[1, 1];
            range1.Interior.ColorIndex = 1;
            range1.Font.ColorIndex = 2;
            range1.EntireRow.Font.Bold = true;

            Range range2 = excelWorksheet.Range[excelWorksheet.Cells[2, 1], excelWorksheet.Cells[5, 1]];
            range2.Interior.ColorIndex = 15;
            range2.Font.ColorIndex = 2;

            int i = 2;
            int j = 3;

            foreach (ItemPedido item in Pedido.listaPedidoDefinitiva)
            {
                excelWorksheet.Cells[i, j] = "Nombre del Producto: " + item.nombre;
                excelWorksheet.Cells[i + 1, j] = "Cantidad: " + item.cantidad;
                excelWorksheet.Cells[i + 2, j] = "Precio Unitario: " + item.precio;
                excelWorksheet.Cells[i + 3, j] = "Total: " + (item.precio * item.cantidad);
                j += 2;
            }

            excelWorksheet.Columns[1].AutoFit();

            for (int k = 1; k < Pedido.listaPedidoDefinitiva.Count; k++)
            {
                excelWorksheet.Columns[k * 2 + 1].AutoFit();
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Factura.xlsx";
                saveFileDialog.InitialDirectory = @"C:\MiCarpeta\";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    excelWorkbook.SaveAs(filePath);
                }
            }

            excelWorkbook.Close();
            excelApp.Quit();
        }
    }
}
