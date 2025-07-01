namespace WindowsFormsApp2
{
    partial class FormReporteRRHH
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
            this.btnFiltrarTarea = new System.Windows.Forms.Button();
            this.lblTotalTareas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFiltrarFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFiltrarProyecto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiltrarEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarFecha = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidadEmpleadosDisponibles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgEmpleadosDisponibles = new System.Windows.Forms.DataGridView();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarTarea
            // 
            this.btnFiltrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTarea.Location = new System.Drawing.Point(241, 212);
            this.btnFiltrarTarea.Name = "btnFiltrarTarea";
            this.btnFiltrarTarea.Size = new System.Drawing.Size(150, 51);
            this.btnFiltrarTarea.TabIndex = 74;
            this.btnFiltrarTarea.Text = "Mostrar";
            this.btnFiltrarTarea.UseVisualStyleBackColor = true;
            // 
            // lblTotalTareas
            // 
            this.lblTotalTareas.AutoSize = true;
            this.lblTotalTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTareas.Location = new System.Drawing.Point(534, 570);
            this.lblTotalTareas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTareas.Name = "lblTotalTareas";
            this.lblTotalTareas.Size = new System.Drawing.Size(18, 20);
            this.lblTotalTareas.TabIndex = 73;
            this.lblTotalTareas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 570);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Total tareas:";
            // 
            // dtpFiltrarFecha
            // 
            this.dtpFiltrarFecha.Location = new System.Drawing.Point(247, 172);
            this.dtpFiltrarFecha.Name = "dtpFiltrarFecha";
            this.dtpFiltrarFecha.Size = new System.Drawing.Size(288, 22);
            this.dtpFiltrarFecha.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Filtrar por fecha:";
            // 
            // cbFiltrarProyecto
            // 
            this.cbFiltrarProyecto.FormattingEnabled = true;
            this.cbFiltrarProyecto.Location = new System.Drawing.Point(247, 129);
            this.cbFiltrarProyecto.Name = "cbFiltrarProyecto";
            this.cbFiltrarProyecto.Size = new System.Drawing.Size(288, 24);
            this.cbFiltrarProyecto.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Filtrar por proyecto:";
            // 
            // cbFiltrarEmpleado
            // 
            this.cbFiltrarEmpleado.FormattingEnabled = true;
            this.cbFiltrarEmpleado.Location = new System.Drawing.Point(247, 88);
            this.cbFiltrarEmpleado.Name = "cbFiltrarEmpleado";
            this.cbFiltrarEmpleado.Size = new System.Drawing.Size(288, 24);
            this.cbFiltrarEmpleado.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Filtrar por empleado:";
            // 
            // dgTareas
            // 
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Location = new System.Drawing.Point(39, 278);
            this.dgTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgTareas.Name = "dgTareas";
            this.dgTareas.RowHeadersWidth = 51;
            this.dgTareas.Size = new System.Drawing.Size(575, 275);
            this.dgTareas.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Aplica los filtros para visualizar las tareas:";
            // 
            // btnSeleccionarFecha
            // 
            this.btnSeleccionarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFecha.Location = new System.Drawing.Point(1230, 227);
            this.btnSeleccionarFecha.Name = "btnSeleccionarFecha";
            this.btnSeleccionarFecha.Size = new System.Drawing.Size(128, 55);
            this.btnSeleccionarFecha.TabIndex = 83;
            this.btnSeleccionarFecha.Text = "Seleccionar";
            this.btnSeleccionarFecha.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1197, 736);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 82;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCantidadEmpleadosDisponibles
            // 
            this.lblCantidadEmpleadosDisponibles.AutoSize = true;
            this.lblCantidadEmpleadosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEmpleadosDisponibles.Location = new System.Drawing.Point(946, 730);
            this.lblCantidadEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadEmpleadosDisponibles.Name = "lblCantidadEmpleadosDisponibles";
            this.lblCantidadEmpleadosDisponibles.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadEmpleadosDisponibles.TabIndex = 81;
            this.lblCantidadEmpleadosDisponibles.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 730);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Total de empleados disponibles:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(673, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Empleados disponibles:";
            // 
            // dgEmpleadosDisponibles
            // 
            this.dgEmpleadosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleadosDisponibles.Location = new System.Drawing.Point(677, 426);
            this.dgEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpleadosDisponibles.Name = "dgEmpleadosDisponibles";
            this.dgEmpleadosDisponibles.RowHeadersWidth = 51;
            this.dgEmpleadosDisponibles.Size = new System.Drawing.Size(648, 277);
            this.dgEmpleadosDisponibles.TabIndex = 78;
            // 
            // mcCalendario
            // 
            this.mcCalendario.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.mcCalendario.Location = new System.Drawing.Point(676, 141);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(673, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(606, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Selecciona una fecha para visualizar los empleados que estén disponibles:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 45);
            this.label9.TabIndex = 75;
            this.label9.Text = "Calendario de actividades";
            // 
            // FormReporteRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 922);
            this.Controls.Add(this.btnSeleccionarFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCantidadEmpleadosDisponibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgEmpleadosDisponibles);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFiltrarTarea);
            this.Controls.Add(this.lblTotalTareas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFiltrarFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFiltrarProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiltrarEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgTareas);
            this.Controls.Add(this.label2);
            this.Name = "FormReporteRRHH";
            this.Text = "FormReporteRRHH";
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrarTarea;
        private System.Windows.Forms.Label lblTotalTareas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFiltrarFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFiltrarProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltrarEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidadEmpleadosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgEmpleadosDisponibles;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}