
namespace PF_PVA
{
    partial class HistorialPedidos
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
            this.lvHistorial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHistorialPedido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvHistorial
            // 
            this.lvHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvHistorial.FullRowSelect = true;
            this.lvHistorial.HideSelection = false;
            this.lvHistorial.Location = new System.Drawing.Point(12, 46);
            this.lvHistorial.Name = "lvHistorial";
            this.lvHistorial.Size = new System.Drawing.Size(511, 226);
            this.lvHistorial.TabIndex = 31;
            this.lvHistorial.UseCompatibleStateImageBehavior = false;
            this.lvHistorial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID pedido";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID cliente";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha pedido";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dirección";
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pagado";
            // 
            // lblHistorialPedido
            // 
            this.lblHistorialPedido.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialPedido.Location = new System.Drawing.Point(12, 9);
            this.lblHistorialPedido.Name = "lblHistorialPedido";
            this.lblHistorialPedido.Size = new System.Drawing.Size(511, 29);
            this.lblHistorialPedido.TabIndex = 32;
            this.lblHistorialPedido.Text = "HISTORIAL PEDIDOS";
            this.lblHistorialPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(448, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // HistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 313);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblHistorialPedido);
            this.Controls.Add(this.lvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HistorialPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHistorial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.Label lblHistorialPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}