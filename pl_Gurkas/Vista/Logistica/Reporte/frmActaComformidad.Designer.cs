
namespace pl_Gurkas.Vista.Logistica.Reporte
{
    partial class frmActaComformidad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActaComformidad));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cboempleadoActivo = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalleDescuento = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfecha2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // cboempleadoActivo
            // 
            this.cboempleadoActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempleadoActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempleadoActivo.FormattingEnabled = true;
            this.cboempleadoActivo.Location = new System.Drawing.Point(118, 8);
            this.cboempleadoActivo.Name = "cboempleadoActivo";
            this.cboempleadoActivo.Size = new System.Drawing.Size(335, 21);
            this.cboempleadoActivo.TabIndex = 97;
            this.cboempleadoActivo.SelectedIndexChanged += new System.EventHandler(this.cboempleadoActivo_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(12, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 15);
            this.label42.TabIndex = 98;
            this.label42.Text = "Buscar Personal:";
            // 
            // cboUnidad
            // 
            this.cboUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(118, 35);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(335, 21);
            this.cboUnidad.TabIndex = 216;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 217;
            this.label2.Text = "Unidad:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(118, 62);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(335, 20);
            this.txtDNI.TabIndex = 218;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(12, 62);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(34, 15);
            this.DNI.TabIndex = 219;
            this.DNI.Text = "DNI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 220;
            this.label1.Text = "DETALLE DE DESCUENTO :";
            // 
            // txtDetalleDescuento
            // 
            this.txtDetalleDescuento.Location = new System.Drawing.Point(12, 123);
            this.txtDetalleDescuento.Multiline = true;
            this.txtDetalleDescuento.Name = "txtDetalleDescuento";
            this.txtDetalleDescuento.Size = new System.Drawing.Size(441, 70);
            this.txtDetalleDescuento.TabIndex = 221;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(12, 218);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(441, 88);
            this.txtConcepto.TabIndex = 223;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 222;
            this.label3.Text = "CONCEPTO : ";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(12, 331);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(441, 88);
            this.txtObservaciones.TabIndex = 225;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 224;
            this.label4.Text = "OBSERVACIONES : ";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(76, 429);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(150, 20);
            this.txtmonto.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 227;
            this.label5.Text = "MONTO :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(296, 429);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(157, 20);
            this.txtTotal.TabIndex = 228;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 229;
            this.label6.Text = "TOTAL :";
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRINT.Image = global::pl_Gurkas.Properties.Resources.print_32;
            this.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRINT.Location = new System.Drawing.Point(247, 464);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(206, 46);
            this.BTNPRINT.TabIndex = 230;
            this.BTNPRINT.Text = "IMPRIMIR DOCUMENTO";
            this.BTNPRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNPRINT.UseVisualStyleBackColor = true;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblfecha2
            // 
            this.lblfecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha2.Location = new System.Drawing.Point(12, 464);
            this.lblfecha2.Name = "lblfecha2";
            this.lblfecha2.Size = new System.Drawing.Size(214, 46);
            this.lblfecha2.TabIndex = 231;
            this.lblfecha2.Text = "22";
            // 
            // frmActaComformidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 519);
            this.Controls.Add(this.lblfecha2);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetalleDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboempleadoActivo);
            this.Controls.Add(this.label42);
            this.Name = "frmActaComformidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActaComformidad";
            this.Load += new System.EventHandler(this.frmActaComformidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cboempleadoActivo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalleDescuento;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfecha2;
    }
}