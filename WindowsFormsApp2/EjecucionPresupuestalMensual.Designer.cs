namespace WindowsFormsApp2
{
    partial class EjecucionPresupuestalMensual
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
            this.btnExprotarApdf = new System.Windows.Forms.Button();
            this.label500000 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporteEjecucionMensualUnidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbMesPresupuestoMensual = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirEjecucionPresupuestal = new System.Windows.Forms.Button();
            this.lblTotalPresupuesto = new System.Windows.Forms.Label();
            this.lblTotalEjecutado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExprotarApdf
            // 
            this.btnExprotarApdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExprotarApdf.Location = new System.Drawing.Point(435, 553);
            this.btnExprotarApdf.Name = "btnExprotarApdf";
            this.btnExprotarApdf.Size = new System.Drawing.Size(162, 49);
            this.btnExprotarApdf.TabIndex = 35;
            this.btnExprotarApdf.Text = "Exportar a PDF ";
            this.btnExprotarApdf.UseVisualStyleBackColor = true;
            // 
            // label500000
            // 
            this.label500000.AutoSize = true;
            this.label500000.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label500000.Location = new System.Drawing.Point(85, 582);
            this.label500000.Name = "label500000";
            this.label500000.Size = new System.Drawing.Size(130, 20);
            this.label500000.TabIndex = 32;
            this.label500000.Text = "Total Ejecutado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total presupuesto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 267);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnGenerarReporteEjecucionMensualUnidad
            // 
            this.btnGenerarReporteEjecucionMensualUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteEjecucionMensualUnidad.Location = new System.Drawing.Point(278, 192);
            this.btnGenerarReporteEjecucionMensualUnidad.Name = "btnGenerarReporteEjecucionMensualUnidad";
            this.btnGenerarReporteEjecucionMensualUnidad.Size = new System.Drawing.Size(162, 49);
            this.btnGenerarReporteEjecucionMensualUnidad.TabIndex = 29;
            this.btnGenerarReporteEjecucionMensualUnidad.Text = "Reporte";
            this.btnGenerarReporteEjecucionMensualUnidad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Unidad:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 27;
            // 
            // cbMesPresupuestoMensual
            // 
            this.cbMesPresupuestoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesPresupuestoMensual.FormattingEnabled = true;
            this.cbMesPresupuestoMensual.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio ",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMesPresupuestoMensual.Location = new System.Drawing.Point(114, 147);
            this.cbMesPresupuestoMensual.Name = "cbMesPresupuestoMensual";
            this.cbMesPresupuestoMensual.Size = new System.Drawing.Size(197, 28);
            this.cbMesPresupuestoMensual.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ejecución Presupuestal Mensual por Unidad";
            // 
            // btnSalirEjecucionPresupuestal
            // 
            this.btnSalirEjecucionPresupuestal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEjecucionPresupuestal.Location = new System.Drawing.Point(598, 657);
            this.btnSalirEjecucionPresupuestal.Name = "btnSalirEjecucionPresupuestal";
            this.btnSalirEjecucionPresupuestal.Size = new System.Drawing.Size(132, 40);
            this.btnSalirEjecucionPresupuestal.TabIndex = 36;
            this.btnSalirEjecucionPresupuestal.Text = "Salir";
            this.btnSalirEjecucionPresupuestal.UseVisualStyleBackColor = true;
            this.btnSalirEjecucionPresupuestal.Click += new System.EventHandler(this.btnSalirEjecucionPresupuestal_Click);
            // 
            // lblTotalPresupuesto
            // 
            this.lblTotalPresupuesto.AutoSize = true;
            this.lblTotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPresupuesto.Location = new System.Drawing.Point(243, 549);
            this.lblTotalPresupuesto.Name = "lblTotalPresupuesto";
            this.lblTotalPresupuesto.Size = new System.Drawing.Size(18, 20);
            this.lblTotalPresupuesto.TabIndex = 37;
            this.lblTotalPresupuesto.Text = "0";
            // 
            // lblTotalEjecutado
            // 
            this.lblTotalEjecutado.AutoSize = true;
            this.lblTotalEjecutado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEjecutado.Location = new System.Drawing.Point(243, 582);
            this.lblTotalEjecutado.Name = "lblTotalEjecutado";
            this.lblTotalEjecutado.Size = new System.Drawing.Size(18, 20);
            this.lblTotalEjecutado.TabIndex = 38;
            this.lblTotalEjecutado.Text = "0";
            // 
            // EjecucionPresupuestalMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 709);
            this.Controls.Add(this.lblTotalEjecutado);
            this.Controls.Add(this.lblTotalPresupuesto);
            this.Controls.Add(this.btnSalirEjecucionPresupuestal);
            this.Controls.Add(this.btnExprotarApdf);
            this.Controls.Add(this.label500000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarReporteEjecucionMensualUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbMesPresupuestoMensual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EjecucionPresupuestalMensual";
            this.Text = "EjecucionPresupuestalMensual";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExprotarApdf;
        private System.Windows.Forms.Label label500000;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerarReporteEjecucionMensualUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbMesPresupuestoMensual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirEjecucionPresupuestal;
        private System.Windows.Forms.Label lblTotalPresupuesto;
        private System.Windows.Forms.Label lblTotalEjecutado;
    }
}