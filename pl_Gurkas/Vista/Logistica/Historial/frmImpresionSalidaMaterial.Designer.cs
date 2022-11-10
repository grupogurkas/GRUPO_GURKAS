
namespace pl_Gurkas.Vista.Logistica.Historial
{
    partial class frmImpresionSalidaMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpresionSalidaMaterial));
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblcodentre = new System.Windows.Forms.Label();
            this.lbldnientr = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.lblemp = new System.Windows.Forms.Label();
            this.lblnombrear = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblAreaLaboral = new System.Windows.Forms.Label();
            this.dgvHistorialOrdenes = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblImformacionAdicional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRINT.Image = global::pl_Gurkas.Properties.Resources.print_32;
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(282, 12);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(206, 46);
            this.BTNPRINT.TabIndex = 116;
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
            this.btnPDF.Location = new System.Drawing.Point(127, 12);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(149, 46);
            this.btnPDF.TabIndex = 115;
            this.btnPDF.Text = "GENERAR PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.salir_empleado_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar.TabIndex = 114;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblcodentre
            // 
            this.lblcodentre.AutoSize = true;
            this.lblcodentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodentre.Location = new System.Drawing.Point(34, 165);
            this.lblcodentre.Name = "lblcodentre";
            this.lblcodentre.Size = new System.Drawing.Size(55, 15);
            this.lblcodentre.TabIndex = 247;
            this.lblcodentre.Text = "codentre";
            // 
            // lbldnientr
            // 
            this.lbldnientr.AutoSize = true;
            this.lbldnientr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldnientr.Location = new System.Drawing.Point(34, 137);
            this.lbldnientr.Name = "lbldnientr";
            this.lbldnientr.Size = new System.Drawing.Size(35, 15);
            this.lbldnientr.TabIndex = 246;
            this.lbldnientr.Text = "dnen";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(34, 81);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(37, 15);
            this.lbldni.TabIndex = 245;
            this.lbldni.Text = "lbldni";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(34, 193);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(23, 15);
            this.lbldireccion.TabIndex = 240;
            this.lbldireccion.Text = "dic";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(34, 277);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(24, 15);
            this.lblruc.TabIndex = 241;
            this.lblruc.Text = "ruc";
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.Location = new System.Drawing.Point(34, 249);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(32, 15);
            this.lblemp.TabIndex = 242;
            this.lblemp.Text = "emp";
            // 
            // lblnombrear
            // 
            this.lblnombrear.AutoSize = true;
            this.lblnombrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrear.Location = new System.Drawing.Point(34, 109);
            this.lblnombrear.Name = "lblnombrear";
            this.lblnombrear.Size = new System.Drawing.Size(43, 15);
            this.lblnombrear.TabIndex = 243;
            this.lblnombrear.Text = "nomar";
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.Location = new System.Drawing.Point(34, 221);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(23, 15);
            this.lblver.TabIndex = 244;
            this.lblver.Text = "ver";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(388, 218);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(60, 15);
            this.lblUnidad.TabIndex = 248;
            this.lblUnidad.Text = "lblUnidad";
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(388, 249);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(49, 15);
            this.lblSede.TabIndex = 249;
            this.lblSede.Text = "lblSede";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(388, 277);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 15);
            this.lblPuesto.TabIndex = 250;
            this.lblPuesto.Text = "lblPuesto";
            // 
            // lblAreaLaboral
            // 
            this.lblAreaLaboral.AutoSize = true;
            this.lblAreaLaboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaLaboral.Location = new System.Drawing.Point(396, 307);
            this.lblAreaLaboral.Name = "lblAreaLaboral";
            this.lblAreaLaboral.Size = new System.Drawing.Size(87, 15);
            this.lblAreaLaboral.TabIndex = 251;
            this.lblAreaLaboral.Text = "lblAreaLaboral";
            // 
            // dgvHistorialOrdenes
            // 
            this.dgvHistorialOrdenes.AllowUserToDeleteRows = false;
            this.dgvHistorialOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialOrdenes.Location = new System.Drawing.Point(25, 307);
            this.dgvHistorialOrdenes.Name = "dgvHistorialOrdenes";
            this.dgvHistorialOrdenes.ReadOnly = true;
            this.dgvHistorialOrdenes.Size = new System.Drawing.Size(352, 140);
            this.dgvHistorialOrdenes.TabIndex = 252;
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
            // lblImformacionAdicional
            // 
            this.lblImformacionAdicional.AutoSize = true;
            this.lblImformacionAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImformacionAdicional.Location = new System.Drawing.Point(396, 345);
            this.lblImformacionAdicional.Name = "lblImformacionAdicional";
            this.lblImformacionAdicional.Size = new System.Drawing.Size(139, 15);
            this.lblImformacionAdicional.TabIndex = 253;
            this.lblImformacionAdicional.Text = "lblImformacionAdicional";
            // 
            // frmImpresionSalidaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 65);
            this.Controls.Add(this.lblImformacionAdicional);
            this.Controls.Add(this.dgvHistorialOrdenes);
            this.Controls.Add(this.lblAreaLaboral);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblcodentre);
            this.Controls.Add(this.lbldnientr);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblruc);
            this.Controls.Add(this.lblemp);
            this.Controls.Add(this.lblnombrear);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmImpresionSalidaMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImpresionSalidaMaterial";
            this.Load += new System.EventHandler(this.frmImpresionSalidaMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblcodentre;
        private System.Windows.Forms.Label lbldnientr;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Label lblnombrear;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblAreaLaboral;
        private System.Windows.Forms.DataGridView dgvHistorialOrdenes;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblImformacionAdicional;
    }
}