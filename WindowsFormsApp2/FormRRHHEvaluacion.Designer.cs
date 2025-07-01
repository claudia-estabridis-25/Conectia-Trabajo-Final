namespace WindowsFormsApp2
{
    partial class FormRRHHEvaluacion
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
            this.dgResumenEvaluacion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPuntajes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbComentarios = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarEvaluacion = new System.Windows.Forms.Button();
            this.btnDescargarEvaluacion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoEvaluacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResumenEvaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Evaluación de empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Evaluación de Desempeño";
            // 
            // dgResumenEvaluacion
            // 
            this.dgResumenEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResumenEvaluacion.Location = new System.Drawing.Point(40, 438);
            this.dgResumenEvaluacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgResumenEvaluacion.Name = "dgResumenEvaluacion";
            this.dgResumenEvaluacion.RowHeadersWidth = 51;
            this.dgResumenEvaluacion.Size = new System.Drawing.Size(640, 299);
            this.dgResumenEvaluacion.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Puntaje de acuerdo a indicadores:";
            // 
            // tbPuntajes
            // 
            this.tbPuntajes.Location = new System.Drawing.Point(315, 182);
            this.tbPuntajes.Name = "tbPuntajes";
            this.tbPuntajes.Size = new System.Drawing.Size(349, 22);
            this.tbPuntajes.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Comentarios adicionales:";
            // 
            // rtbComentarios
            // 
            this.rtbComentarios.Location = new System.Drawing.Point(315, 227);
            this.rtbComentarios.Name = "rtbComentarios";
            this.rtbComentarios.Size = new System.Drawing.Size(349, 105);
            this.rtbComentarios.TabIndex = 44;
            this.rtbComentarios.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Resumen:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(600, 785);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 39);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarEvaluacion
            // 
            this.btnRegistrarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEvaluacion.Location = new System.Drawing.Point(397, 353);
            this.btnRegistrarEvaluacion.Name = "btnRegistrarEvaluacion";
            this.btnRegistrarEvaluacion.Size = new System.Drawing.Size(166, 47);
            this.btnRegistrarEvaluacion.TabIndex = 60;
            this.btnRegistrarEvaluacion.Text = "Registrar";
            this.btnRegistrarEvaluacion.UseVisualStyleBackColor = true;
            this.btnRegistrarEvaluacion.Click += new System.EventHandler(this.btnRegistrarEvaluacion_Click);
            // 
            // btnDescargarEvaluacion
            // 
            this.btnDescargarEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarEvaluacion.Location = new System.Drawing.Point(41, 754);
            this.btnDescargarEvaluacion.Name = "btnDescargarEvaluacion";
            this.btnDescargarEvaluacion.Size = new System.Drawing.Size(224, 47);
            this.btnDescargarEvaluacion.TabIndex = 61;
            this.btnDescargarEvaluacion.Text = "Descargar Evalución";
            this.btnDescargarEvaluacion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Código de evaluación:";
            // 
            // tbCodigoEvaluacion
            // 
            this.tbCodigoEvaluacion.Location = new System.Drawing.Point(315, 139);
            this.tbCodigoEvaluacion.Name = "tbCodigoEvaluacion";
            this.tbCodigoEvaluacion.Size = new System.Drawing.Size(349, 22);
            this.tbCodigoEvaluacion.TabIndex = 63;
            // 
            // FormRRHHEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 838);
            this.Controls.Add(this.tbCodigoEvaluacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDescargarEvaluacion);
            this.Controls.Add(this.btnRegistrarEvaluacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbComentarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPuntajes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgResumenEvaluacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRRHHEvaluacion";
            this.Text = "Evaluaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgResumenEvaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgResumenEvaluacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPuntajes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbComentarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarEvaluacion;
        private System.Windows.Forms.Button btnDescargarEvaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoEvaluacion;
    }
}