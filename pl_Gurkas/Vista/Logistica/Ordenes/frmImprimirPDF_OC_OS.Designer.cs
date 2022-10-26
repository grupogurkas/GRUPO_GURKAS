
namespace pl_Gurkas.Vista.Logistica.Ordenes
{
    partial class frmImprimirPDF_OC_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirPDF_OC_OS));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.lblemp = new System.Windows.Forms.Label();
            this.dgvHistorialOrdenes = new System.Windows.Forms.DataGridView();
            this.lblruc = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblnombrear = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.lblTelefonoemp = new System.Windows.Forms.Label();
            this.lblcorreoemp = new System.Windows.Forms.Label();
            this.lblrucemp = new System.Windows.Forms.Label();
            this.lbldireccionemp = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblCelEmp = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblorden_servicio = new System.Windows.Forms.Label();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.salir_empleado_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar.TabIndex = 111;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Image = global::pl_Gurkas.Properties.Resources.pdf_32;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(127, 12);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(149, 46);
            this.btnPDF.TabIndex = 112;
            this.btnPDF.Text = "GENERAR PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRINT.Image = global::pl_Gurkas.Properties.Resources.print_32;
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(282, 12);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(206, 46);
            this.BTNPRINT.TabIndex = 113;
            this.BTNPRINT.Text = "IMPRIMIR DOCUMENTO";
            this.BTNPRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNPRINT.UseVisualStyleBackColor = true;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(22, 84);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(37, 13);
            this.lblemp.TabIndex = 114;
            this.lblemp.Text = "lblemp";
            // 
            // dgvHistorialOrdenes
            // 
            this.dgvHistorialOrdenes.AllowUserToDeleteRows = false;
            this.dgvHistorialOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialOrdenes.Location = new System.Drawing.Point(12, 259);
            this.dgvHistorialOrdenes.Name = "dgvHistorialOrdenes";
            this.dgvHistorialOrdenes.ReadOnly = true;
            this.dgvHistorialOrdenes.Size = new System.Drawing.Size(585, 157);
            this.dgvHistorialOrdenes.TabIndex = 118;
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(22, 117);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(32, 13);
            this.lblruc.TabIndex = 119;
            this.lblruc.Text = "lblruc";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(22, 144);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(60, 13);
            this.lbldireccion.TabIndex = 120;
            this.lbldireccion.Text = "lbldireccion";
            // 
            // lblnombrear
            // 
            this.lblnombrear.AutoSize = true;
            this.lblnombrear.Location = new System.Drawing.Point(22, 166);
            this.lblnombrear.Name = "lblnombrear";
            this.lblnombrear.Size = new System.Drawing.Size(61, 13);
            this.lblnombrear.TabIndex = 121;
            this.lblnombrear.Text = "lblnombrear";
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.Location = new System.Drawing.Point(22, 191);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(32, 13);
            this.lblver.TabIndex = 122;
            this.lblver.Text = "lblver";
            // 
            // lblTelefonoemp
            // 
            this.lblTelefonoemp.AutoSize = true;
            this.lblTelefonoemp.Location = new System.Drawing.Point(472, 177);
            this.lblTelefonoemp.Name = "lblTelefonoemp";
            this.lblTelefonoemp.Size = new System.Drawing.Size(79, 13);
            this.lblTelefonoemp.TabIndex = 127;
            this.lblTelefonoemp.Text = "lblTelefonoemp";
            // 
            // lblcorreoemp
            // 
            this.lblcorreoemp.AutoSize = true;
            this.lblcorreoemp.Location = new System.Drawing.Point(473, 154);
            this.lblcorreoemp.Name = "lblcorreoemp";
            this.lblcorreoemp.Size = new System.Drawing.Size(67, 13);
            this.lblcorreoemp.TabIndex = 126;
            this.lblcorreoemp.Text = "lblcorreoemp";
            // 
            // lblrucemp
            // 
            this.lblrucemp.AutoSize = true;
            this.lblrucemp.Location = new System.Drawing.Point(473, 130);
            this.lblrucemp.Name = "lblrucemp";
            this.lblrucemp.Size = new System.Drawing.Size(52, 13);
            this.lblrucemp.TabIndex = 125;
            this.lblrucemp.Text = "lblrucemp";
            // 
            // lbldireccionemp
            // 
            this.lbldireccionemp.AutoSize = true;
            this.lbldireccionemp.Location = new System.Drawing.Point(472, 107);
            this.lbldireccionemp.Name = "lbldireccionemp";
            this.lbldireccionemp.Size = new System.Drawing.Size(80, 13);
            this.lbldireccionemp.TabIndex = 124;
            this.lbldireccionemp.Text = "lbldireccionemp";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(473, 84);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(32, 13);
            this.lblRS.TabIndex = 123;
            this.lblRS.Text = "lblRS";
            // 
            // lblCelEmp
            // 
            this.lblCelEmp.AutoSize = true;
            this.lblCelEmp.Location = new System.Drawing.Point(473, 200);
            this.lblCelEmp.Name = "lblCelEmp";
            this.lblCelEmp.Size = new System.Drawing.Size(53, 13);
            this.lblCelEmp.TabIndex = 128;
            this.lblCelEmp.Text = "lblCelEmp";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(473, 224);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(77, 13);
            this.lblObservacion.TabIndex = 129;
            this.lblObservacion.Text = "lblObservacion";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(629, 271);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(37, 13);
            this.lblanio.TabIndex = 130;
            this.lblanio.Text = "lblanio";
            // 
            // lblorden_servicio
            // 
            this.lblorden_servicio.AutoSize = true;
            this.lblorden_servicio.Location = new System.Drawing.Point(629, 310);
            this.lblorden_servicio.Name = "lblorden_servicio";
            this.lblorden_servicio.Size = new System.Drawing.Size(86, 13);
            this.lblorden_servicio.TabIndex = 131;
            this.lblorden_servicio.Text = "lblorden_servicio";
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Location = new System.Drawing.Point(631, 345);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(76, 13);
            this.lblFechaOrden.TabIndex = 132;
            this.lblFechaOrden.Text = "lblFechaOrden";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtIgv);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Location = new System.Drawing.Point(780, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 99);
            this.groupBox3.TabIndex = 255;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costos Totales:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 256;
            this.label16.Text = "S/.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(88, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 255;
            this.label15.Text = "S/.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 254;
            this.label14.Text = "S/.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 248;
            this.label13.Text = "Sub-Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 252;
            this.label9.Text = "TOTAL:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(111, 20);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(114, 20);
            this.txtSubTotal.TabIndex = 253;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 250;
            this.label10.Text = "IGV:";
            // 
            // txtIgv
            // 
            this.txtIgv.Enabled = false;
            this.txtIgv.Location = new System.Drawing.Point(111, 43);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(114, 20);
            this.txtIgv.TabIndex = 251;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(111, 68);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(114, 20);
            this.txtTotal.TabIndex = 249;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmImprimirPDF_OC_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 63);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblFechaOrden);
            this.Controls.Add(this.lblorden_servicio);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblCelEmp);
            this.Controls.Add(this.lblTelefonoemp);
            this.Controls.Add(this.lblcorreoemp);
            this.Controls.Add(this.lblrucemp);
            this.Controls.Add(this.lbldireccionemp);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.lblnombrear);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblruc);
            this.Controls.Add(this.dgvHistorialOrdenes);
            this.Controls.Add(this.lblemp);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmImprimirPDF_OC_OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImprimirPDF_OC_OS";
            this.Load += new System.EventHandler(this.frmImprimirPDF_OC_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.DataGridView dgvHistorialOrdenes;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombrear;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.Label lblTelefonoemp;
        private System.Windows.Forms.Label lblcorreoemp;
        private System.Windows.Forms.Label lblrucemp;
        private System.Windows.Forms.Label lbldireccionemp;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblCelEmp;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblorden_servicio;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}