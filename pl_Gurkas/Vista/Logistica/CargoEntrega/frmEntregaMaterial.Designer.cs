
namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    partial class frmEntregaMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregaMaterial));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.cboempleadoActivo = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblemp = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstadoMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidadTecno = new System.Windows.Forms.TextBox();
            this.label142 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoPuesto = new System.Windows.Forms.ComboBox();
            this.cboAreaLaboral = new System.Windows.Forms.ComboBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.txtInformacionAdicional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaProducto = new System.Windows.Forms.DataGridView();
            this.btnCertificadoBasc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioEntrega = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblnombrear = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lbldnientr = new System.Windows.Forms.Label();
            this.lblcodentre = new System.Windows.Forms.Label();
            this.txtNumVale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::pl_Gurkas.Properties.Resources.nuevo_emplado_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(572, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 46);
            this.btnNuevo.TabIndex = 100;
            this.btnNuevo.Text = "Nueva Entrega";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrega.Image = global::pl_Gurkas.Properties.Resources.add_trabajador_32;
            this.btnEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrega.Location = new System.Drawing.Point(462, 10);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(104, 46);
            this.btnEntrega.TabIndex = 99;
            this.btnEntrega.Text = "Registrar Entrega";
            this.btnEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrega.UseVisualStyleBackColor = true;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // cboempleadoActivo
            // 
            this.cboempleadoActivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempleadoActivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempleadoActivo.FormattingEnabled = true;
            this.cboempleadoActivo.Location = new System.Drawing.Point(121, 9);
            this.cboempleadoActivo.Name = "cboempleadoActivo";
            this.cboempleadoActivo.Size = new System.Drawing.Size(335, 21);
            this.cboempleadoActivo.TabIndex = 97;
            this.cboempleadoActivo.SelectedIndexChanged += new System.EventHandler(this.cboempleadoActivo_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(15, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 15);
            this.label42.TabIndex = 96;
            this.label42.Text = "Buscar Personal:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNumVale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvListaProducto);
            this.panel1.Controls.Add(this.btnCertificadoBasc);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtpFechaAdquisicion);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 574);
            this.panel1.TabIndex = 95;
            // 
            // lblemp
            // 
            this.lblemp.AutoSize = true;
            this.lblemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.Location = new System.Drawing.Point(1203, 41);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(32, 15);
            this.lblemp.TabIndex = 234;
            this.lblemp.Text = "emp";
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruc.Location = new System.Drawing.Point(1223, 15);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(24, 15);
            this.lblruc.TabIndex = 233;
            this.lblruc.Text = "ruc";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(1145, 39);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(23, 15);
            this.lbldireccion.TabIndex = 232;
            this.lbldireccion.Text = "dic";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(699, 117);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(249, 47);
            this.txtObservacion.TabIndex = 230;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(699, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 231;
            this.label8.Text = "Observacion :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboEstadoMaterial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtCantidadTecno);
            this.groupBox2.Controls.Add(this.label142);
            this.groupBox2.Location = new System.Drawing.Point(699, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 92);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Producto Entrega";
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(91, 26);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(406, 21);
            this.cboProducto.TabIndex = 229;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 227;
            this.label3.Text = "Condicion de\r\nEntrega";
            // 
            // cboEstadoMaterial
            // 
            this.cboEstadoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoMaterial.FormattingEnabled = true;
            this.cboEstadoMaterial.Location = new System.Drawing.Point(340, 58);
            this.cboEstadoMaterial.Name = "cboEstadoMaterial";
            this.cboEstadoMaterial.Size = new System.Drawing.Size(157, 21);
            this.cboEstadoMaterial.TabIndex = 228;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 221;
            this.label1.Text = "Producto \r\nSe Entrega\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::pl_Gurkas.Properties.Resources.add_trabajador_32;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(503, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 46);
            this.btnAgregar.TabIndex = 223;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidadTecno
            // 
            this.txtCantidadTecno.Location = new System.Drawing.Point(91, 59);
            this.txtCantidadTecno.Name = "txtCantidadTecno";
            this.txtCantidadTecno.Size = new System.Drawing.Size(158, 20);
            this.txtCantidadTecno.TabIndex = 217;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(6, 60);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(59, 15);
            this.label142.TabIndex = 216;
            this.label142.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoPuesto);
            this.groupBox1.Controls.Add(this.cboAreaLaboral);
            this.groupBox1.Controls.Add(this.cboUnidad);
            this.groupBox1.Controls.Add(this.cboSede);
            this.groupBox1.Controls.Add(this.cboEmpresa);
            this.groupBox1.Controls.Add(this.txtInformacionAdicional);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 174);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales:";
            // 
            // cboTipoPuesto
            // 
            this.cboTipoPuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoPuesto.FormattingEnabled = true;
            this.cboTipoPuesto.Location = new System.Drawing.Point(104, 26);
            this.cboTipoPuesto.Name = "cboTipoPuesto";
            this.cboTipoPuesto.Size = new System.Drawing.Size(246, 21);
            this.cboTipoPuesto.TabIndex = 229;
            // 
            // cboAreaLaboral
            // 
            this.cboAreaLaboral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAreaLaboral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAreaLaboral.FormattingEnabled = true;
            this.cboAreaLaboral.Location = new System.Drawing.Point(104, 54);
            this.cboAreaLaboral.Name = "cboAreaLaboral";
            this.cboAreaLaboral.Size = new System.Drawing.Size(246, 21);
            this.cboAreaLaboral.TabIndex = 228;
            // 
            // cboUnidad
            // 
            this.cboUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(104, 113);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(246, 21);
            this.cboUnidad.TabIndex = 227;
            this.cboUnidad.SelectedIndexChanged += new System.EventHandler(this.cboUnidad_SelectedIndexChanged_1);
            // 
            // cboSede
            // 
            this.cboSede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(104, 140);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(246, 21);
            this.cboSede.TabIndex = 226;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(104, 86);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(246, 21);
            this.cboEmpresa.TabIndex = 218;
            this.cboEmpresa.SelectedIndexChanged += new System.EventHandler(this.cboEmpresa_SelectedIndexChanged);
            // 
            // txtInformacionAdicional
            // 
            this.txtInformacionAdicional.Location = new System.Drawing.Point(356, 53);
            this.txtInformacionAdicional.Multiline = true;
            this.txtInformacionAdicional.Name = "txtInformacionAdicional";
            this.txtInformacionAdicional.Size = new System.Drawing.Size(312, 108);
            this.txtInformacionAdicional.TabIndex = 218;
            this.txtInformacionAdicional.TextChanged += new System.EventHandler(this.txtInformacionAdicional_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 216;
            this.label7.Text = "Sede:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(356, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 15);
            this.label14.TabIndex = 219;
            this.label14.Text = "Informacion  Adicional:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(12, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 15);
            this.label27.TabIndex = 217;
            this.label27.Text = "Empresa : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 215;
            this.label2.Text = "Unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 211;
            this.label6.Text = "Puesto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 191;
            this.label4.Text = "Area Entrega";
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProducto.Location = new System.Drawing.Point(11, 183);
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.Size = new System.Drawing.Size(1309, 384);
            this.dgvListaProducto.TabIndex = 220;
            this.dgvListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProducto_CellContentClick);
            this.dgvListaProducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaProducto_CellPainting);
            // 
            // btnCertificadoBasc
            // 
            this.btnCertificadoBasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificadoBasc.Image = global::pl_Gurkas.Properties.Resources.descarga_32;
            this.btnCertificadoBasc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCertificadoBasc.Location = new System.Drawing.Point(1202, 101);
            this.btnCertificadoBasc.Name = "btnCertificadoBasc";
            this.btnCertificadoBasc.Size = new System.Drawing.Size(110, 46);
            this.btnCertificadoBasc.TabIndex = 226;
            this.btnCertificadoBasc.Text = "Imprimir";
            this.btnCertificadoBasc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCertificadoBasc.UseVisualStyleBackColor = true;
            this.btnCertificadoBasc.Click += new System.EventHandler(this.btnCertificadoBasc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(977, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 15);
            this.label12.TabIndex = 194;
            this.label12.Text = "Fecha De Entrega:";
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dtpFechaAdquisicion.Enabled = false;
            this.dtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(1092, 113);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaAdquisicion.TabIndex = 193;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::pl_Gurkas.Properties.Resources.png;
            this.pictureBox16.Location = new System.Drawing.Point(1256, 3);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(78, 53);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 224;
            this.pictureBox16.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 196;
            this.label5.Text = "Entregado Por:";
            // 
            // txtUsuarioEntrega
            // 
            this.txtUsuarioEntrega.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsuarioEntrega.Location = new System.Drawing.Point(121, 39);
            this.txtUsuarioEntrega.Name = "txtUsuarioEntrega";
            this.txtUsuarioEntrega.Size = new System.Drawing.Size(335, 20);
            this.txtUsuarioEntrega.TabIndex = 195;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::pl_Gurkas.Properties.Resources.cerrar_sesion_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(681, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 46);
            this.btnCerrar.TabIndex = 94;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(800, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(368, 21);
            this.lblFecha.TabIndex = 226;
            this.lblFecha.Text = "22";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(800, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 24);
            this.lblHora.TabIndex = 227;
            this.lblHora.Text = "22";
            // 
            // lblnombrear
            // 
            this.lblnombrear.AutoSize = true;
            this.lblnombrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrear.Location = new System.Drawing.Point(1174, 12);
            this.lblnombrear.Name = "lblnombrear";
            this.lblnombrear.Size = new System.Drawing.Size(43, 15);
            this.lblnombrear.TabIndex = 235;
            this.lblnombrear.Text = "nomar";
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.Location = new System.Drawing.Point(1174, 39);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(23, 15);
            this.lblver.TabIndex = 236;
            this.lblver.Text = "ver";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldni.Location = new System.Drawing.Point(1116, 41);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(21, 15);
            this.lbldni.TabIndex = 237;
            this.lbldni.Text = "dn";
            // 
            // lbldnientr
            // 
            this.lbldnientr.AutoSize = true;
            this.lbldnientr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldnientr.Location = new System.Drawing.Point(1062, 47);
            this.lbldnientr.Name = "lbldnientr";
            this.lbldnientr.Size = new System.Drawing.Size(35, 15);
            this.lbldnientr.TabIndex = 238;
            this.lbldnientr.Text = "dnen";
            // 
            // lblcodentre
            // 
            this.lblcodentre.AutoSize = true;
            this.lblcodentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodentre.Location = new System.Drawing.Point(1001, 47);
            this.lblcodentre.Name = "lblcodentre";
            this.lblcodentre.Size = new System.Drawing.Size(55, 15);
            this.lblcodentre.TabIndex = 239;
            this.lblcodentre.Text = "codentre";
            // 
            // txtNumVale
            // 
            this.txtNumVale.Location = new System.Drawing.Point(1092, 144);
            this.txtNumVale.Name = "txtNumVale";
            this.txtNumVale.Size = new System.Drawing.Size(104, 20);
            this.txtNumVale.TabIndex = 231;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(977, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 230;
            this.label9.Text = "Num Vale :";
            // 
            // frmEntregaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 651);
            this.Controls.Add(this.lblcodentre);
            this.Controls.Add(this.lbldnientr);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblruc);
            this.Controls.Add(this.lblemp);
            this.Controls.Add(this.lblnombrear);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.cboempleadoActivo);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsuarioEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntregaMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntregaMaterial";
            this.Load += new System.EventHandler(this.frmEntregaMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.ComboBox cboempleadoActivo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstadoMaterial;
        private System.Windows.Forms.Button btnCertificadoBasc;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.TextBox txtInformacionAdicional;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCantidadTecno;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioEntrega;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.ComboBox cboTipoPuesto;
        private System.Windows.Forms.ComboBox cboAreaLaboral;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblemp;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombrear;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lbldnientr;
        private System.Windows.Forms.Label lblcodentre;
        private System.Windows.Forms.TextBox txtNumVale;
        private System.Windows.Forms.Label label9;
    }
}