﻿namespace FrbaCrucero
{
    partial class loginView
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clienteboton = new System.Windows.Forms.Button();
            this.vendedorboton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.usuarioTextB = new System.Windows.Forms.TextBox();
            this.passTextB = new System.Windows.Forms.TextBox();
            this.userPassLabel = new System.Windows.Forms.Label();
            this.opcionLabel = new System.Windows.Forms.Label();
            this.ingresarboton = new System.Windows.Forms.Button();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clienteboton
            // 
            this.clienteboton.Location = new System.Drawing.Point(16, 85);
            this.clienteboton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteboton.Name = "clienteboton";
            this.clienteboton.Size = new System.Drawing.Size(100, 28);
            this.clienteboton.TabIndex = 0;
            this.clienteboton.Text = "Cliente";
            this.clienteboton.UseVisualStyleBackColor = true;
            this.clienteboton.Click += new System.EventHandler(this.clienteboton_Click);
            // 
            // vendedorboton
            // 
            this.vendedorboton.Location = new System.Drawing.Point(16, 137);
            this.vendedorboton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vendedorboton.Name = "vendedorboton";
            this.vendedorboton.Size = new System.Drawing.Size(100, 28);
            this.vendedorboton.TabIndex = 1;
            this.vendedorboton.Text = "Vendedor";
            this.vendedorboton.UseVisualStyleBackColor = true;
            this.vendedorboton.Click += new System.EventHandler(this.vendedorboton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(268, 97);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(57, 17);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Usuario";
            this.userLabel.Visible = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(268, 158);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(81, 17);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Contraseña";
            this.passLabel.Visible = false;
            // 
            // usuarioTextB
            // 
            this.usuarioTextB.Location = new System.Drawing.Point(372, 94);
            this.usuarioTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuarioTextB.Name = "usuarioTextB";
            this.usuarioTextB.Size = new System.Drawing.Size(132, 22);
            this.usuarioTextB.TabIndex = 4;
            this.usuarioTextB.Visible = false;
            this.usuarioTextB.TextChanged += new System.EventHandler(this.usuarioTextB_TextChanged);
            // 
            // passTextB
            // 
            this.passTextB.Location = new System.Drawing.Point(372, 149);
            this.passTextB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTextB.Name = "passTextB";
            this.passTextB.PasswordChar = '*';
            this.passTextB.Size = new System.Drawing.Size(132, 22);
            this.passTextB.TabIndex = 5;
            this.passTextB.Visible = false;
            this.passTextB.TextChanged += new System.EventHandler(this.passTextB_TextChanged);
            // 
            // userPassLabel
            // 
            this.userPassLabel.AutoSize = true;
            this.userPassLabel.Location = new System.Drawing.Point(291, 52);
            this.userPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPassLabel.Name = "userPassLabel";
            this.userPassLabel.Size = new System.Drawing.Size(196, 17);
            this.userPassLabel.TabIndex = 6;
            this.userPassLabel.Text = "Ingrese Usuario y Contraseña";
            this.userPassLabel.Visible = false;
            // 
            // opcionLabel
            // 
            this.opcionLabel.AutoSize = true;
            this.opcionLabel.Location = new System.Drawing.Point(16, 30);
            this.opcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opcionLabel.Name = "opcionLabel";
            this.opcionLabel.Size = new System.Drawing.Size(154, 17);
            this.opcionLabel.TabIndex = 7;
            this.opcionLabel.Text = "Seleccione una Opcion";
            // 
            // ingresarboton
            // 
            this.ingresarboton.Location = new System.Drawing.Point(272, 198);
            this.ingresarboton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ingresarboton.Name = "ingresarboton";
            this.ingresarboton.Size = new System.Drawing.Size(100, 28);
            this.ingresarboton.TabIndex = 8;
            this.ingresarboton.Text = "Ingresar";
            this.ingresarboton.UseVisualStyleBackColor = true;
            this.ingresarboton.Visible = false;
            this.ingresarboton.Click += new System.EventHandler(this.ingresarboton_Click);
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.Location = new System.Drawing.Point(440, 198);
            this.cancelarBoton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(100, 28);
            this.cancelarBoton.TabIndex = 9;
            this.cancelarBoton.Text = "Cancelar";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // loginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 252);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.ingresarboton);
            this.Controls.Add(this.opcionLabel);
            this.Controls.Add(this.userPassLabel);
            this.Controls.Add(this.passTextB);
            this.Controls.Add(this.usuarioTextB);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.vendedorboton);
            this.Controls.Add(this.clienteboton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginView";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clienteboton;
        private System.Windows.Forms.Button vendedorboton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox usuarioTextB;
        private System.Windows.Forms.TextBox passTextB;
        private System.Windows.Forms.Label userPassLabel;
        private System.Windows.Forms.Label opcionLabel;
        private System.Windows.Forms.Button ingresarboton;
        private System.Windows.Forms.Button cancelarBoton;



    }
}

