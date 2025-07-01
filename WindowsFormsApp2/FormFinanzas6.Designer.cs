namespace WindowsFormsApp2
{
    partial class FormFinanzas6
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgKPIsCumplidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoReporte = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreReporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDescripcionReporte = new System.Windows.Forms.RichTextBox();
            this.btnGuardarReporte = new System.Windows.Forms.Button();
            this.btnAbrirReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKPIsCumplidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 52);
            this.label1.TabIndex = 54;
            this.label1.Text = "Reportes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Objetivos KPI cumplidos:";
            // 
            // dgKPIsCumplidos
            // 
            this.dgKPIsCumplidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKPIsCumplidos.Location = new System.Drawing.Point(35, 157);
            this.dgKPIsCumplidos.Name = "dgKPIsCumplidos";
            this.dgKPIsCumplidos.RowHeadersWidth = 51;
            this.dgKPIsCumplidos.RowTemplate.Height = 24;
            this.dgKPIsCumplidos.Size = new System.Drawing.Size(595, 311);
            this.dgKPIsCumplidos.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Ingresar Reporte:";
            // 
            // tbCodigoReporte
            // 
            this.tbCodigoReporte.Location = new System.Drawing.Point(773, 157);
            this.tbCodigoReporte.Name = "tbCodigoReporte";
            this.tbCodigoReporte.Size = new System.Drawing.Size(380, 22);
            this.tbCodigoReporte.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(693, 157);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 22);
            this.label15.TabIndex = 92;
            this.label15.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 94;
            this.label4.Text = "Nombre:";
            // 
            // tbNombreReporte
            // 
            this.tbNombreReporte.Location = new System.Drawing.Point(773, 194);
            this.tbNombreReporte.Name = "tbNombreReporte";
            this.tbNombreReporte.Size = new System.Drawing.Size(380, 22);
            this.tbNombreReporte.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 96;
            this.label5.Text = "Fecha:";
            // 
            // dtpFechaReporte
            // 
            this.dtpFechaReporte.Location = new System.Drawing.Point(773, 233);
            this.dtpFechaReporte.Name = "dtpFechaReporte";
            this.dtpFechaReporte.Size = new System.Drawing.Size(380, 22);
            this.dtpFechaReporte.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(657, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 98;
            this.label7.Text = "Descripción:";
            // 
            // rtbDescripcionReporte
            // 
            this.rtbDescripcionReporte.Location = new System.Drawing.Point(773, 275);
            this.rtbDescripcionReporte.Name = "rtbDescripcionReporte";
            this.rtbDescripcionReporte.Size = new System.Drawing.Size(380, 193);
            this.rtbDescripcionReporte.TabIndex = 99;
            this.rtbDescripcionReporte.Text = "";
            // 
            // btnGuardarReporte
            // 
            this.btnGuardarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReporte.Location = new System.Drawing.Point(860, 498);
            this.btnGuardarReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarReporte.Name = "btnGuardarReporte";
            this.btnGuardarReporte.Size = new System.Drawing.Size(208, 49);
            this.btnGuardarReporte.TabIndex = 100;
            this.btnGuardarReporte.Text = "Guardar Reporte";
            this.btnGuardarReporte.UseVisualStyleBackColor = true;
            // 
            // btnAbrirReporte
            // 
            this.btnAbrirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirReporte.Location = new System.Drawing.Point(422, 498);
            this.btnAbrirReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirReporte.Name = "btnAbrirReporte";
            this.btnAbrirReporte.Size = new System.Drawing.Size(208, 49);
            this.btnAbrirReporte.TabIndex = 101;
            this.btnAbrirReporte.Text = "Abrir Reporte";
            this.btnAbrirReporte.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(13, 560);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 38);
            this.btnSalir.TabIndex = 102;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormFinanzas6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 609);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrirReporte);
            this.Controls.Add(this.btnGuardarReporte);
            this.Controls.Add(this.rtbDescripcionReporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombreReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodigoReporte);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgKPIsCumplidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormFinanzas6";
            this.Text = "FormFinanzas6";
            ((System.ComponentModel.ISupportInitialize)(this.dgKPIsCumplidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgKPIsCumplidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoReporte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDescripcionReporte;
        private System.Windows.Forms.Button btnGuardarReporte;
        private System.Windows.Forms.Button btnAbrirReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}