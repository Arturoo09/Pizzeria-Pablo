
namespace PF_PVA
{
    partial class ElegirPizza
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
            this.lblElegirPizza = new System.Windows.Forms.Label();
            this.btnAnadirPedido = new System.Windows.Forms.Button();
            this.clbElegirPizza = new System.Windows.Forms.CheckedListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblElegirPizza
            // 
            this.lblElegirPizza.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirPizza.Location = new System.Drawing.Point(25, 18);
            this.lblElegirPizza.Name = "lblElegirPizza";
            this.lblElegirPizza.Size = new System.Drawing.Size(511, 29);
            this.lblElegirPizza.TabIndex = 33;
            this.lblElegirPizza.Text = "ELEGIR PIZZA";
            this.lblElegirPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnadirPedido
            // 
            this.btnAnadirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirPedido.Location = new System.Drawing.Point(376, 309);
            this.btnAnadirPedido.Name = "btnAnadirPedido";
            this.btnAnadirPedido.Size = new System.Drawing.Size(160, 45);
            this.btnAnadirPedido.TabIndex = 40;
            this.btnAnadirPedido.Text = "Añadir al pedido";
            this.btnAnadirPedido.UseVisualStyleBackColor = true;
            this.btnAnadirPedido.Click += new System.EventHandler(this.btnAnadirPedido_Click);
            // 
            // clbElegirPizza
            // 
            this.clbElegirPizza.FormattingEnabled = true;
            this.clbElegirPizza.Location = new System.Drawing.Point(30, 59);
            this.clbElegirPizza.Name = "clbElegirPizza";
            this.clbElegirPizza.Size = new System.Drawing.Size(506, 244);
            this.clbElegirPizza.TabIndex = 41;
            this.clbElegirPizza.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbElegirPizza_ItemCheck);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(265, 309);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 45);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(26, 321);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(69, 321);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 20);
            this.lblPrecio.TabIndex = 44;
            this.lblPrecio.Text = "00,00€";
            this.lblPrecio.Visible = false;
            // 
            // lblPrecioOk
            // 
            this.lblPrecioOk.AutoSize = true;
            this.lblPrecioOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioOk.Location = new System.Drawing.Point(133, 321);
            this.lblPrecioOk.Name = "lblPrecioOk";
            this.lblPrecioOk.Size = new System.Drawing.Size(58, 20);
            this.lblPrecioOk.TabIndex = 45;
            this.lblPrecioOk.Text = "00,00€";
            this.lblPrecioOk.Visible = false;
            // 
            // ElegirPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.lblPrecioOk);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.clbElegirPizza);
            this.Controls.Add(this.btnAnadirPedido);
            this.Controls.Add(this.lblElegirPizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ElegirPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblElegirPizza;
        private System.Windows.Forms.Button btnAnadirPedido;
        private System.Windows.Forms.CheckedListBox clbElegirPizza;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioOk;
    }
}