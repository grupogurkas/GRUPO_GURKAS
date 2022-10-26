
namespace pl_Gurkas.Vista.CentroControl.ReporteAsistencia
{
    partial class frmAsistenciaDePersonalDetallado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaDePersonalDetallado));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvAsistenciaPersonalDetallado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.Unida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtfincompleto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconsultarcompleto = new System.Windows.Forms.Button();
            this.dtiniciocompleto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaPersonalDetallado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 474);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1073, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::pl_Gurkas.Properties.Resources.Excel_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(935, 35);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(109, 46);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvAsistenciaPersonalDetallado
            // 
            this.dgvAsistenciaPersonalDetallado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistenciaPersonalDetallado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaPersonalDetallado.Location = new System.Drawing.Point(12, 114);
            this.dgvAsistenciaPersonalDetallado.Name = "dgvAsistenciaPersonalDetallado";
            this.dgvAsistenciaPersonalDetallado.Size = new System.Drawing.Size(1073, 354);
            this.dgvAsistenciaPersonalDetallado.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboUnidad);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.Unida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asistencia de Personal Detallado";
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(73, 20);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(279, 24);
            this.cboUnidad.TabIndex = 19;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(249, 62);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // Unida
            // 
            this.Unida.AutoSize = true;
            this.Unida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unida.Location = new System.Drawing.Point(15, 23);
            this.Unida.Name = "Unida";
            this.Unida.Size = new System.Drawing.Size(52, 16);
            this.Unida.TabIndex = 18;
            this.Unida.Text = "Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Al";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(358, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 46);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(89, 62);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de\r\nMarcaciones\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtfincompleto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnconsultarcompleto);
            this.groupBox2.Controls.Add(this.dtiniciocompleto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(494, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 96);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asistencia deCompleta Personal Detallado";
            // 
            // dtfincompleto
            // 
            this.dtfincompleto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfincompleto.Location = new System.Drawing.Point(210, 34);
            this.dtfincompleto.Name = "dtfincompleto";
            this.dtfincompleto.Size = new System.Drawing.Size(103, 20);
            this.dtfincompleto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Al";
            // 
            // btnconsultarcompleto
            // 
            this.btnconsultarcompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultarcompleto.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnconsultarcompleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultarcompleto.Location = new System.Drawing.Point(319, 23);
            this.btnconsultarcompleto.Name = "btnconsultarcompleto";
            this.btnconsultarcompleto.Size = new System.Drawing.Size(109, 46);
            this.btnconsultarcompleto.TabIndex = 8;
            this.btnconsultarcompleto.Text = "Consultar";
            this.btnconsultarcompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconsultarcompleto.UseVisualStyleBackColor = true;
            this.btnconsultarcompleto.Click += new System.EventHandler(this.btnconsultarcompleto_Click);
            // 
            // dtiniciocompleto
            // 
            this.dtiniciocompleto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtiniciocompleto.Location = new System.Drawing.Point(79, 34);
            this.dtiniciocompleto.Name = "dtiniciocompleto";
            this.dtiniciocompleto.Size = new System.Drawing.Size(103, 20);
            this.dtiniciocompleto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de\r\nMarcaciones\r\n";
            // 
            // frmAsistenciaDePersonalDetallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvAsistenciaPersonalDetallado);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsistenciaDePersonalDetallado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsistenciaDePersonalDetallado";
            this.Load += new System.EventHandler(this.frmAsistenciaDePersonalDetallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaPersonalDetallado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvAsistenciaPersonalDetallado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label Unida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtfincompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnconsultarcompleto;
        private System.Windows.Forms.DateTimePicker dtiniciocompleto;
        private System.Windows.Forms.Label label5;
    }
}