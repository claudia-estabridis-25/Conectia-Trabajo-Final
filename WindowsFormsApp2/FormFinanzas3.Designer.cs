﻿namespace WindowsFormsApp2
{
    partial class FormFinanzas3
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
            this.dgGastos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoGasto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantidadGasto = new System.Windows.Forms.TextBox();
            this.tbSustentoGasto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalGasto = new System.Windows.Forms.Label();
            this.dgAlertas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbAreaGasto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarGasto = new System.Windows.Forms.Button();
            this.btnDescargarAlertas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Gastos:";
            // 
            // dgGastos
            // 
            this.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGastos.Location = new System.Drawing.Point(582, 160);
            this.dgGastos.Margin = new System.Windows.Forms.Padding(4);
            this.dgGastos.Name = "dgGastos";
            this.dgGastos.RowHeadersWidth = 51;
            this.dgGastos.Size = new System.Drawing.Size(601, 269);
            this.dgGastos.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 52);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gastos de tu empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "Registra tus gastos:";
            // 
            // tbCodigoGasto
            // 
            this.tbCodigoGasto.Location = new System.Drawing.Point(202, 170);
            this.tbCodigoGasto.Name = "tbCodigoGasto";
            this.tbCodigoGasto.Size = new System.Drawing.Size(230, 22);
            this.tbCodigoGasto.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "Sustento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Cantidad:";
            // 
            // tbCantidadGasto
            // 
            this.tbCantidadGasto.Location = new System.Drawing.Point(202, 209);
            this.tbCantidadGasto.Name = "tbCantidadGasto";
            this.tbCantidadGasto.Size = new System.Drawing.Size(230, 22);
            this.tbCantidadGasto.TabIndex = 91;
            // 
            // tbSustentoGasto
            // 
            this.tbSustentoGasto.Location = new System.Drawing.Point(202, 247);
            this.tbSustentoGasto.Name = "tbSustentoGasto";
            this.tbSustentoGasto.Size = new System.Drawing.Size(359, 22);
            this.tbSustentoGasto.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 451);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 22);
            this.label4.TabIndex = 93;
            this.label4.Text = "Alertas de sobregasto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(956, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "Gasto Total:";
            // 
            // lblTotalGasto
            // 
            this.lblTotalGasto.AutoSize = true;
            this.lblTotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGasto.Location = new System.Drawing.Point(1079, 447);
            this.lblTotalGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGasto.Name = "lblTotalGasto";
            this.lblTotalGasto.Size = new System.Drawing.Size(18, 20);
            this.lblTotalGasto.TabIndex = 95;
            this.lblTotalGasto.Text = "0";
            // 
            // dgAlertas
            // 
            this.dgAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlertas.Location = new System.Drawing.Point(48, 496);
            this.dgAlertas.Margin = new System.Windows.Forms.Padding(4);
            this.dgAlertas.Name = "dgAlertas";
            this.dgAlertas.RowHeadersWidth = 51;
            this.dgAlertas.Size = new System.Drawing.Size(703, 258);
            this.dgAlertas.TabIndex = 96;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1092, 744);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 35);
            this.btnSalir.TabIndex = 97;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbAreaGasto
            // 
            this.tbAreaGasto.Location = new System.Drawing.Point(202, 285);
            this.tbAreaGasto.Name = "tbAreaGasto";
            this.tbAreaGasto.Size = new System.Drawing.Size(269, 22);
            this.tbAreaGasto.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Áre de la empresa:";
            // 
            // btnRegistrarGasto
            // 
            this.btnRegistrarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGasto.Location = new System.Drawing.Point(202, 327);
            this.btnRegistrarGasto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarGasto.Name = "btnRegistrarGasto";
            this.btnRegistrarGasto.Size = new System.Drawing.Size(201, 41);
            this.btnRegistrarGasto.TabIndex = 100;
            this.btnRegistrarGasto.Text = "Registrar Gasto";
            this.btnRegistrarGasto.UseVisualStyleBackColor = true;
            // 
            // btnDescargarAlertas
            // 
            this.btnDescargarAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarAlertas.Location = new System.Drawing.Point(815, 586);
            this.btnDescargarAlertas.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarAlertas.Name = "btnDescargarAlertas";
            this.btnDescargarAlertas.Size = new System.Drawing.Size(205, 75);
            this.btnDescargarAlertas.TabIndex = 101;
            this.btnDescargarAlertas.Text = "Descargar listado de alertas";
            this.btnDescargarAlertas.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1025, 113);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 38);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(833, 113);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 38);
            this.btnEditar.TabIndex = 102;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormFinanzas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1215, 791);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDescargarAlertas);
            this.Controls.Add(this.btnRegistrarGasto);
            this.Controls.Add(this.tbAreaGasto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgAlertas);
            this.Controls.Add(this.lblTotalGasto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSustentoGasto);
            this.Controls.Add(this.tbCantidadGasto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCodigoGasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgGastos);
            this.Controls.Add(this.label1);
            this.Name = "FormFinanzas3";
            this.Text = "FormFinanzas3";
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgGastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCantidadGasto;
        private System.Windows.Forms.TextBox tbSustentoGasto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalGasto;
        private System.Windows.Forms.DataGridView dgAlertas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbAreaGasto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrarGasto;
        private System.Windows.Forms.Button btnDescargarAlertas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}