namespace WindowsFormsApp2
{
    partial class FormFinanzas5
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
            this.tbCodigoObjetivo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcionObjetivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClasificacionObjetivo = new System.Windows.Forms.TextBox();
            this.btnRegistrarObjetivo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgObjetivosKPI = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAreaObjetivoKPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPuntajeMinimoKPI = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgObjetivosKPI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 52);
            this.label1.TabIndex = 52;
            this.label1.Text = "Objetivos KPI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "Registra los objetivos:";
            // 
            // tbCodigoObjetivo
            // 
            this.tbCodigoObjetivo.Location = new System.Drawing.Point(169, 180);
            this.tbCodigoObjetivo.Name = "tbCodigoObjetivo";
            this.tbCodigoObjetivo.Size = new System.Drawing.Size(230, 22);
            this.tbCodigoObjetivo.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(90, 180);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 22);
            this.label15.TabIndex = 77;
            this.label15.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 79;
            this.label2.Text = "Descripción:";
            // 
            // tbDescripcionObjetivo
            // 
            this.tbDescripcionObjetivo.Location = new System.Drawing.Point(169, 259);
            this.tbDescripcionObjetivo.Name = "tbDescripcionObjetivo";
            this.tbDescripcionObjetivo.Size = new System.Drawing.Size(230, 22);
            this.tbDescripcionObjetivo.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "Clasificación:";
            // 
            // tbClasificacionObjetivo
            // 
            this.tbClasificacionObjetivo.Location = new System.Drawing.Point(169, 220);
            this.tbClasificacionObjetivo.Name = "tbClasificacionObjetivo";
            this.tbClasificacionObjetivo.Size = new System.Drawing.Size(230, 22);
            this.tbClasificacionObjetivo.TabIndex = 82;
            // 
            // btnRegistrarObjetivo
            // 
            this.btnRegistrarObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarObjetivo.Location = new System.Drawing.Point(109, 400);
            this.btnRegistrarObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarObjetivo.Name = "btnRegistrarObjetivo";
            this.btnRegistrarObjetivo.Size = new System.Drawing.Size(208, 49);
            this.btnRegistrarObjetivo.TabIndex = 86;
            this.btnRegistrarObjetivo.Text = "Registrar Objtetivo KPI";
            this.btnRegistrarObjetivo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(891, 557);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 43);
            this.btnSalir.TabIndex = 87;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgObjetivosKPI
            // 
            this.dgObjetivosKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObjetivosKPI.Location = new System.Drawing.Point(440, 164);
            this.dgObjetivosKPI.Name = "dgObjetivosKPI";
            this.dgObjetivosKPI.RowHeadersWidth = 51;
            this.dgObjetivosKPI.RowTemplate.Height = 24;
            this.dgObjetivosKPI.Size = new System.Drawing.Size(559, 314);
            this.dgObjetivosKPI.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 89;
            this.label4.Text = "Lista de objetivos KPI:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 499);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(254, 22);
            this.label16.TabIndex = 90;
            this.label16.Text = "Clic aquí para ver los reportes:";
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportes.Location = new System.Drawing.Point(38, 541);
            this.btnVerReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(208, 49);
            this.btnVerReportes.TabIndex = 91;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Área:";
            // 
            // tbAreaObjetivoKPI
            // 
            this.tbAreaObjetivoKPI.Location = new System.Drawing.Point(169, 300);
            this.tbAreaObjetivoKPI.Name = "tbAreaObjetivoKPI";
            this.tbAreaObjetivoKPI.Size = new System.Drawing.Size(230, 22);
            this.tbAreaObjetivoKPI.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 22);
            this.label7.TabIndex = 94;
            this.label7.Text = "Puntaje mínimo:";
            // 
            // tbPuntajeMinimoKPI
            // 
            this.tbPuntajeMinimoKPI.Location = new System.Drawing.Point(169, 343);
            this.tbPuntajeMinimoKPI.Name = "tbPuntajeMinimoKPI";
            this.tbPuntajeMinimoKPI.Size = new System.Drawing.Size(230, 22);
            this.tbPuntajeMinimoKPI.TabIndex = 95;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(632, 499);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 48);
            this.btnEliminar.TabIndex = 105;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(440, 499);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 48);
            this.btnEditar.TabIndex = 104;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormFinanzas5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 619);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tbPuntajeMinimoKPI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAreaObjetivoKPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgObjetivosKPI);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarObjetivo);
            this.Controls.Add(this.tbClasificacionObjetivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescripcionObjetivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigoObjetivo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormFinanzas5";
            this.Text = "FormFinanzas5";
            ((System.ComponentModel.ISupportInitialize)(this.dgObjetivosKPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigoObjetivo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcionObjetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClasificacionObjetivo;
        private System.Windows.Forms.Button btnRegistrarObjetivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgObjetivosKPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAreaObjetivoKPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPuntajeMinimoKPI;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}