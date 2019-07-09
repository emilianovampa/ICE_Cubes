namespace FrbaCrucero.PagoReserva
{
    partial class BusquedaReservaVista
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
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PagarBoton = new System.Windows.Forms.Button();
            this.NroReservaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelarBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(12, 44);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 0;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Numero de Reserva";
            // 
            // PagarBoton
            // 
            this.PagarBoton.Location = new System.Drawing.Point(434, 273);
            this.PagarBoton.Name = "PagarBoton";
            this.PagarBoton.Size = new System.Drawing.Size(75, 23);
            this.PagarBoton.TabIndex = 2;
            this.PagarBoton.Text = "Pagar";
            this.PagarBoton.UseVisualStyleBackColor = true;
            this.PagarBoton.Click += new System.EventHandler(this.PagarBoton_Click);
            // 
            // NroReservaTextBox
            // 
            this.NroReservaTextBox.Location = new System.Drawing.Point(12, 73);
            this.NroReservaTextBox.Name = "NroReservaTextBox";
            this.NroReservaTextBox.Size = new System.Drawing.Size(240, 20);
            this.NroReservaTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(610, 134);
            this.dataGridView1.TabIndex = 4;
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(524, 273);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(75, 23);
            this.CancelarBoton.TabIndex = 5;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // BusquedaReservaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 308);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NroReservaTextBox);
            this.Controls.Add(this.PagarBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarBoton);
            this.Name = "BusquedaReservaVista";
            this.Text = "Pago de Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PagarBoton;
        private System.Windows.Forms.TextBox NroReservaTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelarBoton;
    }
}