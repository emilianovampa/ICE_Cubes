namespace FrbaCrucero.AbmCrucero.Baja
{
    partial class BajaCrucero
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
            this.motivoLabel = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.TextBox();
            this.corrimientoLabel = new System.Windows.Forms.Label();
            this.corrimiento = new System.Windows.Forms.TextBox();
            this.fechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.fechaRegresoLabel = new System.Windows.Forms.Label();
            this.permanente = new System.Windows.Forms.CheckBox();
            this.darBaja = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // motivoLabel
            // 
            this.motivoLabel.AutoSize = true;
            this.motivoLabel.Location = new System.Drawing.Point(12, 60);
            this.motivoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motivoLabel.Name = "motivoLabel";
            this.motivoLabel.Size = new System.Drawing.Size(49, 17);
            this.motivoLabel.TabIndex = 67;
            this.motivoLabel.Text = "Motivo";
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(15, 81);
            this.motivo.Margin = new System.Windows.Forms.Padding(4);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(522, 22);
            this.motivo.TabIndex = 66;
            // 
            // corrimientoLabel
            // 
            this.corrimientoLabel.AutoSize = true;
            this.corrimientoLabel.Location = new System.Drawing.Point(413, 16);
            this.corrimientoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.corrimientoLabel.Name = "corrimientoLabel";
            this.corrimientoLabel.Size = new System.Drawing.Size(80, 17);
            this.corrimientoLabel.TabIndex = 65;
            this.corrimientoLabel.Text = "Corrimiento";
            // 
            // corrimiento
            // 
            this.corrimiento.Location = new System.Drawing.Point(416, 35);
            this.corrimiento.Margin = new System.Windows.Forms.Padding(4);
            this.corrimiento.Name = "corrimiento";
            this.corrimiento.Size = new System.Drawing.Size(121, 22);
            this.corrimiento.TabIndex = 64;
            // 
            // fechaRegreso
            // 
            this.fechaRegreso.Location = new System.Drawing.Point(134, 35);
            this.fechaRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.fechaRegreso.Name = "fechaRegreso";
            this.fechaRegreso.Size = new System.Drawing.Size(265, 22);
            this.fechaRegreso.TabIndex = 63;
            // 
            // fechaRegresoLabel
            // 
            this.fechaRegresoLabel.AutoSize = true;
            this.fechaRegresoLabel.Location = new System.Drawing.Point(131, 13);
            this.fechaRegresoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fechaRegresoLabel.Name = "fechaRegresoLabel";
            this.fechaRegresoLabel.Size = new System.Drawing.Size(125, 17);
            this.fechaRegresoLabel.TabIndex = 62;
            this.fechaRegresoLabel.Text = "Fecha de Regreso";
            // 
            // permanente
            // 
            this.permanente.AutoSize = true;
            this.permanente.Location = new System.Drawing.Point(12, 35);
            this.permanente.Margin = new System.Windows.Forms.Padding(4);
            this.permanente.Name = "permanente";
            this.permanente.Size = new System.Drawing.Size(107, 21);
            this.permanente.TabIndex = 61;
            this.permanente.Text = "Permanente";
            this.permanente.UseVisualStyleBackColor = true;
            // 
            // darBaja
            // 
            this.darBaja.AutoSize = true;
            this.darBaja.Location = new System.Drawing.Point(12, 12);
            this.darBaja.Name = "darBaja";
            this.darBaja.Size = new System.Drawing.Size(105, 21);
            this.darBaja.TabIndex = 60;
            this.darBaja.Text = "Dar de Baja";
            this.darBaja.UseVisualStyleBackColor = true;
            this.darBaja.CheckedChanged += new System.EventHandler(this.darBaja_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 134);
            this.Controls.Add(this.motivoLabel);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.corrimientoLabel);
            this.Controls.Add(this.corrimiento);
            this.Controls.Add(this.fechaRegreso);
            this.Controls.Add(this.fechaRegresoLabel);
            this.Controls.Add(this.permanente);
            this.Controls.Add(this.darBaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label motivoLabel;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.Label corrimientoLabel;
        private System.Windows.Forms.TextBox corrimiento;
        private System.Windows.Forms.DateTimePicker fechaRegreso;
        private System.Windows.Forms.Label fechaRegresoLabel;
        private System.Windows.Forms.CheckBox permanente;
        private System.Windows.Forms.CheckBox darBaja;
    }
}