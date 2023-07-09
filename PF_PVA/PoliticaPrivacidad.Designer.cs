namespace PF_PVA
{
    partial class PoliticaPrivacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoliticaPrivacidad));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnNoAceptar = new System.Windows.Forms.RadioButton();
            this.rbtnAceptar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(448, 244);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "POLÍTICA DE PRIVACIDAD";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(12, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(153, 40);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnNoAceptar
            // 
            this.rbtnNoAceptar.AutoSize = true;
            this.rbtnNoAceptar.Location = new System.Drawing.Point(12, 324);
            this.rbtnNoAceptar.Name = "rbtnNoAceptar";
            this.rbtnNoAceptar.Size = new System.Drawing.Size(236, 17);
            this.rbtnNoAceptar.TabIndex = 6;
            this.rbtnNoAceptar.TabStop = true;
            this.rbtnNoAceptar.Text = "NO acepto la politica de protección de datos";
            this.rbtnNoAceptar.UseVisualStyleBackColor = true;
            this.rbtnNoAceptar.CheckedChanged += new System.EventHandler(this.rbtnNoAceptar_CheckedChanged);
            // 
            // rbtnAceptar
            // 
            this.rbtnAceptar.AutoSize = true;
            this.rbtnAceptar.Location = new System.Drawing.Point(12, 301);
            this.rbtnAceptar.Name = "rbtnAceptar";
            this.rbtnAceptar.Size = new System.Drawing.Size(269, 17);
            this.rbtnAceptar.TabIndex = 5;
            this.rbtnAceptar.TabStop = true;
            this.rbtnAceptar.Text = "He leído y acepto la politica de protección de datos";
            this.rbtnAceptar.UseVisualStyleBackColor = true;
            this.rbtnAceptar.CheckedChanged += new System.EventHandler(this.rbtnAceptar_CheckedChanged);
            // 
            // PoliticaPrivacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbtnNoAceptar);
            this.Controls.Add(this.rbtnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PoliticaPrivacidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoliticaPrivacidad";
            this.Load += new System.EventHandler(this.PoliticaPrivacidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.RadioButton rbtnAceptar;
        public System.Windows.Forms.RadioButton rbtnNoAceptar;
    }
}