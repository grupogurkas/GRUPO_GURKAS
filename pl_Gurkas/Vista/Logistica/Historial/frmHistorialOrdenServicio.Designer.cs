
namespace pl_Gurkas.Vista.Logistica.Historial
{
    partial class frmHistorialOrdenServicio
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtordencomprar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProveedorMesANIO = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvHistorialOrdenServicio = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedorPorRuc = new System.Windows.Forms.Button();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenServicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.txtFactura);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(984, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 79);
            this.groupBox6.TabIndex = 116;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Busqueda por Factura";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(264, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 46);
            this.button5.TabIndex = 66;
            this.button5.Text = "Buscar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(58, 30);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(200, 20);
            this.txtFactura.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 101;
            this.label8.Text = "Factura";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.txtordencomprar);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(438, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 67);
            this.groupBox5.TabIndex = 114;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busqueda por Orden de Servicio";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(348, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 46);
            this.button4.TabIndex = 66;
            this.button4.Text = "Buscar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtordencomprar
            // 
            this.txtordencomprar.Location = new System.Drawing.Point(142, 30);
            this.txtordencomprar.Name = "txtordencomprar";
            this.txtordencomprar.Size = new System.Drawing.Size(200, 20);
            this.txtordencomprar.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 101;
            this.label7.Text = "ORDEN DE SERVICIO :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboProveedorMesANIO);
            this.groupBox4.Location = new System.Drawing.Point(12, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 100);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar Por Proveedor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::pl_Gurkas.Properties.Resources.buscar_afp_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(370, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 9;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "MES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Proveedor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "AÑO";
            // 
            // cboProveedorMesANIO
            // 
            this.cboProveedorMesANIO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProveedorMesANIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedorMesANIO.FormattingEnabled = true;
            this.cboProveedorMesANIO.Location = new System.Drawing.Point(75, 24);
            this.cboProveedorMesANIO.Name = "cboProveedorMesANIO";
            this.cboProveedorMesANIO.Size = new System.Drawing.Size(289, 21);
            this.cboProveedorMesANIO.TabIndex = 53;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::pl_Gurkas.Properties.Resources.Excel_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1302, 112);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(41, 48);
            this.btnExcel.TabIndex = 119;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 627);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1336, 12);
            this.progressBar1.TabIndex = 118;
            // 
            // dgvHistorialOrdenServicio
            // 
            this.dgvHistorialOrdenServicio.AllowUserToDeleteRows = false;
            this.dgvHistorialOrdenServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialOrdenServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialOrdenServicio.Location = new System.Drawing.Point(12, 199);
            this.dgvHistorialOrdenServicio.Name = "dgvHistorialOrdenServicio";
            this.dgvHistorialOrdenServicio.ReadOnly = true;
            this.dgvHistorialOrdenServicio.Size = new System.Drawing.Size(1337, 422);
            this.dgvHistorialOrdenServicio.TabIndex = 117;
            this.dgvHistorialOrdenServicio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialOrdenServicio_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtm);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(777, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 75);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Orden Servicio";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(42, 20);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 20);
            this.txtm.TabIndex = 73;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::pl_Gurkas.Properties.Resources.buscar_afp_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(148, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 41);
            this.button3.TabIndex = 9;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(42, 46);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "MES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "AÑO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarProveedorPorRuc);
            this.groupBox1.Controls.Add(this.txtRucProveedor);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 75);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por RUC de Provedor";
            // 
            // btnBuscarProveedorPorRuc
            // 
            this.btnBuscarProveedorPorRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedorPorRuc.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProveedorPorRuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProveedorPorRuc.Location = new System.Drawing.Point(215, 15);
            this.btnBuscarProveedorPorRuc.Name = "btnBuscarProveedorPorRuc";
            this.btnBuscarProveedorPorRuc.Size = new System.Drawing.Size(111, 46);
            this.btnBuscarProveedorPorRuc.TabIndex = 66;
            this.btnBuscarProveedorPorRuc.Text = "Buscar";
            this.btnBuscarProveedorPorRuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedorPorRuc.UseVisualStyleBackColor = true;
            this.btnBuscarProveedorPorRuc.Click += new System.EventHandler(this.btnBuscarProveedorPorRuc_Click);
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Location = new System.Drawing.Point(46, 29);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(163, 20);
            this.txtRucProveedor.TabIndex = 102;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(4, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 15);
            this.label.TabIndex = 101;
            this.label.Text = "RUC:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboProveedor);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 75);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Por Proveedor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::pl_Gurkas.Properties.Resources.buscar_afp_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(370, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Proveedor :";
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(75, 24);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(289, 21);
            this.cboProveedor.TabIndex = 53;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.salir_empleado_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(925, 108);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 46);
            this.btnCerrar.TabIndex = 110;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmHistorialOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 651);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgvHistorialOrdenServicio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistorialOrdenServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorialOrdenServicio";
            this.Load += new System.EventHandler(this.frmHistorialOrdenServicio_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenServicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtordencomprar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProveedorMesANIO;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvHistorialOrdenServicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarProveedorPorRuc;
        private System.Windows.Forms.TextBox txtRucProveedor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Button btnCerrar;
    }
}