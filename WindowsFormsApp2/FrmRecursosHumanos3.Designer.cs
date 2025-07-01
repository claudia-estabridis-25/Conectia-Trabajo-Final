namespace WindowsFormsApp2
{
    partial class FrmRecursosHumanos3
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHorasDisponibles = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHabilidades = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProyectos = new System.Windows.Forms.ComboBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnAsignarProyecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empleados:";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(37, 195);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.Size = new System.Drawing.Size(801, 217);
            this.dgEmpleados.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHorasDisponibles);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblHabilidades);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(471, 440);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(308, 190);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado seleccionado:";
            // 
            // lblHorasDisponibles
            // 
            this.lblHorasDisponibles.AutoSize = true;
            this.lblHorasDisponibles.Location = new System.Drawing.Point(161, 152);
            this.lblHorasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorasDisponibles.Name = "lblHorasDisponibles";
            this.lblHorasDisponibles.Size = new System.Drawing.Size(18, 20);
            this.lblHorasDisponibles.TabIndex = 9;
            this.lblHorasDisponibles.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 152);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Horas disponibles:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(161, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "xxxxxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código:";
            // 
            // lblHabilidades
            // 
            this.lblHabilidades.AutoSize = true;
            this.lblHabilidades.Location = new System.Drawing.Point(161, 121);
            this.lblHabilidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabilidades.Name = "lblHabilidades";
            this.lblHabilidades.Size = new System.Drawing.Size(79, 20);
            this.lblHabilidades.TabIndex = 5;
            this.lblHabilidades.Text = "Proactivo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(161, 93);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(75, 20);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Soldador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(161, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(39, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Ivan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Habilidades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Proyectos:";
            // 
            // cbProyectos
            // 
            this.cbProyectos.FormattingEnabled = true;
            this.cbProyectos.Location = new System.Drawing.Point(131, 440);
            this.cbProyectos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProyectos.Name = "cbProyectos";
            this.cbProyectos.Size = new System.Drawing.Size(210, 24);
            this.cbProyectos.TabIndex = 20;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(237, 606);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(166, 56);
            this.btnCalendario.TabIndex = 19;
            this.btnCalendario.Text = "Ver calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnAsignarProyecto
            // 
            this.btnAsignarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarProyecto.Location = new System.Drawing.Point(112, 488);
            this.btnAsignarProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarProyecto.Name = "btnAsignarProyecto";
            this.btnAsignarProyecto.Size = new System.Drawing.Size(168, 50);
            this.btnAsignarProyecto.TabIndex = 18;
            this.btnAsignarProyecto.Text = "Asignar a proyecto";
            this.btnAsignarProyecto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Asignar Proyectos";
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.Location = new System.Drawing.Point(37, 606);
            this.btnVerTareas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.Size = new System.Drawing.Size(162, 56);
            this.btnVerTareas.TabIndex = 32;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = true;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(568, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Selecciona un empleado, luego elije un proyecto de la lista y asígnalo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(710, 677);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmRecursosHumanos3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 750);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerTareas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProyectos);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnAsignarProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEmpleados);
            this.Name = "FrmRecursosHumanos3";
            this.Text = "FrmRecursosHumanos2";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHabilidades;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProyectos;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnAsignarProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHorasDisponibles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerTareas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
    }
}