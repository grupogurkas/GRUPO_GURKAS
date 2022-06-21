
namespace pl_Gurkas.Vista.Logistica.producto
{
    partial class frmListarProductos
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
            this.dgvBuscarProducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboCodigoSistema = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnBuscarProductoSistema = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProductoCodigo = new System.Windows.Forms.Button();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarCodigoProducto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarProducto
            // 
            this.dgvBuscarProducto.AllowUserToAddRows = false;
            this.dgvBuscarProducto.AllowUserToDeleteRows = false;
            this.dgvBuscarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProducto.Location = new System.Drawing.Point(12, 142);
            this.dgvBuscarProducto.Name = "dgvBuscarProducto";
            this.dgvBuscarProducto.ReadOnly = true;
            this.dgvBuscarProducto.RowHeadersWidth = 51;
            this.dgvBuscarProducto.Size = new System.Drawing.Size(1297, 488);
            this.dgvBuscarProducto.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1299, 124);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::pl_Gurkas.Properties.Resources.Excel_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1158, 71);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 46);
            this.btnExcel.TabIndex = 64;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboCodigoSistema);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.btnBuscarProductoSistema);
            this.groupBox4.Location = new System.Drawing.Point(800, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 75);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda por Codigo Sistema";
            // 
            // cboCodigoSistema
            // 
            this.cboCodigoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoSistema.FormattingEnabled = true;
            this.cboCodigoSistema.Location = new System.Drawing.Point(54, 28);
            this.cboCodigoSistema.Name = "cboCodigoSistema";
            this.cboCodigoSistema.Size = new System.Drawing.Size(184, 21);
            this.cboCodigoSistema.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 15);
            this.label27.TabIndex = 67;
            this.label27.Text = "Codigo : ";
            // 
            // btnBuscarProductoSistema
            // 
            this.btnBuscarProductoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoSistema.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProductoSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProductoSistema.Location = new System.Drawing.Point(244, 14);
            this.btnBuscarProductoSistema.Name = "btnBuscarProductoSistema";
            this.btnBuscarProductoSistema.Size = new System.Drawing.Size(96, 46);
            this.btnBuscarProductoSistema.TabIndex = 66;
            this.btnBuscarProductoSistema.Text = "Buscar";
            this.btnBuscarProductoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProductoSistema.UseVisualStyleBackColor = true;
            this.btnBuscarProductoSistema.Click += new System.EventHandler(this.btnBuscarProductoSistema_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarProductoCodigo);
            this.groupBox3.Controls.Add(this.txtCodProducto);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Location = new System.Drawing.Point(470, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 75);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda por Codigo Producto";
            // 
            // btnBuscarProductoCodigo
            // 
            this.btnBuscarProductoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoCodigo.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProductoCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProductoCodigo.Location = new System.Drawing.Point(210, 15);
            this.btnBuscarProductoCodigo.Name = "btnBuscarProductoCodigo";
            this.btnBuscarProductoCodigo.Size = new System.Drawing.Size(94, 46);
            this.btnBuscarProductoCodigo.TabIndex = 66;
            this.btnBuscarProductoCodigo.Text = "Buscar";
            this.btnBuscarProductoCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProductoCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarProductoCodigo.Click += new System.EventHandler(this.btnBuscarProductoCodigo_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(65, 29);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(139, 20);
            this.txtCodProducto.TabIndex = 102;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 30);
            this.label.TabIndex = 101;
            this.label.Text = "Codigo \r\nProducto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnBuscarCodigoProducto);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 75);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por Nombre Producto";
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(72, 32);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(279, 21);
            this.cboProducto.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 30);
            this.label11.TabIndex = 65;
            this.label11.Text = "Buscar \r\nProducto :";
            // 
            // btnBuscarCodigoProducto
            // 
            this.btnBuscarCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigoProducto.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarCodigoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigoProducto.Location = new System.Drawing.Point(357, 17);
            this.btnBuscarCodigoProducto.Name = "btnBuscarCodigoProducto";
            this.btnBuscarCodigoProducto.Size = new System.Drawing.Size(95, 46);
            this.btnBuscarCodigoProducto.TabIndex = 66;
            this.btnBuscarCodigoProducto.Text = "Buscar";
            this.btnBuscarCodigoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigoProducto.UseVisualStyleBackColor = true;
            this.btnBuscarCodigoProducto.Click += new System.EventHandler(this.btnBuscarCodigoProveedor_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.cerrar_sesion_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(1158, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 46);
            this.btnCerrar.TabIndex = 98;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 636);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1297, 13);
            this.progressBar1.TabIndex = 14;
            // 
            // frmListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBuscarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Productos";
            this.Load += new System.EventHandler(this.frmListarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCodigoSistema;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnBuscarProductoSistema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarProductoCodigo;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarCodigoProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}