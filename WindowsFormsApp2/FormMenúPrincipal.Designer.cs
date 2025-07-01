namespace WindowsFormsApp2
{
    partial class FormMenúPrincipal
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
            this.btnMonitoreoRRHH = new System.Windows.Forms.Button();
            this.btnControlFinanciero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFondoActual = new System.Windows.Forms.Label();
            this.lblTotalProcesos = new System.Windows.Forms.Label();
            this.lblTotalEmpleados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGestionRecursosMateriales = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMonitoreoRRHH
            // 
            this.btnMonitoreoRRHH.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoreoRRHH.Location = new System.Drawing.Point(40, 205);
            this.btnMonitoreoRRHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonitoreoRRHH.Name = "btnMonitoreoRRHH";
            this.btnMonitoreoRRHH.Size = new System.Drawing.Size(272, 91);
            this.btnMonitoreoRRHH.TabIndex = 14;
            this.btnMonitoreoRRHH.Text = "Monitoreo de Recursos Humanos";
            this.btnMonitoreoRRHH.UseVisualStyleBackColor = true;
            this.btnMonitoreoRRHH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnControlFinanciero
            // 
            this.btnControlFinanciero.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlFinanciero.Location = new System.Drawing.Point(40, 443);
            this.btnControlFinanciero.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlFinanciero.Name = "btnControlFinanciero";
            this.btnControlFinanciero.Size = new System.Drawing.Size(272, 91);
            this.btnControlFinanciero.TabIndex = 16;
            this.btnControlFinanciero.Text = "Control Financiero Descentralizado";
            this.btnControlFinanciero.UseVisualStyleBackColor = true;
            this.btnControlFinanciero.Click += new System.EventHandler(this.btnControlFinanciero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.lblFondoActual);
            this.groupBox1.Controls.Add(this.lblTotalProcesos);
            this.groupBox1.Controls.Add(this.lblTotalEmpleados);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(370, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(335, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen:";
            // 
            // lblFondoActual
            // 
            this.lblFondoActual.AutoSize = true;
            this.lblFondoActual.Location = new System.Drawing.Point(175, 106);
            this.lblFondoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFondoActual.Name = "lblFondoActual";
            this.lblFondoActual.Size = new System.Drawing.Size(23, 25);
            this.lblFondoActual.TabIndex = 5;
            this.lblFondoActual.Text = "0";
            // 
            // lblTotalProcesos
            // 
            this.lblTotalProcesos.AutoSize = true;
            this.lblTotalProcesos.Location = new System.Drawing.Point(175, 74);
            this.lblTotalProcesos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProcesos.Name = "lblTotalProcesos";
            this.lblTotalProcesos.Size = new System.Drawing.Size(23, 25);
            this.lblTotalProcesos.TabIndex = 4;
            this.lblTotalProcesos.Text = "3";
            // 
            // lblTotalEmpleados
            // 
            this.lblTotalEmpleados.AutoSize = true;
            this.lblTotalEmpleados.Location = new System.Drawing.Point(175, 42);
            this.lblTotalEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmpleados.Name = "lblTotalEmpleados";
            this.lblTotalEmpleados.Size = new System.Drawing.Size(23, 25);
            this.lblTotalEmpleados.TabIndex = 3;
            this.lblTotalEmpleados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fondo actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total procesos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total empleados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 62);
            this.label1.TabIndex = 28;
            this.label1.Text = "Menú Principal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(670, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Selecciona uno de los tres procesos que podrás automatizar en tu empresa:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnGestionRecursosMateriales
            // 
            this.btnGestionRecursosMateriales.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionRecursosMateriales.Location = new System.Drawing.Point(40, 322);
            this.btnGestionRecursosMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionRecursosMateriales.Name = "btnGestionRecursosMateriales";
            this.btnGestionRecursosMateriales.Size = new System.Drawing.Size(272, 91);
            this.btnGestionRecursosMateriales.TabIndex = 30;
            this.btnGestionRecursosMateriales.Text = "Gestión de Recursos Materiales";
            this.btnGestionRecursosMateriales.UseVisualStyleBackColor = true;
            this.btnGestionRecursosMateriales.Click += new System.EventHandler(this.btnGestionRecursosMateriales_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.Location = new System.Drawing.Point(541, 540);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(164, 63);
            this.btnCerrarSesión.TabIndex = 31;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // FormMenúPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 619);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnGestionRecursosMateriales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnControlFinanciero);
            this.Controls.Add(this.btnMonitoreoRRHH);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenúPrincipal";
            this.Text = "Panel de Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMonitoreoRRHH;
        private System.Windows.Forms.Button btnControlFinanciero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFondoActual;
        private System.Windows.Forms.Label lblTotalProcesos;
        private System.Windows.Forms.Label lblTotalEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGestionRecursosMateriales;
        private System.Windows.Forms.Button btnCerrarSesión;
    }
}