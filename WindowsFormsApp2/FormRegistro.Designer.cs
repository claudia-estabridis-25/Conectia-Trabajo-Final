namespace WindowsFormsApp2
{
    partial class FormRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbRubro = new System.Windows.Forms.TextBox();
            this.tbGerente = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "¡Bienvenido a Conectia! A continuación registra tu empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número RUC:";
            // 
            // tbRuc
            // 
            this.tbRuc.Location = new System.Drawing.Point(234, 293);
            this.tbRuc.Margin = new System.Windows.Forms.Padding(4);
            this.tbRuc.Name = "tbRuc";
            this.tbRuc.Size = new System.Drawing.Size(248, 22);
            this.tbRuc.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rubro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gerente General:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(234, 337);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(248, 22);
            this.tbNombre.TabIndex = 13;
            // 
            // tbRubro
            // 
            this.tbRubro.Location = new System.Drawing.Point(234, 379);
            this.tbRubro.Margin = new System.Windows.Forms.Padding(4);
            this.tbRubro.Name = "tbRubro";
            this.tbRubro.Size = new System.Drawing.Size(248, 22);
            this.tbRubro.TabIndex = 14;
            // 
            // tbGerente
            // 
            this.tbGerente.Location = new System.Drawing.Point(234, 418);
            this.tbGerente.Margin = new System.Windows.Forms.Padding(4);
            this.tbGerente.Name = "tbGerente";
            this.tbGerente.Size = new System.Drawing.Size(248, 22);
            this.tbGerente.TabIndex = 15;
            // 
            // btnRegistrarEmpresa
            // 
            this.btnRegistrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpresa.Location = new System.Drawing.Point(261, 474);
            this.btnRegistrarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            this.btnRegistrarEmpresa.Size = new System.Drawing.Size(180, 47);
            this.btnRegistrarEmpresa.TabIndex = 16;
            this.btnRegistrarEmpresa.Text = "Registrar Empresa";
            this.btnRegistrarEmpresa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 62);
            this.label2.TabIndex = 17;
            this.label2.Text = "Registro";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(502, 623);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 43);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(21, 617);
            this.btnRegistrarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(180, 55);
            this.btnRegistrarEmpleado.TabIndex = 26;
            this.btnRegistrarEmpleado.Text = "Registrar empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnIniciaSesion_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 690);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarEmpresa);
            this.Controls.Add(this.tbGerente);
            this.Controls.Add(this.tbRubro);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistro";
            this.Text = "Conectia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbRubro;
        private System.Windows.Forms.TextBox tbGerente;
        private System.Windows.Forms.Button btnRegistrarEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
    }
}

