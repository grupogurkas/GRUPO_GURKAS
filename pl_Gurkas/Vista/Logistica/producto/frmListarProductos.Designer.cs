
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
            this.dgvBuscarProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnBuscarProveedorPorEmpresa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedorPorRuc = new System.Windows.Forms.Button();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarCodigoProveedor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarProveedor
            // 
            this.dgvBuscarProveedor.AllowUserToAddRows = false;
            this.dgvBuscarProveedor.AllowUserToDeleteRows = false;
            this.dgvBuscarProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProveedor.Location = new System.Drawing.Point(12, 142);
            this.dgvBuscarProveedor.Name = "dgvBuscarProveedor";
            this.dgvBuscarProveedor.ReadOnly = true;
            this.dgvBuscarProveedor.RowHeadersWidth = 51;
            this.dgvBuscarProveedor.Size = new System.Drawing.Size(1351, 551);
            this.dgvBuscarProveedor.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1351, 124);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::pl_Gurkas.Properties.Resources.Excel_32;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1230, 71);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 46);
            this.btnExcel.TabIndex = 64;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboEmpresa);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.btnBuscarProveedorPorEmpresa);
            this.groupBox4.Location = new System.Drawing.Point(818, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 75);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda por Codigo Sistema";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(54, 28);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(215, 21);
            this.cboEmpresa.TabIndex = 68;
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
            // btnBuscarProveedorPorEmpresa
            // 
            this.btnBuscarProveedorPorEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedorPorEmpresa.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProveedorPorEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProveedorPorEmpresa.Location = new System.Drawing.Point(284, 14);
            this.btnBuscarProveedorPorEmpresa.Name = "btnBuscarProveedorPorEmpresa";
            this.btnBuscarProveedorPorEmpresa.Size = new System.Drawing.Size(96, 46);
            this.btnBuscarProveedorPorEmpresa.TabIndex = 66;
            this.btnBuscarProveedorPorEmpresa.Text = "Buscar";
            this.btnBuscarProveedorPorEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedorPorEmpresa.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarProveedorPorRuc);
            this.groupBox3.Controls.Add(this.txtRucProveedor);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Location = new System.Drawing.Point(470, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 75);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda por Codigo Producto";
            // 
            // btnBuscarProveedorPorRuc
            // 
            this.btnBuscarProveedorPorRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedorPorRuc.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarProveedorPorRuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProveedorPorRuc.Location = new System.Drawing.Point(234, 15);
            this.btnBuscarProveedorPorRuc.Name = "btnBuscarProveedorPorRuc";
            this.btnBuscarProveedorPorRuc.Size = new System.Drawing.Size(94, 46);
            this.btnBuscarProveedorPorRuc.TabIndex = 66;
            this.btnBuscarProveedorPorRuc.Text = "Buscar";
            this.btnBuscarProveedorPorRuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedorPorRuc.UseVisualStyleBackColor = true;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Location = new System.Drawing.Point(65, 29);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(163, 20);
            this.txtRucProveedor.TabIndex = 102;
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
            this.groupBox2.Controls.Add(this.btnBuscarCodigoProveedor);
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
            // btnBuscarCodigoProveedor
            // 
            this.btnBuscarCodigoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigoProveedor.Image = global::pl_Gurkas.Properties.Resources.buscar_empleado_32;
            this.btnBuscarCodigoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigoProveedor.Location = new System.Drawing.Point(357, 17);
            this.btnBuscarCodigoProveedor.Name = "btnBuscarCodigoProveedor";
            this.btnBuscarCodigoProveedor.Size = new System.Drawing.Size(95, 46);
            this.btnBuscarCodigoProveedor.TabIndex = 66;
            this.btnBuscarCodigoProveedor.Text = "Buscar";
            this.btnBuscarCodigoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigoProveedor.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.cerrar_sesion_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(1230, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 46);
            this.btnCerrar.TabIndex = 98;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBuscarProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarProductos";
            this.Text = "Listar Productos";
            this.Load += new System.EventHandler(this.frmListarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProveedor)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvBuscarProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnBuscarProveedorPorEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarProveedorPorRuc;
        private System.Windows.Forms.TextBox txtRucProveedor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarCodigoProveedor;
        private System.Windows.Forms.Button btnCerrar;
    }
}