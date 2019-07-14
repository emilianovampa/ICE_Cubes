namespace FrbaCrucero.AbmRol
{
    partial class MenuRolView
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
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnColumnModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkBoxColumnEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAgregarRol.Location = new System.Drawing.Point(187, 36);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(123, 33);
            this.btnAgregarRol.TabIndex = 0;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnColumnModificar,
            this.checkBoxColumnEliminar});
            this.dataGridView.Location = new System.Drawing.Point(38, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(451, 150);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnColumnModificar
            // 
            this.btnColumnModificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnColumnModificar.HeaderText = "Modificar";
            this.btnColumnModificar.Name = "btnColumnModificar";
            this.btnColumnModificar.ReadOnly = true;
            this.btnColumnModificar.Width = 64;
            // 
            // checkBoxColumnEliminar
            // 
            this.checkBoxColumnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.checkBoxColumnEliminar.HeaderText = "Eliminar";
            this.checkBoxColumnEliminar.Name = "checkBoxColumnEliminar";
            this.checkBoxColumnEliminar.ReadOnly = true;
            this.checkBoxColumnEliminar.Width = 56;
            // 
            // MenuRolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 301);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAgregarRol);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuRolView";
            this.Text = "MenuRolView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnColumnModificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumnEliminar;
    }
}