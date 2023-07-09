using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace PF_PVA
{
    public partial class LogIn : Form
    {
        Database database = new Database();
        public static string nombre;
        public static int id_usuario;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Los campos no deben de estar en blanco!", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlDataReader lector_usuarios;

                lector_usuarios = database.LeerBBDD("id, nombre_usuario, contrasena", "Usuarios",
                    "WHERE nombre_usuario = '" + txtUsuario.Text + "' and contrasena = '" + txtPassword.Text + "'");

                string username;
                string password;
                int id;
                bool usuarioEncontrado = false;

                while (lector_usuarios.Read())
                {
                    id = int.Parse(lector_usuarios["id"].ToString());
                    username = lector_usuarios["nombre_usuario"].ToString();
                    password = lector_usuarios["contrasena"].ToString();

                    if (username == txtUsuario.Text && password == txtPassword.Text)
                    {
                        usuarioEncontrado = true;
                        nombre = txtUsuario.Text;
                        id_usuario = id;
                        this.Visible = false;

                        Home home = new Home();
                        home.lblNombreUsuario.Text = "Hola, " + username + "!";

                        home.ShowDialog();
                        break;
                    }
                }

                if (!usuarioEncontrado)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (MessageBox.Show("¿Te gustaria registrarte?", "SIGN IN",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SignUp signUp = new SignUp();
                        signUp.txtUsuario.Text = txtUsuario.Text;
                        signUp.txtContrasena.Text = txtPassword.Text;

                        signUp.ShowDialog();
                    }
                    else
                    {
                        txtUsuario.Clear(); txtPassword.Clear(); txtUsuario.Focus();
                    }
                }

                lector_usuarios.Close();
                database.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar entrar en la app!!" + "\n\nError: " + ex, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear(); txtPassword.Clear(); txtUsuario.Focus();
            }
        }

        bool showPassword = false;

        private void pbViewPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtPassword.UseSystemPasswordChar = false;
                imgConstrasena.Image = Properties.Resources.ojo;
            }

            if (!showPassword)
            {
                imgConstrasena.Image = Properties.Resources.ver;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(null, null);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader lector_usuarios;

                lector_usuarios = database.LeerBBDD("*", "Usuarios", null);

                string mensaje = "Username - Password \n";

                while (lector_usuarios.Read())
                {
                    mensaje += lector_usuarios["nombre_usuario"].ToString() + " - " + lector_usuarios["contrasena"].ToString() + "\n";
                }

                MessageBox.Show(mensaje, "BBDD", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar entrar en la BBDD!!" + "\n\nError: " + ex, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignUp signIn = new SignUp();
                signIn.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No se ha podido acceder al formulario de registro, prueba mas tarde!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
