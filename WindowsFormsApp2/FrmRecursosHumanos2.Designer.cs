namespace WindowsFormsApp2
{
    partial class FrmRecursosHumanos2
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
            this.dgProyectos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarProyecto = new System.Windows.Forms.Button();
            this.tbCodigoProyecto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNombreProyecto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnVerAsignarProyectos = new System.Windows.Forms.Button();
            this.btnVerEvaluaciones = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalProyectos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gestionar Proyectos";
            // 
            // dgProyectos
            // 
            this.dgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProyectos.Location = new System.Drawing.Point(567, 156);
            this.dgProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.dgProyectos.Name = "dgProyectos";
            this.dgProyectos.RowHeadersWidth = 51;
            this.dgProyectos.Size = new System.Drawing.Size(720, 483);
            this.dgProyectos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Proyectos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nombre del proyecto:";
            // 
            // btnRegistrarProyecto
            // 
            this.btnRegistrarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProyecto.Location = new System.Drawing.Point(175, 423);
            this.btnRegistrarProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarProyecto.Name = "btnRegistrarProyecto";
            this.btnRegistrarProyecto.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarProyecto.TabIndex = 19;
            this.btnRegistrarProyecto.Text = "Registrar proyecto";
            this.btnRegistrarProyecto.UseVisualStyleBackColor = true;
            // 
            // tbCodigoProyecto
            // 
            this.tbCodigoProyecto.Location = new System.Drawing.Point(216, 156);
            this.tbCodigoProyecto.Name = "tbCodigoProyecto";
            this.tbCodigoProyecto.Size = new System.Drawing.Size(286, 22);
            this.tbCodigoProyecto.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Código del proyecto:";
            // 
            // tbNombreProyecto
            // 
            this.tbNombreProyecto.Location = new System.Drawing.Point(216, 190);
            this.tbNombreProyecto.Name = "tbNombreProyecto";
            this.tbNombreProyecto.Size = new System.Drawing.Size(286, 22);
            this.tbNombreProyecto.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descripción:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(216, 227);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(286, 96);
            this.rtbDescripcion.TabIndex = 25;
            this.rtbDescripcion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(214, 342);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(288, 22);
            this.dtpFechaInicio.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(214, 378);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(288, 22);
            this.dtpFechaFin.TabIndex = 29;
            // 
            // btnVerAsignarProyectos
            // 
            this.btnVerAsignarProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAsignarProyectos.Location = new System.Drawing.Point(35, 558);
            this.btnVerAsignarProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerAsignarProyectos.Name = "btnVerAsignarProyectos";
            this.btnVerAsignarProyectos.Size = new System.Drawing.Size(196, 54);
            this.btnVerAsignarProyectos.TabIndex = 31;
            this.btnVerAsignarProyectos.Text = "Ver Asignar proyectos";
            this.btnVerAsignarProyectos.UseVisualStyleBackColor = true;
            this.btnVerAsignarProyectos.Click += new System.EventHandler(this.btnVerAsignarProyectos_Click);
            // 
            // btnVerEvaluaciones
            // 
            this.btnVerEvaluaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEvaluaciones.Location = new System.Drawing.Point(40, 698);
            this.btnVerEvaluaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerEvaluaciones.Name = "btnVerEvaluaciones";
            this.btnVerEvaluaciones.Size = new System.Drawing.Size(168, 54);
            this.btnVerEvaluaciones.TabIndex = 33;
            this.btnVerEvaluaciones.Text = "Ver Evaluaciones";
            this.btnVerEvaluaciones.UseVisualStyleBackColor = true;
            this.btnVerEvaluaciones.Click += new System.EventHandler(this.btnVerEvaluaciones_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(31, 110);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(262, 22);
            this.label17.TabIndex = 54;
            this.label17.Text = "Registra los datos del proyecto:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1034, 656);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total de proyectos:";
            // 
            // lblTotalProyectos
            // 
            this.lblTotalProyectos.AutoSize = true;
            this.lblTotalProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProyectos.Location = new System.Drawing.Point(1204, 656);
            this.lblTotalProyectos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProyectos.Name = "lblTotalProyectos";
            this.lblTotalProyectos.Size = new System.Drawing.Size(18, 20);
            this.lblTotalProyectos.TabIndex = 56;
            this.lblTotalProyectos.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 518);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(379, 22);
            this.label16.TabIndex = 58;
            this.label16.Text = "Clic aquí para asignar proyectos a empleados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 654);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 22);
            this.label9.TabIndex = 59;
            this.label9.Text = "Clic aquí para evaluar a tus empleados:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1159, 709);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(759, 665);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 48);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(567, 665);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 48);
            this.btnEditar.TabIndex = 60;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmRecursosHumanos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 775);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotalProyectos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnVerEvaluaciones);
            this.Controls.Add(this.btnVerAsignarProyectos);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombreProyecto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCodigoProyecto);
            this.Controls.Add(this.btnRegistrarProyecto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgProyectos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecursosHumanos2";
            this.Text = "FrmRecursosHumanos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProyectos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegistrarProyecto;
        private System.Windows.Forms.TextBox tbCodigoProyecto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNombreProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnVerAsignarProyectos;
        private System.Windows.Forms.Button btnVerEvaluaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalProyectos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}