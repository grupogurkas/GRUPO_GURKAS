
namespace pl_Gurkas.Vista.Logistica.Historial
{
    partial class frmBuscarVale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarVale));
            this.label11 = new System.Windows.Forms.Label();
            this.dgvBuscarVale = new System.Windows.Forms.DataGridView();
            this.txtCodPersonal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombPersonal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarVale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 30);
            this.label11.TabIndex = 66;
            this.label11.Text = "Nombre\r\nPersonal:";
            // 
            // dgvBuscarVale
            // 
            this.dgvBuscarVale.AllowUserToAddRows = false;
            this.dgvBuscarVale.AllowUserToDeleteRows = false;
            this.dgvBuscarVale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarVale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBuscarVale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarVale.Location = new System.Drawing.Point(12, 85);
            this.dgvBuscarVale.Name = "dgvBuscarVale";
            this.dgvBuscarVale.ReadOnly = true;
            this.dgvBuscarVale.RowHeadersWidth = 51;
            this.dgvBuscarVale.Size = new System.Drawing.Size(701, 310);
            this.dgvBuscarVale.TabIndex = 246;
            // 
            // txtCodPersonal
            // 
            this.txtCodPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPersonal.Location = new System.Drawing.Point(75, 53);
            this.txtCodPersonal.Name = "txtCodPersonal";
            this.txtCodPersonal.Size = new System.Drawing.Size(211, 22);
            this.txtCodPersonal.TabIndex = 248;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 247;
            this.label7.Text = "Codigo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pl_Gurkas.Properties.Resources.png;
            this.pictureBox1.Location = new System.Drawing.Point(588, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 249;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombPersonal
            // 
            this.txtNombPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombPersonal.Location = new System.Drawing.Point(75, 22);
            this.txtNombPersonal.Name = "txtNombPersonal";
            this.txtNombPersonal.Size = new System.Drawing.Size(297, 22);
            this.txtNombPersonal.TabIndex = 250;
            // 
            // frmBuscarVale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 407);
            this.Controls.Add(this.txtNombPersonal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCodPersonal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvBuscarVale);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarVale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarVale";
            this.Load += new System.EventHandler(this.frmBuscarVale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarVale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvBuscarVale;
        private System.Windows.Forms.TextBox txtCodPersonal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombPersonal;
    }
}