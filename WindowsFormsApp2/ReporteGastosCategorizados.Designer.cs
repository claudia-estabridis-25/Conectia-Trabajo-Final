namespace WindowsFormsApp2
{
    partial class ReporteGastosCategorizados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.cbPeriodoFiltrar = new System.Windows.Forms.ComboBox();
            this.cbUnidadFiltrar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 187);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReporte.Location = new System.Drawing.Point(319, 265);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(169, 52);
            this.btnVerReporte.TabIndex = 19;
            this.btnVerReporte.Text = "Ver reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            // 
            // cbPeriodoFiltrar
            // 
            this.cbPeriodoFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodoFiltrar.FormattingEnabled = true;
            this.cbPeriodoFiltrar.Location = new System.Drawing.Point(472, 212);
            this.cbPeriodoFiltrar.Name = "cbPeriodoFiltrar";
            this.cbPeriodoFiltrar.Size = new System.Drawing.Size(210, 28);
            this.cbPeriodoFiltrar.TabIndex = 18;
            // 
            // cbUnidadFiltrar
            // 
            this.cbUnidadFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadFiltrar.FormattingEnabled = true;
            this.cbUnidadFiltrar.Location = new System.Drawing.Point(142, 212);
            this.cbUnidadFiltrar.Name = "cbUnidadFiltrar";
            this.cbUnidadFiltrar.Size = new System.Drawing.Size(210, 28);
            this.cbUnidadFiltrar.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Periodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = " Gastos Categorizados por Tipo de Compra";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(646, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 37);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSALIRgastos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(662, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selecciona por área o unidad de la empresa y por periodo para ver los tipos de co" +
    "mpra:";
            // 
            // ReporteGastosCategorizadosTipoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.cbPeriodoFiltrar);
            this.Controls.Add(this.cbUnidadFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteGastosCategorizadosTipoCompra";
            this.Text = "ReporteGastosCategorizadosTipoCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.ComboBox cbPeriodoFiltrar;
        private System.Windows.Forms.ComboBox cbUnidadFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
    }
}