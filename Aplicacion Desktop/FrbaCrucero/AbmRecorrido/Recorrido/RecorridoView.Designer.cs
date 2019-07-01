namespace FrbaCrucero{
    partial class RecorridoView
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
            this.gridTramos = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.addLine = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nroRecorrido = new System.Windows.Forms.TextBox();
            this.EstadoText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTramos
            // 
            this.gridTramos.AllowUserToAddRows = false;
            this.gridTramos.AllowUserToDeleteRows = false;
            this.gridTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Del});
            this.gridTramos.Location = new System.Drawing.Point(12, 124);
            this.gridTramos.MultiSelect = false;
            this.gridTramos.Name = "gridTramos";
            this.gridTramos.ReadOnly = true;
            this.gridTramos.RowTemplate.Height = 24;
            this.gridTramos.Size = new System.Drawing.Size(1068, 380);
            this.gridTramos.TabIndex = 0;
            this.gridTramos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTramos_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 38;
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Text = "Del";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 35;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(401, 74);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(181, 35);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar Recorrido";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // addLine
            // 
            this.addLine.Location = new System.Drawing.Point(27, 74);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(181, 35);
            this.addLine.TabIndex = 2;
            this.addLine.Text = "Agregar linea al final";
            this.addLine.UseVisualStyleBackColor = true;
            this.addLine.Click += new System.EventHandler(this.addLine_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(214, 74);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(181, 35);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar Recorrido";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Recorrido:";
            // 
            // nroRecorrido
            // 
            this.nroRecorrido.Enabled = false;
            this.nroRecorrido.Location = new System.Drawing.Point(179, 32);
            this.nroRecorrido.Name = "nroRecorrido";
            this.nroRecorrido.Size = new System.Drawing.Size(144, 22);
            this.nroRecorrido.TabIndex = 5;
            // 
            // EstadoText
            // 
            this.EstadoText.Enabled = false;
            this.EstadoText.Location = new System.Drawing.Point(346, 32);
            this.EstadoText.Name = "EstadoText";
            this.EstadoText.Size = new System.Drawing.Size(144, 22);
            this.EstadoText.TabIndex = 6;
            // 
            // RecorridoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 516);
            this.Controls.Add(this.EstadoText);
            this.Controls.Add(this.nroRecorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.gridTramos);
            this.Name = "RecorridoView";
            this.Text = "Recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.gridTramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTramos;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button addLine;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nroRecorrido;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.TextBox EstadoText;
    }
}