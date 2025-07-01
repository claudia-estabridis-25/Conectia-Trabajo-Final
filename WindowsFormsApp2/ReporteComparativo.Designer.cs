namespace WindowsFormsApp2
{
    partial class ReporteComparativo
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
            this.btnComparar = new System.Windows.Forms.Button();
            this.cbPeriodoFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirReporteComparativoDeGastos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 220);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(378, 154);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(138, 46);
            this.btnComparar.TabIndex = 13;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // cbPeriodoFiltrar
            // 
            this.cbPeriodoFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodoFiltrar.FormattingEnabled = true;
            this.cbPeriodoFiltrar.Location = new System.Drawing.Point(112, 164);
            this.cbPeriodoFiltrar.Name = "cbPeriodoFiltrar";
            this.cbPeriodoFiltrar.Size = new System.Drawing.Size(224, 28);
            this.cbPeriodoFiltrar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Periodo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reporte comparativo de gasto entre diferentes sedes";
            // 
            // btnSalirReporteComparativoDeGastos
            // 
            this.btnSalirReporteComparativoDeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirReporteComparativoDeGastos.Location = new System.Drawing.Point(695, 463);
            this.btnSalirReporteComparativoDeGastos.Name = "btnSalirReporteComparativoDeGastos";
            this.btnSalirReporteComparativoDeGastos.Size = new System.Drawing.Size(118, 42);
            this.btnSalirReporteComparativoDeGastos.TabIndex = 15;
            this.btnSalirReporteComparativoDeGastos.Text = "Salir";
            this.btnSalirReporteComparativoDeGastos.UseVisualStyleBackColor = true;
            this.btnSalirReporteComparativoDeGastos.Click += new System.EventHandler(this.btnSalirReporteComparativoDeGastos_Click);
            // 
            // ReporteComparativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 517);
            this.Controls.Add(this.btnSalirReporteComparativoDeGastos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.cbPeriodoFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteComparativo";
            this.Text = "ReporteComparativoGastoDiferentesSedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.ComboBox cbPeriodoFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirReporteComparativoDeGastos;
    }
}