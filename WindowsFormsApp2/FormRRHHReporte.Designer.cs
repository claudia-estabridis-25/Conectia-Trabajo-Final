namespace WindowsFormsApp2
{
    partial class FormRRHHReporte
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
            this.cbTipoProyecto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnListarProyectos = new System.Windows.Forms.Button();
            this.tbPuntaje = new System.Windows.Forms.TextBox();
            this.btnListarEmpleadosPuntaje = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarPorTareas = new System.Windows.Forms.Button();
            this.tbTarea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarPorTipoProyecto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgProyectos = new System.Windows.Forms.DataGridView();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoProyecto
            // 
            this.cbTipoProyecto.FormattingEnabled = true;
            this.cbTipoProyecto.Location = new System.Drawing.Point(51, 813);
            this.cbTipoProyecto.Name = "cbTipoProyecto";
            this.cbTipoProyecto.Size = new System.Drawing.Size(270, 24);
            this.cbTipoProyecto.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 351);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(258, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "Ingresa un puntaje de evaluación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Ingresa la fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Ingresa la fecha de fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(56, 107);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaInicio.TabIndex = 94;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(56, 179);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaFin.TabIndex = 95;
            // 
            // btnListarProyectos
            // 
            this.btnListarProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProyectos.Location = new System.Drawing.Point(108, 218);
            this.btnListarProyectos.Name = "btnListarProyectos";
            this.btnListarProyectos.Size = new System.Drawing.Size(170, 51);
            this.btnListarProyectos.TabIndex = 96;
            this.btnListarProyectos.Text = "Mostrar proyectos";
            this.btnListarProyectos.UseVisualStyleBackColor = true;
            // 
            // tbPuntaje
            // 
            this.tbPuntaje.Location = new System.Drawing.Point(56, 387);
            this.tbPuntaje.Name = "tbPuntaje";
            this.tbPuntaje.Size = new System.Drawing.Size(274, 22);
            this.tbPuntaje.TabIndex = 97;
            // 
            // btnListarEmpleadosPuntaje
            // 
            this.btnListarEmpleadosPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEmpleadosPuntaje.Location = new System.Drawing.Point(108, 426);
            this.btnListarEmpleadosPuntaje.Name = "btnListarEmpleadosPuntaje";
            this.btnListarEmpleadosPuntaje.Size = new System.Drawing.Size(170, 51);
            this.btnListarEmpleadosPuntaje.TabIndex = 98;
            this.btnListarEmpleadosPuntaje.Text = "Mostrar empleados";
            this.btnListarEmpleadosPuntaje.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Proyectos según rango de fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Empleados según puntaje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 528);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 22);
            this.label5.TabIndex = 104;
            this.label5.Text = "Buscar empleados por tareas";
            // 
            // btnBuscarPorTareas
            // 
            this.btnBuscarPorTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorTareas.Location = new System.Drawing.Point(108, 641);
            this.btnBuscarPorTareas.Name = "btnBuscarPorTareas";
            this.btnBuscarPorTareas.Size = new System.Drawing.Size(170, 51);
            this.btnBuscarPorTareas.TabIndex = 103;
            this.btnBuscarPorTareas.Text = "Buscar";
            this.btnBuscarPorTareas.UseVisualStyleBackColor = true;
            // 
            // tbTarea
            // 
            this.tbTarea.Location = new System.Drawing.Point(56, 602);
            this.tbTarea.Name = "tbTarea";
            this.tbTarea.Size = new System.Drawing.Size(274, 22);
            this.tbTarea.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 566);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Ingresa el nombre de una tarea:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 742);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 22);
            this.label7.TabIndex = 108;
            this.label7.Text = "Empleados según tipo de proyecto";
            // 
            // btnBuscarPorTipoProyecto
            // 
            this.btnBuscarPorTipoProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorTipoProyecto.Location = new System.Drawing.Point(108, 855);
            this.btnBuscarPorTipoProyecto.Name = "btnBuscarPorTipoProyecto";
            this.btnBuscarPorTipoProyecto.Size = new System.Drawing.Size(170, 51);
            this.btnBuscarPorTipoProyecto.TabIndex = 107;
            this.btnBuscarPorTipoProyecto.Text = "Buscar";
            this.btnBuscarPorTipoProyecto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 780);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 20);
            this.label8.TabIndex = 105;
            this.label8.Text = "Ingresa un tipo de proyecto:";
            // 
            // dgProyectos
            // 
            this.dgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProyectos.Location = new System.Drawing.Point(394, 34);
            this.dgProyectos.Name = "dgProyectos";
            this.dgProyectos.RowHeadersWidth = 51;
            this.dgProyectos.RowTemplate.Height = 24;
            this.dgProyectos.Size = new System.Drawing.Size(838, 385);
            this.dgProyectos.TabIndex = 109;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(394, 486);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(838, 385);
            this.dgEmpleados.TabIndex = 110;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1124, 914);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 39);
            this.btnSalir.TabIndex = 111;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormRRHHReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 966);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.dgProyectos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarPorTipoProyecto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarPorTareas);
            this.Controls.Add(this.tbTarea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListarEmpleadosPuntaje);
            this.Controls.Add(this.tbPuntaje);
            this.Controls.Add(this.btnListarProyectos);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbTipoProyecto);
            this.Name = "FormRRHHReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoProyecto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnListarProyectos;
        private System.Windows.Forms.TextBox tbPuntaje;
        private System.Windows.Forms.Button btnListarEmpleadosPuntaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarPorTareas;
        private System.Windows.Forms.TextBox tbTarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarPorTipoProyecto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgProyectos;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnSalir;
    }
}