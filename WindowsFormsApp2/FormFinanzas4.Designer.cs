namespace WindowsFormsApp2
{
    partial class FormFinanzas4
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
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCodigoFondo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.tbCantidadFondo = new System.Windows.Forms.TextBox();
            this.dgFondos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadTotalFondos = new System.Windows.Forms.Label();
            this.btnRegistrarFondo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFondos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fondos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(51, 130);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(474, 25);
            this.label17.TabIndex = 71;
            this.label17.Text = "Ingresa los datos de los fondos que tiene tu empresa:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(132, 181);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 22);
            this.label15.TabIndex = 72;
            this.label15.Text = "Código:";
            // 
            // tbCodigoFondo
            // 
            this.tbCodigoFondo.Location = new System.Drawing.Point(221, 183);
            this.tbCodigoFondo.Name = "tbCodigoFondo";
            this.tbCodigoFondo.Size = new System.Drawing.Size(230, 22);
            this.tbCodigoFondo.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "¿Está disponible?";
            // 
            // cbDisponibilidad
            // 
            this.cbDisponibilidad.FormattingEnabled = true;
            this.cbDisponibilidad.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbDisponibilidad.Location = new System.Drawing.Point(221, 278);
            this.cbDisponibilidad.Name = "cbDisponibilidad";
            this.cbDisponibilidad.Size = new System.Drawing.Size(152, 24);
            this.cbDisponibilidad.TabIndex = 76;
            // 
            // tbCantidadFondo
            // 
            this.tbCantidadFondo.Location = new System.Drawing.Point(221, 229);
            this.tbCantidadFondo.Name = "tbCantidadFondo";
            this.tbCantidadFondo.Size = new System.Drawing.Size(230, 22);
            this.tbCantidadFondo.TabIndex = 77;
            // 
            // dgFondos
            // 
            this.dgFondos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFondos.Location = new System.Drawing.Point(56, 437);
            this.dgFondos.Name = "dgFondos";
            this.dgFondos.RowHeadersWidth = 51;
            this.dgFondos.RowTemplate.Height = 24;
            this.dgFondos.Size = new System.Drawing.Size(622, 247);
            this.dgFondos.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Tus fondos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(29, 729);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 80;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 710);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Cantidad Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCantidadTotalFondos
            // 
            this.lblCantidadTotalFondos.AutoSize = true;
            this.lblCantidadTotalFondos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotalFondos.Location = new System.Drawing.Point(585, 710);
            this.lblCantidadTotalFondos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadTotalFondos.Name = "lblCantidadTotalFondos";
            this.lblCantidadTotalFondos.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadTotalFondos.TabIndex = 82;
            this.lblCantidadTotalFondos.Text = "0";
            this.lblCantidadTotalFondos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnRegistrarFondo
            // 
            this.btnRegistrarFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarFondo.Location = new System.Drawing.Point(217, 328);
            this.btnRegistrarFondo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarFondo.Name = "btnRegistrarFondo";
            this.btnRegistrarFondo.Size = new System.Drawing.Size(208, 49);
            this.btnRegistrarFondo.TabIndex = 85;
            this.btnRegistrarFondo.Text = "Registrar Fondo";
            this.btnRegistrarFondo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(569, 394);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 36);
            this.btnEliminar.TabIndex = 87;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(441, 394);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 36);
            this.btnEditar.TabIndex = 86;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormFinanzas4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 785);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrarFondo);
            this.Controls.Add(this.lblCantidadTotalFondos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgFondos);
            this.Controls.Add(this.tbCantidadFondo);
            this.Controls.Add(this.cbDisponibilidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigoFondo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Name = "FormFinanzas4";
            this.Text = "FormFinanzas4";
            ((System.ComponentModel.ISupportInitialize)(this.dgFondos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCodigoFondo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDisponibilidad;
        private System.Windows.Forms.TextBox tbCantidadFondo;
        private System.Windows.Forms.DataGridView dgFondos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidadTotalFondos;
        private System.Windows.Forms.Button btnRegistrarFondo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}