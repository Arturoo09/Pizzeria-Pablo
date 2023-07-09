using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class SignUp : Form
    {
        Database database = new Database();

        public SignUp()
        {
            InitializeComponent();
            cbxAceptarPrivacidad.Enabled = false;
            cbxAceptarPrivacidad.Visible = false;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        bool showPP = false;

        private void btnPrivacidad_Click(object sender, System.EventArgs e)
        {
            try
            {
                showPP = !showPP;

                PoliticaPrivacidad pp = new PoliticaPrivacidad();
                pp.ShowDialog();

                if (pp.flag == 1)
                {
                    cbxAceptarPrivacidad.Checked = true;
                    imgPrivacidad.Image = Properties.Resources.me_gusta;
                }
                else
                {
                    cbxAceptarPrivacidad.Checked = false;
                    imgPrivacidad.Image = Properties.Resources.disgusto;
                }
            }
            catch 
            {
                MessageBox.Show("Error al intentar acceder al formulario!!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbxAceptarPrivacidad.Checked == true)
                {
                    if (txtUsuario.Text == "" || txtContrasena.Text == "" || txtNombre.Text == "" || txtEmail.Text == "" || txtTelefono.Text == "")
                    {
                        MessageBox.Show("Los campos no deben de estar en blanco!", "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string username = txtUsuario.Text;
                    string password = txtContrasena.Text;
                    string name = txtNombre.Text;
                    string email = txtEmail.Text;
                    string tlf = txtTelefono.Text;

                    bool usuarioExistente = false;
                    SqlDataReader lectorUsuario;
                    lectorUsuario = database.LeerBBDD("nombre_usuario", "Usuarios",
                        "WHERE nombre_usuario = '" + username + "'");
                    if (lectorUsuario.HasRows)
                    {
                        usuarioExistente = true;
                    }
                    lectorUsuario.Close();

                    if (usuarioExistente)
                    {
                        MessageBox.Show("El nombre de usuario ya existe en la base de datos.", "Advertencia",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Clear(); txtContrasena.Clear(); txtUsuario.Focus();
                        return;
                    }

                    bool credencialesValidas = false;
                    SqlDataReader lectorCredenciales;
                    lectorCredenciales = database.LeerBBDD("nombre_usuario, contrasena", "Usuarios",
                        "WHERE nombre_usuario = '" + username + "' AND contrasena = '" + password + "'");

                    if (!lectorCredenciales.HasRows)
                    {
                        credencialesValidas = true;
                    }
                    lectorCredenciales.Close();

                    if (!credencialesValidas)
                    {
                        MessageBox.Show("Credenciales inválidas.", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Clear(); txtContrasena.Clear(); txtUsuario.Focus();
                        return;
                    }

                    // Obtener el último id y sumar 1
                    SqlDataReader lectorId;
                    lectorId = database.LeerBBDD("TOP 1 id", "Usuarios", "ORDER BY id DESC");
                    int id = 1;
                    int admin = 0;
                    if (lectorId.HasRows)
                    {
                        lectorId.Read();
                        id = Convert.ToInt32(lectorId.GetValue(0)) + 1;
                    }
                    lectorId.Close();

                    database.InsertarBBDD("[dbo].[Usuarios] ([id], [nombre], [direccion], [telefono], [nombre_usuario], [contrasena], [es_administrador])",
                        id + ", N'" + name + "', N'" + email + "', N'" + tlf + "', N'" + username + "', N'" + password +"', N'" + admin + "'");

                    MessageBox.Show("Usuario Registrado con exito.\nVuelva a iniciar sesion para entrar a la app!", "REGISTRADO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    database.CerrarConexion();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Primero Debes Aceptar Nuestra Politica de Privacidad de Datos!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool showPassword = false;

        private void pbViewPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtContrasena.UseSystemPasswordChar = false;
                imgContrasena.Image = Properties.Resources.ojo;
            }

            if (!showPassword)
            {
                imgContrasena.Image = Properties.Resources.ver;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
    }
}
