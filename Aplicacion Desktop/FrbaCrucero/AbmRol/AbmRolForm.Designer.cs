namespace FrbaCrucero.AbmRol
{
    partial class AbmRolForm
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
            this.btn_altaRol = new System.Windows.Forms.Button();
            this.btn_bajaRol = new System.Windows.Forms.Button();
            this.btn_modificacionRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_altaRol
            // 
            this.btn_altaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaRol.Location = new System.Drawing.Point(75, 80);
            this.btn_altaRol.Name = "btn_altaRol";
            this.btn_altaRol.Size = new System.Drawing.Size(125, 25);
            this.btn_altaRol.TabIndex = 0;
            this.btn_altaRol.Text = "Alta";
            this.btn_altaRol.UseVisualStyleBackColor = true;
            this.btn_altaRol.Click += new System.EventHandler(this.btn_altaRol_Click);
            // 
            // btn_bajaRol
            // 
            this.btn_bajaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bajaRol.Location = new System.Drawing.Point(75, 132);
            this.btn_bajaRol.Name = "btn_bajaRol";
            this.btn_bajaRol.Size = new System.Drawing.Size(125, 25);
            this.btn_bajaRol.TabIndex = 1;
            this.btn_bajaRol.Text = "Baja";
            this.btn_bajaRol.UseVisualStyleBackColor = true;
            // 
            // btn_modificacionRol
            // 
            this.btn_modificacionRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificacionRol.Location = new System.Drawing.Point(75, 183);
            this.btn_modificacionRol.Name = "btn_modificacionRol";
            this.btn_modificacionRol.Size = new System.Drawing.Size(125, 25);
            this.btn_modificacionRol.TabIndex = 2;
            this.btn_modificacionRol.Text = "Modificación";
            this.btn_modificacionRol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Funcionalidades";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(75, 252);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(125, 23);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // AbmRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacionRol);
            this.Controls.Add(this.btn_bajaRol);
            this.Controls.Add(this.btn_altaRol);
            this.Name = "AbmRolForm";
            this.Text = "AbmRolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaRol;
        private System.Windows.Forms.Button btn_bajaRol;
        private System.Windows.Forms.Button btn_modificacionRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
    }
}