namespace PF_PVA
{
    partial class Pedido
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
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.PictureBox();
            this.btnMenos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(367, 273);
            this.txtCant.Multiline = true;
            this.txtCant.Name = "txtCant";
            this.txtCant.ReadOnly = true;
            this.txtCant.Size = new System.Drawing.Size(30, 30);
            this.txtCant.TabIndex = 42;
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCant.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(327, 393);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 20);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total: 00,00€";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(12, 373);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(120, 40);
            this.btnPagar.TabIndex = 40;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 226);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cant.";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripción";
            this.columnHeader3.Width = 248;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 48;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(158, 9);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(133, 29);
            this.lblSignUp.TabIndex = 37;
            this.lblSignUp.Text = "TU PEDIDO";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMas
            // 
            this.btnMas.Image = global::PF_PVA.Properties.Resources.mas_icono;
            this.btnMas.Location = new System.Drawing.Point(403, 273);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(30, 30);
            this.btnMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMas.TabIndex = 44;
            this.btnMas.TabStop = false;
            this.btnMas.Visible = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Image = global::PF_PVA.Properties.Resources.menos_icono;
            this.btnMenos.Location = new System.Drawing.Point(331, 273);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 30);
            this.btnMenos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenos.TabIndex = 43;
            this.btnMenos.TabStop = false;
            this.btnMenos.Visible = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.btnMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMas;
        private System.Windows.Forms.PictureBox btnMenos;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnSalir;
    }
}