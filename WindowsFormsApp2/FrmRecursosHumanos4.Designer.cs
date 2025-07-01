namespace WindowsFormsApp2
{
    partial class FrmRecursosHumanos4
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
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.dgEmpleadosDisponibles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadEmpleadosDisponibles = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "Calendario de actividades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(606, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Selecciona una fecha para visualizar los empleados que estén disponibles:";
            // 
            // mcCalendario
            // 
            this.mcCalendario.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mcCalendario.Location = new System.Drawing.Point(41, 149);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 27;
            // 
            // dgEmpleadosDisponibles
            // 
            this.dgEmpleadosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleadosDisponibles.Location = new System.Drawing.Point(42, 434);
            this.dgEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpleadosDisponibles.Name = "dgEmpleadosDisponibles";
            this.dgEmpleadosDisponibles.RowHeadersWidth = 51;
            this.dgEmpleadosDisponibles.Size = new System.Drawing.Size(648, 277);
            this.dgEmpleadosDisponibles.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Empleados disponibles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 738);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total de empleados disponibles:";
            // 
            // lblCantidadEmpleadosDisponibles
            // 
            this.lblCantidadEmpleadosDisponibles.AutoSize = true;
            this.lblCantidadEmpleadosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEmpleadosDisponibles.Location = new System.Drawing.Point(311, 738);
            this.lblCantidadEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadEmpleadosDisponibles.Name = "lblCantidadEmpleadosDisponibles";
            this.lblCantidadEmpleadosDisponibles.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadEmpleadosDisponibles.TabIndex = 32;
            this.lblCantidadEmpleadosDisponibles.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(562, 744);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionarFecha
            // 
            this.btnSeleccionarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFecha.Location = new System.Drawing.Point(595, 235);
            this.btnSeleccionarFecha.Name = "btnSeleccionarFecha";
            this.btnSeleccionarFecha.Size = new System.Drawing.Size(128, 55);
            this.btnSeleccionarFecha.TabIndex = 60;
            this.btnSeleccionarFecha.Text = "Seleccionar";
            this.btnSeleccionarFecha.UseVisualStyleBackColor = true;
            // 
            // FrmRecursosHumanos4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 800);
            this.Controls.Add(this.btnSeleccionarFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCantidadEmpleadosDisponibles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgEmpleadosDisponibles);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecursosHumanos4";
            this.Text = "FrmRecursosHumanos3";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.DataGridView dgEmpleadosDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadEmpleadosDisponibles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionarFecha;
    }
}