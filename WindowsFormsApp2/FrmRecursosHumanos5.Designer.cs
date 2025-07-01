namespace WindowsFormsApp2
{
    partial class FrmRecursosHumanos5
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
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltrarEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiltrarProyecto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFiltrarFecha = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalTareas = new System.Windows.Forms.Label();
            this.btnFiltrarTarea = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgProyectos = new System.Windows.Forms.DataGridView();
            this.tbCodigoTarea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreTarea = new System.Windows.Forms.TextBox();
            this.tbDescripcionTarea = new System.Windows.Forms.TextBox();
            this.btnRegistrarTarea = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 49);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Aplica los filtros para visualizar las tareas:";
            // 
            // dgTareas
            // 
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Location = new System.Drawing.Point(704, 346);
            this.dgTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgTareas.Name = "dgTareas";
            this.dgTareas.RowHeadersWidth = 51;
            this.dgTareas.Size = new System.Drawing.Size(575, 275);
            this.dgTareas.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filtrar por empleado:";
            // 
            // cbFiltrarEmpleado
            // 
            this.cbFiltrarEmpleado.FormattingEnabled = true;
            this.cbFiltrarEmpleado.Location = new System.Drawing.Point(912, 156);
            this.cbFiltrarEmpleado.Name = "cbFiltrarEmpleado";
            this.cbFiltrarEmpleado.Size = new System.Drawing.Size(288, 24);
            this.cbFiltrarEmpleado.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Filtrar por proyecto:";
            // 
            // cbFiltrarProyecto
            // 
            this.cbFiltrarProyecto.FormattingEnabled = true;
            this.cbFiltrarProyecto.Location = new System.Drawing.Point(912, 197);
            this.cbFiltrarProyecto.Name = "cbFiltrarProyecto";
            this.cbFiltrarProyecto.Size = new System.Drawing.Size(288, 24);
            this.cbFiltrarProyecto.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Filtrar por fecha:";
            // 
            // dtpFiltrarFecha
            // 
            this.dtpFiltrarFecha.Location = new System.Drawing.Point(912, 240);
            this.dtpFiltrarFecha.Name = "dtpFiltrarFecha";
            this.dtpFiltrarFecha.Size = new System.Drawing.Size(288, 22);
            this.dtpFiltrarFecha.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(605, 678);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 41);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1067, 638);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Total tareas:";
            // 
            // lblTotalTareas
            // 
            this.lblTotalTareas.AutoSize = true;
            this.lblTotalTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTareas.Location = new System.Drawing.Point(1199, 638);
            this.lblTotalTareas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTareas.Name = "lblTotalTareas";
            this.lblTotalTareas.Size = new System.Drawing.Size(18, 20);
            this.lblTotalTareas.TabIndex = 62;
            this.lblTotalTareas.Text = "0";
            // 
            // btnFiltrarTarea
            // 
            this.btnFiltrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTarea.Location = new System.Drawing.Point(906, 280);
            this.btnFiltrarTarea.Name = "btnFiltrarTarea";
            this.btnFiltrarTarea.Size = new System.Drawing.Size(150, 51);
            this.btnFiltrarTarea.TabIndex = 63;
            this.btnFiltrarTarea.Text = "Mostrar";
            this.btnFiltrarTarea.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 22);
            this.label7.TabIndex = 64;
            this.label7.Text = "Registra tareas en cada proyecto:";
            // 
            // dgProyectos
            // 
            this.dgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProyectos.Location = new System.Drawing.Point(31, 164);
            this.dgProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.dgProyectos.Name = "dgProyectos";
            this.dgProyectos.RowHeadersWidth = 51;
            this.dgProyectos.Size = new System.Drawing.Size(605, 278);
            this.dgProyectos.TabIndex = 65;
            // 
            // tbCodigoTarea
            // 
            this.tbCodigoTarea.Location = new System.Drawing.Point(195, 503);
            this.tbCodigoTarea.Name = "tbCodigoTarea";
            this.tbCodigoTarea.Size = new System.Drawing.Size(192, 22);
            this.tbCodigoTarea.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 505);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Código de tarea:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 539);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 574);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Descripción:";
            // 
            // tbNombreTarea
            // 
            this.tbNombreTarea.Location = new System.Drawing.Point(195, 539);
            this.tbNombreTarea.Name = "tbNombreTarea";
            this.tbNombreTarea.Size = new System.Drawing.Size(319, 22);
            this.tbNombreTarea.TabIndex = 70;
            // 
            // tbDescripcionTarea
            // 
            this.tbDescripcionTarea.Location = new System.Drawing.Point(195, 574);
            this.tbDescripcionTarea.Name = "tbDescripcionTarea";
            this.tbDescripcionTarea.Size = new System.Drawing.Size(319, 22);
            this.tbDescripcionTarea.TabIndex = 71;
            // 
            // btnRegistrarTarea
            // 
            this.btnRegistrarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTarea.Location = new System.Drawing.Point(195, 615);
            this.btnRegistrarTarea.Name = "btnRegistrarTarea";
            this.btnRegistrarTarea.Size = new System.Drawing.Size(158, 51);
            this.btnRegistrarTarea.TabIndex = 72;
            this.btnRegistrarTarea.Text = "Registrar Tarea";
            this.btnRegistrarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(499, 460);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 41);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(499, 114);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 37);
            this.btnEditar.TabIndex = 73;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmRecursosHumanos5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1314, 739);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrarTarea);
            this.Controls.Add(this.tbDescripcionTarea);
            this.Controls.Add(this.tbNombreTarea);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCodigoTarea);
            this.Controls.Add(this.dgProyectos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFiltrarTarea);
            this.Controls.Add(this.lblTotalTareas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFiltrarFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFiltrarProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFiltrarEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgTareas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecursosHumanos5";
            this.Text = "FrmRecursosHumanos5";
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltrarEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltrarProyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFiltrarFecha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalTareas;
        private System.Windows.Forms.Button btnFiltrarTarea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgProyectos;
        private System.Windows.Forms.TextBox tbCodigoTarea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreTarea;
        private System.Windows.Forms.TextBox tbDescripcionTarea;
        private System.Windows.Forms.Button btnRegistrarTarea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}