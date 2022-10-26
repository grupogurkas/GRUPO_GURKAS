
namespace pl_Gurkas.Vista.Logistica.Ordenes
{
    partial class frmOrdenCompraImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompraImprimir));
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
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.lblorden_servicio = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblCelEmp = new System.Windows.Forms.Label();
            this.lblTelefonoemp = new System.Windows.Forms.Label();
            this.lblcorreoemp = new System.Windows.Forms.Label();
            this.lblrucemp = new System.Windows.Forms.Label();
            this.lbldireccionemp = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.lblnombrear = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.dgvHistorialOrdenes = new System.Windows.Forms.DataGridView();
            this.lblemp = new System.Windows.Forms.Label();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(782, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 99);
            this.groupBox3.TabIndex = 275;
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
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Location = new System.Drawing.Point(633, 345);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(76, 13);
            this.lblFechaOrden.TabIndex = 274;
            this.lblFechaOrden.Text = "lblFechaOrden";
            // 
            // lblorden_servicio
            // 
            this.lblorden_servicio.AutoSize = true;
            this.lblorden_servicio.Location = new System.Drawing.Point(631, 310);
            this.lblorden_servicio.Name = "lblorden_servicio";
            this.lblorden_servicio.Size = new System.Drawing.Size(86, 13);
            this.lblorden_servicio.TabIndex = 273;
            this.lblorden_servicio.Text = "lblorden_servicio";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(631, 271);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(37, 13);
            this.lblanio.TabIndex = 272;
            this.lblanio.Text = "lblanio";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(475, 224);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(77, 13);
            this.lblObservacion.TabIndex = 271;
            this.lblObservacion.Text = "lblObservacion";
            // 
            // lblCelEmp
            // 
            this.lblCelEmp.AutoSize = true;
            this.lblCelEmp.Location = new System.Drawing.Point(475, 200);
            this.lblCelEmp.Name = "lblCelEmp";
            this.lblCelEmp.Size = new System.Drawing.Size(53, 13);
            this.lblCelEmp.TabIndex = 270;
            this.lblCelEmp.Text = "lblCelEmp";
            // 
            // lblTelefonoemp
            // 
            this.lblTelefonoemp.AutoSize = true;
            this.lblTelefonoemp.Location = new System.Drawing.Point(474, 177);
            this.lblTelefonoemp.Name = "lblTelefonoemp";
            this.lblTelefonoemp.Size = new System.Drawing.Size(79, 13);
            this.lblTelefonoemp.TabIndex = 269;
            this.lblTelefonoemp.Text = "lblTelefonoemp";
            // 
            // lblcorreoemp
            // 
            this.lblcorreoemp.AutoSize = true;
            this.lblcorreoemp.Location = new System.Drawing.Point(475, 154);
            this.lblcorreoemp.Name = "lblcorreoemp";
            this.lblcorreoemp.Size = new System.Drawing.Size(67, 13);
            this.lblcorreoemp.TabIndex = 268;
            this.lblcorreoemp.Text = "lblcorreoemp";
            // 
            // lblrucemp
            // 
            this.lblrucemp.AutoSize = true;
            this.lblrucemp.Location = new System.Drawing.Point(475, 130);
            this.lblrucemp.Name = "lblrucemp";
            this.lblrucemp.Size = new System.Drawing.Size(52, 13);
            this.lblrucemp.TabIndex = 267;
            this.lblrucemp.Text = "lblrucemp";
            // 
            // lbldireccionemp
            // 
            this.lbldireccionemp.AutoSize = true;
            this.lbldireccionemp.Location = new System.Drawing.Point(474, 107);
            this.lbldireccionemp.Name = "lbldireccionemp";
            this.lbldireccionemp.Size = new System.Drawing.Size(80, 13);
            this.lbldireccionemp.TabIndex = 266;
            this.lbldireccionemp.Text = "lbldireccionemp";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(475, 84);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(32, 13);
            this.lblRS.TabIndex = 265;
            this.lblRS.Text = "lblRS";
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.Location = new System.Drawing.Point(24, 191);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(32, 13);
            this.lblver.TabIndex = 264;
            this.lblver.Text = "lblver";
            // 
            // lblnombrear
            // 
            this.lblnombrear.AutoSize = true;
            this.lblnombrear.Location = new System.Drawing.Point(24, 166);
            this.lblnombrear.Name = "lblnombrear";
            this.lblnombrear.Size = new System.Drawing.Size(61, 13);
            this.lblnombrear.TabIndex = 263;
            this.lblnombrear.Text = "lblnombrear";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(24, 144);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(60, 13);
            this.lbldireccion.TabIndex = 262;
            this.lbldireccion.Text = "lbldireccion";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(24, 117);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(32, 13);
            this.lblruc.TabIndex = 261;
            this.lblruc.Text = "lblruc";
            // 
            // dgvHistorialOrdenes
            // 
            this.dgvHistorialOrdenes.AllowUserToDeleteRows = false;
            this.dgvHistorialOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialOrdenes.Location = new System.Drawing.Point(14, 259);
            this.dgvHistorialOrdenes.Name = "dgvHistorialOrdenes";
            this.dgvHistorialOrdenes.ReadOnly = true;
            this.dgvHistorialOrdenes.Size = new System.Drawing.Size(585, 157);
            this.dgvHistorialOrdenes.TabIndex = 260;
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Location = new System.Drawing.Point(24, 84);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(37, 13);
            this.lblemp.TabIndex = 259;
            this.lblemp.Text = "lblemp";
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRINT.Image = global::pl_Gurkas.Properties.Resources.print_32;
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(284, 12);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(206, 46);
            this.BTNPRINT.TabIndex = 258;
            this.BTNPRINT.Text = "IMPRIMIR DOCUMENTO";
            this.BTNPRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNPRINT.UseVisualStyleBackColor = true;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Image = global::pl_Gurkas.Properties.Resources.pdf_32;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(129, 12);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(149, 46);
            this.btnPDF.TabIndex = 257;
            this.btnPDF.Text = "GENERAR PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.salir_empleado_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(14, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar.TabIndex = 256;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmOrdenCompraImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 67);
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
            this.Name = "frmOrdenCompraImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenCompraImprimir";
            this.Load += new System.EventHandler(this.frmOrdenCompraImprimir_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.Label lblorden_servicio;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblCelEmp;
        private System.Windows.Forms.Label lblTelefonoemp;
        private System.Windows.Forms.Label lblcorreoemp;
        private System.Windows.Forms.Label lblrucemp;
        private System.Windows.Forms.Label lbldireccionemp;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.Label lblnombrear;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.DataGridView dgvHistorialOrdenes;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}