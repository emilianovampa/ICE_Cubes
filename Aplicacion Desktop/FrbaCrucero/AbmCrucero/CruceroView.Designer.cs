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
            this.agregarCabinas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MarcasCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ServicioCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crucero";
            // 
            // cruceroID
            // 
            this.cruceroID.Location = new System.Drawing.Point(20, 28);
            this.cruceroID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cruceroID.Name = "cruceroID";
            this.cruceroID.ReadOnly = true;
            this.cruceroID.Size = new System.Drawing.Size(76, 20);
            this.cruceroID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cabinas";
            // 
            // agregarCabinas
            // 
            this.agregarCabinas.Location = new System.Drawing.Point(628, 7);
            this.agregarCabinas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agregarCabinas.Name = "agregarCabinas";
            this.agregarCabinas.Size = new System.Drawing.Size(120, 24);
            this.agregarCabinas.TabIndex = 4;
            this.agregarCabinas.Text = "Agregar Cabinas";
            this.agregarCabinas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // MarcasCombo
            // 
            this.MarcasCombo.DisplayMember = "MARCA_NOMBRE";
            this.MarcasCombo.FormattingEnabled = true;
            this.MarcasCombo.Location = new System.Drawing.Point(91, 138);
            this.MarcasCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MarcasCombo.Name = "MarcasCombo";
            this.MarcasCombo.Size = new System.Drawing.Size(208, 21);
            this.MarcasCombo.TabIndex = 6;
            this.MarcasCombo.ValueMember = "MARCA_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(164, 27);
            this.estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Size = new System.Drawing.Size(76, 20);
            this.estado.TabIndex = 8;
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(91, 61);
            this.fechaAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(208, 20);
            this.fechaAlta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Alta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Modelo";
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(91, 85);
            this.modelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(208, 20);
            this.modelo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Identificador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(11, 202);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(157, 19);
            this.Guardar.TabIndex = 19;
            this.Guardar.Text = " Guardar Cambios";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Servicio";
            // 
            // ServicioCombo
            // 
            this.ServicioCombo.DisplayMember = "SERV_NOMBRE";
            this.ServicioCombo.FormattingEnabled = true;
            this.ServicioCombo.Location = new System.Drawing.Point(91, 165);
            this.ServicioCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServicioCombo.Name = "ServicioCombo";
            this.ServicioCombo.Size = new System.Drawing.Size(208, 21);
            this.ServicioCombo.TabIndex = 21;
            this.ServicioCombo.ValueMember = "SERV_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrar,
            this.editar});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(416, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 187);
            this.dataGridView1.TabIndex = 60;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.Width = 41;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.Width = 40;
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(213, 202);
            this.Baja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(142, 19);
            this.Baja.TabIndex = 61;
            this.Baja.Text = "Dar de Baja";
            this.Baja.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(303, 64);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Desconocida";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CruceroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 234);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ServicioCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarcasCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.agregarCabinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cruceroID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CruceroView";
            this.Text = "Crucero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cruceroID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarCabinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MarcasCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ServicioCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}