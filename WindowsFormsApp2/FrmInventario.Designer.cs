namespace WindowsFormsApp2
{
    partial class FrmInventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnReporteInventario = new System.Windows.Forms.Button();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.btnCategorizarRecursos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestión de Recursos Materiales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(599, 217);
            this.dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recursos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrar recurso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 380);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 430);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "Alertas de mantenimiento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 479);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Categorías:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 526);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Disponibilidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(541, 538);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnReporteInventario
            // 
            this.btnReporteInventario.Location = new System.Drawing.Point(451, 430);
            this.btnReporteInventario.Name = "btnReporteInventario";
            this.btnReporteInventario.Size = new System.Drawing.Size(172, 28);
            this.btnReporteInventario.TabIndex = 20;
            this.btnReporteInventario.Text = "Reporte del inventario";
            this.btnReporteInventario.UseVisualStyleBackColor = true;
            this.btnReporteInventario.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConsultarStock
            // 
            this.btnConsultarStock.Location = new System.Drawing.Point(269, 430);
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Size = new System.Drawing.Size(144, 28);
            this.btnConsultarStock.TabIndex = 21;
            this.btnConsultarStock.Text = "Consultar el stock";
            this.btnConsultarStock.UseVisualStyleBackColor = true;
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);
            // 
            // btnCategorizarRecursos
            // 
            this.btnCategorizarRecursos.Location = new System.Drawing.Point(488, 380);
            this.btnCategorizarRecursos.Name = "btnCategorizarRecursos";
            this.btnCategorizarRecursos.Size = new System.Drawing.Size(101, 28);
            this.btnCategorizarRecursos.TabIndex = 22;
            this.btnCategorizarRecursos.Text = "Categorizar";
            this.btnCategorizarRecursos.UseVisualStyleBackColor = true;
            this.btnCategorizarRecursos.Click += new System.EventHandler(this.btnCategorizarRecursos_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 593);
            this.Controls.Add(this.btnCategorizarRecursos);
            this.Controls.Add(this.btnConsultarStock);
            this.Controls.Add(this.btnReporteInventario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReporteInventario;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.Button btnCategorizarRecursos;
    }
}