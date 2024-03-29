﻿namespace FrbaCrucero.CompraPasaje
{
    partial class ComprarPasajeVista
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
            this.FechaDesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.FechHastaDTP = new System.Windows.Forms.DateTimePicker();
            this.SeleccionPOrigenB = new System.Windows.Forms.Button();
            this.PuertoOrigenTB = new System.Windows.Forms.TextBox();
            this.PuertoDestinoTB = new System.Windows.Forms.TextBox();
            this.CantPasajesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelarB = new System.Windows.Forms.Button();
            this.BuscarViajesB = new System.Windows.Forms.Button();
            this.SeleccionarPDestinoB = new System.Windows.Forms.Button();
            this.ViajesDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ComprarReservar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViajesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDesdeDTP
            // 
            this.FechaDesdeDTP.Location = new System.Drawing.Point(103, 63);
            this.FechaDesdeDTP.Name = "FechaDesdeDTP";
            this.FechaDesdeDTP.Size = new System.Drawing.Size(200, 20);
            this.FechaDesdeDTP.TabIndex = 0;
            // 
            // FechHastaDTP
            // 
            this.FechHastaDTP.Location = new System.Drawing.Point(403, 63);
            this.FechHastaDTP.Name = "FechHastaDTP";
            this.FechHastaDTP.Size = new System.Drawing.Size(200, 20);
            this.FechHastaDTP.TabIndex = 1;
            // 
            // SeleccionPOrigenB
            // 
            this.SeleccionPOrigenB.Location = new System.Drawing.Point(11, 114);
            this.SeleccionPOrigenB.Name = "SeleccionPOrigenB";
            this.SeleccionPOrigenB.Size = new System.Drawing.Size(163, 23);
            this.SeleccionPOrigenB.TabIndex = 2;
            this.SeleccionPOrigenB.Text = "Seleccionar Puerto Origen";
            this.SeleccionPOrigenB.UseVisualStyleBackColor = true;
            this.SeleccionPOrigenB.Click += new System.EventHandler(this.SeleccionPuertoB_Click);
            // 
            // PuertoOrigenTB
            // 
            this.PuertoOrigenTB.Enabled = false;
            this.PuertoOrigenTB.Location = new System.Drawing.Point(180, 116);
            this.PuertoOrigenTB.Name = "PuertoOrigenTB";
            this.PuertoOrigenTB.Size = new System.Drawing.Size(117, 20);
            this.PuertoOrigenTB.TabIndex = 3;
            // 
            // PuertoDestinoTB
            // 
            this.PuertoDestinoTB.Enabled = false;
            this.PuertoDestinoTB.Location = new System.Drawing.Point(486, 116);
            this.PuertoDestinoTB.Name = "PuertoDestinoTB";
            this.PuertoDestinoTB.Size = new System.Drawing.Size(117, 20);
            this.PuertoDestinoTB.TabIndex = 4;
            // 
            // CantPasajesCB
            // 
            this.CantPasajesCB.FormattingEnabled = true;
            this.CantPasajesCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CantPasajesCB.Location = new System.Drawing.Point(123, 147);
            this.CantPasajesCB.Name = "CantPasajesCB";
            this.CantPasajesCB.Size = new System.Drawing.Size(35, 21);
            this.CantPasajesCB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Pasajes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Hasta";
            // 
            // CancelarB
            // 
            this.CancelarB.Location = new System.Drawing.Point(528, 411);
            this.CancelarB.Name = "CancelarB";
            this.CancelarB.Size = new System.Drawing.Size(75, 23);
            this.CancelarB.TabIndex = 14;
            this.CancelarB.Text = "Cancelar";
            this.CancelarB.UseVisualStyleBackColor = true;
            this.CancelarB.Click += new System.EventHandler(this.CancelarB_Click);
            // 
            // BuscarViajesB
            // 
            this.BuscarViajesB.Location = new System.Drawing.Point(180, 147);
            this.BuscarViajesB.Name = "BuscarViajesB";
            this.BuscarViajesB.Size = new System.Drawing.Size(423, 23);
            this.BuscarViajesB.TabIndex = 15;
            this.BuscarViajesB.Text = "Buscar Viajes";
            this.BuscarViajesB.UseVisualStyleBackColor = true;
            this.BuscarViajesB.Click += new System.EventHandler(this.BuscarViajesB_Click);
            // 
            // SeleccionarPDestinoB
            // 
            this.SeleccionarPDestinoB.Location = new System.Drawing.Point(316, 116);
            this.SeleccionarPDestinoB.Name = "SeleccionarPDestinoB";
            this.SeleccionarPDestinoB.Size = new System.Drawing.Size(164, 23);
            this.SeleccionarPDestinoB.TabIndex = 16;
            this.SeleccionarPDestinoB.Text = "Seleccionar Puerto Destino";
            this.SeleccionarPDestinoB.UseVisualStyleBackColor = true;
            this.SeleccionarPDestinoB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViajesDGV
            // 
            this.ViajesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViajesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComprarReservar});
            this.ViajesDGV.Location = new System.Drawing.Point(11, 176);
            this.ViajesDGV.Name = "ViajesDGV";
            this.ViajesDGV.Size = new System.Drawing.Size(592, 229);
            this.ViajesDGV.TabIndex = 17;
            this.ViajesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViajesDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Compra / Reserva de pasajes";
            // 
            // ComprarReservar
            // 
            this.ComprarReservar.HeaderText = "Comprar - Reservar";
            this.ComprarReservar.Name = "ComprarReservar";
            // 
            // ComprarPasajeVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViajesDGV);
            this.Controls.Add(this.SeleccionarPDestinoB);
            this.Controls.Add(this.BuscarViajesB);
            this.Controls.Add(this.CancelarB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantPasajesCB);
            this.Controls.Add(this.PuertoDestinoTB);
            this.Controls.Add(this.PuertoOrigenTB);
            this.Controls.Add(this.SeleccionPOrigenB);
            this.Controls.Add(this.FechHastaDTP);
            this.Controls.Add(this.FechaDesdeDTP);
            this.Name = "ComprarPasajeVista";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ViajesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDesdeDTP;
        private System.Windows.Forms.DateTimePicker FechHastaDTP;
        private System.Windows.Forms.Button SeleccionPOrigenB;
        private System.Windows.Forms.TextBox PuertoOrigenTB;
        private System.Windows.Forms.TextBox PuertoDestinoTB;
        private System.Windows.Forms.ComboBox CantPasajesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelarB;
        private System.Windows.Forms.Button BuscarViajesB;
        private System.Windows.Forms.Button SeleccionarPDestinoB;
        private System.Windows.Forms.DataGridView ViajesDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn ComprarReservar;
    }
}