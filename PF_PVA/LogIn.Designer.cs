namespace PF_PVA
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgConstrasena = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.linkLblSignup = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.imgIntro = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConstrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(562, 155);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 29);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "PIZZERIA PABLO";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(497, 587);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(117, 32);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(600, 131);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(156, 24);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "WELCOME TO";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(725, 587);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.imgConstrasena);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.linkLblSignup);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(497, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 337);
            this.panel1.TabIndex = 7;
            // 
            // imgConstrasena
            // 
            this.imgConstrasena.Image = global::PF_PVA.Properties.Resources.ver;
            this.imgConstrasena.Location = new System.Drawing.Point(280, 179);
            this.imgConstrasena.Name = "imgConstrasena";
            this.imgConstrasena.Size = new System.Drawing.Size(29, 20);
            this.imgConstrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConstrasena.TabIndex = 8;
            this.imgConstrasena.TabStop = false;
            this.imgConstrasena.Click += new System.EventHandler(this.pbViewPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(70, 79);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // linkLblSignup
            // 
            this.linkLblSignup.AutoSize = true;
            this.linkLblSignup.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblSignup.Location = new System.Drawing.Point(153, 295);
            this.linkLblSignup.Name = "linkLblSignup";
            this.linkLblSignup.Size = new System.Drawing.Size(45, 13);
            this.linkLblSignup.TabIndex = 5;
            this.linkLblSignup.TabStop = true;
            this.linkLblSignup.Text = "Sign Up";
            this.linkLblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSignIn_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(70, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(116, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(90, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(169, 22);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de Usuario";
            // 
            // imgIntro
            // 
            this.imgIntro.Image = global::PF_PVA.Properties.Resources.pizze_varie_di_gianni;
            this.imgIntro.Location = new System.Drawing.Point(12, 12);
            this.imgIntro.Name = "imgIntro";
            this.imgIntro.Size = new System.Drawing.Size(462, 607);
            this.imgIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIntro.TabIndex = 10;
            this.imgIntro.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.SystemColors.Window;
            this.imgLogo.Image = global::PF_PVA.Properties.Resources.pizza;
            this.imgLogo.Location = new System.Drawing.Point(591, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(165, 106);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 6;
            this.imgLogo.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(856, 633);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.imgIntro);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgConstrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox imgIntro;
        private System.Windows.Forms.PictureBox imgLogo;
        public System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgConstrasena;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel linkLblSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
    }
}