namespace WindowsFormsApp2
{
    partial class FormFinanzas2
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
            this.dgPresupuesto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPresupuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerGastos = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRegistrarPresupuesto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantidadPresupuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAreaPresupuesto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Presupuesto:";
            // 
            // dgPresupuesto
            // 
            this.dgPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresupuesto.Location = new System.Drawing.Point(518, 152);
            this.dgPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.dgPresupuesto.Name = "dgPresupuesto";
            this.dgPresupuesto.RowHeadersWidth = 51;
            this.dgPresupuesto.Size = new System.Drawing.Size(578, 337);
            this.dgPresupuesto.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "Presupuesto";
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.AutoSize = true;
            this.lblSumaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaTotal.Location = new System.Drawing.Point(986, 519);
            this.lblSumaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(18, 20);
            this.lblSumaTotal.TabIndex = 81;
            this.lblSumaTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 519);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Suma Total:";
            // 
            // tbCodigoPresupuesto
            // 
            this.tbCodigoPresupuesto.Location = new System.Drawing.Point(190, 164);
            this.tbCodigoPresupuesto.Name = "tbCodigoPresupuesto";
            this.tbCodigoPresupuesto.Size = new System.Drawing.Size(269, 22);
            this.tbCodigoPresupuesto.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 75;
            this.label6.Text = "Registra tu presupuesto:";
            // 
            // btnVerGastos
            // 
            this.btnVerGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerGastos.Location = new System.Drawing.Point(44, 517);
            this.btnVerGastos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerGastos.Name = "btnVerGastos";
            this.btnVerGastos.Size = new System.Drawing.Size(175, 49);
            this.btnVerGastos.TabIndex = 83;
            this.btnVerGastos.Text = "Ver Gastos";
            this.btnVerGastos.UseVisualStyleBackColor = true;
            this.btnVerGastos.Click += new System.EventHandler(this.btnVerGastos_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 467);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(281, 22);
            this.label16.TabIndex = 82;
            this.label16.Text = "Clic aquí para ingresar los gastos:";
            // 
            // btnRegistrarPresupuesto
            // 
            this.btnRegistrarPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPresupuesto.Location = new System.Drawing.Point(154, 351);
            this.btnRegistrarPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPresupuesto.Name = "btnRegistrarPresupuesto";
            this.btnRegistrarPresupuesto.Size = new System.Drawing.Size(208, 49);
            this.btnRegistrarPresupuesto.TabIndex = 84;
            this.btnRegistrarPresupuesto.Text = "Registrar Presupuesto";
            this.btnRegistrarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(972, 586);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 37);
            this.btnSalir.TabIndex = 85;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Cantidad:";
            // 
            // tbCantidadPresupuesto
            // 
            this.tbCantidadPresupuesto.Location = new System.Drawing.Point(190, 208);
            this.tbCantidadPresupuesto.Name = "tbCantidadPresupuesto";
            this.tbCantidadPresupuesto.Size = new System.Drawing.Size(269, 22);
            this.tbCantidadPresupuesto.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "Detalle:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Áre de la empresa:";
            // 
            // tbAreaPresupuesto
            // 
            this.tbAreaPresupuesto.Location = new System.Drawing.Point(190, 257);
            this.tbAreaPresupuesto.Name = "tbAreaPresupuesto";
            this.tbAreaPresupuesto.Size = new System.Drawing.Size(269, 22);
            this.tbAreaPresupuesto.TabIndex = 91;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(518, 517);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 39);
            this.btnEliminar.TabIndex = 93;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(938, 100);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 42);
            this.btnEditar.TabIndex = 92;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormFinanzas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 636);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tbAreaPresupuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCantidadPresupuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarPresupuesto);
            this.Controls.Add(this.btnVerGastos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblSumaTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodigoPresupuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPresupuesto);
            this.Controls.Add(this.label1);
            this.Name = "FormFinanzas2";
            this.Text = "FormFinanzas2";
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSumaTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPresupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerGastos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRegistrarPresupuesto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCantidadPresupuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAreaPresupuesto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}