namespace FrbaCrucero
{
    partial class TramoView
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
            this.components = new System.ComponentModel.Container();
            this.OrigenLabel = new System.Windows.Forms.Label();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.DestinoLabel = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.BuscarDestino = new System.Windows.Forms.Button();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.buscarOrigen = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.puertoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.puertoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrigenLabel
            // 
            this.OrigenLabel.AutoSize = true;
            this.OrigenLabel.Location = new System.Drawing.Point(62, 35);
            this.OrigenLabel.Name = "OrigenLabel";
            this.OrigenLabel.Size = new System.Drawing.Size(51, 17);
            this.OrigenLabel.TabIndex = 0;
            this.OrigenLabel.Text = "Origen";
            // 
            // textOrigen
            // 
            this.textOrigen.Enabled = false;
            this.textOrigen.Location = new System.Drawing.Point(135, 35);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(278, 22);
            this.textOrigen.TabIndex = 1;
            // 
            // DestinoLabel
            // 
            this.DestinoLabel.AutoSize = true;
            this.DestinoLabel.Location = new System.Drawing.Point(62, 74);
            this.DestinoLabel.Name = "DestinoLabel";
            this.DestinoLabel.Size = new System.Drawing.Size(56, 17);
            this.DestinoLabel.TabIndex = 2;
            this.DestinoLabel.Text = "Destino";
            // 
            // textDestino
            // 
            this.textDestino.Enabled = false;
            this.textDestino.Location = new System.Drawing.Point(135, 74);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(278, 22);
            this.textDestino.TabIndex = 3;
            // 
            // BuscarDestino
            // 
            this.BuscarDestino.Location = new System.Drawing.Point(419, 74);
            this.BuscarDestino.Name = "BuscarDestino";
            this.BuscarDestino.Size = new System.Drawing.Size(75, 23);
            this.BuscarDestino.TabIndex = 4;
            this.BuscarDestino.Text = "Buscar";
            this.BuscarDestino.UseVisualStyleBackColor = true;
            this.BuscarDestino.Click += new System.EventHandler(this.buscarDestino_Click);
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(62, 116);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(48, 17);
            this.PrecioLabel.TabIndex = 5;
            this.PrecioLabel.Text = "Precio";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(135, 113);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(278, 22);
            this.textPrecio.TabIndex = 6;
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // buscarOrigen
            // 
            this.buscarOrigen.Location = new System.Drawing.Point(419, 35);
            this.buscarOrigen.Name = "buscarOrigen";
            this.buscarOrigen.Size = new System.Drawing.Size(75, 23);
            this.buscarOrigen.TabIndex = 7;
            this.buscarOrigen.Text = "Buscar";
            this.buscarOrigen.UseVisualStyleBackColor = true;
            this.buscarOrigen.Click += new System.EventHandler(this.buscarOrigen_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(221, 155);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // puertoBindingSource
            // 
            this.puertoBindingSource.DataSource = typeof(FrbaCrucero.model.Puerto);
            // 
            // TramoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 219);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.buscarOrigen);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.BuscarDestino);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.DestinoLabel);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.OrigenLabel);
            this.Name = "TramoView";
            this.Text = "Tramo";
            ((System.ComponentModel.ISupportInitialize)(this.puertoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource puertoBindingSource;
        private System.Windows.Forms.Label OrigenLabel;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Button buscarOrigen;
        private System.Windows.Forms.Label DestinoLabel;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Button BuscarDestino;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button Aceptar;


    }
}