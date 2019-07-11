namespace FrbaCrucero.AbmCrucero
{
    partial class CruceroView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cruceroID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cabinas = new System.Windows.Forms.DataGridView();
            this.agregarCabinas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MarcasCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.fueraServicio = new System.Windows.Forms.Button();
            this.finVida = new System.Windows.Forms.Button();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cabinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crucero";
            // 
            // cruceroID
            // 
            this.cruceroID.Location = new System.Drawing.Point(90, 21);
            this.cruceroID.Name = "cruceroID";
            this.cruceroID.ReadOnly = true;
            this.cruceroID.Size = new System.Drawing.Size(100, 22);
            this.cruceroID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cabinas";
            // 
            // cabinas
            // 
            this.cabinas.AllowUserToAddRows = false;
            this.cabinas.AllowUserToDeleteRows = false;
            this.cabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabinas.Location = new System.Drawing.Point(14, 251);
            this.cabinas.Name = "cabinas";
            this.cabinas.ReadOnly = true;
            this.cabinas.RowTemplate.Height = 24;
            this.cabinas.Size = new System.Drawing.Size(664, 150);
            this.cabinas.TabIndex = 3;
            // 
            // agregarCabinas
            // 
            this.agregarCabinas.Location = new System.Drawing.Point(518, 219);
            this.agregarCabinas.Name = "agregarCabinas";
            this.agregarCabinas.Size = new System.Drawing.Size(160, 29);
            this.agregarCabinas.TabIndex = 4;
            this.agregarCabinas.Text = "Agregar Cabinas";
            this.agregarCabinas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // MarcasCombo
            // 
            this.MarcasCombo.DisplayMember = "MARCA_NOMBRE";
            this.MarcasCombo.FormattingEnabled = true;
            this.MarcasCombo.Location = new System.Drawing.Point(416, 156);
            this.MarcasCombo.Name = "MarcasCombo";
            this.MarcasCombo.Size = new System.Drawing.Size(121, 24);
            this.MarcasCombo.TabIndex = 6;
            this.MarcasCombo.ValueMember = "MARCA_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(278, 21);
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Size = new System.Drawing.Size(100, 22);
            this.estado.TabIndex = 8;
            // 
            // fueraServicio
            // 
            this.fueraServicio.Location = new System.Drawing.Point(16, 58);
            this.fueraServicio.Name = "fueraServicio";
            this.fueraServicio.Size = new System.Drawing.Size(136, 23);
            this.fueraServicio.TabIndex = 9;
            this.fueraServicio.Text = "Fuera de Servicio";
            this.fueraServicio.UseVisualStyleBackColor = true;
            // 
            // finVida
            // 
            this.finVida.Location = new System.Drawing.Point(158, 58);
            this.finVida.Name = "finVida";
            this.finVida.Size = new System.Drawing.Size(136, 23);
            this.finVida.TabIndex = 10;
            this.finVida.Text = "Fin vida util";
            this.finVida.UseVisualStyleBackColor = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(416, 188);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(121, 22);
            this.fechaAlta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Alta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Modelo";
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(93, 153);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(121, 22);
            this.modelo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Identificador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 48);
            this.dataGridView1.TabIndex = 18;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(14, 416);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(136, 23);
            this.Guardar.TabIndex = 19;
            this.Guardar.Text = " ";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // CruceroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 452);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.finVida);
            this.Controls.Add(this.fueraServicio);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarcasCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.agregarCabinas);
            this.Controls.Add(this.cabinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cruceroID);
            this.Controls.Add(this.label1);
            this.Name = "CruceroView";
            this.Text = "Crucero";
            ((System.ComponentModel.ISupportInitialize)(this.cabinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cruceroID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView cabinas;
        private System.Windows.Forms.Button agregarCabinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MarcasCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Button fueraServicio;
        private System.Windows.Forms.Button finVida;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Guardar;
    }
}