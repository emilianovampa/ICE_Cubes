namespace FrbaCrucero.AbmRecorrido.SeleccionarPuerto
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            // 
            // listaDePuertos
            // 
            this.listaDePuertos.AccessibleName = "listaDePuertos";
            this.listaDePuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDePuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Puerto,
            this.Selected});
            this.listaDePuertos.Location = new System.Drawing.Point(62, 60);
            this.listaDePuertos.MultiSelect = false;
            this.listaDePuertos.Name = "listaDePuertos";
            this.listaDePuertos.RowTemplate.Height = 24;
            this.listaDePuertos.Size = new System.Drawing.Size(494, 150);
            this.listaDePuertos.TabIndex = 3;
            this.listaDePuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDePuertos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Nombre Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            // 
            // SeleccionarPuertoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 253);
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
        private System.Windows.Forms.DataGridView listaDePuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
    }
}