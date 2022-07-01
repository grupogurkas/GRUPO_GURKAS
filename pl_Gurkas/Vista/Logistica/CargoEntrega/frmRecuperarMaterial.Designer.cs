
namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    partial class frmRecuperarMaterial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigoRecuperable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock_recuperable = new System.Windows.Forms.TextBox();
            this.cboMterialRecuperado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.txtrestanter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrecuperabler = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtresumend = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto Devuelto";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(113, 54);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(125, 20);
            this.txtcodigo.TabIndex = 234;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 233;
            this.label3.Text = "CODIGO MATERIAL";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(371, 57);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(116, 20);
            this.txtstock.TabIndex = 232;
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(113, 27);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(417, 21);
            this.cboProducto.TabIndex = 230;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOCK DISPONIBLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Material";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigoRecuperable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtstock_recuperable);
            this.groupBox2.Controls.Add(this.cboMterialRecuperado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 85);
            this.groupBox2.TabIndex = 235;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto Recuperado";
            // 
            // txtCodigoRecuperable
            // 
            this.txtCodigoRecuperable.Location = new System.Drawing.Point(113, 54);
            this.txtCodigoRecuperable.Name = "txtCodigoRecuperable";
            this.txtCodigoRecuperable.Size = new System.Drawing.Size(125, 20);
            this.txtCodigoRecuperable.TabIndex = 234;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 233;
            this.label4.Text = "CODIGO MATERIAL";
            // 
            // txtstock_recuperable
            // 
            this.txtstock_recuperable.Location = new System.Drawing.Point(371, 54);
            this.txtstock_recuperable.Name = "txtstock_recuperable";
            this.txtstock_recuperable.Size = new System.Drawing.Size(116, 20);
            this.txtstock_recuperable.TabIndex = 232;
            this.txtstock_recuperable.TextChanged += new System.EventHandler(this.txtstock_recuperable_TextChanged);
            // 
            // cboMterialRecuperado
            // 
            this.cboMterialRecuperado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMterialRecuperado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMterialRecuperado.FormattingEnabled = true;
            this.cboMterialRecuperado.Location = new System.Drawing.Point(113, 27);
            this.cboMterialRecuperado.Name = "cboMterialRecuperado";
            this.cboMterialRecuperado.Size = new System.Drawing.Size(417, 21);
            this.cboMterialRecuperado.TabIndex = 230;
            this.cboMterialRecuperado.SelectedIndexChanged += new System.EventHandler(this.cboMterialRecuperado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "STOCK RECUPERADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del Material";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRecuperar);
            this.groupBox3.Controls.Add(this.txtrestanter);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtrecuperabler);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtresumend);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 102);
            this.groupBox3.TabIndex = 236;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Image = global::pl_Gurkas.Properties.Resources.add_trabajador_32;
            this.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperar.Location = new System.Drawing.Point(350, 31);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(169, 46);
            this.btnRecuperar.TabIndex = 239;
            this.btnRecuperar.Text = "Recuperar Material";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtrestanter
            // 
            this.txtrestanter.Location = new System.Drawing.Point(137, 71);
            this.txtrestanter.Name = "txtrestanter";
            this.txtrestanter.Size = new System.Drawing.Size(116, 20);
            this.txtrestanter.TabIndex = 238;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 237;
            this.label9.Text = "STOCK RESTANTE";
            // 
            // txtrecuperabler
            // 
            this.txtrecuperabler.Location = new System.Drawing.Point(137, 45);
            this.txtrecuperabler.Name = "txtrecuperabler";
            this.txtrecuperabler.Size = new System.Drawing.Size(116, 20);
            this.txtrecuperabler.TabIndex = 236;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 235;
            this.label8.Text = "STOCK RECUPERADO";
            // 
            // txtresumend
            // 
            this.txtresumend.Location = new System.Drawing.Point(137, 19);
            this.txtresumend.Name = "txtresumend";
            this.txtresumend.Size = new System.Drawing.Size(116, 20);
            this.txtresumend.TabIndex = 236;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 235;
            this.label7.Text = "STOCK DISPONIBLE";
            // 
            // frmRecuperarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 332);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRecuperarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarMaterial";
            this.Load += new System.EventHandler(this.frmRecuperarMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigoRecuperable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstock_recuperable;
        private System.Windows.Forms.ComboBox cboMterialRecuperado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtrestanter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrecuperabler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtresumend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRecuperar;
    }
}