namespace WindowsFormsApp2
{
    partial class FormInventario3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCategoriaMaterial = new System.Windows.Forms.TextBox();
            this.tbCodigoMaterial = new System.Windows.Forms.TextBox();
            this.btnBuscarPorCodigo = new System.Windows.Forms.Button();
            this.btnBuscarPorCategoria = new System.Windows.Forms.Button();
            this.dgAlertas = new System.Windows.Forms.DataGridView();
            this.btnOrdenarPrioridad = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDescargarAlertas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEstadoMaterial = new System.Windows.Forms.TextBox();
            this.btnBuscarPorEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "Alertas de Mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Categoría del recurso material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Código del recurso material: ";
            // 
            // tbCategoriaMaterial
            // 
            this.tbCategoriaMaterial.Location = new System.Drawing.Point(51, 338);
            this.tbCategoriaMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tbCategoriaMaterial.Name = "tbCategoriaMaterial";
            this.tbCategoriaMaterial.Size = new System.Drawing.Size(242, 22);
            this.tbCategoriaMaterial.TabIndex = 44;
            // 
            // tbCodigoMaterial
            // 
            this.tbCodigoMaterial.Location = new System.Drawing.Point(51, 228);
            this.tbCodigoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigoMaterial.Name = "tbCodigoMaterial";
            this.tbCodigoMaterial.Size = new System.Drawing.Size(242, 22);
            this.tbCodigoMaterial.TabIndex = 45;
            // 
            // btnBuscarPorCodigo
            // 
            this.btnBuscarPorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorCodigo.Location = new System.Drawing.Point(301, 215);
            this.btnBuscarPorCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorCodigo.Name = "btnBuscarPorCodigo";
            this.btnBuscarPorCodigo.Size = new System.Drawing.Size(133, 47);
            this.btnBuscarPorCodigo.TabIndex = 46;
            this.btnBuscarPorCodigo.Text = "Buscar";
            this.btnBuscarPorCodigo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorCategoria
            // 
            this.btnBuscarPorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorCategoria.Location = new System.Drawing.Point(301, 327);
            this.btnBuscarPorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorCategoria.Name = "btnBuscarPorCategoria";
            this.btnBuscarPorCategoria.Size = new System.Drawing.Size(133, 42);
            this.btnBuscarPorCategoria.TabIndex = 47;
            this.btnBuscarPorCategoria.Text = "Buscar";
            this.btnBuscarPorCategoria.UseVisualStyleBackColor = true;
            // 
            // dgAlertas
            // 
            this.dgAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlertas.Location = new System.Drawing.Point(494, 215);
            this.dgAlertas.Margin = new System.Windows.Forms.Padding(4);
            this.dgAlertas.Name = "dgAlertas";
            this.dgAlertas.RowHeadersWidth = 51;
            this.dgAlertas.Size = new System.Drawing.Size(634, 320);
            this.dgAlertas.TabIndex = 49;
            // 
            // btnOrdenarPrioridad
            // 
            this.btnOrdenarPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPrioridad.Location = new System.Drawing.Point(904, 143);
            this.btnOrdenarPrioridad.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarPrioridad.Name = "btnOrdenarPrioridad";
            this.btnOrdenarPrioridad.Size = new System.Drawing.Size(224, 46);
            this.btnOrdenarPrioridad.TabIndex = 50;
            this.btnOrdenarPrioridad.Text = "Ordenar por prioridad";
            this.btnOrdenarPrioridad.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(494, 143);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 46);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(22, 583);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 38);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ingresa los datos para mostrar alertas:";
            // 
            // btnDescargarAlertas
            // 
            this.btnDescargarAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarAlertas.Location = new System.Drawing.Point(674, 560);
            this.btnDescargarAlertas.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarAlertas.Name = "btnDescargarAlertas";
            this.btnDescargarAlertas.Size = new System.Drawing.Size(275, 53);
            this.btnDescargarAlertas.TabIndex = 54;
            this.btnDescargarAlertas.Text = "Descargar listado de alertas";
            this.btnDescargarAlertas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Estado del recurso material:";
            // 
            // tbEstadoMaterial
            // 
            this.tbEstadoMaterial.Location = new System.Drawing.Point(51, 453);
            this.tbEstadoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tbEstadoMaterial.Name = "tbEstadoMaterial";
            this.tbEstadoMaterial.Size = new System.Drawing.Size(242, 22);
            this.tbEstadoMaterial.TabIndex = 56;
            // 
            // btnBuscarPorEstado
            // 
            this.btnBuscarPorEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorEstado.Location = new System.Drawing.Point(301, 442);
            this.btnBuscarPorEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorEstado.Name = "btnBuscarPorEstado";
            this.btnBuscarPorEstado.Size = new System.Drawing.Size(133, 42);
            this.btnBuscarPorEstado.TabIndex = 57;
            this.btnBuscarPorEstado.Text = "Buscar";
            this.btnBuscarPorEstado.UseVisualStyleBackColor = true;
            // 
            // FormInventario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1180, 639);
            this.Controls.Add(this.btnBuscarPorEstado);
            this.Controls.Add(this.tbEstadoMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDescargarAlertas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnOrdenarPrioridad);
            this.Controls.Add(this.dgAlertas);
            this.Controls.Add(this.btnBuscarPorCategoria);
            this.Controls.Add(this.btnBuscarPorCodigo);
            this.Controls.Add(this.tbCodigoMaterial);
            this.Controls.Add(this.tbCategoriaMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInventario3";
            this.Text = "FormInventario3";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategoriaMaterial;
        private System.Windows.Forms.TextBox tbCodigoMaterial;
        private System.Windows.Forms.Button btnBuscarPorCodigo;
        private System.Windows.Forms.Button btnBuscarPorCategoria;
        private System.Windows.Forms.DataGridView dgAlertas;
        private System.Windows.Forms.Button btnOrdenarPrioridad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDescargarAlertas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEstadoMaterial;
        private System.Windows.Forms.Button btnBuscarPorEstado;
    }
}