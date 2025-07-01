namespace WindowsFormsApp2
{
    partial class FormInventario2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarMaterialFiltros = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbCategoriaMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreMaterial = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstadoMaterial = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaAdquisicionMaterial = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarMaterialPorNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Consultar stock y disponibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Stock y Disponibilidad Actual:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(646, 350);
            this.dataGridView1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(741, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Buscar por nombre:";
            // 
            // btnMostrarMaterialFiltros
            // 
            this.btnMostrarMaterialFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMaterialFiltros.Location = new System.Drawing.Point(880, 329);
            this.btnMostrarMaterialFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarMaterialFiltros.Name = "btnMostrarMaterialFiltros";
            this.btnMostrarMaterialFiltros.Size = new System.Drawing.Size(138, 46);
            this.btnMostrarMaterialFiltros.TabIndex = 42;
            this.btnMostrarMaterialFiltros.Text = "Mostrar";
            this.btnMostrarMaterialFiltros.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(548, 131);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 41);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cbCategoriaMaterial
            // 
            this.cbCategoriaMaterial.FormattingEnabled = true;
            this.cbCategoriaMaterial.Location = new System.Drawing.Point(850, 205);
            this.cbCategoriaMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoriaMaterial.Name = "cbCategoriaMaterial";
            this.cbCategoriaMaterial.Size = new System.Drawing.Size(295, 24);
            this.cbCategoriaMaterial.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 112);
            this.label5.TabIndex = 45;
            this.label5.Text = "🔴 Stock bajo\n\n🟡 Stock medio\n\n🟢Stock alto\n\n⚫ Sin stock o fuera de servicio";
            // 
            // tbNombreMaterial
            // 
            this.tbNombreMaterial.Location = new System.Drawing.Point(750, 450);
            this.tbNombreMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreMaterial.Name = "tbNombreMaterial";
            this.tbNombreMaterial.Size = new System.Drawing.Size(249, 22);
            this.tbNombreMaterial.TabIndex = 46;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 596);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 41);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Aplicar filtros:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Estado:";
            // 
            // cbEstadoMaterial
            // 
            this.cbEstadoMaterial.FormattingEnabled = true;
            this.cbEstadoMaterial.Location = new System.Drawing.Point(850, 248);
            this.cbEstadoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoMaterial.Name = "cbEstadoMaterial";
            this.cbEstadoMaterial.Size = new System.Drawing.Size(295, 24);
            this.cbEstadoMaterial.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Fecha adquisición:";
            // 
            // dtpFechaAdquisicionMaterial
            // 
            this.dtpFechaAdquisicionMaterial.Location = new System.Drawing.Point(911, 286);
            this.dtpFechaAdquisicionMaterial.Name = "dtpFechaAdquisicionMaterial";
            this.dtpFechaAdquisicionMaterial.Size = new System.Drawing.Size(234, 22);
            this.dtpFechaAdquisicionMaterial.TabIndex = 52;
            // 
            // btnBuscarMaterialPorNombre
            // 
            this.btnBuscarMaterialPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMaterialPorNombre.Location = new System.Drawing.Point(1007, 437);
            this.btnBuscarMaterialPorNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarMaterialPorNombre.Name = "btnBuscarMaterialPorNombre";
            this.btnBuscarMaterialPorNombre.Size = new System.Drawing.Size(138, 46);
            this.btnBuscarMaterialPorNombre.TabIndex = 53;
            this.btnBuscarMaterialPorNombre.Text = "Buscar";
            this.btnBuscarMaterialPorNombre.UseVisualStyleBackColor = true;
            // 
            // FormInventario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 648);
            this.Controls.Add(this.btnBuscarMaterialPorNombre);
            this.Controls.Add(this.dtpFechaAdquisicionMaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEstadoMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbNombreMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCategoriaMaterial);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnMostrarMaterialFiltros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInventario2";
            this.Text = "FormInventario2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarMaterialFiltros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbCategoriaMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreMaterial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstadoMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicionMaterial;
        private System.Windows.Forms.Button btnBuscarMaterialPorNombre;
    }
}