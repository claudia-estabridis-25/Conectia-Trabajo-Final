namespace WindowsFormsApp2
{
    partial class FormInventario1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoMaterial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombreMaterial = new System.Windows.Forms.TextBox();
            this.tbAreaEmpresaMaterial = new System.Windows.Forms.TextBox();
            this.dtpFechaAdquisicionMaterial = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalRecursosMateriales = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstadoMaterial = new System.Windows.Forms.ComboBox();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVerMantenimiento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDisponibilidadMaterial = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbStockMaterial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCategoriaMaterial = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Registro de Recusos Materiales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingresa los datos del recurso material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Código:";
            // 
            // tbCodigoMaterial
            // 
            this.tbCodigoMaterial.Location = new System.Drawing.Point(221, 195);
            this.tbCodigoMaterial.Name = "tbCodigoMaterial";
            this.tbCodigoMaterial.Size = new System.Drawing.Size(235, 22);
            this.tbCodigoMaterial.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Fecha de adquisición:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Área de la empresa:";
            // 
            // tbNombreMaterial
            // 
            this.tbNombreMaterial.Location = new System.Drawing.Point(221, 234);
            this.tbNombreMaterial.Name = "tbNombreMaterial";
            this.tbNombreMaterial.Size = new System.Drawing.Size(235, 22);
            this.tbNombreMaterial.TabIndex = 33;
            // 
            // tbAreaEmpresaMaterial
            // 
            this.tbAreaEmpresaMaterial.Location = new System.Drawing.Point(221, 395);
            this.tbAreaEmpresaMaterial.Name = "tbAreaEmpresaMaterial";
            this.tbAreaEmpresaMaterial.Size = new System.Drawing.Size(235, 22);
            this.tbAreaEmpresaMaterial.TabIndex = 35;
            // 
            // dtpFechaAdquisicionMaterial
            // 
            this.dtpFechaAdquisicionMaterial.Location = new System.Drawing.Point(221, 273);
            this.dtpFechaAdquisicionMaterial.Name = "dtpFechaAdquisicionMaterial";
            this.dtpFechaAdquisicionMaterial.Size = new System.Drawing.Size(235, 22);
            this.dtpFechaAdquisicionMaterial.TabIndex = 36;
            // 
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(249, 520);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(173, 52);
            this.btnRegistrarMaterial.TabIndex = 37;
            this.btnRegistrarMaterial.Text = "Registrar";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 296);
            this.dataGridView1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Lista de recursos materiales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(929, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total:";
            // 
            // lblTotalRecursosMateriales
            // 
            this.lblTotalRecursosMateriales.AutoSize = true;
            this.lblTotalRecursosMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecursosMateriales.Location = new System.Drawing.Point(1005, 502);
            this.lblTotalRecursosMateriales.Name = "lblTotalRecursosMateriales";
            this.lblTotalRecursosMateriales.Size = new System.Drawing.Size(18, 20);
            this.lblTotalRecursosMateriales.TabIndex = 41;
            this.lblTotalRecursosMateriales.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Estado:";
            // 
            // cbEstadoMaterial
            // 
            this.cbEstadoMaterial.FormattingEnabled = true;
            this.cbEstadoMaterial.Items.AddRange(new object[] {
            "Óptimo",
            "Bueno",
            "Regular",
            "Malo",
            "Dañado"});
            this.cbEstadoMaterial.Location = new System.Drawing.Point(221, 310);
            this.cbEstadoMaterial.Name = "cbEstadoMaterial";
            this.cbEstadoMaterial.Size = new System.Drawing.Size(235, 24);
            this.cbEstadoMaterial.TabIndex = 43;
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportes.Location = new System.Drawing.Point(34, 668);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(173, 52);
            this.btnVerReportes.TabIndex = 44;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 621);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 22);
            this.label10.TabIndex = 45;
            this.label10.Text = "Clic aquí para ver los reportes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 621);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "Clic aquí para ver el mantenimiento:";
            // 
            // btnVerMantenimiento
            // 
            this.btnVerMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMantenimiento.Location = new System.Drawing.Point(313, 668);
            this.btnVerMantenimiento.Name = "btnVerMantenimiento";
            this.btnVerMantenimiento.Size = new System.Drawing.Size(173, 52);
            this.btnVerMantenimiento.TabIndex = 47;
            this.btnVerMantenimiento.Text = "Ver Mantenimiento";
            this.btnVerMantenimiento.UseVisualStyleBackColor = true;
            this.btnVerMantenimiento.Click += new System.EventHandler(this.btnVerMantenimiento_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(999, 705);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 42);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(636, 621);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(397, 22);
            this.label12.TabIndex = 49;
            this.label12.Text = "Clic aquí para consultar el stock y disponibilidad:";
            // 
            // btnVerStock
            // 
            this.btnVerStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerStock.Location = new System.Drawing.Point(640, 668);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(226, 52);
            this.btnVerStock.TabIndex = 50;
            this.btnVerStock.Text = "Ver Stock y Disponibilidad";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(85, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Disponibilidad:";
            // 
            // cbDisponibilidadMaterial
            // 
            this.cbDisponibilidadMaterial.FormattingEnabled = true;
            this.cbDisponibilidadMaterial.Items.AddRange(new object[] {
            "Disponible",
            "En uso",
            "No disponible"});
            this.cbDisponibilidadMaterial.Location = new System.Drawing.Point(221, 435);
            this.cbDisponibilidadMaterial.Name = "cbDisponibilidadMaterial";
            this.cbDisponibilidadMaterial.Size = new System.Drawing.Size(235, 24);
            this.cbDisponibilidadMaterial.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(148, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 53;
            this.label14.Text = "Stock:";
            // 
            // tbStockMaterial
            // 
            this.tbStockMaterial.Location = new System.Drawing.Point(221, 481);
            this.tbStockMaterial.Name = "tbStockMaterial";
            this.tbStockMaterial.Size = new System.Drawing.Size(235, 22);
            this.tbStockMaterial.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(118, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Categoría:";
            // 
            // cbCategoriaMaterial
            // 
            this.cbCategoriaMaterial.FormattingEnabled = true;
            this.cbCategoriaMaterial.Items.AddRange(new object[] {
            "Material de oficina",
            "Aparatos electrónicos",
            "Computadoras",
            "Impresoras",
            "Cosas de escritorio"});
            this.cbCategoriaMaterial.Location = new System.Drawing.Point(221, 350);
            this.cbCategoriaMaterial.Name = "cbCategoriaMaterial";
            this.cbCategoriaMaterial.Size = new System.Drawing.Size(235, 24);
            this.cbCategoriaMaterial.TabIndex = 56;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(708, 502);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 48);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(516, 502);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 48);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormInventarioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 759);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbCategoriaMaterial);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbStockMaterial);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbDisponibilidadMaterial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerMantenimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.cbEstadoMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalRecursosMateriales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrarMaterial);
            this.Controls.Add(this.dtpFechaAdquisicionMaterial);
            this.Controls.Add(this.tbAreaEmpresaMaterial);
            this.Controls.Add(this.tbNombreMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodigoMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInventarioRegistro";
            this.Text = "FormInventarioRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombreMaterial;
        private System.Windows.Forms.TextBox tbAreaEmpresaMaterial;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicionMaterial;
        private System.Windows.Forms.Button btnRegistrarMaterial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalRecursosMateriales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEstadoMaterial;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVerMantenimiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbDisponibilidadMaterial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbStockMaterial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCategoriaMaterial;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}