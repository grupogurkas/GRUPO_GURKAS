﻿
namespace pl_Gurkas.Vista.Planilla
{
    partial class frmCalculoDeVacaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmpleadoV = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvPlataformaPlanilla = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDiasVendidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdiasdisfrutados = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtperiodofin = new System.Windows.Forms.TextBox();
            this.txtpinicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfin = new System.Windows.Forms.Label();
            this.btnPlantilla = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtdiasacumulados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboempleadoActivo = new System.Windows.Forms.ComboBox();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformaPlanilla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboEmpleadoV);
            this.groupBox1.Location = new System.Drawing.Point(790, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 78);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Calculo de Vacaciones";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::pl_Gurkas.Properties.Resources.delete_docuemnt_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 69;
            this.button1.Text = "Eliminar Vacaciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Empleado : ";
            // 
            // cboEmpleadoV
            // 
            this.cboEmpleadoV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEmpleadoV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmpleadoV.FormattingEnabled = true;
            this.cboEmpleadoV.Location = new System.Drawing.Point(85, 27);
            this.cboEmpleadoV.Name = "cboEmpleadoV";
            this.cboEmpleadoV.Size = new System.Drawing.Size(321, 21);
            this.cboEmpleadoV.TabIndex = 68;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 629);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1336, 12);
            this.progressBar1.TabIndex = 71;
            // 
            // dgvPlataformaPlanilla
            // 
            this.dgvPlataformaPlanilla.AllowUserToDeleteRows = false;
            this.dgvPlataformaPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlataformaPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlataformaPlanilla.Location = new System.Drawing.Point(12, 247);
            this.dgvPlataformaPlanilla.Name = "dgvPlataformaPlanilla";
            this.dgvPlataformaPlanilla.ReadOnly = true;
            this.dgvPlataformaPlanilla.Size = new System.Drawing.Size(1337, 376);
            this.dgvPlataformaPlanilla.TabIndex = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtanio);
            this.groupBox3.Controls.Add(this.txtmes);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboPago);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtperiodofin);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Controls.Add(this.txtpinicio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDiasVendidos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnPlantilla);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboempleadoActivo);
            this.groupBox3.Controls.Add(this.dtpinicio);
            this.groupBox3.Controls.Add(this.txtdiasdisfrutados);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpfin);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.txtdiasacumulados);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 231);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empleado Gurkas";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::pl_Gurkas.Properties.Resources.icon_validare_300__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(601, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 47);
            this.button2.TabIndex = 69;
            this.button2.Text = "Verificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 32);
            this.label9.TabIndex = 67;
            this.label9.Text = "Sueldo para \r\nCalculo:";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::pl_Gurkas.Properties.Resources.Excel_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(601, 73);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(140, 48);
            this.btnExcel.TabIndex = 47;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.salir_empleado_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(1208, 189);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 48);
            this.btnCerrar.TabIndex = 47;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDiasVendidos
            // 
            this.txtDiasVendidos.Location = new System.Drawing.Point(132, 194);
            this.txtDiasVendidos.Name = "txtDiasVendidos";
            this.txtDiasVendidos.Size = new System.Drawing.Size(82, 20);
            this.txtDiasVendidos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Dias Vendidos :";
            // 
            // txtdiasdisfrutados
            // 
            this.txtdiasdisfrutados.Location = new System.Drawing.Point(132, 170);
            this.txtdiasdisfrutados.Name = "txtdiasdisfrutados";
            this.txtdiasdisfrutados.Size = new System.Drawing.Size(82, 20);
            this.txtdiasdisfrutados.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Dias Disfrutados :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Periodo Fin :";
            // 
            // txtperiodofin
            // 
            this.txtperiodofin.Location = new System.Drawing.Point(342, 57);
            this.txtperiodofin.Name = "txtperiodofin";
            this.txtperiodofin.Size = new System.Drawing.Size(180, 20);
            this.txtperiodofin.TabIndex = 3;
            // 
            // txtpinicio
            // 
            this.txtpinicio.Location = new System.Drawing.Point(108, 54);
            this.txtpinicio.Name = "txtpinicio";
            this.txtpinicio.Size = new System.Drawing.Size(124, 20);
            this.txtpinicio.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Periodo Inicio :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(206, 90);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(130, 20);
            this.dtpinicio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fecha Salida de Vacaciones :";
            // 
            // dtpfin
            // 
            this.dtpfin.AutoSize = true;
            this.dtpfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfin.Location = new System.Drawing.Point(6, 120);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(194, 16);
            this.dtpfin.TabIndex = 55;
            this.dtpfin.Text = "Fecha Retorno de Vacaciones:";
            // 
            // btnPlantilla
            // 
            this.btnPlantilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantilla.Image = global::pl_Gurkas.Properties.Resources.planilla_32;
            this.btnPlantilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantilla.Location = new System.Drawing.Point(601, 20);
            this.btnPlantilla.Name = "btnPlantilla";
            this.btnPlantilla.Size = new System.Drawing.Size(140, 47);
            this.btnPlantilla.TabIndex = 54;
            this.btnPlantilla.Text = "Generar \r\nPagos";
            this.btnPlantilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlantilla.UseVisualStyleBackColor = true;
            this.btnPlantilla.Click += new System.EventHandler(this.btnPlantilla_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::pl_Gurkas.Properties.Resources.save_32_png_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(601, 179);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 47);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtdiasacumulados
            // 
            this.txtdiasacumulados.Location = new System.Drawing.Point(132, 144);
            this.txtdiasacumulados.Name = "txtdiasacumulados";
            this.txtdiasacumulados.Size = new System.Drawing.Size(82, 20);
            this.txtdiasacumulados.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Empleado : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Dias Acumulados :";
            // 
            // cboempleadoActivo
            // 
            this.cboempleadoActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempleadoActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempleadoActivo.FormattingEnabled = true;
            this.cboempleadoActivo.Location = new System.Drawing.Point(108, 24);
            this.cboempleadoActivo.Name = "cboempleadoActivo";
            this.cboempleadoActivo.Size = new System.Drawing.Size(414, 21);
            this.cboempleadoActivo.TabIndex = 1;
            this.cboempleadoActivo.SelectedIndexChanged += new System.EventHandler(this.cboempleadoActivo_SelectedIndexChanged);
            // 
            // cboPago
            // 
            this.cboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(342, 180);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(180, 21);
            this.cboPago.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 32);
            this.label10.TabIndex = 230;
            this.label10.Text = "Periodo de  \r\npago :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 231;
            this.label11.Text = "Mes :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 232;
            this.label12.Text = "Año :";
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(418, 88);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(104, 20);
            this.txtmes.TabIndex = 233;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(418, 115);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(104, 20);
            this.txtanio.TabIndex = 234;
            // 
            // frmCalculoDeVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgvPlataformaPlanilla);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculoDeVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculoPlanilla";
            this.Load += new System.EventHandler(this.frmCalculoDeVacaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlataformaPlanilla)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEmpleadoV;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvPlataformaPlanilla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDiasVendidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdiasdisfrutados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtperiodofin;
        private System.Windows.Forms.TextBox txtpinicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dtpfin;
        private System.Windows.Forms.Button btnPlantilla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtdiasacumulados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboempleadoActivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}