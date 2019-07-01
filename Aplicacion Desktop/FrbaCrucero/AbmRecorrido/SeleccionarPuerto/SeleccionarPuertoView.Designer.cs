namespace FrbaCrucero
{
    partial class SeleccionarPuertoView
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
            this.NombrePuerto = new System.Windows.Forms.Label();
            this.textNombrePuerto = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.listaDePuertos = new System.Windows.Forms.DataGridView();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SeleccionadoLabel = new System.Windows.Forms.Label();
            this.idSelectedText = new System.Windows.Forms.TextBox();
            this.nombreSelectedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaDePuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // NombrePuerto
            // 
            this.NombrePuerto.AutoSize = true;
            this.NombrePuerto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NombrePuerto.Location = new System.Drawing.Point(59, 20);
            this.NombrePuerto.Name = "NombrePuerto";
            this.NombrePuerto.Size = new System.Drawing.Size(127, 17);
            this.NombrePuerto.TabIndex = 0;
            this.NombrePuerto.Text = "Nombre del Puerto";
            this.NombrePuerto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textNombrePuerto
            // 
            this.textNombrePuerto.Location = new System.Drawing.Point(192, 20);
            this.textNombrePuerto.Name = "textNombrePuerto";
            this.textNombrePuerto.Size = new System.Drawing.Size(246, 22);
            this.textNombrePuerto.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(445, 20);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // listaDePuertos
            // 
            this.listaDePuertos.AccessibleName = "listaDePuertos";
            this.listaDePuertos.AllowUserToAddRows = false;
            this.listaDePuertos.AllowUserToDeleteRows = false;
            this.listaDePuertos.AllowUserToOrderColumns = true;
            this.listaDePuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDePuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECCIONAR});
            this.listaDePuertos.Location = new System.Drawing.Point(62, 91);
            this.listaDePuertos.MultiSelect = false;
            this.listaDePuertos.Name = "listaDePuertos";
            this.listaDePuertos.ReadOnly = true;
            this.listaDePuertos.RowTemplate.Height = 24;
            this.listaDePuertos.Size = new System.Drawing.Size(494, 354);
            this.listaDePuertos.TabIndex = 3;
            this.listaDePuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDePuertos_CellContentClick);
            // 
            // SELECCIONAR
            // 
            this.SELECCIONAR.HeaderText = "";
            this.SELECCIONAR.Name = "SELECCIONAR";
            this.SELECCIONAR.ReadOnly = true;
            this.SELECCIONAR.Text = "Seleccionar";
            this.SELECCIONAR.ToolTipText = "Seleccionar";
            this.SELECCIONAR.UseColumnTextForButtonValue = true;
            this.SELECCIONAR.Width = 70;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(444, 56);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // SeleccionadoLabel
            // 
            this.SeleccionadoLabel.AutoSize = true;
            this.SeleccionadoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SeleccionadoLabel.Location = new System.Drawing.Point(59, 59);
            this.SeleccionadoLabel.Name = "SeleccionadoLabel";
            this.SeleccionadoLabel.Size = new System.Drawing.Size(93, 17);
            this.SeleccionadoLabel.TabIndex = 5;
            this.SeleccionadoLabel.Text = "Seleccionado";
            this.SeleccionadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idSelectedText
            // 
            this.idSelectedText.Enabled = false;
            this.idSelectedText.Location = new System.Drawing.Point(192, 56);
            this.idSelectedText.Name = "idSelectedText";
            this.idSelectedText.Size = new System.Drawing.Size(53, 22);
            this.idSelectedText.TabIndex = 6;
            // 
            // nombreSelectedText
            // 
            this.nombreSelectedText.Enabled = false;
            this.nombreSelectedText.Location = new System.Drawing.Point(251, 56);
            this.nombreSelectedText.Name = "nombreSelectedText";
            this.nombreSelectedText.Size = new System.Drawing.Size(187, 22);
            this.nombreSelectedText.TabIndex = 7;
            // 
            // SeleccionarPuertoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 470);
            this.Controls.Add(this.nombreSelectedText);
            this.Controls.Add(this.idSelectedText);
            this.Controls.Add(this.SeleccionadoLabel);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.listaDePuertos);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.textNombrePuerto);
            this.Controls.Add(this.NombrePuerto);
            this.Name = "SeleccionarPuertoView";
            this.Text = "Seleccionar un Puerto";
            ((System.ComponentModel.ISupportInitialize)(this.listaDePuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombrePuerto;
        private System.Windows.Forms.TextBox textNombrePuerto;
        private System.Windows.Forms.Button Buscar;
        public System.Windows.Forms.DataGridView listaDePuertos;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label SeleccionadoLabel;
        public System.Windows.Forms.TextBox idSelectedText;
        public System.Windows.Forms.TextBox nombreSelectedText;
        private System.Windows.Forms.DataGridViewButtonColumn SELECCIONAR;
    }
}