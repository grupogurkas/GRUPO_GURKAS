
namespace pl_Gurkas.Vista.Logistica.Ordenes
{
    partial class frmOrdenAprovada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarProductoTecnologia = new System.Windows.Forms.Button();
            this.cboNombreProductoTecnologico = new System.Windows.Forms.ComboBox();
            this.label81 = new System.Windows.Forms.Label();
            this.btnActualizarProductoTecnologico = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodavp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProductoTecnologia
            // 
            this.btnBuscarProductoTecnologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoTecnologia.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProductoTecnologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProductoTecnologia.Location = new System.Drawing.Point(598, 25);
            this.btnBuscarProductoTecnologia.Name = "btnBuscarProductoTecnologia";
            this.btnBuscarProductoTecnologia.Size = new System.Drawing.Size(119, 51);
            this.btnBuscarProductoTecnologia.TabIndex = 96;
            this.btnBuscarProductoTecnologia.Text = "Buscar";
            this.btnBuscarProductoTecnologia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProductoTecnologia.UseVisualStyleBackColor = true;
            this.btnBuscarProductoTecnologia.Click += new System.EventHandler(this.btnBuscarProductoTecnologia_Click);
            // 
            // cboNombreProductoTecnologico
            // 
            this.cboNombreProductoTecnologico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNombreProductoTecnologico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNombreProductoTecnologico.FormattingEnabled = true;
            this.cboNombreProductoTecnologico.Location = new System.Drawing.Point(194, 25);
            this.cboNombreProductoTecnologico.Name = "cboNombreProductoTecnologico";
            this.cboNombreProductoTecnologico.Size = new System.Drawing.Size(398, 21);
            this.cboNombreProductoTecnologico.TabIndex = 98;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(12, 26);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(176, 15);
            this.label81.TabIndex = 97;
            this.label81.Text = "Numero de Orden de Compra :";
            // 
            // btnActualizarProductoTecnologico
            // 
            this.btnActualizarProductoTecnologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProductoTecnologico.Image = global::pl_Gurkas.Properties.Resources.empleado_update_32;
            this.btnActualizarProductoTecnologico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProductoTecnologico.Location = new System.Drawing.Point(723, 25);
            this.btnActualizarProductoTecnologico.Name = "btnActualizarProductoTecnologico";
            this.btnActualizarProductoTecnologico.Size = new System.Drawing.Size(150, 51);
            this.btnActualizarProductoTecnologico.TabIndex = 93;
            this.btnActualizarProductoTecnologico.Text = "Guardar";
            this.btnActualizarProductoTecnologico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarProductoTecnologico.UseVisualStyleBackColor = true;
            this.btnActualizarProductoTecnologico.Click += new System.EventHandler(this.btnActualizarProductoTecnologico_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.cerrar_sesion_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(879, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 51);
            this.btnCerrar.TabIndex = 94;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.Location = new System.Drawing.Point(12, 90);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(988, 399);
            this.dgvAsistencia.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "Factura Asociada :";
            // 
            // txtcodavp
            // 
            this.txtcodavp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodavp.Location = new System.Drawing.Point(194, 52);
            this.txtcodavp.Name = "txtcodavp";
            this.txtcodavp.Size = new System.Drawing.Size(398, 22);
            this.txtcodavp.TabIndex = 101;
            // 
            // frmOrdenAprovada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 501);
            this.Controls.Add(this.txtcodavp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.btnBuscarProductoTecnologia);
            this.Controls.Add(this.cboNombreProductoTecnologico);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.btnActualizarProductoTecnologico);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmOrdenAprovada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenAprobada";
            this.Load += new System.EventHandler(this.frmOrdenAprovada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarProductoTecnologia;
        private System.Windows.Forms.ComboBox cboNombreProductoTecnologico;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Button btnActualizarProductoTecnologico;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodavp;
    }
}