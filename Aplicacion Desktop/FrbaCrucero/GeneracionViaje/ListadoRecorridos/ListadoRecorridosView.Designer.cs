namespace FrbaCrucero
{
    partial class ListadoRecorridosView
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
            this.PuertoOrigen = new System.Windows.Forms.TextBox();
            this.puertoOrigenLabel = new System.Windows.Forms.Label();
            this.BuscarOrigen = new System.Windows.Forms.Button();
            this.puertoOrigenDestino = new System.Windows.Forms.Label();
            this.PuertoDestino = new System.Windows.Forms.TextBox();
            this.BuscarDestino = new System.Windows.Forms.Button();
            this.pasaPorBuscar = new System.Windows.Forms.Button();
            this.PasaPor = new System.Windows.Forms.TextBox();
            this.pasaPorLabel = new System.Windows.Forms.Label();
            this.desdeLabel = new System.Windows.Forms.Label();
            this.precioDesde = new System.Windows.Forms.TextBox();
            this.hastaLabel = new System.Windows.Forms.Label();
            this.precioHasta = new System.Windows.Forms.TextBox();
            this.Recorridos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BuscarRecorridos = new System.Windows.Forms.Button();
            this.LimpiarBusqueda = new System.Windows.Forms.Button();
            this.recorridoSeleccionado = new System.Windows.Forms.DataGridView();
            this.Aceptar = new System.Windows.Forms.Button();
            this.agregarNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EstadoBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Recorridos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorridoSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertoOrigen
            // 
            this.PuertoOrigen.Enabled = false;
            this.PuertoOrigen.Location = new System.Drawing.Point(115, 33);
            this.PuertoOrigen.Name = "PuertoOrigen";
            this.PuertoOrigen.Size = new System.Drawing.Size(199, 22);
            this.PuertoOrigen.TabIndex = 0;
            // 
            // puertoOrigenLabel
            // 
            this.puertoOrigenLabel.AutoSize = true;
            this.puertoOrigenLabel.Location = new System.Drawing.Point(12, 36);
            this.puertoOrigenLabel.Name = "puertoOrigenLabel";
            this.puertoOrigenLabel.Size = new System.Drawing.Size(97, 17);
            this.puertoOrigenLabel.TabIndex = 1;
            this.puertoOrigenLabel.Text = "Puerto Origen";
            // 
            // BuscarOrigen
            // 
            this.BuscarOrigen.Location = new System.Drawing.Point(320, 33);
            this.BuscarOrigen.Name = "BuscarOrigen";
            this.BuscarOrigen.Size = new System.Drawing.Size(30, 23);
            this.BuscarOrigen.TabIndex = 2;
            this.BuscarOrigen.Text = "...";
            this.BuscarOrigen.UseVisualStyleBackColor = true;
            this.BuscarOrigen.Click += new System.EventHandler(this.BuscarOrigen_Click);
            // 
            // puertoOrigenDestino
            // 
            this.puertoOrigenDestino.AutoSize = true;
            this.puertoOrigenDestino.Location = new System.Drawing.Point(12, 71);
            this.puertoOrigenDestino.Name = "puertoOrigenDestino";
            this.puertoOrigenDestino.Size = new System.Drawing.Size(102, 17);
            this.puertoOrigenDestino.TabIndex = 3;
            this.puertoOrigenDestino.Text = "Puerto Destino";
            // 
            // PuertoDestino
            // 
            this.PuertoDestino.Enabled = false;
            this.PuertoDestino.Location = new System.Drawing.Point(117, 71);
            this.PuertoDestino.Name = "PuertoDestino";
            this.PuertoDestino.Size = new System.Drawing.Size(197, 22);
            this.PuertoDestino.TabIndex = 4;
            // 
            // BuscarDestino
            // 
            this.BuscarDestino.Location = new System.Drawing.Point(320, 70);
            this.BuscarDestino.Name = "BuscarDestino";
            this.BuscarDestino.Size = new System.Drawing.Size(30, 23);
            this.BuscarDestino.TabIndex = 5;
            this.BuscarDestino.Text = "...";
            this.BuscarDestino.UseVisualStyleBackColor = true;
            this.BuscarDestino.Click += new System.EventHandler(this.BuscarDestino_Click);
            // 
            // pasaPorBuscar
            // 
            this.pasaPorBuscar.Location = new System.Drawing.Point(643, 34);
            this.pasaPorBuscar.Name = "pasaPorBuscar";
            this.pasaPorBuscar.Size = new System.Drawing.Size(31, 23);
            this.pasaPorBuscar.TabIndex = 10;
            this.pasaPorBuscar.Text = "...";
            this.pasaPorBuscar.UseVisualStyleBackColor = true;
            this.pasaPorBuscar.Click += new System.EventHandler(this.pasaPorBuscar_Click);
            // 
            // PasaPor
            // 
            this.PasaPor.Enabled = false;
            this.PasaPor.Location = new System.Drawing.Point(442, 34);
            this.PasaPor.Name = "PasaPor";
            this.PasaPor.Size = new System.Drawing.Size(194, 22);
            this.PasaPor.TabIndex = 9;
            // 
            // pasaPorLabel
            // 
            this.pasaPorLabel.AutoSize = true;
            this.pasaPorLabel.Location = new System.Drawing.Point(370, 36);
            this.pasaPorLabel.Name = "pasaPorLabel";
            this.pasaPorLabel.Size = new System.Drawing.Size(66, 17);
            this.pasaPorLabel.TabIndex = 8;
            this.pasaPorLabel.Text = "Pasa Por";
            // 
            // desdeLabel
            // 
            this.desdeLabel.AutoSize = true;
            this.desdeLabel.Location = new System.Drawing.Point(686, 37);
            this.desdeLabel.Name = "desdeLabel";
            this.desdeLabel.Size = new System.Drawing.Size(105, 17);
            this.desdeLabel.TabIndex = 13;
            this.desdeLabel.Text = "Precio Desde $";
            // 
            // precioDesde
            // 
            this.precioDesde.Location = new System.Drawing.Point(797, 34);
            this.precioDesde.Name = "precioDesde";
            this.precioDesde.Size = new System.Drawing.Size(74, 22);
            this.precioDesde.TabIndex = 14;
            this.precioDesde.TextChanged += new System.EventHandler(this.precioDesde_TextChanged);
            // 
            // hastaLabel
            // 
            this.hastaLabel.AutoSize = true;
            this.hastaLabel.Location = new System.Drawing.Point(690, 71);
            this.hastaLabel.Name = "hastaLabel";
            this.hastaLabel.Size = new System.Drawing.Size(101, 17);
            this.hastaLabel.TabIndex = 15;
            this.hastaLabel.Text = "Precio Hasta $";
            // 
            // precioHasta
            // 
            this.precioHasta.Location = new System.Drawing.Point(797, 71);
            this.precioHasta.Name = "precioHasta";
            this.precioHasta.Size = new System.Drawing.Size(74, 22);
            this.precioHasta.TabIndex = 16;
            this.precioHasta.TextChanged += new System.EventHandler(this.precioHasta_TextChanged);
            // 
            // Recorridos
            // 
            this.Recorridos.AllowUserToAddRows = false;
            this.Recorridos.AllowUserToDeleteRows = false;
            this.Recorridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Recorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recorridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Editar});
            this.Recorridos.Location = new System.Drawing.Point(12, 132);
            this.Recorridos.Name = "Recorridos";
            this.Recorridos.ReadOnly = true;
            this.Recorridos.RowTemplate.Height = 24;
            this.Recorridos.Size = new System.Drawing.Size(859, 232);
            this.Recorridos.TabIndex = 17;
            this.Recorridos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Recorridos_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            this.Seleccionar.Width = 88;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 51;
            // 
            // BuscarRecorridos
            // 
            this.BuscarRecorridos.Location = new System.Drawing.Point(15, 100);
            this.BuscarRecorridos.Name = "BuscarRecorridos";
            this.BuscarRecorridos.Size = new System.Drawing.Size(94, 26);
            this.BuscarRecorridos.TabIndex = 18;
            this.BuscarRecorridos.Text = "Buscar";
            this.BuscarRecorridos.UseVisualStyleBackColor = true;
            this.BuscarRecorridos.Click += new System.EventHandler(this.BuscarRecorridos_Click);
            // 
            // LimpiarBusqueda
            // 
            this.LimpiarBusqueda.Location = new System.Drawing.Point(117, 100);
            this.LimpiarBusqueda.Name = "LimpiarBusqueda";
            this.LimpiarBusqueda.Size = new System.Drawing.Size(94, 26);
            this.LimpiarBusqueda.TabIndex = 19;
            this.LimpiarBusqueda.Text = "Limpiar";
            this.LimpiarBusqueda.UseVisualStyleBackColor = true;
            this.LimpiarBusqueda.Click += new System.EventHandler(this.LimpiarBusqueda_Click);
            // 
            // recorridoSeleccionado
            // 
            this.recorridoSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridoSeleccionado.Location = new System.Drawing.Point(12, 399);
            this.recorridoSeleccionado.Name = "recorridoSeleccionado";
            this.recorridoSeleccionado.RowTemplate.Height = 24;
            this.recorridoSeleccionado.Size = new System.Drawing.Size(856, 130);
            this.recorridoSeleccionado.TabIndex = 20;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(12, 370);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(856, 23);
            this.Aceptar.TabIndex = 21;
            this.Aceptar.Text = "Transferir Recorrido Seleccionado";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // agregarNuevo
            // 
            this.agregarNuevo.Location = new System.Drawing.Point(655, 100);
            this.agregarNuevo.Name = "agregarNuevo";
            this.agregarNuevo.Size = new System.Drawing.Size(216, 26);
            this.agregarNuevo.TabIndex = 22;
            this.agregarNuevo.Text = "Agregar Nuevo Recorrido";
            this.agregarNuevo.UseVisualStyleBackColor = true;
            this.agregarNuevo.Click += new System.EventHandler(this.agregarNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Estado";
            // 
            // EstadoBox
            // 
            this.EstadoBox.FormattingEnabled = true;
            this.EstadoBox.Items.AddRange(new object[] {
            "TODOS",
            "SOLO ACTIVOS",
            "SOLO ELIMINADOS"});
            this.EstadoBox.Location = new System.Drawing.Point(442, 70);
            this.EstadoBox.Name = "EstadoBox";
            this.EstadoBox.Size = new System.Drawing.Size(194, 24);
            this.EstadoBox.TabIndex = 25;
            // 
            // ListadoRecorridosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 531);
            this.Controls.Add(this.EstadoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarNuevo);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.recorridoSeleccionado);
            this.Controls.Add(this.LimpiarBusqueda);
            this.Controls.Add(this.BuscarRecorridos);
            this.Controls.Add(this.Recorridos);
            this.Controls.Add(this.precioHasta);
            this.Controls.Add(this.hastaLabel);
            this.Controls.Add(this.precioDesde);
            this.Controls.Add(this.desdeLabel);
            this.Controls.Add(this.pasaPorBuscar);
            this.Controls.Add(this.PasaPor);
            this.Controls.Add(this.pasaPorLabel);
            this.Controls.Add(this.BuscarDestino);
            this.Controls.Add(this.PuertoDestino);
            this.Controls.Add(this.puertoOrigenDestino);
            this.Controls.Add(this.BuscarOrigen);
            this.Controls.Add(this.puertoOrigenLabel);
            this.Controls.Add(this.PuertoOrigen);
            this.Name = "ListadoRecorridosView";
            this.Text = "ListarRecorridos";
            ((System.ComponentModel.ISupportInitialize)(this.Recorridos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recorridoSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PuertoOrigen;
        private System.Windows.Forms.Label puertoOrigenLabel;
        private System.Windows.Forms.Button BuscarOrigen;
        private System.Windows.Forms.Label puertoOrigenDestino;
        private System.Windows.Forms.TextBox PuertoDestino;
        private System.Windows.Forms.Button BuscarDestino;
        private System.Windows.Forms.Button pasaPorBuscar;
        private System.Windows.Forms.TextBox PasaPor;
        private System.Windows.Forms.Label pasaPorLabel;
        private System.Windows.Forms.Label desdeLabel;
        private System.Windows.Forms.TextBox precioDesde;
        private System.Windows.Forms.Label hastaLabel;
        private System.Windows.Forms.TextBox precioHasta;
        private System.Windows.Forms.DataGridView Recorridos;
        private System.Windows.Forms.Button BuscarRecorridos;
        private System.Windows.Forms.Button LimpiarBusqueda;
        private System.Windows.Forms.DataGridView recorridoSeleccionado;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button agregarNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.ComboBox EstadoBox;
    }
}